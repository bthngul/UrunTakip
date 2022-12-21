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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLMUSTERİTableAdapter tableAdapter = new DataSet1TableAdapters.TBLMUSTERİTableAdapter(); //MüşteriTablosu veritabanında tableAdapter Diye nesne oluşturduk.
        //DataSet'imizde tanımlı Metodları çağırmak için tanımladık.
        private void btnGeri_Click(object sender, EventArgs e)//anaMenüye dönmek için oluşturduğumuz geri butonunun kodları
        {
            AnaMenu anamenü = new AnaMenu();
            anamenü.Show();
            this.Hide();
        }
        //Burada önceki formlara nazaran DATASET kullanılmaktadır. kullanım amacı; SQL üzerinden temel crud(Yazma-Okuma-Güncelleme-Silme) işlemlerini uzun sorgulara gerek
        //-Kalmadan bunları daha kolay bir yöntemle hazır olarak veren yapılar olduğu için kullanılmıştır.
        private void BtnUrunLıst_Click(object sender, EventArgs e)//Müşterileri Listelemek İçin.
        {
            dataGridView1.DataSource = tableAdapter.MusteriListesi();
        }

        private void BtnMusKydt_Click(object sender, EventArgs e)//Yeni Müşteri Kaydetmek İçin.
        {
            try
            {
                if (MusAdTxt.Text == string.Empty || MusSoyadTxt.Text == string.Empty || MusSehirTxt.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen Kayıt Sırasında Boş Alan Bırakmayınız!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                { 
                tableAdapter.MusteriEkle(MusAdTxt.Text, MusSoyadTxt.Text, MusSehirTxt.Text,MusTelefonTxt.Text);
                    MessageBox.Show("Kayıt  Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Müşteri Kayıt sırasında hata oluştu.", hata.Message);
            }
        }

        private void BtnMusSıl_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusIdTxt.Text == string.Empty)
                {
                    MessageBox.Show("ID Kısmı Boş Bırakılamaz.!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tableAdapter.MusteriSil(int.Parse(MusIdTxt.Text));
                    MessageBox.Show("Silme  Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Müşteri Silme sırasında hata oluştu.", hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//DataGridwiewde tıklandığında bulunduğu konumu textbox'a aktarıyor.
        {
            MusIdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //Müşteri ID metinboxundaki değere, datagridview'in (e.rowIndex (yani benim tıklamış olduğum)) satırın indeksini alıp celss ile string olarak ÜRÜNID metin boxuna aktardık.
            MusAdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//alttaki işlemlerde de aynı mantık kullanılmıştır.
            MusSoyadTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            MusSehirTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            MusTelefonTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnMusGuncl_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusAdTxt.Text == string.Empty || MusSoyadTxt.Text == string.Empty || MusSehirTxt.Text == string.Empty || MusTelefonTxt.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen Güncelleme Sırasında Boş Alan Bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tableAdapter.MusteriGüncelle(MusAdTxt.Text, MusSoyadTxt.Text, MusSehirTxt.Text,MusTelefonTxt.Text,int.Parse(MusIdTxt.Text));
                    MessageBox.Show("Güncelleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Müşteri Güncelleme sırasında hata oluştu.", hata.Message);
            }
        }

        private void BtnMusAra_Click(object sender, EventArgs e)
        {
            if (radioButtonAd.Checked == true)
            {
                dataGridView1.DataSource = tableAdapter.AdaGöreListele(MusAramaTxt.Text);
                MessageBox.Show("Ad'a göre Listelendi.", "Listeleme Başarılı", MessageBoxButtons.OK);
            }
            if (radioButtonSoyad.Checked == true)
            {
                dataGridView1.DataSource = tableAdapter.SoyadaGöreListele(MusAramaTxt.Text);
                MessageBox.Show("Soyad'a göre Listelendi.", "Listeleme Başarılı", MessageBoxButtons.OK);
            }
            if (radioButtonSehir.Checked == true)
            {
                dataGridView1.DataSource = tableAdapter.SehireGöreListele(MusAramaTxt.Text);
                MessageBox.Show("Şehir'e göre Listelendi.", "Listeleme Başarılı", MessageBoxButtons.OK);
            }
        }

        private void FrmMusteri_Load(object sender, EventArgs e)//tool tipler yardım amaçlıdır kullanıcıya gerekli ipuçları verir.
        {   //Tool tip müşteri silme
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dikkat!";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.SetToolTip(BtnMusSıl, "Silme işleminin geri dönüşü yoktur..");
            //-----------------------------------------------------------------------
            //Ara butonu
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dikkat!";
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.SetToolTip(BtnMusAra, "Arama için seçim yapınız.");
        }
    }
}
