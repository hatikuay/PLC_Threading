using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PLC_Threading.PlcConnectivity
{
    internal class Plc3
    {

        #region Singleton

         private static readonly Lazy<Plc3> _instance = new Lazy<Plc3>(() => new Plc3());

        public static Plc3 Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        #endregion

        #region Public properties

        public ConnectionStates ConnectionState { get { return plcDriver != null ? plcDriver.ConnectionState : ConnectionStates.Offline; } }

        public DB1 Db1 { get; set; }

        public TimeSpan CycleReadTime { get; private set; }

        #endregion

        #region Private fields

        IPlcSyncDriver plcDriver;
        readonly System.Timers.Timer timer = new System.Timers.Timer();

        public DateTime lastReadTime;

        #endregion

        #region Constructor

        private Plc3()
        {
            Db1 = new DB1();
            timer.Interval = 100; // ms
            timer.Elapsed += timer_Elapsed;
            timer.Enabled = true;
            lastReadTime = DateTime.Now;
        }

        #endregion

        #region Event handlers

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (plcDriver == null || plcDriver.ConnectionState != ConnectionStates.Online)
            {
                return;
            }

            timer.Enabled = false;
            CycleReadTime = DateTime.Now - lastReadTime;
            try
            {
                RefreshTags();
            }
            finally
            {
                timer.Enabled = true;
                lastReadTime = DateTime.Now;
            }
        }

        #endregion

        #region Public methods

        public void Connect(string ipAddress)
        {
            if (!IsValidIp(ipAddress))
            {
                throw new ArgumentException("Ip address is not valid");
            }
            plcDriver = new S7NetPlcDriver(CpuType.S71200, ipAddress, 0, 1);
            plcDriver.Connect();
        }

        public void Disconnect()
        {
            if (plcDriver == null || this.ConnectionState == ConnectionStates.Offline)
            {
                return;
            }
            plcDriver.Disconnect();
        }

        public void Write(string name, object value)
        {
            if (plcDriver == null || plcDriver.ConnectionState != ConnectionStates.Online)
            {
                return;
            }
            Tag tag = new Tag(name, value);
            List<Tag> tagList = new List<Tag>();
            tagList.Add(tag);
            plcDriver.WriteItems(tagList);
        }

        public void Write(List<Tag> tags)
        {
            if (plcDriver == null || plcDriver.ConnectionState != ConnectionStates.Online)
            {
                return;
            }
            plcDriver.WriteItems(tags);
        }

        #endregion

        #region Private methods

        private bool IsValidIp(string addr)
        {
            IPAddress? ip;
            bool valid = !string.IsNullOrEmpty(addr) && IPAddress.TryParse(addr, out ip);
            return valid;
        }

        private void RefreshTags()
        {
            plcDriver.ReadClass(Db1, 1);
        }

        #endregion


    }
}

