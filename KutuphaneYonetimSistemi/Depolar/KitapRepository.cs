using System.Collections.Generic;
using System.Data.SqlClient;
using KutuphaneYonetimSistemi.Modeller;
using KutuphaneYonetimSistemi.Veriler;

namespace KutuphaneYonetimSistemi.Depolar
{
    public class KitapRepository
    {
        // 1. Tüm Kitapları Getir (Listeleme için)
        public List<Kitap> TumKitaplariGetir()
        {
            List<Kitap> liste = new List<Kitap>();
            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                string sorgu = "SELECT * FROM Kitaplar";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kitap k = new Kitap
                    {
                        Id = (int)dr["Id"],
                        KitapAd = dr["KitapAd"].ToString(),
                        Yazar = dr["Yazar"].ToString(),
                        SayfaSayisi = dr["SayfaSayisi"] != System.DBNull.Value ? (int)dr["SayfaSayisi"] : 0,
                        Stok = dr["Stok"] != System.DBNull.Value ? (int)dr["Stok"] : 0
                    };
                    liste.Add(k);
                }
            }
            return liste;
        }

        // 2. Kitap Ekleme
        public bool KitapEkle(Kitap kitap)
        {
            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                string sorgu = "INSERT INTO Kitaplar (KitapAd, Yazar, SayfaSayisi, Stok) VALUES (@ad, @yazar, @sayfa, @stok)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", kitap.KitapAd);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@sayfa", kitap.SayfaSayisi);
                komut.Parameters.AddWithValue("@stok", kitap.Stok);

                baglanti.Open();
                return komut.ExecuteNonQuery() > 0;
            }
        }

        // 3. Kitap Silme
        public bool KitapSil(int id)
        {
            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                string sorgu = "DELETE FROM Kitaplar WHERE Id = @id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                return komut.ExecuteNonQuery() > 0;
            }
        }
       
        // 4. Kitap Güncelleme
        public bool KitapGuncelle(Kitap kitap)
        {
            using (SqlConnection baglanti = VeritabaniBaglantisi.BaglantiAl())
            {
                string sorgu = "UPDATE Kitaplar SET KitapAd = @ad, Yazar = @yazar, SayfaSayisi = @sayfa, Stok = @stok WHERE Id = @id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", kitap.Id);
                komut.Parameters.AddWithValue("@ad", kitap.KitapAd);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@sayfa", kitap.SayfaSayisi);
                komut.Parameters.AddWithValue("@stok", kitap.Stok);

                baglanti.Open();
                return komut.ExecuteNonQuery() > 0;
            }
        }
    }


}
