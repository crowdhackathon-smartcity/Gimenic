namespace Eco2City
{
    partial class Form3
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
            this.BackToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToForm1
            // 
            this.BackToForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToForm1.Location = new System.Drawing.Point(12, 12);
            this.BackToForm1.Name = "BackToForm1";
            this.BackToForm1.Size = new System.Drawing.Size(57, 48);
            this.BackToForm1.TabIndex = 0;
            this.BackToForm1.Text = "<-";
            this.BackToForm1.UseVisualStyleBackColor = true;
            this.BackToForm1.Click += new System.EventHandler(this.BackToForm1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 651);
            this.Controls.Add(this.BackToForm1);
            this.Name = "Form3";
            this.Text = "EcoCity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToForm1;
    }
}