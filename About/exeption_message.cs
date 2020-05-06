using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryApp.About
{
    public class exeption_message
    {
        public static void exept_msg(string err_msg)
        {
            MessageBox.Show(@"Error Detail: 
  " + err_msg.ToString());
        }
    }
}
