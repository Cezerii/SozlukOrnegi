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
    public partial class testetme : Form
    {
        public testetme()
        {
            InitializeComponent();
        }

        private void Testetme_Load(object sender, EventArgs e)
        {
            btnılerı.Text = "BAŞLA";
            rdasıkkı.Visible = false;
            rdbsıkkı.Visible = false;
            rdcsıkkı.Visible = false;
            rddsıkkı.Visible = false;

        }

        private void Btnılerı_Click(object sender, EventArgs e)
        {
            btnılerı.Text = "SONRAKİ SORU";
            rdasıkkı.Visible = true;
            rdbsıkkı.Visible = true;
            rdcsıkkı.Visible = true;
            rddsıkkı.Visible = true;
        }
    }
}
