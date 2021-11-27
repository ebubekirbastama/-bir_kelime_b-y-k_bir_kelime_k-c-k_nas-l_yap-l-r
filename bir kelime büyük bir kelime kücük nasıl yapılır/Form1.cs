using System;
using System.Text;
using System.Windows.Forms;

namespace bir_kelime_büyük_bir_kelime_kücük_nasıl_yapılır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder EBSsb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            EBSTime(textBox1.Text,textBox2);
            
        }

        private void EBSTime(string cml, TextBox tex)
        {
          
            bool uppercase = false;
            foreach (char c in cml)
            {
                if (uppercase)
                    EBSsb.Append(char.ToUpper(c));
                else
                    EBSsb.Append(char.ToLower(c));

                uppercase = !uppercase;
            }

            tex.Text = EBSsb.ToString();
        }
    }
}
