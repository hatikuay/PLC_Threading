using PLC_Threading.PlcConnectivity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;





namespace PLC_Threading
{
    public partial class MainWindow : Form
    {
        //DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            //timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += timer_Tick;
            timer.Enabled = true;
            txtIpAddress.Text = Settings.Default.IpAddress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnConnect.Enabled = Plc.Instance.ConnectionState == ConnectionStates.Offline;
            btnDisconnect.Enabled = Plc.Instance.ConnectionState != ConnectionStates.Offline;
            lblConnectionState.Text = Plc.Instance.ConnectionState.ToString();
            //ledMachineInRun.Fill = Plc.Instance.Db1.BitVariable0 ? Brushes.Green : Brushes.Gray;
            lblSpeed.Text = Plc.Instance.Db1.IntVariable.ToString();
            lblTemperature.Text = Plc.Instance.Db1.RealVariable.ToString();
            lblAutomaticSpeed.Text = Plc.Instance.Db1.DIntVariable.ToString();
            lblSetDwordVariable.Text = Plc.Instance.Db1.DWordVariable.ToString();
            // statusbar
            lblReadTime.Text = Plc.Instance.CycleReadTime.TotalMilliseconds.ToString(CultureInfo.InvariantCulture);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Plc.Instance.Connect(txtIpAddress.Text);
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
                Plc.Instance.Disconnect();
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
                Plc.Instance.Write(PlcTags.BitVariable, 1);
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
                Plc.Instance.Write(PlcTags.BitVariable, 0);
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
                Plc.Instance.Write(PlcTags.DoubleVariable, realVar);
            }
        }

        private void txtSetSpeed_TextChanged(object sender, EventArgs e)
        {
            short wordVar;
            bool canConvert = short.TryParse(txtSetSpeed.Text, out wordVar);
            if (canConvert)
            {
                Plc.Instance.Write(PlcTags.IntVariable, wordVar);
            }

        }

        private void txtSetAutomaticSpeed_TextChanged(object sender, EventArgs e)
        {
            int dintVar;
            bool canConvert = int.TryParse(txtSetAutomaticSpeed.Text, out dintVar);
            if (canConvert)
            {
                Plc.Instance.Write(PlcTags.DIntVariable, dintVar);
            }
        }

        private void txtSetDwordVariable_TextChanged(object sender, EventArgs e)
        {
            ushort dwordVar;
            bool canConvert = ushort.TryParse(txtSetDwordVariable.Text, out dwordVar);
            if (canConvert)
            {
                Plc.Instance.Write(PlcTags.DwordVariable, dwordVar);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {

        }

        private void lblSpeed_Click(object sender, EventArgs e)
        {

        }

        private void lblAutomaticSpeed_Click(object sender, EventArgs e)
        {

        }

        private void lblSetDwordVariable_Click(object sender, EventArgs e)
        {

        }
    }
}