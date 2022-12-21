namespace Urun_Takip
{
    partial class FrmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSatisGüncelle = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtToplamSatis = new System.Windows.Forms.TextBox();
            this.TxtFiyatSatis = new System.Windows.Forms.TextBox();
            this.TxtAdetSatis = new System.Windows.Forms.TextBox();
            this.TxtSatisMüsteri = new System.Windows.Forms.TextBox();
            this.TxtSatisID = new System.Windows.Forms.TextBox();
            this.BtnSatisHesapla = new System.Windows.Forms.Button();
            this.BtnSatisKydt = new System.Windows.Forms.Button();
            this.BtnSatisLıst = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnSatisGüncelle);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.TxtToplamSatis);
            this.groupBox2.Controls.Add(this.TxtFiyatSatis);
            this.groupBox2.Controls.Add(this.TxtAdetSatis);
            this.groupBox2.Controls.Add(this.TxtSatisMüsteri);
            this.groupBox2.Controls.Add(this.TxtSatisID);
            this.groupBox2.Controls.Add(this.BtnSatisHesapla);
            this.groupBox2.Controls.Add(this.BtnSatisKydt);
            this.groupBox2.Controls.Add(this.BtnSatisLıst);
            this.groupBox2.Location = new System.Drawing.Point(957, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 633);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // BtnSatisGüncelle
            // 
            this.BtnSatisGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnSatisGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSatisGüncelle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnSatisGüncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSatisGüncelle.Location = new System.Drawing.Point(53, 567);
            this.BtnSatisGüncelle.Margin = new System.Windows.Forms.Padding(30);
            this.BtnSatisGüncelle.Name = "BtnSatisGüncelle";
            this.BtnSatisGüncelle.Size = new System.Drawing.Size(187, 64);
            this.BtnSatisGüncelle.TabIndex = 21;
            this.BtnSatisGüncelle.Text = "Güncelle";
            this.BtnSatisGüncelle.UseVisualStyleBackColor = false;
            this.BtnSatisGüncelle.Click += new System.EventHandler(this.BtnSatisGüncelle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(145, 296);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 22);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // TxtToplamSatis
            // 
            this.TxtToplamSatis.BackColor = System.Drawing.Color.White;
            this.TxtToplamSatis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtToplamSatis.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplamSatis.Location = new System.Drawing.Point(145, 248);
            this.TxtToplamSatis.MaxLength = 20;
            this.TxtToplamSatis.Multiline = true;
            this.TxtToplamSatis.Name = "TxtToplamSatis";
            this.TxtToplamSatis.Size = new System.Drawing.Size(130, 32);
            this.TxtToplamSatis.TabIndex = 19;
            // 
            // TxtFiyatSatis
            // 
            this.TxtFiyatSatis.BackColor = System.Drawing.Color.White;
            this.TxtFiyatSatis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFiyatSatis.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyatSatis.Location = new System.Drawing.Point(145, 202);
            this.TxtFiyatSatis.MaxLength = 9;
            this.TxtFiyatSatis.Multiline = true;
            this.TxtFiyatSatis.Name = "TxtFiyatSatis";
            this.TxtFiyatSatis.Size = new System.Drawing.Size(130, 32);
            this.TxtFiyatSatis.TabIndex = 18;
            // 
            // TxtAdetSatis
            // 
            this.TxtAdetSatis.BackColor = System.Drawing.Color.White;
            this.TxtAdetSatis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdetSatis.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdetSatis.Location = new System.Drawing.Point(145, 156);
            this.TxtAdetSatis.MaxLength = 5;
            this.TxtAdetSatis.Multiline = true;
            this.TxtAdetSatis.Name = "TxtAdetSatis";
            this.TxtAdetSatis.Size = new System.Drawing.Size(130, 32);
            this.TxtAdetSatis.TabIndex = 17;
            // 
            // TxtSatisMüsteri
            // 
            this.TxtSatisMüsteri.BackColor = System.Drawing.Color.White;
            this.TxtSatisMüsteri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSatisMüsteri.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatisMüsteri.Location = new System.Drawing.Point(145, 109);
            this.TxtSatisMüsteri.MaxLength = 100;
            this.TxtSatisMüsteri.Multiline = true;
            this.TxtSatisMüsteri.Name = "TxtSatisMüsteri";
            this.TxtSatisMüsteri.Size = new System.Drawing.Size(130, 32);
            this.TxtSatisMüsteri.TabIndex = 16;
            // 
            // TxtSatisID
            // 
            this.TxtSatisID.BackColor = System.Drawing.Color.White;
            this.TxtSatisID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSatisID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatisID.Location = new System.Drawing.Point(145, 17);
            this.TxtSatisID.MaxLength = 50;
            this.TxtSatisID.Multiline = true;
            this.TxtSatisID.Name = "TxtSatisID";
            this.TxtSatisID.Size = new System.Drawing.Size(130, 32);
            this.TxtSatisID.TabIndex = 14;
            // 
            // BtnSatisHesapla
            // 
            this.BtnSatisHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnSatisHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSatisHesapla.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnSatisHesapla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSatisHesapla.Location = new System.Drawing.Point(53, 412);
            this.BtnSatisHesapla.Margin = new System.Windows.Forms.Padding(30);
            this.BtnSatisHesapla.Name = "BtnSatisHesapla";
            this.BtnSatisHesapla.Size = new System.Drawing.Size(187, 64);
            this.BtnSatisHesapla.TabIndex = 6;
            this.BtnSatisHesapla.Text = "Hesapla";
            this.BtnSatisHesapla.UseVisualStyleBackColor = false;
            this.BtnSatisHesapla.Click += new System.EventHandler(this.BtnSatisHesapla_Click);
            // 
            // BtnSatisKydt
            // 
            this.BtnSatisKydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnSatisKydt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSatisKydt.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnSatisKydt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSatisKydt.Location = new System.Drawing.Point(53, 489);
            this.BtnSatisKydt.Margin = new System.Windows.Forms.Padding(30);
            this.BtnSatisKydt.Name = "BtnSatisKydt";
            this.BtnSatisKydt.Size = new System.Drawing.Size(187, 64);
            this.BtnSatisKydt.TabIndex = 5;
            this.BtnSatisKydt.Text = "Satis Yap";
            this.BtnSatisKydt.UseVisualStyleBackColor = false;
            this.BtnSatisKydt.Click += new System.EventHandler(this.BtnSatisKydt_Click);
            // 
            // BtnSatisLıst
            // 
            this.BtnSatisLıst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnSatisLıst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSatisLıst.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnSatisLıst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSatisLıst.Location = new System.Drawing.Point(53, 340);
            this.BtnSatisLıst.Margin = new System.Windows.Forms.Padding(30);
            this.BtnSatisLıst.Name = "BtnSatisLıst";
            this.BtnSatisLıst.Size = new System.Drawing.Size(187, 64);
            this.BtnSatisLıst.TabIndex = 4;
            this.BtnSatisLıst.Text = "Listele";
            this.BtnSatisLıst.UseVisualStyleBackColor = false;
            this.BtnSatisLıst.Click += new System.EventHandler(this.BtnSatisLıst_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGeri.BackgroundImage = global::Urun_Takip.Properties.Resources.geriButon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGeri.Location = new System.Drawing.Point(1174, 5);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 68);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(917, 679);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Urun_Takip.Properties.Resources.SATIŞBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox2);
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.MaximizeBox = false;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSatisHesapla;
        private System.Windows.Forms.Button BtnSatisKydt;
        private System.Windows.Forms.Button BtnSatisLıst;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtToplamSatis;
        private System.Windows.Forms.TextBox TxtFiyatSatis;
        private System.Windows.Forms.TextBox TxtAdetSatis;
        private System.Windows.Forms.TextBox TxtSatisMüsteri;
        private System.Windows.Forms.TextBox TxtSatisID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BtnSatisGüncelle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}