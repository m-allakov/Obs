namespace Obs.View
{
    partial class SinifKayitFrm
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
            btnKaydet = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            txtKontenjan = new TextBox();
            txtSinifAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(124, 211);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(94, 29);
            btnKayit.TabIndex = 0;
            btnKayit.Text = "Bul";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(24, 268);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 0, 0);
            btnSil.ForeColor = SystemColors.ActiveCaptionText;
            btnSil.Location = new Point(224, 268);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(124, 268);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 3;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtKontenjan
            // 
            txtKontenjan.Location = new Point(124, 139);
            txtKontenjan.Name = "txtKontenjan";
            txtKontenjan.Size = new Size(125, 27);
            txtKontenjan.TabIndex = 4;
            // 
            // txtSinifAd
            // 
            txtSinifAd.Location = new Point(124, 85);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(125, 27);
            txtSinifAd.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 146);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Kontenjan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 92);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "Sınıf Adı";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(6, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 8;
            btnGeri.Text = "Ana Sayfa";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // SinifKayitFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 338);
            Controls.Add(btnGeri);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSinifAd);
            Controls.Add(txtKontenjan);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(btnKayit);
            Name = "SinifKayitFrm";
            Text = "SinifKayitFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayit;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGüncelle;
        private TextBox txtKontenjan;
        private TextBox txtSinifAd;
        private Label label1;
        private Label label2;
        private Button btnGeri;
    }
}