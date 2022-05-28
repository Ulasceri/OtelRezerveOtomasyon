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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int standartfiyat = 600;
        public static int superfiyat = 1300;
        public static int premiumfiyat = 2000;
        public static int kralfiyat = 4750;

        private void button1_Click(object sender, EventArgs e)
        {
            
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            label5.Text = "Standart Odamızda konforlu bir konaklama ve iyi \n bir gece uykusu için gereken  her şeye sahip olacaksınız. \n Büyük yatak, oda içi kahve ve çay olanakları ile \n ücretsiz kablosuz ağ bağlantısının keyfini çıkarın.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            label6.Text = "Daha geniş alan için balkonlu Superior  Odalarımızdan \n birini ayırtın. Konforlu bir konaklama ve iyi bir \n gece uykusu için gereken her şeye sahip olacaksınız.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            label7.Text = "Geniş bir ortam seviyorsanız, Premium Odalarımız \n idealdir  .Superior Odalarla aynı olanaklara sahip bu \n odalar ekstra konfor için daha fazla alan sunar.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            label8.Text = "Kendinizi tam anlamıyla krallara ait bir \n dairenin içerisinde hissedeceğiniz eşsiz \n bir deneyim için kral dairesi hizmetimizi \n denemelisiniz.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.toplamfiyat = Form3.toplamfiyat + 650;
            DialogResult secenek = MessageBox.Show("Standart Oda İle Devam Etmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Form3 sonekran = new Form3();
                sonekran.Show();
                this.Visible = false;
            }
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3.toplamfiyat = Form3.toplamfiyat + 1300;
            DialogResult secenek = MessageBox.Show("Superior Oda İle Devam Etmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Form3 sonekran = new Form3();
                sonekran.Show();
                this.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3.toplamfiyat = Form3.toplamfiyat + 2000;
            DialogResult secenek = MessageBox.Show("Premium Oda İle Devam Etmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Form3 sonekran = new Form3();
                sonekran.Show();
                this.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3.toplamfiyat = Form3.toplamfiyat + 4750;
            DialogResult secenek = MessageBox.Show("Kral Dairesi İle Devam Etmek İstiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Form3 sonekran = new Form3();
                sonekran.Show();
                this.Visible = false;
            }
        }
    }
}
