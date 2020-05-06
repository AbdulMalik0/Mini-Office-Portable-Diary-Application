namespace diaryApp.About
{
    partial class login_form
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
            this.login_pass_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_user_comboBox1 = new System.Windows.Forms.ComboBox();
            this.login_image_loader = new System.Windows.Forms.Button();
            this.login_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.login_okay_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_pass_textBox2
            // 
            this.login_pass_textBox2.Location = new System.Drawing.Point(82, 241);
            this.login_pass_textBox2.Name = "login_pass_textBox2";
            this.login_pass_textBox2.PasswordChar = '*';
            this.login_pass_textBox2.Size = new System.Drawing.Size(160, 20);
            this.login_pass_textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login_user_comboBox1);
            this.groupBox1.Controls.Add(this.login_image_loader);
            this.groupBox1.Controls.Add(this.login_pass_textBox2);
            this.groupBox1.Controls.Add(this.login_pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // login_user_comboBox1
            // 
            this.login_user_comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_user_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.login_user_comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user_comboBox1.FormattingEnabled = true;
            this.login_user_comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.login_user_comboBox1.Location = new System.Drawing.Point(82, 214);
            this.login_user_comboBox1.MaxDropDownItems = 2;
            this.login_user_comboBox1.Name = "login_user_comboBox1";
            this.login_user_comboBox1.Size = new System.Drawing.Size(160, 24);
            this.login_user_comboBox1.TabIndex = 1;
            // 
            // login_image_loader
            // 
            this.login_image_loader.Location = new System.Drawing.Point(249, 181);
            this.login_image_loader.Name = "login_image_loader";
            this.login_image_loader.Size = new System.Drawing.Size(75, 23);
            this.login_image_loader.TabIndex = 13;
            this.login_image_loader.Text = "Load Image";
            this.login_image_loader.UseVisualStyleBackColor = true;
            this.login_image_loader.Click += new System.EventHandler(this.login_image_loader_Click);
            // 
            // login_pictureBox1
            // 
            this.login_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_pictureBox1.Location = new System.Drawing.Point(82, 31);
            this.login_pictureBox1.Name = "login_pictureBox1";
            this.login_pictureBox1.Size = new System.Drawing.Size(160, 151);
            this.login_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_pictureBox1.TabIndex = 8;
            this.login_pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(73, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Welcome to Diary Login Page";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files |*.jpg |*.bmp  png files |*.png";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Image = global::diaryApp.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(305, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_okay_but
            // 
            this.login_okay_but.BackColor = System.Drawing.Color.LightGreen;
            this.login_okay_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_okay_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_okay_but.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.login_okay_but.Image = global::diaryApp.Properties.Resources.okay;
            this.login_okay_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_okay_but.Location = new System.Drawing.Point(12, 375);
            this.login_okay_but.Name = "login_okay_but";
            this.login_okay_but.Size = new System.Drawing.Size(72, 36);
            this.login_okay_but.TabIndex = 1;
            this.login_okay_but.Text = "Ok";
            this.login_okay_but.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_okay_but.UseVisualStyleBackColor = false;
            this.login_okay_but.Click += new System.EventHandler(this.login_okay_but_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::diaryApp.Properties.Resources.splash_screen;
            this.ClientSize = new System.Drawing.Size(391, 431);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_okay_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_form_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox login_pictureBox1;
        private System.Windows.Forms.TextBox login_pass_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_okay_but;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox login_user_comboBox1;
        private System.Windows.Forms.Button login_image_loader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}