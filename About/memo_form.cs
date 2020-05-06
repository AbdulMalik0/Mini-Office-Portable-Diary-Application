using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;

namespace diaryApp.About
{
    public partial class memo_form : Form
    {
        public memo_form()
        {
            InitializeComponent();
        }

       

        private void font_edit_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_fontDialog1.ShowDialog();
            this.memo_richTextBox1.SelectionFont = memo_fontDialog1.Font;
        }

        private void fontcolor_edit_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_colorDialog1.ShowDialog();
            this.memo_richTextBox1.SelectionColor = memo_colorDialog1.Color;
        }

        private void font_backcolor_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_colorDialog1.ShowDialog();
            this.memo_richTextBox1.SelectionBackColor = memo_colorDialog1.Color;
        }

        private void align_left_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void align_center_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void align_right_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void align_justify_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void indent_increase_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionIndent = this.memo_richTextBox1.SelectionIndent + 10;
        }

        private void indent_decrease_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.SelectionIndent = this.memo_richTextBox1.SelectionIndent - 10;
        }

        private void copy_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.Copy();
        }

        private void cut_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.Cut();
        }

        private void paste_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.Paste();
        }

        private void undo_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.Undo();
        }

        private void redo_toolstrip_Click(object sender, EventArgs e)
        {
            this.memo_richTextBox1.Redo();
        }

        private void print_toolstrip_Click(object sender, EventArgs e)
        {
            memo_printDialog1.ShowDialog();
            
        }
        private void save_memo_toolstrip_Click(object sender, EventArgs e)
        {
            try
            {
                long saved = diaryApp.Properties.Settings.Default.saved_memo;
                saved = saved + 1;

                diaryApp.Properties.Settings.Default.saved_memo = saved;
                //diaryApp.Properties.Settings.Default.Save();
                int nn = (int)saved;
                nn = nn + 1;
                string doc_path = Application.StartupPath + "\\data\\docs\\" + title_memo_richtext.Text + ".rtf";
                this.memo_richTextBox1.SaveFile(doc_path);

                //string[] title_arr = new string [10];
                //diaryApp.Properties.Settings.Default.files_names.Insert(0,"*"+title_memo_richtext.Text);
                //diaryApp.Properties.Settings.Default.Save();

                //memo_comboBox1.Items.Add(diaryApp.Properties.Settings.Default.files_names);
            }
            catch (Exception ex)
            {
                diaryApp.About.exeption_message.exept_msg(ex.ToString());
            }
            

        }

        private void memo_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.DefaultExt = ".rtf";
            ofd.InitialDirectory = Application.StartupPath + "\\data\\docs";
            //ofd.SafeFileName.Contains(".rtf");

            //memo_openFileDialog1.ShowDialog();
            //memo_openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.SafeFileName.Contains(".rtf"))
            {
                memo_richTextBox1.LoadFile(ofd.FileName);
                return;
            }
            if (ofd.FileName is null || ofd.SafeFileName == null)
            {
                MessageBox.Show("no file selected");
                return;
            }
            
            else
            {
                try
                {
                    memo_richTextBox1.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception)
                {
                    //                   MessageBox.Show(@"There's an issue: 
                    //" + ex);
                    return;
                }
                
            }
            
            //System.IO.StreamReader sr = new System.IO.StreamReader(memo_openFileDialog1.FileName);
            //memo_richTextBox1.Text = sr.ReadToEnd();
            //sr.Close();


            
        }

        private void memo_form_Load(object sender, EventArgs e)
        {
           

        }
        private void refreshRate_Tick(object sender, EventArgs e)
        {
        }

        private void memo_form_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.O)
            {
                openToolStripMenuItem_Click(sender, e);
            }
            if(e.Control && e.KeyCode == Keys.P)
            {
                print_toolstrip_Click(sender, e);
            }
            if(e.Control && e.KeyCode == Keys.S)
            {
                save_memo_toolstrip_Click(sender, e);
            }
            if(e.Control && e.KeyCode == Keys.C)
            {
                copy_toolstrip_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                cut_toolstrip_Click(sender, e);
            }
            if(e.Control && e.KeyCode == Keys.V)
            {
                paste_toolstrip_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Z)
                undo_toolstrip_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.Y)
                redo_toolstrip_Click(sender, e);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_toolstrip_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_memo_toolstrip_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memo_form memofrm = new memo_form();
            memofrm.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo_toolstrip_Click(sender, e);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo_toolstrip_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy_toolstrip_Click(sender, e);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut_toolstrip_Click(sender, e);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste_toolstrip_Click(sender, e);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.memo_richTextBox1.WordWrap == true)
                this.memo_richTextBox1.WordWrap = false;
            else
                this.memo_richTextBox1.WordWrap = true;


        }

        private void multilineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.memo_richTextBox1.Multiline == true)
                this.memo_richTextBox1.Multiline = false;
            else
                this.memo_richTextBox1.Multiline = true;
        }
    }
}
