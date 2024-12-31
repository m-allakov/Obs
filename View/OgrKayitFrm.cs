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
                MessageBox.Show("Tüm Alananlarý doldurun.");
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
                    MessageBox.Show("Bu sýnýf dolu, baþka bir sýnýf seçin.", "Kontenjan Doldu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show("Öðrenci baþarýyla eklendi.");
            }
        }
        //----------- OGR KAYIT EKLEME END--------------------//

        //----------- OGR KAYIT BULMA START-----------------//
        private void btnKayitBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrNumara.Text))
            {
                MessageBox.Show("Lütfen öðrenci numarasý girin.");
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
                MessageBox.Show("Öðrenci bulundu!");
            }
            else
            {
                MessageBox.Show("Öðrenci bulunamadý.");
            }
        }
        //----------- OGR KAYIT BULMA END-----------------//
        //
        //----------- OGR KAYIT GÜNCELLEME START--------------------//
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (ogrenci == null)
            {
                MessageBox.Show("Lütfen önce bir öðrenci arayýn.");
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
                MessageBox.Show("Öðrenci baþarýyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncelleme iþlemi baþarýsýz oldu.");
            }

            // Alanlarý temizle
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            txtOgrNumara.Clear();
            cmbSinif.SelectedIndex = -1;
        }
        //----------- OGR KAYIT GÜNCELLEME END--------------------//
        //
        //----------- OGR KAYIT SÝLME START--------------------//
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

                    
                    var sonuc = MessageBox.Show($"{ogrenci.Ad} {ogrenci.Soyad} adlý öðrencinin kayýtlý olduðu dersler: {dersListesi}. Bu dersler de silinecek. Devam etmek istiyor musunuz?",
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
                        MessageBox.Show("Öðrenci ve ders kayýtlarý baþarýyla silindi.");
                    }
                }
                else
                {
                    if (ogrenci == null)
                    {
                        MessageBox.Show("Önce öðrenci seçin.");
                        return;
                    }
                    
                    var sonuc = MessageBox.Show($"{ogrenci.Ad} {ogrenci.Soyad} adlý öðrenciyi silmek istediðinizden emin misiniz?",
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
                        MessageBox.Show("Öðrenci baþarýyla silindi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce silinecek bir öðrenci seçin.", "Öðrenci Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
        }
        //----------- OGR KAYIT SÝLME END--------------------//
        //
        //----------- ANA SAYFAYA YÖNLENDÝRME START--------------------//
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFrm giris = new GirisFrm();
            giris.Show();
            this.Hide();
        }
        //----------- ANA SAYFAYA YÖNLENDÝRME START--------------------//
    }
}
