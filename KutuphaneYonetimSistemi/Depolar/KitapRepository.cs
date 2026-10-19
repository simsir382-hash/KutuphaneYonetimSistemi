using System.Collections.Generic;
using System.Data.SqlClient;
using KutuphaneYonetimSistemi.Modeller;
using KutuphaneYonetimSistemi.Veriler;

namespace KutuphaneYonetimSistemi.Depolar
{
    public class KitapRepository
    {
        public List<Kitap> TumKitaplariGetir()
        {
            List<Kitap> liste = new List<Kitap>();

            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Kitaplar";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Kitap
                    {
                        Id = (int)dr["Id"],
                        KitapAd = dr["KitapAd"].ToString(),
                        Yazar = dr["Yazar"].ToString(),
                        SayfaSayisi = (int)dr["SayfaSayisi"],
                        Stok = (int)dr["Stok"]
                    });
                }
            }

            return liste;
        }
    }
}

