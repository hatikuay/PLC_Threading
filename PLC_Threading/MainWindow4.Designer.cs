namespace PLC_Threading
{
    partial class MainWindow4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetDwordVariable = new System.Windows.Forms.TextBox();
            this.txtSetAutomaticSpeed = new System.Windows.Forms.TextBox();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.txtSetTemperature = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblAutomaticSpeed = new System.Windows.Forms.Label();
            this.lblSetDwordVariable = new System.Windows.Forms.Label();
            this.lblReadTime = new System.Windows.Forms.Label();
            this.lblConnectionState = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 98;
            this.label1.Text = "Set real variable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 97;
            this.label2.Text = "Set word variable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "Set DInt variable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 95;
            this.label4.Text = "Set Dword variable:";
            // 
            // txtSetDwordVariable
            // 
            this.txtSetDwordVariable.Location = new System.Drawing.Point(232, 219);
            this.txtSetDwordVariable.Name = "txtSetDwordVariable";
            this.txtSetDwordVariable.Size = new System.Drawing.Size(100, 23);
            this.txtSetDwordVariable.TabIndex = 94;
            this.txtSetDwordVariable.TextChanged += new System.EventHandler(this.txtSetDwordVariable_TextChanged);
            // 
            // txtSetAutomaticSpeed
            // 
            this.txtSetAutomaticSpeed.Location = new System.Drawing.Point(232, 190);
            this.txtSetAutomaticSpeed.Name = "txtSetAutomaticSpeed";
            this.txtSetAutomaticSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtSetAutomaticSpeed.TabIndex = 93;
            this.txtSetAutomaticSpeed.TextChanged += new System.EventHandler(this.txtSetAutomaticSpeed_TextChanged);
            // 
            // txtSetSpeed
            // 
            this.txtSetSpeed.Location = new System.Drawing.Point(232, 161);
            this.txtSetSpeed.Name = "txtSetSpeed";
            this.txtSetSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtSetSpeed.TabIndex = 92;
            this.txtSetSpeed.TextChanged += new System.EventHandler(this.txtSetSpeed_TextChanged);
            // 
            // txtSetTemperature
            // 
            this.txtSetTemperature.Location = new System.Drawing.Point(232, 132);
            this.txtSetTemperature.Name = "txtSetTemperature";
            this.txtSetTemperature.Size = new System.Drawing.Size(100, 23);
            this.txtSetTemperature.TabIndex = 91;
            this.txtSetTemperature.TextChanged += new System.EventHandler(this.txtSetTemperature_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 197);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 45);
            this.btnStop.TabIndex = 90;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 132);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 45);
            this.btnStart.TabIndex = 89;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(338, 135);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(45, 15);
            this.lblTemperature.TabIndex = 88;
            this.lblTemperature.Text = "###.##";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(338, 164);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(45, 15);
            this.lblSpeed.TabIndex = 87;
            this.lblSpeed.Text = "###.##";
            // 
            // lblAutomaticSpeed
            // 
            this.lblAutomaticSpeed.AutoSize = true;
            this.lblAutomaticSpeed.Location = new System.Drawing.Point(338, 193);
            this.lblAutomaticSpeed.Name = "lblAutomaticSpeed";
            this.lblAutomaticSpeed.Size = new System.Drawing.Size(45, 15);
            this.lblAutomaticSpeed.TabIndex = 86;
            this.lblAutomaticSpeed.Text = "###.##";
            // 
            // lblSetDwordVariable
            // 
            this.lblSetDwordVariable.AutoSize = true;
            this.lblSetDwordVariable.Location = new System.Drawing.Point(338, 222);
            this.lblSetDwordVariable.Name = "lblSetDwordVariable";
            this.lblSetDwordVariable.Size = new System.Drawing.Size(45, 15);
            this.lblSetDwordVariable.TabIndex = 85;
            this.lblSetDwordVariable.Text = "###.##";
            // 
            // lblReadTime
            // 
            this.lblReadTime.AutoSize = true;
            this.lblReadTime.Location = new System.Drawing.Point(152, 269);
            this.lblReadTime.Name = "lblReadTime";
            this.lblReadTime.Size = new System.Drawing.Size(95, 15);
            this.lblReadTime.TabIndex = 84;
            this.lblReadTime.Text = "Cyclic read time:";
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.AutoSize = true;
            this.lblConnectionState.Location = new System.Drawing.Point(12, 269);
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(100, 15);
            this.lblConnectionState.TabIndex = 83;
            this.lblConnectionState.Text = "Connection state:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(12, 53);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(100, 23);
            this.txtIpAddress.TabIndex = 82;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(215, 53);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(91, 45);
            this.btnDisconnect.TabIndex = 81;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 52);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 45);
            this.btnConnect.TabIndex = 80;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // MainWindow4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSetDwordVariable);
            this.Controls.Add(this.txtSetAutomaticSpeed);
            this.Controls.Add(this.txtSetSpeed);
            this.Controls.Add(this.txtSetTemperature);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblAutomaticSpeed);
            this.Controls.Add(this.lblSetDwordVariable);
            this.Controls.Add(this.lblReadTime);
            this.Controls.Add(this.lblConnectionState);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainWindow4";
            this.Text = "MainWindow4";
            this.Load += new System.EventHandler(this.MainWindow4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSetDwordVariable;
        private TextBox txtSetAutomaticSpeed;
        private TextBox txtSetSpeed;
        private TextBox txtSetTemperature;
        private Button btnStop;
        private Button btnStart;
        private Label lblTemperature;
        private Label lblSpeed;
        private Label lblAutomaticSpeed;
        private Label lblSetDwordVariable;
        private Label lblReadTime;
        private Label lblConnectionState;
        private TextBox txtIpAddress;
        private Button btnDisconnect;
        private Button btnConnect;
        private System.Windows.Forms.Timer timer1;
    }
}