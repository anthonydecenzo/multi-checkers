namespace multicheckers.Server
{
    partial class ServerGUI
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
            this.btnServerStart = new CS_ClassLibraryTester.OriginButton();
            this.originGroupBox1 = new CS_ClassLibraryTester.OriginGroupBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.originTheme1.SuspendLayout();
            this.originGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // originTheme1
            // 
            this.originTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.originTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.originTheme1.Controls.Add(this.originGroupBox1);
            this.originTheme1.Controls.Add(this.btnServerStart);
            this.originTheme1.Customization = "JiYn//////8=";
            this.originTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originTheme1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.originTheme1.Image = null;
            this.originTheme1.Location = new System.Drawing.Point(0, 0);
            this.originTheme1.Movable = true;
            this.originTheme1.Name = "originTheme1";
            this.originTheme1.NoRounding = false;
            this.originTheme1.Sizable = true;
            this.originTheme1.Size = new System.Drawing.Size(800, 450);
            this.originTheme1.SmartBounds = true;
            this.originTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.originTheme1.TabIndex = 0;
            this.originTheme1.Text = "originTheme1";
            this.originTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.originTheme1.Transparent = false;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Customization = "AKX/////////////";
            this.btnServerStart.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnServerStart.Image = null;
            this.btnServerStart.Location = new System.Drawing.Point(542, 202);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.NoRounding = false;
            this.btnServerStart.Size = new System.Drawing.Size(246, 23);
            this.btnServerStart.TabIndex = 0;
            this.btnServerStart.Text = "Start Server";
            this.btnServerStart.Transparent = false;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // originGroupBox1
            // 
            this.originGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.originGroupBox1.Controls.Add(this.txtServerPort);
            this.originGroupBox1.Controls.Add(this.label2);
            this.originGroupBox1.Controls.Add(this.label1);
            this.originGroupBox1.Controls.Add(this.txtServerIP);
            this.originGroupBox1.Customization = "wMDA/4CAgP//////";
            this.originGroupBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.originGroupBox1.Image = null;
            this.originGroupBox1.Location = new System.Drawing.Point(12, 35);
            this.originGroupBox1.Movable = true;
            this.originGroupBox1.Name = "originGroupBox1";
            this.originGroupBox1.NoRounding = false;
            this.originGroupBox1.Sizable = true;
            this.originGroupBox1.Size = new System.Drawing.Size(776, 161);
            this.originGroupBox1.SmartBounds = true;
            this.originGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.originGroupBox1.TabIndex = 1;
            this.originGroupBox1.Text = "Server Information";
            this.originGroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.originGroupBox1.Transparent = false;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(16, 55);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(204, 20);
            this.txtServerIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port:";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(265, 55);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(166, 20);
            this.txtServerPort.TabIndex = 3;
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.originTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerGUI";
            this.Text = "ServerGUI";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.originTheme1.ResumeLayout(false);
            this.originGroupBox1.ResumeLayout(false);
            this.originGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.OriginTheme originTheme1;
        private CS_ClassLibraryTester.OriginGroupBox originGroupBox1;
        private CS_ClassLibraryTester.OriginButton btnServerStart;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
    }
}