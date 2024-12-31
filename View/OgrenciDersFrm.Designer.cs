namespace Obs.View
{
    partial class OgrenciDersFrm
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
            btnGeri = new Button();
            dgDersListesi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            txtNumara = new TextBox();
            txtDersAd = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDersKodu = new TextBox();
            btnDersAra = new Button();
            btnOgrAra = new Button();
            btnDersKaydet = new Button();
            btnDersSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDersListesi).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 0;
            btnGeri.Text = "Ana Sayfa";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // dgDersListesi
            // 
            dgDersListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDersListesi.Location = new Point(296, 67);
            dgDersListesi.Name = "dgDersListesi";
            dgDersListesi.RowHeadersWidth = 51;
            dgDersListesi.Size = new Size(637, 290);
            dgDersListesi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 83);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 4;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 21);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Soyadı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Numarası";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(98, 154);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(0, 20);
            lblSoyad.TabIndex = 9;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(98, 115);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(0, 20);
            lblAd.TabIndex = 8;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(90, 185);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(137, 27);
            txtNumara.TabIndex = 10;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(377, 34);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(137, 27);
            txtDersAd.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 37);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 12;
            label6.Text = "Ders Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 37);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 14;
            label7.Text = "Ders Kodu";
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(628, 34);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(137, 27);
            txtDersKodu.TabIndex = 13;
            // 
            // btnDersAra
            // 
            btnDersAra.Location = new Point(789, 32);
            btnDersAra.Name = "btnDersAra";
            btnDersAra.Size = new Size(144, 29);
            btnDersAra.TabIndex = 15;
            btnDersAra.Text = "Ders Ara";
            btnDersAra.UseVisualStyleBackColor = true;
            btnDersAra.Click += btnDersAra_Click;
            // 
            // btnOgrAra
            // 
            btnOgrAra.Location = new Point(12, 235);
            btnOgrAra.Name = "btnOgrAra";
            btnOgrAra.Size = new Size(215, 29);
            btnOgrAra.TabIndex = 16;
            btnOgrAra.Text = "Öğrenci Ara";
            btnOgrAra.UseVisualStyleBackColor = true;
            btnOgrAra.Click += btnOgrAra_Click;
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(299, 378);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(215, 29);
            btnDersKaydet.TabIndex = 17;
            btnDersKaydet.Text = "Seçilen Dersleri Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.Location = new Point(534, 378);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(215, 29);
            btnDersSil.TabIndex = 18;
            btnDersSil.Text = "Seçilen Dersleri Sil";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // OgrenciDersFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 445);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersKaydet);
            Controls.Add(btnOgrAra);
            Controls.Add(btnDersAra);
            Controls.Add(label7);
            Controls.Add(txtDersKodu);
            Controls.Add(label6);
            Controls.Add(txtDersAd);
            Controls.Add(txtNumara);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgDersListesi);
            Controls.Add(btnGeri);
            Name = "OgrenciDersFrm";
            Text = "OgrenciDers";
            ((System.ComponentModel.ISupportInitialize)dgDersListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeri;
        private DataGridView dgDersListesi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSoyad;
        private Label lblAd;
        private TextBox txtNumara;
        private TextBox txtDersAd;
        private Label label6;
        private Label label7;
        private TextBox txtDersKodu;
        private Button btnDersAra;
        private Button btnOgrAra;
        private Button btnDersKaydet;
        private Button btnDersSil;
    }
}