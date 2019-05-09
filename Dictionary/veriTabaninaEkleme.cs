using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dictionary
{
    class veriTabaninaEkleme
    {
        dataBase db = new dataBase();
        public string turkceKarsiligi { get; set; }
        public string ingilizceKarsiligi  { get; set; }
        public string turkceTuru { get; set; }
        public string ingilizceTuru { get; set; }
        public void kelimeGuncelle(string turkcesi,string ingilizcesi,string t_turu,string i_turu,string cumle,GroupBox group)
        {
            if(db.baglanti.State==System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kelime_ekle = new SqlCommand("insert into kelimeler values(@TurkceAnlami,@IngilizceAnlami,@KelimeTuru,@IKelimeTuru,@Cumle)", db.baglanti);
                kelime_ekle.Parameters.AddWithValue("TurkceAnlami", turkcesi);
                kelime_ekle.Parameters.AddWithValue("IngilizceAnlami", ingilizcesi);
                kelime_ekle.Parameters.AddWithValue("KelimeTuru", t_turu);
                kelime_ekle.Parameters.AddWithValue("IKelimeTuru", i_turu);
                kelime_ekle.Parameters.AddWithValue("Cumle", cumle);
                kelime_ekle.ExecuteNonQuery();
                // bilgi verecek kutunun  türünü belirleme
                System.Windows.Forms.MessageBox.Show("Kelime kaydoldu","Bilgi",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                foreach (Control item in group.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                kelime_ekle.Dispose();
            }
            catch(Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
