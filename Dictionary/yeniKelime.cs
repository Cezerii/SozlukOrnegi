using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Dictionary
{
    class yeniKelime
    {
        dataBase db = new dataBase();
        public void KelimeGuncelle(string turkcesi,string ingilizcesi,string t_turu,string i_turu,string cumle,GroupBox grup)
        {
            if(db.baglanti.State==System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kelimeGuncelle = new SqlCommand("update kelimeler set TurkceAnlami=@TurkceAnlami,IngilziceAnlami=@IngilziceAnlami,Cumle=@Cumle , KelimeTuru=@KelimeTuru , IKelimeTuru=@IKelimeTuru", db.baglanti);
                kelimeGuncelle.Parameters.AddWithValue("@TurkceAnlami", turkcesi);
                kelimeGuncelle.Parameters.AddWithValue("@IngilziceAnlami", ingilizcesi);
                kelimeGuncelle.Parameters.AddWithValue("@KelimeTuru", t_turu);
                kelimeGuncelle.Parameters.AddWithValue("@IKelimeTuru", i_turu);
                kelimeGuncelle.Parameters.AddWithValue("@Cumle", cumle);
                int tut = kelimeGuncelle.ExecuteNonQuery();
                kelimeGuncelle.Dispose();
                if(tut==1)
                {
                    MessageBox.Show("İşlem başaralı", "Sozluk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach(Control item in grup.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                       
                }
                else { MessageBox.Show("Kelime Güncelleme Başarız olmuştur"); }
                db.baglanti.Close();
            }
           
            catch(Exception hata)
            {
                MessageBox.Show(" " + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
