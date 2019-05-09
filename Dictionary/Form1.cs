using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //form hareketi için
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }

                    return;
            }
            base.WndProc(ref m);
        }

        kayitGiris musteri = new kayitGiris();
        Menu menu = new Menu();
        private void Girisbtn_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizini giriniz", "HATA | Sozluk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                musteri.MusteriGiris(textBox1.Text, textBox2.Text);
                string bilgiTut = textBox1.Text + " " + textBox2.Text.ToString();
                if (musteri.girisDurumu == bilgiTut)
                {
                    menu.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz", "HATA | Sozluk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Sifre güncelleme icin 
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreGuncelle yeni = new SifreGuncelle();
            yeni.Show();
            this.Hide();
        }
         //kayitol
        private void KayitOl_Click(object sender, EventArgs e)
        {
            frmKayitOl frm = new frmKayitOl();
            frm.Show();
            this.Hide();
        }

       
    }
}
