using Microsoft.EntityFrameworkCore;
using Obs.Data;
using Obs.Helper;
using Obs.Model;
using Obs.View;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Obs
{
    public partial class OgrKayitFrm : Form
    {
        public Ogrenci? ogrenci = null;

        
        private OBSDBContext context = new OBSDBContext(); 

        public OgrKayitFrm()
        {
            InitializeComponent();
            SiniflariYukle(); 
        }

        
        private void SiniflariYukle()
        {
            var siniflar = context.Siniflar.ToList();
            cmbSinif.DataSource = siniflar;
            cmbSinif.DisplayMember = "SinifAd"; 
            cmbSinif.ValueMember = "SinifId"; 
        }

        //
        //----------- OGR KAYIT EKLEME START--------------------//
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (FormHelper.AlanlarDoluMu(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrNumara.Text))
            {
                MessageBox.Show("T�m Alananlar� doldurun.");
                return;
            }

                string ad = txtOgrAd.Text;
                string soyad = txtOgrSoyad.Text;
                string numara = txtOgrNumara.Text;
                int sinifId = (int)cmbSinif.SelectedValue; 
            

            using (var context = new OBSDBContext())
            {
                
                if (FormHelper.SinifKontenjanDolduMu(context, sinifId))
                {
                    MessageBox.Show("Bu s�n�f dolu, ba�ka bir s�n�f se�in.", "Kontenjan Doldu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ogrenci == null)
                {
                    MessageBox.Show("");
                    return;
                }
                var newOgrenci = new Ogrenci
                {
                    Ad = ad,
                    Soyad = soyad,
                    Numara = numara,
                    SinifId = sinifId
                };

                context.Students.Add(newOgrenci);

                
                var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                sinif.AktifKontenjan++;

                context.SaveChanges();

                MessageBox.Show("��renci ba�ar�yla eklendi.");
            }
        }
        //----------- OGR KAYIT EKLEME END--------------------//

        //----------- OGR KAYIT BULMA START-----------------//
        private void btnKayitBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrNumara.Text))
            {
                MessageBox.Show("L�tfen ��renci numaras� girin.");
                return;
            }

            string ogrNumara = txtOgrNumara.Text;
            ogrenci = context.Students.FirstOrDefault(o => o.Numara == ogrNumara);

            if (ogrenci != null)
            {
                txtOgrAd.Text = ogrenci.Ad;
                txtOgrSoyad.Text = ogrenci.Soyad;
                txtOgrNumara.Text = ogrenci.Numara;
                cmbSinif.SelectedValue = ogrenci.SinifId; 
                MessageBox.Show("��renci bulundu!");
            }
            else
            {
                MessageBox.Show("��renci bulunamad�.");
            }
        }
        //----------- OGR KAYIT BULMA END-----------------//
        //
        //----------- OGR KAYIT G�NCELLEME START--------------------//
        private void btnG�ncelle_Click(object sender, EventArgs e)
        {
            if (ogrenci == null)
            {
                MessageBox.Show("L�tfen �nce bir ��renci aray�n.");
                return;
            }

            if (!FormHelper.AlanlarDoluMu(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrNumara.Text)) return;

            ogrenci.Ad = txtOgrAd.Text;
            ogrenci.Soyad = txtOgrSoyad.Text;
            ogrenci.Numara = txtOgrNumara.Text;
            ogrenci.SinifId = (int)cmbSinif.SelectedValue; 

            context.Students.Update(ogrenci);
            int etkilenenSatir = context.SaveChanges();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("��renci ba�ar�yla g�ncellendi.");
            }
            else
            {
                MessageBox.Show("G�ncelleme i�lemi ba�ar�s�z oldu.");
            }

            // Alanlar� temizle
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            txtOgrNumara.Clear();
            cmbSinif.SelectedIndex = -1;
        }
        //----------- OGR KAYIT G�NCELLEME END--------------------//
        //
        //----------- OGR KAYIT S�LME START--------------------//
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (ogrenci != null)
            {
                
                var ogrenciDersler = context.OgrenciDersler
                    .Include(od => od.Ders) 
                    .Where(od => od.OgrenciId == ogrenci.OgrenciId)
                    .ToList();

                if (ogrenciDersler.Any()&ogrenci!=null)
                {
                    
                    string dersListesi = string.Join(", ", ogrenciDersler.Select(od => od.Ders?.DersAd ?? "Bilinmeyen Ders"));

                    
                    var sonuc = MessageBox.Show($"{ogrenci.Ad} {ogrenci.Soyad} adl� ��rencinin kay�tl� oldu�u dersler: {dersListesi}. Bu dersler de silinecek. Devam etmek istiyor musunuz?",
                                                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (sonuc == DialogResult.Yes)
                    {
                        
                        context.OgrenciDersler.RemoveRange(ogrenciDersler);

                        
                        context.Students.Remove(ogrenci);

                        
                        var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == ogrenci.SinifId);
                        if (sinif != null)
                        {
                            sinif.AktifKontenjan--;
                        }

                        
                        context.SaveChanges();
                        MessageBox.Show("��renci ve ders kay�tlar� ba�ar�yla silindi.");
                    }
                }
                else
                {
                    if (ogrenci == null)
                    {
                        MessageBox.Show("�nce ��renci se�in.");
                        return;
                    }
                    
                    var sonuc = MessageBox.Show($"{ogrenci.Ad} {ogrenci.Soyad} adl� ��renciyi silmek istedi�inizden emin misiniz?",
                                                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (sonuc == DialogResult.Yes & ogrenci != null)
                    {
                        context.Students.Remove(ogrenci);

                        
                        var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == ogrenci.SinifId);
                        if (sinif != null)
                        {
                            sinif.AktifKontenjan--;
                        }

                        context.SaveChanges();
                        MessageBox.Show("��renci ba�ar�yla silindi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("L�tfen �nce silinecek bir ��renci se�in.", "��renci Se�ilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
        }
        //----------- OGR KAYIT S�LME END--------------------//
        //
        //----------- ANA SAYFAYA Y�NLEND�RME START--------------------//
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFrm giris = new GirisFrm();
            giris.Show();
            this.Hide();
        }
        //----------- ANA SAYFAYA Y�NLEND�RME START--------------------//
    }
}
