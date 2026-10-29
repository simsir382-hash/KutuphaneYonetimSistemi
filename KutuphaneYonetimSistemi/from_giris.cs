using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi.Depolar;

namespace KutuphaneYonetimSistemi
{
    public partial class from_giris : Form
    {
        private KullaniciRepository _kullaniciRepo = new KullaniciRepository();

        public from_giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            var kullanici = _kullaniciRepo.GirisYap(kadi, sifre);

            if (kullanici != null)
            {
                Oturum.AktifKullanici = kullanici;

                // Ana formu aç ve giriş formunu gizle (Hocanın mantığı)
                form_baslangic anaForm = new form_baslangic();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
