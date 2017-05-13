namespace Eco2City
{
    partial class Form1
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
            this.geiaTimer = new System.Windows.Forms.Timer(this.components);
            this.KalwsorTimer = new System.Windows.Forms.Timer(this.components);
            this.geia = new System.Windows.Forms.Label();
            this.kalwsorisma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geiaTimer
            // 
            this.geiaTimer.Interval = 19;
            this.geiaTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KalwsorTimer
            // 
            this.KalwsorTimer.Interval = 19;
            this.KalwsorTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // geia
            // 
            this.geia.AutoSize = true;
            this.geia.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.geia.Location = new System.Drawing.Point(775, 308);
            this.geia.Name = "geia";
            this.geia.Size = new System.Drawing.Size(306, 72);
            this.geia.TabIndex = 0;
            this.geia.Text = "Γεια σας !";
            // 
            // kalwsorisma
            // 
            this.kalwsorisma.AutoSize = true;
            this.kalwsorisma.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.kalwsorisma.Location = new System.Drawing.Point(393, 317);
            this.kalwsorisma.Name = "kalwsorisma";
            this.kalwsorisma.Size = new System.Drawing.Size(1148, 72);
            this.kalwsorisma.TabIndex = 1;
            this.kalwsorisma.Text = "Καλως ορίσατε στην εφαρμογή EcoCity";
            this.kalwsorisma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 839);
            this.Controls.Add(this.kalwsorisma);
            this.Controls.Add(this.geia);
            this.Name = "Form1";
            this.Text = "EcoCity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer geiaTimer;
        private System.Windows.Forms.Timer KalwsorTimer;
        private System.Windows.Forms.Label geia;
        private System.Windows.Forms.Label kalwsorisma;
    }
}

