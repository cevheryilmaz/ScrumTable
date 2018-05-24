using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum_Table
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAd, sifre;
            kullaniciAd = txtAd.Text;
            sifre = txtSifre.Text;
            if(kullaniciAd=="admin" && sifre=="1234")
            {
                MessageBox.Show("Giriş Başarılı!!!");
                FormBaslangic fb = new FormBaslangic();
                fb.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!!!");
            }
        }
    }
}
