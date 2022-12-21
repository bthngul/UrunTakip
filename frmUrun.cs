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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"
                Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //baglanti komutunu global de tanımladık böylece diğer
                                                                                                    //nesneler ile beraber çağırabileceğiz.

        private void BtnUrunLıst_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select UrunID,UrunAd, Stok, AlisFiyat, SatisFiyat, KategoriAd ,Kategori FROM TBLURUNLER\r\ninner join TBLKATEGORİ\r\nON TBLURUNLER.Kategori = TBLKATEGORİ.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Kategori"].Visible = false;

        }

        private void frmUrun_Load(object sender, EventArgs e)//Kategorilerin combobox'a getirme işlemini gerçekleştirdik. formun load kısmına yazdık çünkü form çalıştırıldığında ekranda gözüküyor olması gerekir.
        {
            SqlCommand komut2 = new SqlCommand("select * from TBLKATEGORİ", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);//dt2 deki veriler ile datatable'ı doldurduk
            comboBox1.DisplayMember = "KategoriAd";
            comboBox1.ValueMember = "ID";//arka planda çalışır.
            comboBox1.DataSource = dt2; //dt2 datatabel daki değerleri combobox' a atadık.
            //---------------TOOL------------
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dikkat!";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.SetToolTip(BtnUrunSıl, "Silme işleminin geri dönüşü yoktur..");


        }

        private void BtnUrunKydt_Click(object sender, EventArgs e)//yeni ürün kaydetme işleminde kullanılan kaydet butonunun kod satırı
        {
            try
            {
                baglanti.Open();//SQL DataAdapter kullanılmadığı için butona bastığımızda bağlantının çalışması gerekeceği için baglantıyı open ediyoruz.
                SqlCommand komut3 = new SqlCommand("insert into TBLURUNLER (UrunAD,Stok,AlisFiyat,SatisFiyat,Kategori) " +
                    "values(@p1,@p2,@p3,@p4,@p5)", baglanti);//Parametreleri aslında bir yol olarak kullandık, veritabanındaki parametrelere erişmek için p1,p2...p5 e kadar değişken tanımladık
                komut3.Parameters.AddWithValue("@p1", UrunAdıTxt.Text);//p1 değişkeni ürün adı metinboxundaki değeri yeni değer olarak veritabanına ekleyecek
                komut3.Parameters.AddWithValue("@p2", numericUpDown1.Value);//p2 değişkeni stoktaki numericupdowndaki değer ile veritabanına ekleyecek. (text özelliği olmadığı için value (değer) özelliği tanımlanmıştır.)
                komut3.Parameters.AddWithValue("@p3", decimal.Parse(UrunAlsTxt.Text));//p3 değişkeni alışfiyatındaki text değerindeki değer ile veritabanına eklenmiştir.
                komut3.Parameters.AddWithValue("@p4", decimal.Parse(UrunStsTxt.Text));//p4 değişkeni satışfiyatındaki text değeri ile veritabanına eklenecek
                komut3.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);//p5 değişkeni ise comboboxtaki seçilen değer ile veritabanına ekleme yapacak.
                komut3.ExecuteNonQuery(); // YAPILAN DEĞİŞİKLİKLERİ VERİTABANINA yazdırmak için kullanılan kod.
                baglanti.Close();//baglantının en son kapanması gerekiyor.
                MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu.", hata.Message);
            }
        }

        private void BtnUrunSıl_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunIdTxt.Text == string.Empty)
                {
                    MessageBox.Show("Silme işlemi urunID'ye göre gerçekleşir. \rID BOŞ BIRAKILAMAZ.");//ID KISMI BOŞ KALAMAZ DİYE HATA KONTROLÜ YAPTIRTTIK.
                }
                else
                {

                    baglanti.Open();//tekrardan bağlantımızı açtık
                    SqlCommand komut4 = new SqlCommand("delete from TBLURUNLER where UrunID = @p1", baglanti);//sqlcommand sınıfından komut4 adında nesne türettik.
                    komut4.Parameters.AddWithValue("@p1", UrunIdTxt.Text);
                    komut4.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme İşlemi başarıyla gerçekleşti.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Ürün silme sırasında hata oluştu.", hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//bu işlem biz datagridwiev in üzerinde dolaşırken sağ taraftaki sütunlara bulunduğumuz konumun bilgisini aktarır.
        {
            UrunIdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //Ürün ID metinboxundaki değere, datagridview'in (e.rowIndex (yani benim tıklamış olduğum)) satırın indeksini alıp celss ile string olarak ÜRÜNID metin boxuna aktardık.
            UrunAdıTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//alttaki işlemlerde de aynı mantık kullanılmıştır.
            UrunAlsTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            UrunStsTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()); //numericupdawn text özelliği kabul olmadığından dolayı değeri int değere dönüştüp atadık.
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void BtnUrunGuncl_Click(object sender, EventArgs e)//bu işlem veritabanı güncellenmesi ile ilgilidir.
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update TBLURUNLER set UrunAd=@p1,AlisFiyat=@p3,SatisFiyat=@p4,Kategori=@p5,Stok=@p2 where UrunID=@p6", baglanti);//Bir yol oluşturduk. değişkenler ile veritabanı güncellemesi yapacak.
            komut5.Parameters.AddWithValue("@p1", UrunAdıTxt.Text);//ürün adının textboxunu @p1 değişkenine atadık.
            komut5.Parameters.AddWithValue("@p3", decimal.Parse(UrunAlsTxt.Text));//alış fiyaatındaki textboxu @p3 değişkenine atadık.
            komut5.Parameters.AddWithValue("@p4", decimal.Parse(UrunStsTxt.Text));//satış fiyatındaki textboxu @p4 değişkenine atadık.
            komut5.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);//Kategori için kullandığımız combobox'daki seçili olan değeri @p5 değişkenine atadık.
            komut5.Parameters.AddWithValue("@p6", UrunIdTxt.Text);//UrunID textboxunu @p6 değişkenine atadık.
            komut5.Parameters.AddWithValue("@p2",numericUpDown1.Value);
            komut5.ExecuteNonQuery();//yapılan değişiklikleri veritabanına yansıtmak için kullanılır.
            baglanti.Close();
            MessageBox.Show("Ürün bilgileri başarıyla güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu anamenü = new AnaMenu();
            anamenü.Show();
            this.Hide();
        }
    }
}
