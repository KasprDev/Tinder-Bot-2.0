namespace TinderBot2._0
{
    partial class MainForm
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
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLikerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(12, 36);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(84, 82);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(100, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "N/A";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoLikerToolStripMenuItem,
            this.messagerToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // autoLikerToolStripMenuItem
            // 
            this.autoLikerToolStripMenuItem.Name = "autoLikerToolStripMenuItem";
            this.autoLikerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoLikerToolStripMenuItem.Text = "Auto Liker";
            this.autoLikerToolStripMenuItem.Click += new System.EventHandler(this.autoLikerToolStripMenuItem_Click);
            // 
            // messagerToolStripMenuItem
            // 
            this.messagerToolStripMenuItem.Name = "messagerToolStripMenuItem";
            this.messagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messagerToolStripMenuItem.Text = "Messager";
            this.messagerToolStripMenuItem.Click += new System.EventHandler(this.messagerToolStripMenuItem_Click);
            // 
            // lblBio
            // 
            this.lblBio.ForeColor = System.Drawing.Color.DimGray;
            this.lblBio.Location = new System.Drawing.Point(100, 55);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(372, 63);
            this.lblBio.TabIndex = 4;
            this.lblBio.Text = "lblBio";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 128);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureUser;
        private Label labelName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem functionsToolStripMenuItem;
        private ToolStripMenuItem autoLikerToolStripMenuItem;
        private Label lblBio;
        private ToolStripMenuItem messagerToolStripMenuItem;
    }
}