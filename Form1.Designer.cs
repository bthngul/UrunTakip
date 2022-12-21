namespace Urun_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ktgBtnList = new System.Windows.Forms.Button();
            this.kategoriTxt = new System.Windows.Forms.TextBox();
            this.ktgBtnKaydet = new System.Windows.Forms.Button();
            this.ktgBtnSil = new System.Windows.Forms.Button();
            this.ktgBtnGünc = new System.Windows.Forms.Button();
            this.ktgBtnAra = new System.Windows.Forms.Button();
            this.KategoriIDtxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGeri.BackgroundImage = global::Urun_Takip.Properties.Resources.geriButon;
            resources.ApplyResources(this.btnGeri, "btnGeri");
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ktgBtnList
            // 
            this.ktgBtnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ktgBtnList, "ktgBtnList");
            this.ktgBtnList.Name = "ktgBtnList";
            this.ktgBtnList.UseVisualStyleBackColor = false;
            this.ktgBtnList.Click += new System.EventHandler(this.ktgBtnList_Click);
            // 
            // kategoriTxt
            // 
            this.kategoriTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kategoriTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.kategoriTxt, "kategoriTxt");
            this.kategoriTxt.ForeColor = System.Drawing.Color.Black;
            this.kategoriTxt.Name = "kategoriTxt";
            // 
            // ktgBtnKaydet
            // 
            this.ktgBtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ktgBtnKaydet, "ktgBtnKaydet");
            this.ktgBtnKaydet.Name = "ktgBtnKaydet";
            this.ktgBtnKaydet.UseVisualStyleBackColor = false;
            this.ktgBtnKaydet.Click += new System.EventHandler(this.ktgBtnKaydet_Click);
            // 
            // ktgBtnSil
            // 
            this.ktgBtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ktgBtnSil, "ktgBtnSil");
            this.ktgBtnSil.Name = "ktgBtnSil";
            this.ktgBtnSil.UseVisualStyleBackColor = false;
            this.ktgBtnSil.Click += new System.EventHandler(this.ktgBtnSil_Click);
            // 
            // ktgBtnGünc
            // 
            this.ktgBtnGünc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ktgBtnGünc, "ktgBtnGünc");
            this.ktgBtnGünc.Name = "ktgBtnGünc";
            this.ktgBtnGünc.UseVisualStyleBackColor = false;
            this.ktgBtnGünc.Click += new System.EventHandler(this.ktgBtnGünc_Click);
            // 
            // ktgBtnAra
            // 
            this.ktgBtnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ktgBtnAra, "ktgBtnAra");
            this.ktgBtnAra.Name = "ktgBtnAra";
            this.ktgBtnAra.UseVisualStyleBackColor = false;
            this.ktgBtnAra.Click += new System.EventHandler(this.ktgBtnAra_Click);
            // 
            // KategoriIDtxt
            // 
            this.KategoriIDtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.KategoriIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.KategoriIDtxt, "KategoriIDtxt");
            this.KategoriIDtxt.ForeColor = System.Drawing.Color.Black;
            this.KategoriIDtxt.Name = "KategoriIDtxt";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Urun_Takip.Properties.Resources.KategoriBG1;
            this.Controls.Add(this.KategoriIDtxt);
            this.Controls.Add(this.ktgBtnAra);
            this.Controls.Add(this.ktgBtnGünc);
            this.Controls.Add(this.ktgBtnSil);
            this.Controls.Add(this.ktgBtnKaydet);
            this.Controls.Add(this.kategoriTxt);
            this.Controls.Add(this.ktgBtnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ktgBtnList;
        private System.Windows.Forms.TextBox kategoriTxt;
        private System.Windows.Forms.Button ktgBtnKaydet;
        private System.Windows.Forms.Button ktgBtnSil;
        private System.Windows.Forms.Button ktgBtnGünc;
        private System.Windows.Forms.Button ktgBtnAra;
        private System.Windows.Forms.TextBox KategoriIDtxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

