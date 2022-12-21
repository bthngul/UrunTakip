using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip
{
    public partial class FrmGırıs : Form
    {
        public FrmGırıs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"
                Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //sql bağlantısını çalıştırmak için globalde tanımladık.

        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From TBLKULLANICI where Kullanıcı=@p1 and Sifre=@p2",baglanti);
            komut1.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                AnaMenu anamenü = new AnaMenu();
                anamenü.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }
            baglanti.Close();
        }

        private void FrmGırıs_Load(object sender, EventArgs e)
        {

        }
    }
}
