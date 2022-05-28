using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int hak = 4;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form6 adminekran = new Form6();
                adminekran.Show();
                this.Visible = false;
            }
            else
            {
                hak = hak - 1;
                MessageBox.Show("Kullanıcı adı veya şifre hatalı kalan hakkınız = "+" "+ +hak);
                if (hak == 0)
                {
                    MessageBox.Show("ÇOK FAZLA HATALI GİRİŞ YAPTINIZ ÇIKIŞ YAPILIYOR");
                    Application.Exit();
                }
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
