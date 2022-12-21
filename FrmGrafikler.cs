using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urun_Takip
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //baglanti komutunu global de tanımladık böylece diğer
                                                                                                                                         //nesneler ile beraber çağırabileceğiz.

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT KategoriAd,Count(*) From TBLURUNLER inner join TBLKATEGORİ on TBLURUNLER.Kategori=TBLKATEGORİ.ID Group By KategoriAd",baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Kategori"].Points.AddXY(reader[0],reader[1]);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anamenü = new AnaMenu();
            anamenü.Show();
            this.Close();
        }
    }
}
