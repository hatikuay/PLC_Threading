using PLC_Threading.PlcConnectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PLC_Threading
{
    public partial class MainWindow4 : Form
    {
        public MainWindow4()
        {
            InitializeComponent();
            //timer.Interval = TimeSpan.FromMilliseconds(100);
            timer1.Tick += timer_Tick;
            timer1.Enabled = true;
            txtIpAddress.Text = Settings.Default.IpAddress;
        }


        private void MainWindow4_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnConnect.Enabled = Plc4.Instance.ConnectionState == ConnectionStates.Offline;
            btnDisconnect.Enabled = Plc4.Instance.ConnectionState != ConnectionStates.Offline;
            lblConnectionState.Text = Plc4.Instance.ConnectionState.ToString();
            //ledMachineInRun.Fill = Plc4.Instance.Db1.BitVariable0 ? Brushes.Green : Brushes.Gray;
            lblSpeed.Text = Plc4.Instance.Db1.IntVariable.ToString();
            lblTemperature.Text = Plc4.Instance.Db1.RealVariable.ToString();
            lblAutomaticSpeed.Text = Plc4.Instance.Db1.DIntVariable.ToString();
            lblSetDwordVariable.Text = Plc4.Instance.Db1.DWordVariable.ToString();
            // statusbar
            lblReadTime.Text = Plc4.Instance.CycleReadTime.TotalMilliseconds.ToString(CultureInfo.InvariantCulture);

        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            try
            {
                Plc4.Instance.Connect(txtIpAddress.Text);
                Settings.Default.IpAddress = txtIpAddress.Text;
                Settings.Default.Save();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Plc4.Instance.Disconnect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Plc4.Instance.Write(PlcTags.BitVariable, 1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                Plc4.Instance.Write(PlcTags.BitVariable, 0);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtSetTemperature_TextChanged(object sender, EventArgs e)
        {
            double realVar;
            bool canConvert = Double.TryParse(txtSetTemperature.Text, out realVar);
            if (canConvert)
            {
                Plc4.Instance.Write(PlcTags.DoubleVariable, realVar);
            }
        }

        private void txtSetSpeed_TextChanged(object sender, EventArgs e)
        {
            short wordVar;
            bool canConvert = short.TryParse(txtSetSpeed.Text, out wordVar);
            if (canConvert)
            {
                Plc4.Instance.Write(PlcTags.IntVariable, wordVar);
            }

        }

        private void txtSetAutomaticSpeed_TextChanged(object sender, EventArgs e)
        {
            int dintVar;
            bool canConvert = int.TryParse(txtSetAutomaticSpeed.Text, out dintVar);
            if (canConvert)
            {
                Plc4.Instance.Write(PlcTags.DIntVariable, dintVar);
            }
        }

        private void txtSetDwordVariable_TextChanged(object sender, EventArgs e)
        {
            ushort dwordVar;
            bool canConvert = ushort.TryParse(txtSetDwordVariable.Text, out dwordVar);
            if (canConvert)
            {
                Plc4.Instance.Write(PlcTags.DwordVariable, dwordVar);
            }
        }
    }
}
