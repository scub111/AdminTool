using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;
using DevExpress.Xpo;

namespace AdminTool
{
    #region Item
    /// <summary>
    /// Таблица "Устройство".
    /// </summary>
    [DBAttribute(Caption = "Устройство", IconFile = "Device.png")]
    public class Device : XPObjectEx
    {
        public Device() : base(Session.DefaultSession) { }

        public Device(Session session) : base(session) { }

        bool _Active;
        /// <summary>
        /// Актив.
        /// </summary>
        [DisplayName("Актив")]
        public bool Active
        {
            get { return _Active; }
            set { SetPropertyValueEx("Active", ref _Active, value); }
        }

        string _IPAddress;
        /// <summary>
        /// IP-адрес.
        /// </summary>
        [DisplayName("IP-адрес")]
        [Size(SizeAttribute.Unlimited)]
        public string IPAddress
        {
            get { return _IPAddress; }
            set { SetPropertyValueEx("IPAddress", ref _IPAddress, value); }
        }

        string _Description;
        /// <summary>
        /// Описание.
        /// </summary>
        [DisplayName("Описание")]
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValueEx("Description", ref _Description, value); }
        }

        string _WindowsVersion;
        /// <summary>
        /// Caption.
        /// </summary>
        [DisplayName("ОС")]
        [Size(SizeAttribute.Unlimited)]
        public string WindowsVersion
        {
            get { return _WindowsVersion; }
            set { SetPropertyValueEx("WindowsVersion", ref _WindowsVersion, value); }
        }

        string _UserName;
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [DisplayName("Пользователь")]
        [Size(SizeAttribute.Unlimited)]
        public string UserName
        {
            get { return _UserName; }
            set { SetPropertyValueEx("UserName", ref _UserName, value); }
        }

        /// <summary>
        /// Таблица-коллекция "Заявки".
        /// </summary>
        [DisplayName("Заявки")]
        [Association("Device-DeviceRequestCollection"), Aggregated]
        public XPCollection<DeviceRequestCollection> DeviceRequestCollection
        {
            get { return GetCollection<DeviceRequestCollection>("DeviceRequestCollection"); }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Объект реального времени.
        /// </summary>
        [NonPersistent]
        [DisplayName("Устройство")]
        public DeviceReal DeviceReal { get; set; }

        /// <summary>
        /// Тип переменной.
        /// </summary>
        [DisplayName("Пинг")]
        [NonPersistent]
        public bool Pinged 
        {
            get
            {
                if (DeviceReal != null)
                    return DeviceReal.Pinged;
                else
                    return false;
            }
        }

        /// <summary>
        /// Тип переменной.
        /// </summary>
        [DisplayName("Время пинга")]
        [NonPersistent]
        public int ReplyTime
        {
            get
            {
                if (DeviceReal != null)
                    return DeviceReal.ReplyTime;
                else
                    return -1;
            }
        }

        /// <summary>
        /// Ошибка.
        /// </summary>
        [DisplayName("Ошибка")]
        [NonPersistent]
        public string Error
        {
            get
            {
                if (DeviceReal != null)
                    return DeviceReal.Error;
                else
                    return "[null]";
            }
        }

        /// <summary>
        /// Выполнен.
        /// </summary>
        [DisplayName("Выполнен")]
        [NonPersistent]
        public bool Done
        {
            get
            {
                if (DeviceReal != null)
                    return DeviceReal.Done;
                else
                    return false;
            }
        }

        /// <summary>
        /// Завершен.
        /// </summary>
        [DisplayName("Завершен")]
        [NonPersistent]
        public bool Finished
        {
            get
            {
                if (DeviceReal != null)
                    return DeviceReal.Finished;
                else
                    return false;
            }
        }

        /// <summary>
        /// Получение данных с реального объекта.
        /// </summary>
        public void GetDataFromReal()
        {
            if (DeviceReal != null)
            {
                if (!string.IsNullOrEmpty(DeviceReal.WindowsVersion))
                    WindowsVersion = DeviceReal.WindowsVersion;

                if (!string.IsNullOrEmpty(DeviceReal.UserName))
                    UserName = DeviceReal.UserName;
            }
        }

        public override void Init()
        {
            base.Init();
            if (!IsLoading)
            {
                IPAddress = "172.31.106.121";
            }
        }
    }
    #endregion

    #region DeviceRequestCollection
    /// <summary>
    /// Таблица-коллекция "Заявки".
    /// </summary>
    [DBAttribute(Caption = "Заявки", IconFile = "DeviceRequestCollection.png")]
    public class DeviceRequestCollection : XPObjectEx
    {
        public DeviceRequestCollection() : base(Session.DefaultSession) { }

        public DeviceRequestCollection(Session session) : base(session) { }

        Device _DeviceOwner;
        /// <summary>
        /// Владелец "Устройство".
        /// </summary>
        [DisplayName("Владелец \"Устройство\"")]
        [Association("Device-DeviceRequestCollection")]
        public Device DeviceOwner
        {
            get { return _DeviceOwner; }
            set { SetPropertyValueEx("DeviceOwner", ref _DeviceOwner, value); }
        }

        bool _Done;
        /// <summary>
        /// Выполнен.
        /// </summary>
        [DisplayName("Выполнен")]
        public bool Done
        {
            get { return _Done; }
            set
            {
                if (value)
                    DoneTime = DateTime.Now;
                SetPropertyValueEx("Done", ref _Done, value);
            }
        }

        DateTime _DoneTime;
        /// <summary>
        /// Время выполнения.
        /// </summary>
        [DisplayName("Время выполнения")]
        public DateTime DoneTime
        {
            get { return _DoneTime; }
            set { SetPropertyValueEx("DoneTime", ref _DoneTime, value); }
        }

        string _Request;
        /// <summary>
        /// Заявка.
        /// </summary>
        [DisplayName("Заявка")]
        [Size(SizeAttribute.Unlimited)]
        public string Request
        {
            get { return _Request; }
            set { SetPropertyValueEx("Request", ref _Request, value); }
        }

        string _Comment;
        /// <summary>
        /// Комментарий.
        /// </summary>
        [DisplayName("Комментарий")]
        [Size(SizeAttribute.Unlimited)]
        public string Comment
        {
            get { return _Comment; }
            set { SetPropertyValueEx("Comment", ref _Comment, value); }
        }

        protected override void OnSaving()
        {
            if (this.DeviceOwner == null)
                Delete();
            base.OnSaving();
        }
    }
    #endregion
}
