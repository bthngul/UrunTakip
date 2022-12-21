using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        private void AnaMenu_Load(object sender, EventArgs e)//BU FORM GEÇİŞ FORMUDUR FORMLAR ARASI BAĞLANTIYI SAĞLAR İLGİLİ BUTONA GÖRE GEÇİŞ YAPAR.
        {

        }

        private void UrunButon_Click(object sender, EventArgs e)//URUN BİLGİLERİ FORMUNA GİDİŞ
        {
            frmUrun urun = new frmUrun();
            urun.Show();
            this.Close();
        }

        private void ButonKategori_Click(object sender, EventArgs e)//KATEGORİ FORMUNA GİDİŞ
        {
            Form1 kategori = new Form1();
            kategori.Show();
            this.Close();
        }

        private void Butonİstatistik_Click(object sender, EventArgs e)//İSTATİSTİKLER FORMUNA GİDİŞ
        {
            Frmİstatistikler istatistikler = new Frmİstatistikler();
            istatistikler.Show();
            this.Close();

        }

        private void ButonGrafikler_Click(object sender, EventArgs e)//GRAFİKLER FORMUNA GİDİŞ
        {
            FrmGrafikler grafikler = new FrmGrafikler();
            grafikler.Show();
            this.Close();
        }

        private void BtnAnaMenü_Click(object sender, EventArgs e) //LOGİN FORMUNA GİDİŞ
        {
            FrmGırıs girişekran = new FrmGırıs();
            girişekran.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)//MÜŞTERİ BİLGİLERİ FORMUNA GİDİŞ
        {
            FrmMusteri müşteri = new FrmMusteri();
            müşteri.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//SATIŞ BİLGİLERİ FORMUNA GİDİŞ
        {
            FrmSatis satış = new FrmSatis();
            satış.Show();
            
        }
    }
}
