using Obs.Data;
using Obs.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Obs.View
{
    public partial class OgrenciDersFrm : Form
    {
        private Ogrenci ogrenci; 
        private OBSDBContext context = new OBSDBContext(); 

        public OgrenciDersFrm()
        {
            InitializeComponent();
        }

        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFrm frm = new GirisFrm();
            frm.Show();
            this.Close(); 
        }

        
        private void btnOgrAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Lütfen öğrenci numarasını girin.");
                return;
            }

            string ogrNumara = txtNumara.Text;
            ogrenci = context.Students.FirstOrDefault(o => o.Numara == ogrNumara);

            if (ogrenci != null)
            {
                lblAd.Text = ogrenci.Ad;
                lblSoyad.Text = ogrenci.Soyad;
                MessageBox.Show("Öğrenci bulundu!");

                
                DersleriYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.");
            }
        }

        
        private void btnDersAra_Click(object sender, EventArgs e)
        {
            DersleriYukle();
        }


        private void DersleriYukle()
        {
            string dersAdi = txtDersAd.Text.Trim();
            string dersKodu = txtDersKodu.Text.Trim();


            var dersler = context.Dersler.AsQueryable();

            if (!string.IsNullOrWhiteSpace(dersAdi))
            {
                dersler = dersler.Where(d => d.DersAd.Contains(dersAdi));
            }

            if (!string.IsNullOrWhiteSpace(dersKodu))
            {
                dersler = dersler.Where(d => d.DersKod.Contains(dersKodu));
            }

            
            dgDersListesi.DataSource = dersler.ToList();
        }

        
        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if (ogrenci == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçin.");
                return;
            }

            
            List<int> secilenDersler = new List<int>();

            foreach (DataGridViewRow row in dgDersListesi.SelectedRows)
            {
                int dersId = (int)row.Cells["DersId"].Value;
                secilenDersler.Add(dersId);
            }

            if (secilenDersler.Count == 0)
            {
                MessageBox.Show("Lütfen kaydetmek istediğiniz dersleri seçin.");
                return;
            }

            
            foreach (var dersId in secilenDersler)
            {
                
                var mevcutKayit = context.OgrenciDersler.FirstOrDefault(od => od.OgrenciId == ogrenci.OgrenciId && od.DersId == dersId);
                if (mevcutKayit != null) continue; 

                OgrenciDers yeniKayit = new OgrenciDers
                {
                    OgrenciId = ogrenci.OgrenciId,
                    DersId = dersId
                };

                context.OgrenciDersler.Add(yeniKayit);
            }

            int etkilenenSatir = context.SaveChanges();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Dersler başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.");
            }
        }

        
        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (ogrenci == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçin.");
                return;
            }

            List<int> secilenDersler = new List<int>();

            foreach (DataGridViewRow row in dgDersListesi.SelectedRows)
            {
                int dersId = (int)row.Cells["DersId"].Value;
                secilenDersler.Add(dersId);
            }

            if (secilenDersler.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz dersleri seçin.");
                return;
            }

            
            foreach (var dersId in secilenDersler)
            {
                var mevcutKayit = context.OgrenciDersler.FirstOrDefault(od => od.OgrenciId == ogrenci.OgrenciId && od.DersId == dersId);
                if (mevcutKayit != null)
                {
                    context.OgrenciDersler.Remove(mevcutKayit);
                }
            }

            int etkilenenSatir = context.SaveChanges();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Dersler başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız oldu.");
            }
        }
    }
}
