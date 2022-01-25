using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chilkat_Unlock_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Chilkat_Unlock());
            button1.Enabled = false;
        }
        public string Chilkat_Unlock()
        {
            Chilkat.Global glob = new Chilkat.Global();
            bool success = glob.UnlockBundle("Anything for 30-day trial");
            if (success != true)
            {
                string message0 = "Error: \r\n" + glob.LastErrorText;
                return message0;

            }

            int status = glob.UnlockStatus;
            if (status == 2)
            {
                string message1 = "Unlocked using purchased unlock code.\r\n" + glob.LastErrorText;
                return message1;
            }
            else
            {
                string message2 = "Unlocked in trial mode.\r\n" + glob.LastErrorText;
                return message2;
            }
            string message3 = glob.LastErrorText;
            return message3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
