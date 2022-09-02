
namespace Ayubo_Drive_Travels
{
    partial class Flash_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flash_Loading));
            this.ProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ProgressBar1.AnimationFunction")));
            this.ProgressBar1.AnimationSpeed = 800;
            this.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(187)))), ((int)(((byte)(231)))));
            this.ProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.ProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(187)))), ((int)(((byte)(231)))));
            this.ProgressBar1.InnerMargin = 2;
            this.ProgressBar1.InnerWidth = -1;
            this.ProgressBar1.Location = new System.Drawing.Point(70, 82);
            this.ProgressBar1.MarqueeAnimationSpeed = 2000;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.ProgressBar1.OuterMargin = -25;
            this.ProgressBar1.OuterWidth = 26;
            this.ProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.ProgressBar1.ProgressWidth = 8;
            this.ProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar1.Size = new System.Drawing.Size(167, 164);
            this.ProgressBar1.StartAngle = 270;
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar1.SubscriptColor = System.Drawing.Color.Black;
            this.ProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar1.SubscriptText = "";
            this.ProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar1.SuperscriptText = "";
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar1.Value = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(187)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.linkLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ProgressBar1);
            this.panel2.Location = new System.Drawing.Point(-3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 368);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(76, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "© All Rights Reserved";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(124, 106);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(63, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 28;
            this.logo.TabStop = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(144, 324);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(93, 16);
            this.linkLabel.TabIndex = 27;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Dilshan Vishmitha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Team Ayubo Lesire (Pvt) Ltd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(76, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Developed by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ayubo Drive Travels";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Flash_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Name = "Flash_Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Flash_Loading";
            this.Load += new System.EventHandler(this.Flash_Loading_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProgressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label3;
    }
}