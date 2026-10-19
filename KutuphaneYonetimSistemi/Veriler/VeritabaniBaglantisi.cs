using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi.Veriler
{
    public class VeritabaniBaglantisi
    {
        // SQL Server bağlantı cümlesi (Kendi SQL sunucu adınıza göre düzenleyebilirsiniz)
        private static string connectionString = @"Server=localhost;Database=KutuphaneDB;Trusted_Connection=True;";

        public static SqlConnection BaglantiAl()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            return baglanti;
        }
    }
}
