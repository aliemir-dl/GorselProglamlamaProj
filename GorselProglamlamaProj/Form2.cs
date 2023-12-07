using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace GorselProglamlamaProj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttontoplantı_Click(object sender, EventArgs e)
        {
            string dosya = @"D:\Masaüstü\";
            string dosyaadi = "KayitDosyasi.txt";
            if (!File.Exists(dosya + dosyaadi))
            {
                File.Create(dosya + dosyaadi);

            }

            Form3 frm4 = new Form3();
            frm4.ShowDialog();
            this.Close();
            //frm4.BringToFront();
        }

        private void buttonkayıt_Click(object sender, EventArgs e)
        {
            string dosyaadres = @"D:\masaüstü\KayitDosyasi.txt";



            if (File.Exists(dosyaadres))
            {
                int i = 0;
                foreach (string satirokuma in File.ReadAllLines(dosyaadres))
                {
                    i++;
                    textBox1.Text += i.ToString() + ") " + satirokuma + "\r\n";

                }
            }
            else
            {
                MessageBox.Show(" bulunamadı");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string dosyasil = @"D:\masaüstü\kayitdosyasi.txt";
            if (File.Exists(dosyasil))
            {

                File.WriteAllText(dosyasil, string.Empty);
                Console.Write("kayıtlı toplantılar silindi");
            }

            else
            {
                Console.Write("kayıtlı toplantı bulunamadı");
            }
            Console.ReadLine();
            textBox1.Text = "";
        }
    }
}
