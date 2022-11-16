namespace PLC_Threading
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.lblConnectionState = new System.Windows.Forms.Label();
            this.lblReadTime = new System.Windows.Forms.Label();
            this.lblSetDwordVariable = new System.Windows.Forms.Label();
            this.lblAutomaticSpeed = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtSetTemperature = new System.Windows.Forms.TextBox();
            this.txtSetSpeed = new System.Windows.Forms.TextBox();
            this.txtSetAutomaticSpeed = new System.Windows.Forms.TextBox();
            this.txtSetDwordVariable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 45);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(215, 47);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(91, 45);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(12, 47);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(100, 23);
            this.txtIpAddress.TabIndex = 2;
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.AutoSize = true;
            this.lblConnectionState.Location = new System.Drawing.Point(12, 263);
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(100, 15);
            this.lblConnectionState.TabIndex = 3;
            this.lblConnectionState.Text = "Connection state:";
            // 
            // lblReadTime
            // 
            this.lblReadTime.AutoSize = true;
            this.lblReadTime.Location = new System.Drawing.Point(152, 263);
            this.lblReadTime.Name = "lblReadTime";
            this.lblReadTime.Size = new System.Drawing.Size(95, 15);
            this.lblReadTime.TabIndex = 4;
            this.lblReadTime.Text = "Cyclic read time:";
            // 
            // lblSetDwordVariable
            // 
            this.lblSetDwordVariable.AutoSize = true;
            this.lblSetDwordVariable.Location = new System.Drawing.Point(338, 216);
            this.lblSetDwordVariable.Name = "lblSetDwordVariable";
            this.lblSetDwordVariable.Size = new System.Drawing.Size(45, 15);
            this.lblSetDwordVariable.TabIndex = 5;
            this.lblSetDwordVariable.Text = "###.##";
            this.lblSetDwordVariable.Click += new System.EventHandler(this.lblSetDwordVariable_Click);
            // 
            // lblAutomaticSpeed
            // 
            this.lblAutomaticSpeed.AutoSize = true;
            this.lblAutomaticSpeed.Location = new System.Drawing.Point(338, 187);
            this.lblAutomaticSpeed.Name = "lblAutomaticSpeed";
            this.lblAutomaticSpeed.Size = new System.Drawing.Size(45, 15);
            this.lblAutomaticSpeed.TabIndex = 6;
            this.lblAutomaticSpeed.Text = "###.##";
            this.lblAutomaticSpeed.Click += new System.EventHandler(this.lblAutomaticSpeed_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(338, 158);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(45, 15);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "###.##";
            this.lblSpeed.Click += new System.EventHandler(this.lblSpeed_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(338, 129);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(45, 15);
            this.lblTemperature.TabIndex = 8;
            this.lblTemperature.Text = "###.##";
            this.lblTemperature.Click += new System.EventHandler(this.lblTemperature_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 126);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 45);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 191);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 45);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtSetTemperature
            // 
            this.txtSetTemperature.Location = new System.Drawing.Point(232, 126);
            this.txtSetTemperature.Name = "txtSetTemperature";
            this.txtSetTemperature.Size = new System.Drawing.Size(100, 23);
            this.txtSetTemperature.TabIndex = 15;
            this.txtSetTemperature.TextChanged += new System.EventHandler(this.txtSetTemperature_TextChanged);
            // 
            // txtSetSpeed
            // 
            this.txtSetSpeed.Location = new System.Drawing.Point(232, 155);
            this.txtSetSpeed.Name = "txtSetSpeed";
            this.txtSetSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtSetSpeed.TabIndex = 16;
            this.txtSetSpeed.TextChanged += new System.EventHandler(this.txtSetSpeed_TextChanged);
            // 
            // txtSetAutomaticSpeed
            // 
            this.txtSetAutomaticSpeed.Location = new System.Drawing.Point(232, 184);
            this.txtSetAutomaticSpeed.Name = "txtSetAutomaticSpeed";
            this.txtSetAutomaticSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtSetAutomaticSpeed.TabIndex = 17;
            this.txtSetAutomaticSpeed.TextChanged += new System.EventHandler(this.txtSetAutomaticSpeed_TextChanged);
            // 
            // txtSetDwordVariable
            // 
            this.txtSetDwordVariable.Location = new System.Drawing.Point(232, 213);
            this.txtSetDwordVariable.Name = "txtSetDwordVariable";
            this.txtSetDwordVariable.Size = new System.Drawing.Size(100, 23);
            this.txtSetDwordVariable.TabIndex = 18;
            this.txtSetDwordVariable.TextChanged += new System.EventHandler(this.txtSetDwordVariable_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Set real variable:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Set word variable:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Set DInt variable:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Set Dword variable:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainWindow
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
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Button btnConnect;
        private Button btnDisconnect;
        private TextBox txtIpAddress;
        private Label lblConnectionState;
        private Label lblReadTime;
        private Label lblSetDwordVariable;
        private Label lblAutomaticSpeed;
        private Label lblSpeed;
        private Label lblTemperature;
        private Button btnStart;
        private Button btnStop;
        private TextBox txtSetTemperature;
        private TextBox txtSetSpeed;
        private TextBox txtSetAutomaticSpeed;
        private TextBox txtSetDwordVariable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}