namespace Obs.View
{
    partial class DersKayitFrm
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
            btnKayit = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKayitBul = new Button();
            txtDersAd = new TextBox();
            txtDersKod = new TextBox();
            lblDersAd = new Label();
            lblDersKod = new Label();
            anaSayfa = new Button();
            SuspendLayout();
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(15, 276);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(94, 29);
            btnKayit.TabIndex = 0;
            btnKayit.Text = "Kaydet";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(115, 276);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(215, 276);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKayitBul
            // 
            btnKayitBul.Location = new Point(115, 232);
            btnKayitBul.Name = "btnKayitBul";
            btnKayitBul.Size = new Size(94, 29);
            btnKayitBul.TabIndex = 3;
            btnKayitBul.Text = "Kayıt Bul";
            btnKayitBul.UseVisualStyleBackColor = true;
            btnKayitBul.Click += btnKayitBul_Click;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(115, 103);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(194, 27);
            txtDersAd.TabIndex = 4;
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(115, 153);
            txtDersKod.Name = "txtDersKod";
            txtDersKod.Size = new Size(194, 27);
            txtDersKod.TabIndex = 5;
            // 
            // lblDersAd
            // 
            lblDersAd.AutoSize = true;
            lblDersAd.Location = new Point(14, 106);
            lblDersAd.Name = "lblDersAd";
            lblDersAd.Size = new Size(66, 20);
            lblDersAd.TabIndex = 6;
            lblDersAd.Text = "Ders Adı";
            // 
            // lblDersKod
            // 
            lblDersKod.AutoSize = true;
            lblDersKod.Location = new Point(14, 161);
            lblDersKod.Name = "lblDersKod";
            lblDersKod.Size = new Size(78, 20);
            lblDersKod.TabIndex = 7;
            lblDersKod.Text = "Ders Kodu";
            // 
            // anaSayfa
            // 
            anaSayfa.Location = new Point(12, 12);
            anaSayfa.Name = "anaSayfa";
            anaSayfa.Size = new Size(94, 29);
            anaSayfa.TabIndex = 8;
            anaSayfa.Text = "Ana Sayfa";
            anaSayfa.UseVisualStyleBackColor = true;
            anaSayfa.Click += anaSayfa_Click_1;
            // 
            // DersKayitFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 346);
            Controls.Add(anaSayfa);
            Controls.Add(lblDersKod);
            Controls.Add(lblDersAd);
            Controls.Add(txtDersKod);
            Controls.Add(txtDersAd);
            Controls.Add(btnKayitBul);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKayit);
            Name = "DersKayitFrm";
            Text = "DersKayitFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayit;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKayitBul;
        private TextBox txtDersAd;
        private TextBox txtDersKod;
        private Label lblDersAd;
        private Label lblDersKod;
        private Button anaSayfa;
    }
}