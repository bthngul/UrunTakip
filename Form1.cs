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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Urun_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"
                Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //baglanti komutunu global de tanımladık böylece diğer
                                                                                                    //nesneler ile beraber çağırabileceğiz.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ktgBtnList_Click(object sender, EventArgs e)//Listele butonu kodları
        {
            SqlCommand komut = new SqlCommand("Select  * From TBLKATEGORİ", baglanti); //Listeleme için yaptığımız SQL sorgusu.
            SqlDataAdapter da = new SqlDataAdapter(komut);//Köprü tanımladık.
            DataTable dt = new DataTable();//veritablosu tanımladık
            da.Fill(dt);//Köprüden gelen veriler ile datatable'ı(veri tablosu) doldurmak için
            dataGridView1.DataSource = dt;//veri tablosunu doldurmak için kullandık hafızada tutulan verileri tabloya aktardık.
        }

        private void ktgBtnKaydet_Click(object sender, EventArgs e)//Kaydet butonu kodları
        {
            try
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into TBLKATEGORİ (KategoriAd) Values (@p1)", baglanti);//SQL sorgusunu baglanti adresinde bulunan veritabanı üzerinden çalışacak.
                komut2.Parameters.AddWithValue("@p1", kategoriTxt.Text); //P1 isimli parametreye komut ataması yaptık. oradaki değer ise kategori adı girdiğimiz metin kutusundan alınan değer.
                komut2.ExecuteNonQuery();//SORGUYU çalıştırma anlamına gelen kod  satırı.
                baglanti.Close();//veritabanı bağlantısını kapattık.
                MessageBox.Show("Kategoriniz başarılı bir şekilde eklendi.");//Kullanıcıya bilgi vermek amacıyla messageBox oluşturduk.
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);//İşlem sırasında olası bir hatada kullanıcıyı bilgilendirmek için hata kontrolü uyguladık.
            }
        }

        private void ktgBtnSil_Click(object sender, EventArgs e)//Sil butonu kodları
        {
            try
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from TBLKATEGORİ where ID=@p1", baglanti);//SQL sorgusunu baglanti adresinde bulunan veritabanı üzerinden çalışacak.
                komut3.Parameters.AddWithValue("@p1", KategoriIDtxt.Text); //P1 isimli parametreye komut ataması yaptık. oradaki değer ise kategori adı girdiğimiz metin kutusundan alınan değer.
                komut3.ExecuteNonQuery();//SORGUYU çalıştırma anlamına gelen kod  satırı.
                baglanti.Close();//veritabanı bağlantısını kapattık.
                MessageBox.Show("Kategoriniz başarılı bir şekilde silindi.");//Kullanıcıya bilgi vermek amacıyla messageBox oluşturduk.
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme sırasında hata oluştu." + hata.Message);//İşlem sırasında olası bir hatada kullanıcıyı bilgilendirmek için hata kontrolü uyguladık.
            }

        }

        private void ktgBtnGünc_Click(object sender, EventArgs e)//Güncelleme butonu kodları
        {
            try
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("update TBLKATEGORİ set KategoriAd=@p1 where ID=@p2", baglanti);//SQL sorgu kodu
                komut4.Parameters.AddWithValue("@p1", kategoriTxt.Text);//1. parametreyi kategori adının textBox'ından gelen değere eşitledik.
                komut4.Parameters.AddWithValue("@p2", KategoriIDtxt.Text);//2. parametreyi kategori ID textBox'ından gelen değere eşitledik.
                komut4.ExecuteNonQuery();//Yapılan değişiklikleri kaydetmesi için çağırdığımız kod.
                baglanti.Close();
                MessageBox.Show("Kategoriniz başarılı bir şekilde güncellendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu." + hata.Message);//detaylı hata mesajı
            }
        }

        private void ktgBtnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Select  * From TBLKATEGORİ where KategoriAd = @p1", baglanti); //SQL sorgusu.
            SqlDataAdapter da = new SqlDataAdapter(komut5);//Köprü tanımladık.
            komut5.Parameters.AddWithValue("@p1", kategoriTxt.Text);
            DataTable dt = new DataTable();//veritablosu tanımladık
            da.Fill(dt);//Köprüden gelen veriler ile datatable'ı(veri tablosu) doldurmak için
            dataGridView1.DataSource = dt;//veri tablosunu doldurmak için kullandık hafızada tutulan verileri tabloya aktardık.

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anamenü = new AnaMenu();
            anamenü.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //TOOL TİP
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dikkat!";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.SetToolTip(ktgBtnSil, "Silme işleminin geri dönüşü yoktur..");
            //--------------------------
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Uyarı";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(ktgBtnAra, "Arama yapmak için ID ve Kategori Adı Gereklidir.");
        }
    }
}
//Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True
