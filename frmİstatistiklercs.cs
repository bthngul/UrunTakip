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
using System.Xml.Linq;

namespace Urun_Takip
{
    public partial class Frmİstatistikler : Form
    {
        public Frmİstatistikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"
                Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //sql bağlantısını çalıştırmak için globalde tanımladık.
        private void Frmİstatistikler_Load(object sender, EventArgs e)
        {
            //Toplam kategori sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from TBLKATEGORİ", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();//DR İSİMLİ nesnemiz komut1 den gelen değeri okuma işlemi gerçekleştirir.
            while (dr.Read())//dr komutu okuma işlemi yaptığı müddetçe
            {
                LblTopKat.Text = dr[0].ToString();//veritabanındaki sorguya göre çıkan sonucu yazdırır. 0.index çünkü sorgu sonucunda tek sütun çıkartır.
            }
            baglanti.Close();
            //Toplam Ürün Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM TBLURUNLER",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblTopUrun.Text= dr2[0].ToString();
            }
            baglanti.Close();
            //En Yüksek Stoklu Ürün
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM TBLURUNLER where Stok=(Select MAX(Stok) from TBLURUNLER)",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                LblMaxStok.Text = dr3["UrunAd"].ToString();
            }
            baglanti.Close();
            //EN Düşük stoklu ürün
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLURUNLER where Stok=(Select MIN(Stok) from TBLURUNLER)", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMinStok.Text = dr4["UrunAd"].ToString();
            }
            baglanti.Close();
            //En Yüksek Stoklu Ürün Getireceği Kar
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT (SatisFiyat - AlisFiyat) * Stok From TBLURUNLER where Stok=(Select MAX(Stok) from TBLURUNLER)\r\n", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblMaxKar.Text = dr5[0].ToString();
            }
            baglanti.Close();
            //En düşük stoklu ürünün getireceği kar
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT (SatisFiyat - AlisFiyat) * Stok From TBLURUNLER where Stok=(Select min(Stok) from TBLURUNLER)\r\n", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
               LblMinKar.Text = dr6[0].ToString();
            }
            baglanti.Close();
            //Toplam Telefon sayısı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("SELECT COUNT(*) From TBLURUNLER WHERE Kategori=(Select ID From TBLKATEGORİ where KategoriAd='Telefon')", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblTopTelefon.Text = dr7[0].ToString();
            }
            baglanti.Close();
            //Toplam Beyaz Eşya sayısı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("SELECT COUNT(*) From TBLURUNLER WHERE Kategori=(Select ID From TBLKATEGORİ where KategoriAd='Beyaz Eşya')\r\n", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LblTopBeyazEsya.Text = dr8[0].ToString();
            }
            baglanti.Close();




        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anamenü = new AnaMenu();
            anamenü.Show();
            this.Close();
        }
    }
}
