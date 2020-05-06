using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryApp.About
{
    public partial class search_memo : Form
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_memo_Load(object sender, EventArgs e)
        {
            //StringCollection strcll = new StringCollection();
            ////strcll.AddRange(diaryApp.Properties.Settings.Default.files_names);
            //this.memo_comboBox1.Items.Add("*"+diaryApp.Properties.Settings.Default.files_names);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
