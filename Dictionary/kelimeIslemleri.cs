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
    class kelimeIslemleri
    {
        public string silDurum { get; set; }
        public string  durum { get; set; }
        public string ingilizce_tut { get; set; }

        dataBase db = new dataBase();
        public DataTable tablola()
        {
            if(db.baglanti.State==ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("select *from kelimeler", db.baglanti);
                SqlDataAdapter adabtor = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                adabtor.Fill(tablo);
                return tablo;
            }
            catch
            {
                return null;
            }
            finally
            {
                db.baglanti.Close();
            }
           
        }
        public void kelimeGuncelleme(int id,string turkcesi,string ingilizicesi,string t_turu,string i_turu,string cumle)
        {
            if(db.baglanti.State==ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                ingilizce_tut = " " + ingilizicesi;
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update kelimeler set TurkceAnlami=@TurkceAnlami,IngilziceAnlami=@IngilziceAnlami,KelimeTuru=@KelimeTuru,IKelimeTuru=@IKelimeTuru,Cumle=@Cumle where id=@id", db.baglanti);
                guncelle.Parameters.AddWithValue("@TurkceAnlami", turkcesi);
                guncelle.Parameters.AddWithValue("@IngilziceAnlami", ingilizicesi);
                guncelle.Parameters.AddWithValue("@KelimeTuru", t_turu);
                guncelle.Parameters.AddWithValue("@IKelimeTuru", i_turu);
                guncelle.Parameters.AddWithValue("@Cumle", cumle);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.ExecuteNonQuery();
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
        public void kelimeSil(int id)
        {
            if(db.baglanti.State==ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete kelimeler where id=@id", db.baglanti);
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
            }
            catch
            {
                
            }
            finally
            {
                db.baglanti.Close();
            }
        }

      public DataTable araYap(string ingilizcesi)
        {

            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("select * from kelimeler where IngilziceAnlami  LIKE '%'+@IngilziceAnlami+'%' ", db.baglanti);


                veriAl.Parameters.AddWithValue("@IngilziceAnlami", ingilizcesi);
                SqlDataAdapter adaptor = new SqlDataAdapter(veriAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch
            {
                return null;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
    }

}
