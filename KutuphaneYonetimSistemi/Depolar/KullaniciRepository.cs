using System.Data.SqlClient;
using KutuphaneYonetimSistemi.Modeller;
using KutuphaneYonetimSistemi.Veriler;

namespace KutuphaneYonetimSistemi.Depolar
{
    public class KullaniciRepository
    {
        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            Kullanici kullanici = null;

            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@kadi AND Sifre=@sifre";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    kullanici = new Kullanici
                    {
                        Id = (int)dr["Id"],
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        AdSoyad = dr["AdSoyad"].ToString()
                    };
                }
            }

            return kullanici;
        }
    }
}
