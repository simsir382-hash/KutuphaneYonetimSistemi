using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi.Depolar;

namespace KutuphaneYonetimSistemi.UserControls
{
    public partial class ucKitapListele : UserControl
    {
        private KitapRepository _kitapRepo = new KitapRepository();

        public ucKitapListele()
        {
            InitializeComponent();
        }

        private void ucKitapListele_Load(object sender, EventArgs e)
        {
            // Veritabanından kitapları getirip DataGridView'e bağlama
            dgvKitaplar.DataSource = _kitapRepo.TumKitaplariGetir();
        }

        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
