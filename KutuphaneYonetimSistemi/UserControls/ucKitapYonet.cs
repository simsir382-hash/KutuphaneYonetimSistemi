using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi.Depolar;
using KutuphaneYonetimSistemi.Modeller;

namespace KutuphaneYonetimSistemi.UserControls
{
    public partial class ucKitapYonet : UserControl
    {
        private KitapRepository _kitapRepo = new KitapRepository();

        public ucKitapYonet()
        {
            InitializeComponent();
        }

        private void ListeyiYenile()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = _kitapRepo.TumKitaplariGetir();
        }

        private void FormTemizle()
        {
            lblKitapAd.Text = "";
            lblYazar.Text = "";
            lblSayfaSayisi.Text = "";
            lblStok.Text = "";
        }

        private void ucKitapYonet_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // 1. Kutucuğun boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtKitapAd.Text))
            {
                MessageBox.Show("Lütfen kitap adını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Doğrudan TextBox nesnelerinden (.Text) değerleri oku
            Kitap yeniKitap = new Kitap
            {
                KitapAd = txtKitapAd.Text,
                Yazar = txtYazar.Text,
                SayfaSayisi = int.TryParse(txtSayfaSayisi.Text, out int sayfa) ? sayfa : 0,
                Stok = int.TryParse(txtStok.Text, out int stok) ? stok : 1
            };

            // 3. Veritabanına kaydet ve listeyi yenile
            if (_kitapRepo.KitapEkle(yeniKitap))
            {
                MessageBox.Show("Kitap başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
                FormTemizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
            {
                int seciliId = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["Id"].Value);

                DialogResult cevap = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (_kitapRepo.KitapSil(seciliId))
                    {
                        MessageBox.Show("Kitap silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListeyiYenile();
                    }
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
