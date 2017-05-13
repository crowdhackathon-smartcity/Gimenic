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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.geiaTimer = new System.Windows.Forms.Timer(this.components);
            this.KalwsorTimer = new System.Windows.Forms.Timer(this.components);
            this.geia = new System.Windows.Forms.Label();
            this.kalwsorisma = new System.Windows.Forms.Label();
            this.PicMap = new System.Windows.Forms.PictureBox();
            this.PicStatistics = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PicMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStatistics)).BeginInit();
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
            this.geia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.kalwsorisma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kalwsorisma.AutoSize = true;
            this.kalwsorisma.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.kalwsorisma.Location = new System.Drawing.Point(317, 308);
            this.kalwsorisma.Name = "kalwsorisma";
            this.kalwsorisma.Size = new System.Drawing.Size(1148, 72);
            this.kalwsorisma.TabIndex = 1;
            this.kalwsorisma.Text = "Καλως ορίσατε στην εφαρμογή EcoCity";
            this.kalwsorisma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicMap
            // 
            this.PicMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicMap.BackgroundImage")));
            this.PicMap.Image = ((System.Drawing.Image)(resources.GetObject("PicMap.Image")));
            this.PicMap.Location = new System.Drawing.Point(1061, 220);
            this.PicMap.Name = "PicMap";
            this.PicMap.Size = new System.Drawing.Size(404, 342);
            this.PicMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMap.TabIndex = 2;
            this.PicMap.TabStop = false;
            this.PicMap.Visible = false;
            // 
            // PicStatistics
            // 
            this.PicStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicStatistics.BackgroundImage")));
            this.PicStatistics.Image = ((System.Drawing.Image)(resources.GetObject("PicStatistics.Image")));
            this.PicStatistics.Location = new System.Drawing.Point(291, 220);
            this.PicStatistics.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.PicStatistics.Name = "PicStatistics";
            this.PicStatistics.Size = new System.Drawing.Size(412, 340);
            this.PicStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicStatistics.TabIndex = 3;
            this.PicStatistics.TabStop = false;
            this.PicStatistics.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 883);
            this.Controls.Add(this.PicStatistics);
            this.Controls.Add(this.PicMap);
            this.Controls.Add(this.kalwsorisma);
            this.Controls.Add(this.geia);
            this.Name = "Form1";
            this.Text = "EcoCity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PicMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer geiaTimer;
        private System.Windows.Forms.Timer KalwsorTimer;
        private System.Windows.Forms.Label geia;
        private System.Windows.Forms.Label kalwsorisma;
        private System.Windows.Forms.PictureBox PicMap;
        private System.Windows.Forms.PictureBox PicStatistics;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

