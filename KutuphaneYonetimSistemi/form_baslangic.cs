using KutuphaneYonetimSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class form_baslangic : Form
    {
        public form_baslangic()
        {
            InitializeComponent();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            panelIcerik.Controls.Clear();
            ucKitapListele uc = new ucKitapListele();
            uc.Dock = DockStyle.Fill;
            panelIcerik.Controls.Add(uc);
        }

        private void btnKitapYonet_Click(object sender, EventArgs e)
        {
            panelIcerik.Controls.Clear();

            // ucKitapListele yerine ucKitapYonet çağırıyoruz
            ucKitapYonet uc = new ucKitapYonet();
            uc.Dock = DockStyle.Fill;
            panelIcerik.Controls.Add(uc);
        }
    }
    }
