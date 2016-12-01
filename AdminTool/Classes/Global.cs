using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpo;
using RapidInterface;
using System.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Usable;

namespace AdminTool
{
    /// <summary>
    /// Основной класс глобальных переменных, которых можно сохранить в XML-файд
    /// </summary>
    public class VarXml
    {
        /// <summary>
        /// Конструктор <see cref="GlobalVarBase"/> class.
        /// </summary>
        public VarXml()
        {
            FileXml = "Config.xml";
            Init();
        }

        /// <summary>
        /// Конструктор <see cref="GlobalVarBase"/> class.
        /// </summary>
        public VarXml(string strFileXml)
        {
            FileXml = strFileXml;
            Init();
        }

        void Init()
        {
            FilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + FileXml;
            ThreadMainPeriod = 5000;
            ThreadMainDelay = 3000;
            AppName = "ABC";
        }

        /// <summary>
        /// Название файла, куда будет сохняться данные.
        /// </summary>
        [XmlIgnore]
        string FileXml;

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        [XmlIgnore]
        public string FilePath;

        public int ThreadMainPeriod;

        public int ThreadMainDelay;

        public string AppName;

        /// <summary>
        /// Сохранить данные в XML-файл.
        /// </summary>
        public void SaveToXML()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(VarXml));
            TextWriter textWriter = new StreamWriter(FilePath);
            xmlSer.Serialize(textWriter, this);
            textWriter.Close();
        }

        /// <summary>
        /// Загрузить данные из XML-файла.
        /// </summary>
        /// <returns></returns>
        public void LoadFromXML()
        {
            if (File.Exists(FilePath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(VarXml));
                TextReader textReader = new StreamReader(FilePath);
                VarXml obj = (VarXml)deserializer.Deserialize(textReader);
                textReader.Close();

                ThreadMainPeriod = obj.ThreadMainPeriod;
                ThreadMainDelay = obj.ThreadMainDelay;
                AppName = obj.AppName;
            }
        }
    }

    public class GlobalDefault
    {
        /// <summary>
        /// Версия программы.
        /// </summary>
        public string Version;

        /// <summary>
        /// Переменные из файла настроек.
        /// </summary>
        public VarXml varXml;


        /// <summary>
        /// Коллекция данных.
        /// </summary>
        public XPCollection DeviceCollection { get; set; }

        public XPCollectionWithUnits CollectionWithUnits { get; set; }

        /// <summary>
        /// Основной поток обработки данных.
        /// </summary>
        public ThreadTimer ThreadMain { get; set; }

        public Collection<DeviceReal> DeviceRealCollection { get; set; }

        public BackgroundWorker WorkerReboot { get; set; }

        /// <summary>
        /// Задержка между получением данных с ОРС-серверов и отправкой их SQL-серверы.
        /// </summary>
        public int ThreadMainDelay { get; set; }

        /// <summary>
        /// Количество завершенных устройств.
        /// </summary>
        public int FinishedCount { get; set; }

        /// <summary>
        /// Количество активных устройств.
        /// </summary>
        public int ActiveCount { get; set; }

        /// <summary>
        /// Название приложения.
        /// </summary>
        public string AppName { get; set; }        

        /// <summary>
        /// Время инициализации системы.
        /// </summary>
        public DateTime InitTime { get; set; }

        /// <summary>
        /// Время работы системы.
        /// </summary>
        public TimeSpan WorkTimeSpanDays { get; set; }

        /// <summary>
        /// Инициализация переменных.
        /// </summary>
        public void Init()
        {
            Version = "v1.0.1";

            InitTime = DateTime.Now;

            string fileName = Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location);
            varXml = new VarXml(string.Format("{0}.xml", fileName));
            varXml.LoadFromXML();

            CollectionWithUnits = new XPCollectionWithUnits();
            DeviceCollection = (CollectionWithUnits.Add(typeof(Device))).Collection;

            DeviceRealCollection = new Collection<DeviceReal>();

            CopyDataToReal();

            // Отправка значений на интерфейс.
            foreach (DeviceReal deviceReal in DeviceRealCollection)
                deviceReal.SendDataToXPObject();

            ThreadMain = new ThreadTimer();
            ThreadMain.Period = varXml.ThreadMainPeriod;
            ThreadMain.WorkChanged += new EventHandler(ThreadMain_WorkChanged);
            ThreadMain.Run();

            ThreadMainDelay = varXml.ThreadMainDelay;
            AppName = varXml.AppName;

            WorkerReboot = new BackgroundWorker();
            WorkerReboot.DoWork += new DoWorkEventHandler(WorkerReboot_DoWork);
        }

        /// <summary>
        /// Заполнение данных реальных объектов с БД.
        /// </summary>
        public void FillData<T, TReal>(XPCollection xpCollection, CollectionEx<TReal> realCollection)
        {
            realCollection.Clear();
            foreach (T server in xpCollection)
                realCollection.Add((TReal)Activator.CreateInstance(typeof(TReal), server, DeviceRealCollection));
        }
        
        /// <summary>
        /// Копирование данных из файла в коллекцию.
        /// </summary>
        public void CopyDataToReal()
        {
            foreach (Device item in DeviceCollection)
                DeviceRealCollection.Add(new DeviceReal(item));
        }

        /// <summary>
        /// Инициализации определенной коллекции данных.
        /// </summary>
        public void InitXPCollection(XPCollection collection, Type type, Session session)
        {
            collection = new XPCollection();
            XPCollectionContainer.InitXPCollection(collection, type, session);
        }

        /// <summary>
        /// Перезагрузка потока и его инициализация.
        /// </summary>
        public void Reboot()
        {
            if (!WorkerReboot.IsBusy)
                WorkerReboot.RunWorkerAsync();
        }

        void WorkerReboot_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            CopyDataToReal();
            ThreadMain.Run();
            XtraMessageBox.Show("Выполнена перезагрузка потока.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Основная функция, которая выполняется в главном потоке.
        /// </summary>
        void ThreadMain_WorkChanged(object sender, EventArgs e)
        {
            FinishedCount = ActiveCount = 0;
            foreach (DeviceReal device in DeviceRealCollection)
            {
                if (device.Active)
                    ActiveCount++;

                if (device.Finished)
                    FinishedCount++;
            }

            Thread.Sleep(ThreadMainDelay);

            /*
            // Отправка значений на интерфейс.
            foreach (DeviceReal item in DeviceRealCollection)
                item.SendDataToXPObject();
            */

            WorkTimeSpanDays = DateTime.Now - InitTime;
        }

        /// <summary>
        /// Получение статуса работы главного потока.
        /// </summary>
        public string GetStatusInfo()
        {
            return string.Format("{0}/{1}", FinishedCount, ActiveCount);
        }
    }

    public class Global
    {
        private static GlobalDefault defaultInstance = new GlobalDefault();
        public static GlobalDefault Default { get { return defaultInstance; } }
    }
}