namespace diaryApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.music_combox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Date_weekday = new System.Windows.Forms.Label();
            this.Date_day = new System.Windows.Forms.Label();
            this.Date_month = new System.Windows.Forms.Label();
            this.Date_year = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show_Desktop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendar_close = new System.Windows.Forms.Button();
            this.minimise = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bkgrd_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Version_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.setting_toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_toolStripButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourAimsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Date_weekday);
            this.panel1.Controls.Add(this.Date_day);
            this.panel1.Controls.Add(this.Date_month);
            this.panel1.Controls.Add(this.Date_year);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Show_Desktop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 617);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.music_combox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 137);
            this.panel3.TabIndex = 9;
            // 
            // music_combox
            // 
            this.music_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.music_combox.BackColor = System.Drawing.Color.MidnightBlue;
            this.music_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music_combox.ForeColor = System.Drawing.Color.Gold;
            this.music_combox.FormattingEnabled = true;
            this.music_combox.Location = new System.Drawing.Point(72, 86);
            this.music_combox.Name = "music_combox";
            this.music_combox.Size = new System.Drawing.Size(83, 21);
            this.music_combox.TabIndex = 11;
            this.music_combox.SelectedIndexChanged += new System.EventHandler(this.music_combox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Music";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(158, 82);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // Date_weekday
            // 
            this.Date_weekday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date_weekday.BackColor = System.Drawing.Color.MidnightBlue;
            this.Date_weekday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_weekday.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Date_weekday.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_weekday.ForeColor = System.Drawing.Color.Gold;
            this.Date_weekday.Location = new System.Drawing.Point(52, 526);
            this.Date_weekday.Name = "Date_weekday";
            this.Date_weekday.Size = new System.Drawing.Size(98, 34);
            this.Date_weekday.TabIndex = 6;
            this.Date_weekday.Text = "Thursday";
            this.Date_weekday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date_weekday.Click += new System.EventHandler(this.Date_weekday_Click);
            // 
            // Date_day
            // 
            this.Date_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date_day.BackColor = System.Drawing.Color.MidnightBlue;
            this.Date_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_day.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Date_day.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_day.ForeColor = System.Drawing.Color.Gold;
            this.Date_day.Location = new System.Drawing.Point(7, 526);
            this.Date_day.Name = "Date_day";
            this.Date_day.Size = new System.Drawing.Size(45, 34);
            this.Date_day.TabIndex = 5;
            this.Date_day.Text = "25";
            this.Date_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date_day.Click += new System.EventHandler(this.Date_weekday_Click);
            // 
            // Date_month
            // 
            this.Date_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date_month.BackColor = System.Drawing.Color.MidnightBlue;
            this.Date_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_month.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Date_month.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_month.ForeColor = System.Drawing.Color.Gold;
            this.Date_month.Location = new System.Drawing.Point(10, 446);
            this.Date_month.Name = "Date_month";
            this.Date_month.Size = new System.Drawing.Size(100, 29);
            this.Date_month.TabIndex = 4;
            this.Date_month.Text = "December";
            this.Date_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date_month.Click += new System.EventHandler(this.Date_weekday_Click);
            // 
            // Date_year
            // 
            this.Date_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date_year.BackColor = System.Drawing.Color.MidnightBlue;
            this.Date_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_year.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Date_year.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_year.ForeColor = System.Drawing.Color.Gold;
            this.Date_year.Location = new System.Drawing.Point(83, 484);
            this.Date_year.Name = "Date_year";
            this.Date_year.Size = new System.Drawing.Size(67, 32);
            this.Date_year.TabIndex = 3;
            this.Date_year.Text = "2019";
            this.Date_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date_year.Click += new System.EventHandler(this.Date_weekday_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::diaryApp.Properties.Resources.calendar_blue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Date_weekday_Click);
            // 
            // Show_Desktop
            // 
            this.Show_Desktop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Show_Desktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Desktop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Show_Desktop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Show_Desktop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Desktop.Image = global::diaryApp.Properties.Resources.desktop;
            this.Show_Desktop.Location = new System.Drawing.Point(0, 574);
            this.Show_Desktop.Name = "Show_Desktop";
            this.Show_Desktop.Size = new System.Drawing.Size(160, 41);
            this.Show_Desktop.TabIndex = 0;
            this.Show_Desktop.Text = "Show Desktop";
            this.Show_Desktop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Show_Desktop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Show_Desktop.UseVisualStyleBackColor = true;
            this.Show_Desktop.Click += new System.EventHandler(this.Show_Desktop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.BackColor = System.Drawing.Color.MidnightBlue;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar1.ForeColor = System.Drawing.Color.Gold;
            this.monthCalendar1.Location = new System.Drawing.Point(168, 407);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // calendar_close
            // 
            this.calendar_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calendar_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendar_close.Image = global::diaryApp.Properties.Resources.closecalendar;
            this.calendar_close.Location = new System.Drawing.Point(391, 396);
            this.calendar_close.Name = "calendar_close";
            this.calendar_close.Size = new System.Drawing.Size(16, 16);
            this.calendar_close.TabIndex = 8;
            this.calendar_close.UseVisualStyleBackColor = true;
            this.calendar_close.Visible = false;
            this.calendar_close.Click += new System.EventHandler(this.calendar_close_Click);
            // 
            // minimise
            // 
            this.minimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimise.BackColor = System.Drawing.Color.MidnightBlue;
            this.minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimise.Image = global::diaryApp.Properties.Resources.minimise;
            this.minimise.Location = new System.Drawing.Point(898, 8);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(30, 30);
            this.minimise.TabIndex = 4;
            this.minimise.UseVisualStyleBackColor = false;
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.MidnightBlue;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::diaryApp.Properties.Resources.exit;
            this.close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.Location = new System.Drawing.Point(934, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bkgrd_comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Version_label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(163, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 41);
            this.panel2.TabIndex = 2;
            // 
            // bkgrd_comboBox1
            // 
            this.bkgrd_comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bkgrd_comboBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bkgrd_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bkgrd_comboBox1.ForeColor = System.Drawing.Color.Gold;
            this.bkgrd_comboBox1.FormattingEnabled = true;
            this.bkgrd_comboBox1.Location = new System.Drawing.Point(728, 9);
            this.bkgrd_comboBox1.Name = "bkgrd_comboBox1";
            this.bkgrd_comboBox1.Size = new System.Drawing.Size(77, 21);
            this.bkgrd_comboBox1.TabIndex = 5;
            this.bkgrd_comboBox1.SelectedIndexChanged += new System.EventHandler(this.bkgrd_comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(659, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background:";
            // 
            // Version_label2
            // 
            this.Version_label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.Version_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_label2.ForeColor = System.Drawing.Color.Gold;
            this.Version_label2.Location = new System.Drawing.Point(63, 11);
            this.Version_label2.Name = "Version_label2";
            this.Version_label2.Size = new System.Drawing.Size(168, 19);
            this.Version_label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version";
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.BackColor = System.Drawing.Color.MidnightBlue;
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clock.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.Color.Gold;
            this.clock.Location = new System.Drawing.Point(535, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(121, 40);
            this.clock.TabIndex = 1;
            this.clock.Text = "12:12:12";
            this.clock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.setting_toolStripButton3,
            this.tool_toolStripButton4,
            this.about_toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(163, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(810, 61);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::diaryApp.Properties.Resources.addicon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 50);
            this.toolStripButton1.Text = "Add Memo F2";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "\r\nAdd";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::diaryApp.Properties.Resources.searchicon;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(92, 50);
            this.toolStripButton2.Text = "Search Memo F3";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = " \r\nSearch";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // setting_toolStripButton3
            // 
            this.setting_toolStripButton3.AutoSize = false;
            this.setting_toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.deleteAccountsToolStripMenuItem});
            this.setting_toolStripButton3.Image = global::diaryApp.Properties.Resources.settingicon;
            this.setting_toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setting_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setting_toolStripButton3.Name = "setting_toolStripButton3";
            this.setting_toolStripButton3.Size = new System.Drawing.Size(92, 50);
            this.setting_toolStripButton3.Text = "Settings F4";
            this.setting_toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // deleteAccountsToolStripMenuItem
            // 
            this.deleteAccountsToolStripMenuItem.Name = "deleteAccountsToolStripMenuItem";
            this.deleteAccountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAccountsToolStripMenuItem.Text = "Delete Accounts";
            // 
            // tool_toolStripButton4
            // 
            this.tool_toolStripButton4.AutoSize = false;
            this.tool_toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.updatesToolStripMenuItem});
            this.tool_toolStripButton4.Image = global::diaryApp.Properties.Resources.toolsicon;
            this.tool_toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool_toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_toolStripButton4.Name = "tool_toolStripButton4";
            this.tool_toolStripButton4.Size = new System.Drawing.Size(92, 50);
            this.tool_toolStripButton4.Text = "Tools F5";
            this.tool_toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // staffsToolStripMenuItem
            // 
            this.staffsToolStripMenuItem.Name = "staffsToolStripMenuItem";
            this.staffsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.staffsToolStripMenuItem.Text = "Staffs F9";
            this.staffsToolStripMenuItem.Click += new System.EventHandler(this.staffsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // about_toolStripButton5
            // 
            this.about_toolStripButton5.AutoSize = false;
            this.about_toolStripButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.ourAimsToolStripMenuItem,
            this.toolStripSeparator1,
            this.contactUsToolStripMenuItem});
            this.about_toolStripButton5.Image = global::diaryApp.Properties.Resources.Help;
            this.about_toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_toolStripButton5.Name = "about_toolStripButton5";
            this.about_toolStripButton5.Size = new System.Drawing.Size(92, 50);
            this.about_toolStripButton5.Text = "About F6";
            this.about_toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us F10";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // ourAimsToolStripMenuItem
            // 
            this.ourAimsToolStripMenuItem.Name = "ourAimsToolStripMenuItem";
            this.ourAimsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ourAimsToolStripMenuItem.Text = "Our Aims & Objectives";
            this.ourAimsToolStripMenuItem.Click += new System.EventHandler(this.ourAimsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 617);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.calendar_close);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimise;
        private System.Windows.Forms.Button Show_Desktop;
        private System.Windows.Forms.ToolStripDropDownButton setting_toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton about_toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourAimsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Date_weekday;
        private System.Windows.Forms.Label Date_day;
        private System.Windows.Forms.Label Date_month;
        private System.Windows.Forms.Label Date_year;
        private System.Windows.Forms.Label Version_label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bkgrd_comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button calendar_close;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox music_combox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripDropDownButton tool_toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

