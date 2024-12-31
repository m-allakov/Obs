namespace Obs
{
    partial class OgrKayitFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGeri = new Button();
            lblAd = new Label();
            label1 = new Label();
            txtOgrAd = new TextBox();
            txtOgrSoyad = new TextBox();
            btnGüncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            btnKayitBul = new Button();
            label3 = new Label();
            label4 = new Label();
            txtOgrNumara = new TextBox();
            cmbSinif = new ComboBox();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(6, 9);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 17;
            btnGeri.Text = "Ana Sayfa";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(24, 99);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(32, 20);
            lblAd.TabIndex = 16;
            lblAd.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 153);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 15;
            label1.Text = "Soyadı";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(124, 92);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(194, 27);
            txtOgrAd.TabIndex = 14;
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(124, 146);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(194, 27);
            txtOgrSoyad.TabIndex = 13;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(124, 367);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 12;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 0, 0);
            btnSil.ForeColor = SystemColors.ActiveCaptionText;
            btnSil.Location = new Point(224, 367);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(24, 367);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKayitBul
            // 
            btnKayitBul.Location = new Point(124, 310);
            btnKayitBul.Name = "btnKayitBul";
            btnKayitBul.Size = new Size(94, 29);
            btnKayitBul.TabIndex = 9;
            btnKayitBul.Text = "Bul";
            btnKayitBul.UseVisualStyleBackColor = true;
            btnKayitBul.Click += btnKayitBul_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 201);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 21;
            label3.Text = "Numara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 255);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 20;
            label4.Text = "Sınıfı";
            // 
            // txtOgrNumara
            // 
            txtOgrNumara.Location = new Point(124, 194);
            txtOgrNumara.Name = "txtOgrNumara";
            txtOgrNumara.Size = new Size(194, 27);
            txtOgrNumara.TabIndex = 19;
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(124, 247);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(194, 28);
            cmbSinif.TabIndex = 22;
            // 
            // OgrKayitFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 429);
            Controls.Add(cmbSinif);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtOgrNumara);
            Controls.Add(btnGeri);
            Controls.Add(lblAd);
            Controls.Add(label1);
            Controls.Add(txtOgrAd);
            Controls.Add(txtOgrSoyad);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(btnKayitBul);
            Name = "OgrKayitFrm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeri;
        private Label lblAd;
        private Label label1;
        private TextBox txtOgrAd;
        private TextBox txtOgrSoyad;
        private Button btnGüncelle;
        private Button btnSil;
        private Button btnKaydet;
        private Button btnKayitBul;
        private Label label3;
        private Label label4;
        private TextBox txtOgrNumara;
        private ComboBox cmbSinif;
    }
}
