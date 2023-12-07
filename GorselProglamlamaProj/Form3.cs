using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProglamlamaProj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tarihkayıt_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"D:\masaüstü\KayitDosyasi.txt";

            using (StreamWriter writer = File.AppendText(dosyaYolu))
            {
                string veri = textBox1.Text;
                writer.WriteLine(veri);
            }

            using (StreamWriter writer = File.AppendText(dosyaYolu))
            {
                string veri = combotarih.Text;
                writer.WriteLine(veri);
            }

            using (StreamWriter writer = File.AppendText(dosyaYolu))
            {
                string veri = dateTimePicker1.Text;
                writer.WriteLine(veri);
            }
            MessageBox.Show("kaydetme işlemi başarılı");
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            this.Hide();
            this.Close();
            //frm2.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
