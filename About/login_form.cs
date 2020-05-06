using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace diaryApp.About
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day dude !!!");
            Application.Exit();
        }

        private void login_okay_but_Click(object sender, EventArgs e)
        {
            try
            {
                string admin = diaryApp.Properties.Settings.Default.Admin_login_pass;
                string staff = diaryApp.Properties.Settings.Default.Staff_login_pass;
                if (login_pass_textBox2.Text == "")
                {
                    MessageBox.Show("Password is required!!!", "Action Needed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if ((login_user_comboBox1.SelectedIndex == 0 && login_pass_textBox2.Text == admin) || (login_user_comboBox1.SelectedIndex == 1 && login_pass_textBox2.Text == staff))
                {
                    MessageBox.Show("Login Accepted", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password incorrect", "Try again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                diaryApp.About.exeption_message.exept_msg(ex.ToString());
            }
            
            
             
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            this.groupBox1.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.login_image_loader.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.label1.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.label2.BackColor = Color.FromArgb(40, 0, 0, 128);
            this.label3.BackColor = Color.FromArgb(40, 0, 0, 128);
        }

        private void login_image_loader_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                string fn = openFileDialog1.FileName;

                this.login_pictureBox1.Load(fn);
            }
            catch (Exception ex)
            {
                diaryApp.About.exeption_message.exept_msg(ex.ToString());
            }
            
        }

        private void login_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_okay_but_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
