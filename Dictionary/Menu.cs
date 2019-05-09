using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//IngilziceAnlami
namespace Dictionary
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }
      

        private void Menu_Load(object sender, EventArgs e)
        {
            kelimeIslemleri me = new kelimeIslemleri();
            dataGridView1.DataSource = me.tablola();
        }
       
        private void Eklebtn_Click(object sender, EventArgs e)
        {
            kelimeEkle ekle = new kelimeEkle();
            ekle.Show();
            this.Hide();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt16(idtut.Text);
            kelimeIslemleri sil = new kelimeIslemleri();
            sil.kelimeSil(id);
            dataGridView1.DataSource = sil.tablola();
            MessageBox.Show(inglizcetxt.Text +" "+ " kelimesi sözlükten silinmiştir...");
        }

        
        private void Arabtn_Click(object sender, EventArgs e)
        {
            kelimeIslemleri islem = new kelimeIslemleri();
            dataGridView1.DataSource = islem.araYap(aratxt.Text);
        }

        private void Guncellebtn_Click(object sender, EventArgs e)
        {
            kelimeGüncellemeFrm güncelle = new kelimeGüncellemeFrm();
            güncelle.Show();
            this.Hide();
        }

      

        private void Verigetirbtn_Click(object sender, EventArgs e)
        {
            kelimeIslemleri getir = new kelimeIslemleri();
            dataGridView1.DataSource = getir.tablola();
        }


        

        private void Ogren_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Enabled = true;
            testetme frm = new testetme();
            frm.Show();
            this.Hide();
            
        }
        
        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        
    }
}
