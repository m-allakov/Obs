using Obs.Data;
using Obs.Model;

namespace Obs.Helper
{
    public static class FormHelper
    {
        public static bool AlanlarDoluMu(string alan)
        {
            if (string.IsNullOrWhiteSpace(alan))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return false;
            }
            return true;
        }

        
        public static bool AlanlarDoluMu(params string[] alanlar)
        {
            foreach (var alan in alanlar)
            {
                if (string.IsNullOrWhiteSpace(alan))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return false;
                }
            }
            return true;
        }


        
        public static bool SilmeOnayi(string dersAd)
        {
            var dialogResult = MessageBox.Show($"'{dersAd}' dersini silmek istediğinizden emin misiniz?",
                                               "Silme Onayı",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }

        
        public static bool SilmeOnayi(int dersKod)
        {
            var dialogResult = MessageBox.Show($"'{dersKod}' koduna sahip dersi silmek istediğinizden emin misiniz?",
                                               "Silme Onayı",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }

        
        public static bool SilmeOnayi(Ders ders)
        {
            var dialogResult = MessageBox.Show($"'{ders.DersAd}' dersini silmek istediğinizden emin misiniz?",
                                               "Silme Onayı",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }

        

        public static bool SinifKontenjanDolduMu(OBSDBContext context, int sinifId)
        {
            
            var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);

            if (sinif == null)
            {
                throw new Exception("Sınıf bulunamadı.");
            }

            
            return sinif.AktifKontenjan >= sinif.Kontenjan;
        }
    }
}