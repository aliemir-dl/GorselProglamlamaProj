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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {

            if (BoxKullanıcı.Text == "" || BoxSifre.Text == "")
            {

                MessageBox.Show("kullanıcıadı veya şifre boş bırakılmaz", "uyar");
            }
            else
            {
                if (BoxSifre.Text == "ali123" && BoxKullanıcı.Text == "ali" || BoxSifre.Text == "merve123" && BoxKullanıcı.Text == "merve" || BoxSifre.Text == "mehmet123" && BoxKullanıcı.Text == "mehmet" || BoxSifre.Text == "ayşe123" && BoxKullanıcı.Text == "ayşe")
                {

                    string dosyaYolu = @"D:\masaüstü\kayitdosyasi.txt";
                    using (StreamWriter writer = File.AppendText(dosyaYolu))
                    {
                        string veri = "kullanıcı adı:" + BoxKullanıcı.Text;
                        writer.WriteLine(veri);
                    }
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                    this.Hide();
                    
                    

                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre hatalı", "uyarı");
                }
            }
        }

        private void BoxKullanıcı_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
