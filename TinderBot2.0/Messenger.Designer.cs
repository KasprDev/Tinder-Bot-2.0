namespace TinderBot2._0
{
    partial class Messenger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.massDelay2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.massDelay1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnMassMessage = new System.Windows.Forms.Button();
            this.btnSelectMass = new System.Windows.Forms.Button();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massDelay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massDelay1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.massDelay2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.massDelay1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnMassMessage);
            this.groupBox1.Controls.Add(this.btnSelectMass);
            this.groupBox1.Controls.Add(this.txtMass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mass Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // massDelay2
            // 
            this.massDelay2.Location = new System.Drawing.Point(111, 87);
            this.massDelay2.Name = "massDelay2";
            this.massDelay2.Size = new System.Drawing.Size(84, 23);
            this.massDelay2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delay (s)";
            // 
            // massDelay1
            // 
            this.massDelay1.Location = new System.Drawing.Point(6, 87);
            this.massDelay1.Name = "massDelay1";
            this.massDelay1.Size = new System.Drawing.Size(84, 23);
            this.massDelay1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Message New Matches";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnMassMessage
            // 
            this.btnMassMessage.Location = new System.Drawing.Point(6, 116);
            this.btnMassMessage.Name = "btnMassMessage";
            this.btnMassMessage.Size = new System.Drawing.Size(189, 29);
            this.btnMassMessage.TabIndex = 2;
            this.btnMassMessage.Text = "Start";
            this.btnMassMessage.UseVisualStyleBackColor = true;
            this.btnMassMessage.Click += new System.EventHandler(this.btnMassMessage_Click);
            // 
            // btnSelectMass
            // 
            this.btnSelectMass.Location = new System.Drawing.Point(169, 20);
            this.btnSelectMass.Name = "btnSelectMass";
            this.btnSelectMass.Size = new System.Drawing.Size(26, 23);
            this.btnSelectMass.TabIndex = 1;
            this.btnSelectMass.Text = "...";
            this.btnSelectMass.UseVisualStyleBackColor = true;
            this.btnSelectMass.Click += new System.EventHandler(this.btnSelectMass_Click);
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(6, 20);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(189, 23);
            this.txtMass.TabIndex = 0;
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 175);
            this.Controls.Add(this.groupBox1);
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massDelay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massDelay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSelectMass;
        private TextBox txtMass;
        private Button btnMassMessage;
        private CheckBox checkBox1;
        private Label label2;
        private NumericUpDown massDelay2;
        private Label label1;
        private NumericUpDown massDelay1;
    }
}