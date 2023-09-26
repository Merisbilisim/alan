using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKısakenar_TextChanged(object sender, EventArgs e)
        {
            




        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar, alan, çevre;
            kısakenar = Convert.ToInt32(txtKısakenar.Text);
            uzunkenar = Convert.ToInt32(txtUzunkenar.Text);
            alan = uzunkenar * kısakenar;
            çevre = (uzunkenar + kısakenar) * 2;

            lblAlan.Text = "Alan :" + alan.ToString();
            lblÇevre.Text = "Çevre :" + çevre.ToString();
        }
    }
}
