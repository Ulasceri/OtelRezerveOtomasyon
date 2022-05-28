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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("ADI = "+Form3.isim + " SOYADI = " + Form3.soyisim + " KALACAĞI GÜN = " + Form3.gün + " TOPLAM FİYAT =  " + Form3.toplamfiyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.Title = "İsimlerin Kayıt Olacağı Yeri Seçiniz.";
            dialog.OverwritePrompt = true;
            dialog.Filter = "Metin Belgeleri|*.txt|Bütün Dosyalar|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) using (System.IO.StreamWriter writer = new System.IO.StreamWriter(dialog.FileName, false)) foreach (object satir in listBox1.Items) writer.WriteLine(satir);

        }
    }
}
