namespace diaryApp.About
{
    partial class splash_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            this.splash_screen_panelparent1 = new System.Windows.Forms.Panel();
            this.splash_progress_panel1 = new System.Windows.Forms.Panel();
            this.splash_house_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splash_timer1 = new System.Windows.Forms.Timer(this.components);
            this.splash_screen_panelparent1.SuspendLayout();
            this.splash_house_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splash_screen_panelparent1
            // 
            this.splash_screen_panelparent1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splash_screen_panelparent1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splash_screen_panelparent1.Controls.Add(this.splash_house_panel1);
            this.splash_screen_panelparent1.Controls.Add(this.label2);
            this.splash_screen_panelparent1.Controls.Add(this.label1);
            this.splash_screen_panelparent1.Location = new System.Drawing.Point(64, 121);
            this.splash_screen_panelparent1.Name = "splash_screen_panelparent1";
            this.splash_screen_panelparent1.Size = new System.Drawing.Size(640, 347);
            this.splash_screen_panelparent1.TabIndex = 0;
            // 
            // splash_progress_panel1
            // 
            this.splash_progress_panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splash_progress_panel1.Location = new System.Drawing.Point(2, 3);
            this.splash_progress_panel1.Name = "splash_progress_panel1";
            this.splash_progress_panel1.Size = new System.Drawing.Size(10, 8);
            this.splash_progress_panel1.TabIndex = 3;
            // 
            // splash_house_panel1
            // 
            this.splash_house_panel1.Controls.Add(this.splash_progress_panel1);
            this.splash_house_panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splash_house_panel1.Location = new System.Drawing.Point(0, 334);
            this.splash_house_panel1.Name = "splash_house_panel1";
            this.splash_house_panel1.Size = new System.Drawing.Size(640, 13);
            this.splash_house_panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(201, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diary Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(154, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // splash_timer1
            // 
            this.splash_timer1.Enabled = true;
            this.splash_timer1.Interval = 50;
            this.splash_timer1.Tick += new System.EventHandler(this.splash_timer1_Tick);
            // 
            // splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 587);
            this.ControlBox = false;
            this.Controls.Add(this.splash_screen_panelparent1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "splash_screen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.splash_screen_Load);
            this.splash_screen_panelparent1.ResumeLayout(false);
            this.splash_screen_panelparent1.PerformLayout();
            this.splash_house_panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splash_screen_panelparent1;
        private System.Windows.Forms.Panel splash_house_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel splash_progress_panel1;
        private System.Windows.Forms.Timer splash_timer1;
    }
}