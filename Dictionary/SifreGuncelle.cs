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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }
      

        private void Button1_Click(object sender, EventArgs e)
        {
            yeniSifre yeni = new yeniSifre();
            yeni.Guncelle(txtAdSoyad.Text, txtKulAdi.Text, txtSifre.Text, txtTekrar.Text, txtSoru.Text, txtCevap.Text, groupBox1);
        }
    }
}
