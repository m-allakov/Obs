using Obs.Data;
using Obs.Helper;
using Obs.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Obs.View
{
    public partial class DersKayitFrm : Form
    {
        private Ders ders = new Ders(); 

        public DersKayitFrm()
        {
            InitializeComponent();
        }

        
        private void btnKayitBul_Click(object sender, EventArgs e)
        {
            using (var context = new OBSDBContext())
            {
                string dersKod = txtDersKod.Text; 

                if (string.IsNullOrEmpty(dersKod))
                {
                    MessageBox.Show("Lütfen ders kodunu girin.");
                    return;
                }

                
                var bulunanDers = context.Dersler.FirstOrDefault(d => d.DersKod == dersKod);

                if (bulunanDers != null)
                {
                    ders = bulunanDers;  
                    txtDersKod.Text = ders.DersKod;
                    txtDersAd.Text = ders.DersAd;
                }
                else
                {
                    MessageBox.Show($"'{dersKod}' ders koduna sahip ders bulunamadı.");
                }
            }
        }

        
        private void btnKayit_Click(object sender, EventArgs e)
        {
            
            if (!FormHelper.AlanlarDoluMu(txtDersAd.Text, txtDersKod.Text)) return;

            using (var context = new OBSDBContext())
            {
                string dersKod = txtDersKod.Text;

                
                var mevcutDers = context.Dersler.FirstOrDefault(d => d.DersKod == dersKod);
                if (mevcutDers != null)
                {
                    MessageBox.Show($"'{dersKod}' koduna sahip ders zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                
                var yeniDers = new Ders
                {
                    DersKod = dersKod,
                    DersAd = txtDersAd.Text
                };

                context.Dersler.Add(yeniDers);
                int etkilenenSatir = context.SaveChanges();

                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Ders başarıyla kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.");
                }
            }

            
            txtDersKod.Clear();
            txtDersAd.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            if (ders == null)
            {
                MessageBox.Show("Lütfen önce bir ders arayın.");
                return;
            }

            if (!FormHelper.AlanlarDoluMu(txtDersAd.Text, txtDersKod.Text)) return;

            using (var context = new OBSDBContext())
            {
                var mevcutDers = context.Dersler.FirstOrDefault(d => d.DersKod == ders.DersKod);
                if (mevcutDers != null)
                {
                    
                    var ayniKoddaDers = context.Dersler.FirstOrDefault(d => d.DersKod == txtDersKod.Text && d.DersId != ders.DersId);
                    if (ayniKoddaDers != null)
                    {
                        MessageBox.Show($"'{txtDersKod.Text}' koduna sahip ders zaten mevcut. Lütfen farklı bir ders kodu girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    mevcutDers.DersKod = txtDersKod.Text;
                    mevcutDers.DersAd = txtDersAd.Text;

                    context.Dersler.Update(mevcutDers);
                    int etkilenenSatir = context.SaveChanges();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Ders başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı.");
                }
            }

            
            txtDersKod.Clear();
            txtDersAd.Clear();
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (ders == null)
            {
                MessageBox.Show("Lütfen önce bir ders arayın.");
                return;
            }

            
            if (!FormHelper.SilmeOnayi(ders)) return;

            using (var context = new OBSDBContext())
            {
                var silinecekDers = context.Dersler.FirstOrDefault(d => d.DersKod == ders.DersKod);
                if (silinecekDers != null)
                {
                    context.Dersler.Remove(silinecekDers);
                    int etkilenenSatir = context.SaveChanges();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Ders başarıyla silindi.");
                        ders = null; 
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı.");
                }
            }

           
            txtDersKod.Clear();
            txtDersAd.Clear();
        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            GirisFrm giris = new GirisFrm();
            giris.ShowDialog();
            this.Hide();
        }

        private void anaSayfa_Click_1(object sender, EventArgs e)
        {
            GirisFrm frm = new GirisFrm();
            frm.Show();
            this.Close();
        }

        
    }
}
