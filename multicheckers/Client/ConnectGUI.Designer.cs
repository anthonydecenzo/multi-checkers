namespace multicheckers.Client
{
    partial class ConnectGUI
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
            this.originTheme1 = new CS_ClassLibraryTester.OriginTheme();
            this.btnConnect = new CS_ClassLibraryTester.OriginButton();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // originTheme1
            // 
            this.originTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.originTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.originTheme1.Controls.Add(this.label3);
            this.originTheme1.Controls.Add(this.txtUsername);
            this.originTheme1.Controls.Add(this.label2);
            this.originTheme1.Controls.Add(this.label1);
            this.originTheme1.Controls.Add(this.txtServerPort);
            this.originTheme1.Controls.Add(this.txtServerIP);
            this.originTheme1.Controls.Add(this.btnConnect);
            this.originTheme1.Customization = "JiYn//////8=";
            this.originTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originTheme1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.originTheme1.Image = null;
            this.originTheme1.Location = new System.Drawing.Point(0, 0);
            this.originTheme1.Movable = true;
            this.originTheme1.Name = "originTheme1";
            this.originTheme1.NoRounding = false;
            this.originTheme1.Sizable = true;
            this.originTheme1.Size = new System.Drawing.Size(456, 179);
            this.originTheme1.SmartBounds = true;
            this.originTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.originTheme1.TabIndex = 0;
            this.originTheme1.Text = "Server Connect";
            this.originTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.originTheme1.Transparent = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Customization = "AKX/////////////";
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnConnect.Image = null;
            this.btnConnect.Location = new System.Drawing.Point(122, 144);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoRounding = false;
            this.btnConnect.Size = new System.Drawing.Size(188, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Transparent = false;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(12, 59);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(153, 23);
            this.txtServerIP.TabIndex = 1;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(241, 59);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(153, 23);
            this.txtServerPort.TabIndex = 2;
            this.txtServerPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Port:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(122, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConnectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 179);
            this.Controls.Add(this.originTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectGUI";
            this.Text = "ConnectGUI";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.originTheme1.ResumeLayout(false);
            this.originTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.OriginTheme originTheme1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private CS_ClassLibraryTester.OriginButton btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
    }
}