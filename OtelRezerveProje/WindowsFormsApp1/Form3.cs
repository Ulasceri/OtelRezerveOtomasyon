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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int indrim;
        public static int toplamfiyat;
        public static string isim;
        public static string soyisim;
        public static int telno;
        public static int gün;
        public static int h1 = 70;
        public static int h2 = 100;
        public static int h3 = 25;
        public static int h4 = 50;
        public static int h5 = 300;
        public static int h6 = 400;
        public static int h7 = 250;
        public static int h8 = 450;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form2.standartfiyat.ToString()); 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                 
        }

        private void button1_Click1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            gün = Convert.ToInt32(textBox4.Text);
            isim = textBox1.Text;
            soyisim = textBox2.Text;
            toplamfiyat = toplamfiyat * gün;
           
            if (checkBox1.Checked == true)
            {
                h1 = h1 * gün;
                toplamfiyat = toplamfiyat + h1;
                label2.Text = toplamfiyat.ToString();
                
            }
            if (checkBox2.Checked == true)
            {
                
                h2 = h2 * gün;
                toplamfiyat = toplamfiyat + h2;
                label2.Text = toplamfiyat.ToString();
               
                
            }
            if (checkBox3.Checked == true)
            {
                h3 = h3 * gün;
                toplamfiyat = toplamfiyat + h3;
                label2.Text = toplamfiyat.ToString();
            }
            if (checkBox4.Checked == true)
            {
                h4 = h4 * gün;
                toplamfiyat = toplamfiyat + h4;
                label2.Text = toplamfiyat.ToString();
            }
            if (checkBox5.Checked == true)
            {
                h5 = h5 * gün;
                toplamfiyat = toplamfiyat + h5;
                label2.Text = toplamfiyat.ToString();
            }
            if (checkBox6.Checked == true)
            {
                h6 = h6 * gün;
                toplamfiyat = toplamfiyat + h6;
                label2.Text = toplamfiyat.ToString();
            }
            if (checkBox7.Checked == true)
            {
                h7 =h7 * gün;
                toplamfiyat = toplamfiyat + h7;
                label2.Text = toplamfiyat.ToString();
            }
            if (checkBox8.Checked == true)
            {
                h8 = h8 * gün;
                toplamfiyat = toplamfiyat + h8;
                label2.Text = toplamfiyat.ToString();

            }
            if (textBox5.Text == "ütopya123")
            {
                indrim = (toplamfiyat / 100) * 10;
                toplamfiyat = toplamfiyat - indrim;
            }
            label2.Text = toplamfiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Seçimlerinizi ve Fiyatı Onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                
                Form4 listekran = new Form4();
                listekran.Show();
                this.Visible = false;
            }
        }
    }
}
