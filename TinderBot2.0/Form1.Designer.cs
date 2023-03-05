namespace TinderBot2._0
{
    partial class Form1
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
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProxyPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProxyUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProxyIp = new System.Windows.Forms.TextBox();
            this.checkStayLoggedIn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Location = new System.Drawing.Point(12, 27);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(280, 23);
            this.txtAuthToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X-Auth-Token";
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(12, 198);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(280, 31);
            this.btnInitialize.TabIndex = 2;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProxyPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProxyUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProxyPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProxyIp);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proxy Password";
            // 
            // txtProxyPass
            // 
            this.txtProxyPass.Location = new System.Drawing.Point(144, 85);
            this.txtProxyPass.Name = "txtProxyPass";
            this.txtProxyPass.Size = new System.Drawing.Size(128, 23);
            this.txtProxyPass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proxy Username";
            // 
            // txtProxyUser
            // 
            this.txtProxyUser.Location = new System.Drawing.Point(6, 85);
            this.txtProxyUser.Name = "txtProxyUser";
            this.txtProxyUser.Size = new System.Drawing.Size(128, 23);
            this.txtProxyUser.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Location = new System.Drawing.Point(144, 37);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(128, 23);
            this.txtProxyPort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP Address";
            // 
            // txtProxyIp
            // 
            this.txtProxyIp.Location = new System.Drawing.Point(6, 37);
            this.txtProxyIp.Name = "txtProxyIp";
            this.txtProxyIp.Size = new System.Drawing.Size(128, 23);
            this.txtProxyIp.TabIndex = 4;
            // 
            // checkStayLoggedIn
            // 
            this.checkStayLoggedIn.AutoSize = true;
            this.checkStayLoggedIn.Location = new System.Drawing.Point(13, 176);
            this.checkStayLoggedIn.Name = "checkStayLoggedIn";
            this.checkStayLoggedIn.Size = new System.Drawing.Size(104, 19);
            this.checkStayLoggedIn.TabIndex = 4;
            this.checkStayLoggedIn.Text = "Stay Logged In";
            this.checkStayLoggedIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 239);
            this.Controls.Add(this.checkStayLoggedIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthToken);
            this.Name = "Form1";
            this.Text = "Account Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAuthToken;
        private Label label1;
        private Button btnInitialize;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtProxyPort;
        private Label label2;
        private TextBox txtProxyIp;
        private CheckBox checkStayLoggedIn;
        private Label label4;
        private TextBox txtProxyPass;
        private Label label5;
        private TextBox txtProxyUser;
    }
}