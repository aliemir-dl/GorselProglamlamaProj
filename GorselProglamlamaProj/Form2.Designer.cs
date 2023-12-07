namespace GorselProglamlamaProj
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonkayıt = new System.Windows.Forms.Button();
            this.buttontoplantı = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(582, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kayıtlı Toplantılar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(252, 247);
            this.textBox1.TabIndex = 17;
            this.textBox1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.buttonSil);
            this.panel2.Controls.Add(this.buttonkayıt);
            this.panel2.Controls.Add(this.buttontoplantı);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 301);
            this.panel2.TabIndex = 16;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(25, 206);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(109, 53);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "kayıtlı toplantıları sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonkayıt
            // 
            this.buttonkayıt.Location = new System.Drawing.Point(25, 111);
            this.buttonkayıt.Name = "buttonkayıt";
            this.buttonkayıt.Size = new System.Drawing.Size(109, 57);
            this.buttonkayıt.TabIndex = 3;
            this.buttonkayıt.Text = "kayıtlı toplantılar";
            this.buttonkayıt.UseVisualStyleBackColor = true;
            this.buttonkayıt.Click += new System.EventHandler(this.buttonkayıt_Click);
            // 
            // buttontoplantı
            // 
            this.buttontoplantı.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttontoplantı.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttontoplantı.Location = new System.Drawing.Point(25, 28);
            this.buttontoplantı.Name = "buttontoplantı";
            this.buttontoplantı.Size = new System.Drawing.Size(109, 55);
            this.buttontoplantı.TabIndex = 1;
            this.buttontoplantı.Text = "toplantı uluştur";
            this.buttontoplantı.UseVisualStyleBackColor = true;
            this.buttontoplantı.Click += new System.EventHandler(this.buttontoplantı_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 55);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "toplantı oluşturma programına hoşgeldiniz";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonkayıt;
        private System.Windows.Forms.Button buttontoplantı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}