using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Chat_Bot
{
    public partial class FormUser : Form
    {
        Thread th;

        public FormUser()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                ChatBot.SetUserName("user");
            }
            else
            {
                ChatBot.SetUserName(textBox_name.Text);  // считывание имени
            }
            
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void open (object obj)
        {
            Application.Run(new FormChat());
        }
    }
}
