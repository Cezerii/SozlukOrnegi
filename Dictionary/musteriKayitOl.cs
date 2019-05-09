using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dictionary
{
    class musteriKayitOl
    {
        dataBase db = new dataBase();
        public void kayitOl(string adiSoyAdi, string kullaniciAdi, string sifre, string tekrar, string soru, string cevap, GroupBox grup)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                if (sifre == tekrar)
                {
                    db.baglanti.Open();
                    SqlCommand kayit_ol = new SqlCommand("insert into kullaniciKayitOl values(@adiSoyadi,@kullaniciAdi,@sifre,@soru,@cevap )", db.baglanti);
                    kayit_ol.Parameters.AddWithValue("@adiSoyadi", adiSoyAdi);
                    kayit_ol.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    kayit_ol.Parameters.AddWithValue("@sifre", sifre);
                    kayit_ol.Parameters.AddWithValue("@soru", soru);
                    kayit_ol.Parameters.AddWithValue("@cevap", cevap);
                    kayit_ol.ExecuteNonQuery();
                    MessageBox.Show(adiSoyAdi + " " + "İsimli müşteri başarılı bir şekilde kayıt oluşmuştur: ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in grup.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    kayit_ol.Dispose();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(""+hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }    
    }
}
