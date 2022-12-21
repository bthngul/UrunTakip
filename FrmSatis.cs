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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"
                Data Source=DESKTOP-E3NETMH;Initial Catalog=DbUrunTakip;Integrated Security=True"); //baglanti komutunu global de tanımladık böylece diğer
                                                                                                    //nesneler ile beraber çağırabileceğiz.

        DataSet1TableAdapters.TBLSATİSLARTableAdapter ds = new DataSet1TableAdapters.TBLSATİSLARTableAdapter(); // dataseti globale ekleyip ilgili araçlarda çağırdık.
        


        private void btnGeri_Click(object sender, EventArgs e)//Anamenüye dönmek için kullanılan buton
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
            
        }

        private void BtnSatisLıst_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("Execute SatisListesi", baglanti);//Sql bağlantısında uzun uzun sorgu yazmak yerine daha kısa yöntem olan Prosedür yöntemini kullandık.
                SqlDataAdapter da = new SqlDataAdapter(komut1);//veritabanı ile form arasında bağlantı oluşturduk.
                DataTable dt = new DataTable();//formda veri tablosu tanımladık
                da.Fill(dt);// veri tablosuna köprü yardımıyla verileri aktardık
                dataGridView1.DataSource = dt; //son olarak verileri formdaki dataGridView'e yazdırdık.
            }
            catch (Exception hata)
            {
                MessageBox.Show("Satış Listeleme sırasında hata oluştu.", hata.Message);
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)//Form yüklendiği zaman bazı özelliklerin gelmesi için
        {
                SqlCommand komut2 = new SqlCommand("Select * from TBLURUNLER", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                comboBox1.ValueMember = "UrunID";
                comboBox1.DisplayMember = "UrunAd"; //görünür olarak ürün adı olur fakat işlemler ürünıd ye göre sıralanır
                comboBox1.DataSource = dt2;//dt2 den gelen veriler ile combobox'da dolum işlermi yapar.
                                           //--------------------TOOL TİPLER------------------------
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dikkat!";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.SetToolTip(BtnSatisHesapla, "Adet ve Fiyat bilgisi giriniz.");


        }

        private void BtnSatisKydt_Click(object sender, EventArgs e)//satış kaydetme butonu
        { 
            try
            {
                ds.SatisYap(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(TxtSatisMüsteri.Text), byte.Parse(TxtAdetSatis.Text), decimal.Parse(TxtFiyatSatis.Text), decimal.Parse(TxtToplamSatis.Text), DateTime.Parse(maskedTextBox1.Text));
                MessageBox.Show("Satış Başarıyla Yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("İşlem Sırasında hata oluştu.");
            }
        }

        private void BtnSatisHesapla_Click(object sender, EventArgs e)//Hesaplama butonu kullanıcı yüksek miktarda adet satın aldığında hesaplamasını kolaylaştırır.
        {
            if (TxtAdetSatis.Text == "" && TxtFiyatSatis.Text =="")
            {
               MessageBox.Show("Lütfen değer giriniz.","HATA!",MessageBoxButtons.OK, MessageBoxIcon.Error);//Adet veya Fiyat Boş kalmaması için uyarı verdirdik.
                return;//Uygulama hataya düşmesin diye çağırılan komut
            }
            double adet, fiyat, toplam;
            adet = Convert.ToDouble(TxtAdetSatis.Text);
            fiyat = Convert.ToDouble(TxtFiyatSatis.Text);
            toplam = adet * fiyat;
            TxtToplamSatis.Text = toplam.ToString();
        }

        private void BtnSatisGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ds.SatisGüncelle(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(TxtSatisMüsteri.Text), byte.Parse(TxtAdetSatis.Text), decimal.Parse(TxtFiyatSatis.Text), decimal.Parse(TxtToplamSatis.Text), DateTime.Parse(maskedTextBox1.Text),int.Parse(TxtSatisID.Text));
                MessageBox.Show("Güncelleme başarılı.","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Güncelleme işleminde hata oluştu","Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//Bu panel diğer formlarda olduğu gibi datagridview üzerinde dolaşırken metin kutularına aktarım sağlayacak.
        {
            TxtSatisID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtSatisMüsteri.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtAdetSatis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtFiyatSatis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();


        }
    }
}
