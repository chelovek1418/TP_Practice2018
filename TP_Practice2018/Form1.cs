using System;
using System.Windows.Forms;
namespace TP_Practice2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] start_text;
        private void action_button_Click(object sender, EventArgs e)
        {
            if (start_textBox.TextLength == 0)
            {
                MessageBox.Show("Отсутствует текст", "Ошибка");
                return;
            }
            end_textBox.Clear();
            start_text = start_textBox.Text.Split(',', '.', '!', '?', ' ', ':', ';', '—', '(', ')', '"', '\t');
            string text = null, text1 = null;
            foreach (string i in start_text)
            {
                text += i;
                text1 += i;
            }
            Random rand = new Random();
            label1:
            string end_text = null;
            int[] index_arr = new int[text1.Length];
            for (int i = 0; i < text1.Length; i++)
            {
                int rand_val;
                char tmp;
                do rand_val = rand.Next(0, text.Length);
                while (index_arr[rand_val] != 0);
                index_arr[rand_val]++;
                tmp = text[i];
                end_text += text[rand_val];
                text.ToCharArray()[rand_val] = tmp;
            }
            if (start_textBox.TextLength != 0 && start_textBox.TextLength != 1 && end_text.Equals(text1))
                goto label1;
            foreach (char i in end_text)
                end_textBox.Text += i;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            start_textBox.Text = end_textBox.Text = null;
        }
    }
}
