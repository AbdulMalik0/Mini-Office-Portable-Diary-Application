using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryApp.About
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
            splashscreen();
        }
        public void splashscreen()
        {
            this.splash_screen_panelparent1.BackColor = Color.FromArgb(50, 0, 0, 128);
            this.splash_house_panel1.BackColor = Color.FromArgb(40, 0, 0, 128);

        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            this.splash_timer1.Start();
            
            
        }

        private void splash_timer1_Tick(object sender, EventArgs e)
        {
            this.splash_progress_panel1.Width += 10;

            try
            {
                if (this.splash_progress_panel1.Width >= 638)
                {
                    this.splash_timer1.Stop();
                    Form1 main_form = new Form1();
                    main_form.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
