using diaryApp.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread t = new Thread(new ThreadStart(splashsss));
            //t.Start();
            //Thread.Sleep(4300);
            //    t.Abort();
            //this.Activate();
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
//            var res =  MessageBox.Show(@"Press Abort to Close
//Press Retry to Restart
//Press Ignore to Cancel", "Are you sure you want to close the Application?", MessageBoxButtons.AbortRetryIgnore, 
//                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
//            if (res == DialogResult.Abort)
//            {
                this.Close();
            //}
            //else if(res == DialogResult.Retry)
            //{
            //    Application.Restart();
            //}
        }

        //public void splashsss()
        //{
        //    Application.Run(new splash_screen());
        //}

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Show_Desktop_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock_methd();
        }

        private void clock_methd()
        {
            this.clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            diaryApp.About.login_form lg_form = new About.login_form();
            //lg_form.ShowDialog();
            lg_form.MdiParent = this;

            this.label1.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.label2.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.label3.BackColor = Color.FromArgb(200, 0, 0, 128);
            this.Version_label2.BackColor = Color.FromArgb(200, 0, 0, 128);
            this.clock.BackColor = Color.FromArgb(200, 0, 0, 128);


            clock_methd();
            date();
            this.Version_label2.Text = Application.ProductVersion;
            background(diaryApp.Properties.Settings.Default.diaryproject);
            newbkgrd();
            music_combo_list();
        }

        public void background(int d)
        {
            d = d + 1;
            string bkgrnd;
            bkgrnd = Application.StartupPath + "\\data\\pics\\" + d +".jpg";
            this.BackgroundImage = Image.FromFile(bkgrnd);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void newbkgrd()
        {
            for (int i = 1; i <= 8; i++)
            {
                this.bkgrd_comboBox1.Items.Add("Image " + i.ToString());
            }
        }

        public void music_combo_list()
        {
            for (int i = 1; i <= 3; i++)
            {
                music_combox.Items.Add(i.ToString());
            }
        }

        public void music_play(int d)
        {
            d = d + 1;
            string music_path = Application.StartupPath + "\\data\\music\\" + d.ToString() + ".mp3";
            this.axWindowsMediaPlayer1.URL = music_path;
        }
        private void music_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            music_play(this.music_combox.SelectedIndex);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void date()
        {
            
            try
            {
                System.Globalization.GregorianCalendar g;
                g = new System.Globalization.GregorianCalendar();

                this.Date_year.Text = g.GetYear(DateTime.Now).ToString();
                //this.Date_year.Text = DateTime.Now.Month.ToString();
                this.Date_day.Text = g.GetDayOfMonth(DateTime.Now).ToString();
                this.Date_weekday.Text = g.GetDayOfWeek(DateTime.Now).ToString();

                int d = g.GetMonth(DateTime.Now);

                this.Date_month.Text = getmonth(d);
            }
            catch (Exception ex)
            {
                diaryApp.About.exeption_message.exept_msg(ex.ToString());
            }
            
        }
        public string getmonth(int d)
        {
            string cal_month = "";
            switch (d)
            {
                case 1:
                    cal_month = "January";
                    break;

                case 2:
                    cal_month = "February";
                    break;

                case 3:
                    cal_month = "March";
                    break;

                case 4:
                    cal_month = "April";
                    break;

                case 5:
                    cal_month = "May";
                    break;

                case 6:
                    cal_month = "June";
                    break;

                case 7:
                    cal_month = "July";
                    break;

                case 8:
                    cal_month = "August";
                    break;

                case 9:
                    cal_month = "September";
                    break;

                case 10:
                    cal_month = "October";
                    break;

                case 11:
                    cal_month = "November";
                    break;

                case 12:
                    cal_month = "December";
                    break;
            }
            return cal_month;
        }

        private void bkgrd_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            background(this.bkgrd_comboBox1.SelectedIndex);
            diaryApp.Properties.Settings.Default.diaryproject = this.bkgrd_comboBox1.SelectedIndex;
            diaryApp.Properties.Settings.Default.Save();
        }

        private void Date_weekday_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            calendar_close.Visible = true;
        }

        private void calendar_close_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            calendar_close.Visible = false;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.aboutus abu_form = new About.aboutus();
            abu_form.ShowDialog();
            abu_form.MdiParent = this;
        }

        private void staffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.user_manage usr_form = new About.user_manage();
            usr_form.Show();
            usr_form.MdiParent = this;
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.login_form lg_form = new About.login_form();
            lg_form.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public void toolStripButton1_Click(object sender, EventArgs e)
        {
            diaryApp.About.memo_form memo_reg = new About.memo_form();
            memo_reg.MdiParent = this;
            memo_reg.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            diaryApp.About.search_memo search_Memo = new About.search_memo();
            search_Memo.Show();
            search_Memo.MdiParent = this;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            if(e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            if(e.KeyCode == Keys.F4)
            {
                this.setting_toolStripButton3.ShowDropDown();
            }
            if (e.KeyCode == Keys.F5)
            {
                this.tool_toolStripButton4.ShowDropDown();
            }
            if (e.KeyCode == Keys.F6)
            {
                this.about_toolStripButton5.ShowDropDown();
            }
            if (e.KeyCode == Keys.F9)
            {
                staffsToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F10)
            {
                aboutUsToolStripMenuItem_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.product product_frm = new product();
            product_frm.MdiParent = this;
            product_frm.Show();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.updates update_frm = new updates();
            update_frm.Show();
            update_frm.MdiParent = this;
        }

        private void ourAimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.aimsandobj aando = new aimsandobj();
            aando.Show();
            aando.MdiParent = this;
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaryApp.About.contact contactus = new contact();
            contactus.Show();
            contactus.MdiParent = this;
        }
    }
}
