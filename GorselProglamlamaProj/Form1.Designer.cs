namespace GorselProglamlamaProj
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BoxSifre = new System.Windows.Forms.TextBox();
            this.BoxKullanıcı = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxSifre
            // 
            this.BoxSifre.Location = new System.Drawing.Point(337, 111);
            this.BoxSifre.Name = "BoxSifre";
            this.BoxSifre.PasswordChar = '*';
            this.BoxSifre.Size = new System.Drawing.Size(100, 20);
            this.BoxSifre.TabIndex = 22;
            // 
            // BoxKullanıcı
            // 
            this.BoxKullanıcı.Location = new System.Drawing.Point(337, 71);
            this.BoxKullanıcı.Name = "BoxKullanıcı";
            this.BoxKullanıcı.Size = new System.Drawing.Size(100, 20);
            this.BoxKullanıcı.TabIndex = 23;
            this.BoxKullanıcı.TextChanged += new System.EventHandler(this.BoxKullanıcı_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 259);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(337, 147);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 23);
            this.buttonGiris.TabIndex = 20;
            this.buttonGiris.Text = "giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxSifre);
            this.Controls.Add(this.BoxKullanıcı);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxSifre;
        private System.Windows.Forms.TextBox BoxKullanıcı;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

