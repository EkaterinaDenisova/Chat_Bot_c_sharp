using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // регулярные выражения

namespace Chat_Bot
{
    public partial class FormChat : Form
    {
        //public Form form1;
        ChatBot bot = new ChatBot();


        //public static int lastLineIndex = 0;

        public FormChat()
        {
            InitializeComponent();
            // не работает
            /*bot.LoadHistory();
            bot.lastLineIndex = bot.history.Count()-1;

            for (int i = 0; i <= bot.lastLineIndex; i++)
            {
                textBox_chat.AppendText(bot.history[i]);
            }*/
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_chat.Clear();
        }

        private void button_request_Click(object sender, EventArgs e)
        {
            textBox_chat.Text += bot.Answer(textBox_request.Text);

            textBox_request.Clear();
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            // не работает
            //bot.SaveHistory();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вот что я умею: \r\n" +
                "1) Здороваться (напиши мне \"привет\", \"хай:)\" и всё в таком духе)\r\n" +
                "2) Складывать, вычитать, умножать и делить числа (\"сложи 5 и 7\",\r\n" +
                "\"вычти 5 из 10\", \"умножь 11 на 4\", \"подели 9 на 3\")\r\n" +
                "3) Говорить дату или время (\"Который час?\", \"Сколько времени\",\r\n" +
                "\"Какая сегодня дата/число/день?\")\r\n"
                , "Справка");
        }
    }
}
