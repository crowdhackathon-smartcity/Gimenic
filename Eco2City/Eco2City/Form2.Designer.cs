namespace Eco2City
{
    partial class Form2
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.co2lab = new System.Windows.Forms.Label();
            this.humlab = new System.Windows.Forms.Label();
            this.co2Pic = new System.Windows.Forms.PictureBox();
            this.HumPic = new System.Windows.Forms.PictureBox();
            this.BackFromMaps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.co2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumPic)).BeginInit();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Καλλίπολη",
            "Νίκαια",
            "Κορυδαλλός",
            "Ρέντη",
            "Ελευσίνα"});
            this.cb1.Location = new System.Drawing.Point(488, 541);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(269, 21);
            this.cb1.TabIndex = 0;
            this.cb1.DropDownClosed += new System.EventHandler(this.cb1_DropDownClosed);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(200, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1204, 473);
            this.webBrowser1.TabIndex = 1;
            // 
            // co2lab
            // 
            this.co2lab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.co2lab.AutoSize = true;
            this.co2lab.Location = new System.Drawing.Point(972, 573);
            this.co2lab.Name = "co2lab";
            this.co2lab.Size = new System.Drawing.Size(28, 13);
            this.co2lab.TabIndex = 4;
            this.co2lab.Text = "CO2";
            this.co2lab.Visible = false;
            // 
            // humlab
            // 
            this.humlab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.humlab.AutoSize = true;
            this.humlab.Location = new System.Drawing.Point(1201, 573);
            this.humlab.Name = "humlab";
            this.humlab.Size = new System.Drawing.Size(29, 13);
            this.humlab.TabIndex = 5;
            this.humlab.Text = "Hum";
            this.humlab.Visible = false;
            // 
            // co2Pic
            // 
            this.co2Pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.co2Pic.Location = new System.Drawing.Point(901, 648);
            this.co2Pic.Name = "co2Pic";
            this.co2Pic.Size = new System.Drawing.Size(172, 156);
            this.co2Pic.TabIndex = 6;
            this.co2Pic.TabStop = false;
            this.co2Pic.Visible = false;
            // 
            // HumPic
            // 
            this.HumPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HumPic.Location = new System.Drawing.Point(1159, 648);
            this.HumPic.Name = "HumPic";
            this.HumPic.Size = new System.Drawing.Size(172, 156);
            this.HumPic.TabIndex = 7;
            this.HumPic.TabStop = false;
            this.HumPic.Visible = false;
            // 
            // BackFromMaps
            // 
            this.BackFromMaps.Location = new System.Drawing.Point(12, 12);
            this.BackFromMaps.Name = "BackFromMaps";
            this.BackFromMaps.Size = new System.Drawing.Size(45, 44);
            this.BackFromMaps.TabIndex = 8;
            this.BackFromMaps.Text = "<-";
            this.BackFromMaps.UseVisualStyleBackColor = true;
            this.BackFromMaps.Click += new System.EventHandler(this.BackFromMaps_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 844);
            this.Controls.Add(this.BackFromMaps);
            this.Controls.Add(this.HumPic);
            this.Controls.Add(this.co2Pic);
            this.Controls.Add(this.humlab);
            this.Controls.Add(this.co2lab);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.cb1);
            this.Name = "Form2";
            this.Text = "EcoCIty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.co2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label co2lab;
        private System.Windows.Forms.Label humlab;
        private System.Windows.Forms.PictureBox co2Pic;
        private System.Windows.Forms.PictureBox HumPic;
        private System.Windows.Forms.Button BackFromMaps;
    }
}