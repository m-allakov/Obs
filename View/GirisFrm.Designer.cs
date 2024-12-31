namespace Obs.View
{
    partial class GirisFrm
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
            btnOgrKayit = new Button();
            btnDersKayit = new Button();
            btnSinifKayit = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnOgrKayit
            // 
            btnOgrKayit.Location = new Point(127, 78);
            btnOgrKayit.Name = "btnOgrKayit";
            btnOgrKayit.Size = new Size(136, 29);
            btnOgrKayit.TabIndex = 0;
            btnOgrKayit.Text = "Öğrenci Kayıt";
            btnOgrKayit.UseVisualStyleBackColor = true;
            btnOgrKayit.Click += btnOgrKayit_Click;
            // 
            // btnDersKayit
            // 
            btnDersKayit.Location = new Point(127, 125);
            btnDersKayit.Name = "btnDersKayit";
            btnDersKayit.Size = new Size(136, 29);
            btnDersKayit.TabIndex = 1;
            btnDersKayit.Text = "Ders Kayıt";
            btnDersKayit.UseVisualStyleBackColor = true;
            btnDersKayit.Click += btnDersKayit_Click;
            // 
            // btnSinifKayit
            // 
            btnSinifKayit.Location = new Point(127, 172);
            btnSinifKayit.Name = "btnSinifKayit";
            btnSinifKayit.Size = new Size(136, 29);
            btnSinifKayit.TabIndex = 2;
            btnSinifKayit.Text = "Sınıf Kayıt";
            btnSinifKayit.UseVisualStyleBackColor = true;
            btnSinifKayit.Click += btnSinifKayit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(127, 224);
            button3.Name = "button3";
            button3.Size = new Size(136, 29);
            button3.TabIndex = 3;
            button3.Text = "Ogrenci Dersi Kayıt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GirisFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(button3);
            Controls.Add(btnSinifKayit);
            Controls.Add(btnDersKayit);
            Controls.Add(btnOgrKayit);
            Name = "GirisFrm";
            Text = "GirisFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOgrKayit;
        private Button btnDersKayit;
        private Button btnSinifKayit;
        private Button button3;
    }
}