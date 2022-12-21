namespace Urun_Takip
{
    partial class FrmMusteri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSehir = new System.Windows.Forms.RadioButton();
            this.radioButtonSoyad = new System.Windows.Forms.RadioButton();
            this.radioButtonAd = new System.Windows.Forms.RadioButton();
            this.MusAramaTxt = new System.Windows.Forms.TextBox();
            this.BtnMusAra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusTelefonTxt = new System.Windows.Forms.TextBox();
            this.MusSehirTxt = new System.Windows.Forms.TextBox();
            this.MusSoyadTxt = new System.Windows.Forms.TextBox();
            this.MusAdTxt = new System.Windows.Forms.TextBox();
            this.MusIdTxt = new System.Windows.Forms.TextBox();
            this.BtnMusGuncl = new System.Windows.Forms.Button();
            this.BtnMusSıl = new System.Windows.Forms.Button();
            this.BtnMusKydt = new System.Windows.Forms.Button();
            this.BtnUrunLıst = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 507);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonSehir);
            this.groupBox1.Controls.Add(this.radioButtonSoyad);
            this.groupBox1.Controls.Add(this.radioButtonAd);
            this.groupBox1.Controls.Add(this.MusAramaTxt);
            this.groupBox1.Controls.Add(this.BtnMusAra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(31, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonSehir
            // 
            this.radioButtonSehir.AutoSize = true;
            this.radioButtonSehir.Location = new System.Drawing.Point(738, 70);
            this.radioButtonSehir.Name = "radioButtonSehir";
            this.radioButtonSehir.Size = new System.Drawing.Size(69, 24);
            this.radioButtonSehir.TabIndex = 12;
            this.radioButtonSehir.TabStop = true;
            this.radioButtonSehir.Text = "Şehir";
            this.radioButtonSehir.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoyad
            // 
            this.radioButtonSoyad.AutoSize = true;
            this.radioButtonSoyad.Location = new System.Drawing.Point(738, 41);
            this.radioButtonSoyad.Name = "radioButtonSoyad";
            this.radioButtonSoyad.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSoyad.TabIndex = 11;
            this.radioButtonSoyad.TabStop = true;
            this.radioButtonSoyad.Text = "Soyad";
            this.radioButtonSoyad.UseVisualStyleBackColor = true;
            // 
            // radioButtonAd
            // 
            this.radioButtonAd.AutoSize = true;
            this.radioButtonAd.Location = new System.Drawing.Point(738, 15);
            this.radioButtonAd.Name = "radioButtonAd";
            this.radioButtonAd.Size = new System.Drawing.Size(50, 24);
            this.radioButtonAd.TabIndex = 10;
            this.radioButtonAd.TabStop = true;
            this.radioButtonAd.Text = "Ad";
            this.radioButtonAd.UseVisualStyleBackColor = true;
            // 
            // MusAramaTxt
            // 
            this.MusAramaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusAramaTxt.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusAramaTxt.Location = new System.Drawing.Point(229, 26);
            this.MusAramaTxt.MaxLength = 50;
            this.MusAramaTxt.Multiline = true;
            this.MusAramaTxt.Name = "MusAramaTxt";
            this.MusAramaTxt.Size = new System.Drawing.Size(485, 39);
            this.MusAramaTxt.TabIndex = 8;
            // 
            // BtnMusAra
            // 
            this.BtnMusAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnMusAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMusAra.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnMusAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMusAra.Location = new System.Drawing.Point(840, 25);
            this.BtnMusAra.Margin = new System.Windows.Forms.Padding(30);
            this.BtnMusAra.Name = "BtnMusAra";
            this.BtnMusAra.Size = new System.Drawing.Size(100, 61);
            this.BtnMusAra.TabIndex = 9;
            this.BtnMusAra.Text = "Ara";
            this.BtnMusAra.UseVisualStyleBackColor = false;
            this.BtnMusAra.Click += new System.EventHandler(this.BtnMusAra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.MusTelefonTxt);
            this.groupBox2.Controls.Add(this.MusSehirTxt);
            this.groupBox2.Controls.Add(this.MusSoyadTxt);
            this.groupBox2.Controls.Add(this.MusAdTxt);
            this.groupBox2.Controls.Add(this.MusIdTxt);
            this.groupBox2.Controls.Add(this.BtnMusGuncl);
            this.groupBox2.Controls.Add(this.BtnMusSıl);
            this.groupBox2.Controls.Add(this.BtnMusKydt);
            this.groupBox2.Controls.Add(this.BtnUrunLıst);
            this.groupBox2.Location = new System.Drawing.Point(985, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 629);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // MusTelefonTxt
            // 
            this.MusTelefonTxt.BackColor = System.Drawing.Color.White;
            this.MusTelefonTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusTelefonTxt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusTelefonTxt.Location = new System.Drawing.Point(108, 284);
            this.MusTelefonTxt.MaxLength = 11;
            this.MusTelefonTxt.Multiline = true;
            this.MusTelefonTxt.Name = "MusTelefonTxt";
            this.MusTelefonTxt.Size = new System.Drawing.Size(130, 32);
            this.MusTelefonTxt.TabIndex = 8;
            // 
            // MusSehirTxt
            // 
            this.MusSehirTxt.BackColor = System.Drawing.Color.White;
            this.MusSehirTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusSehirTxt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusSehirTxt.Location = new System.Drawing.Point(108, 222);
            this.MusSehirTxt.MaxLength = 20;
            this.MusSehirTxt.Multiline = true;
            this.MusSehirTxt.Name = "MusSehirTxt";
            this.MusSehirTxt.Size = new System.Drawing.Size(130, 32);
            this.MusSehirTxt.TabIndex = 3;
            // 
            // MusSoyadTxt
            // 
            this.MusSoyadTxt.BackColor = System.Drawing.Color.White;
            this.MusSoyadTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusSoyadTxt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusSoyadTxt.Location = new System.Drawing.Point(108, 163);
            this.MusSoyadTxt.MaxLength = 50;
            this.MusSoyadTxt.Multiline = true;
            this.MusSoyadTxt.Name = "MusSoyadTxt";
            this.MusSoyadTxt.Size = new System.Drawing.Size(130, 32);
            this.MusSoyadTxt.TabIndex = 2;
            // 
            // MusAdTxt
            // 
            this.MusAdTxt.BackColor = System.Drawing.Color.White;
            this.MusAdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusAdTxt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdTxt.Location = new System.Drawing.Point(108, 102);
            this.MusAdTxt.MaxLength = 50;
            this.MusAdTxt.Multiline = true;
            this.MusAdTxt.Name = "MusAdTxt";
            this.MusAdTxt.Size = new System.Drawing.Size(130, 32);
            this.MusAdTxt.TabIndex = 1;
            // 
            // MusIdTxt
            // 
            this.MusIdTxt.BackColor = System.Drawing.Color.White;
            this.MusIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusIdTxt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusIdTxt.Location = new System.Drawing.Point(108, 44);
            this.MusIdTxt.MaxLength = 50;
            this.MusIdTxt.Multiline = true;
            this.MusIdTxt.Name = "MusIdTxt";
            this.MusIdTxt.Size = new System.Drawing.Size(130, 32);
            this.MusIdTxt.TabIndex = 0;
            // 
            // BtnMusGuncl
            // 
            this.BtnMusGuncl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnMusGuncl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMusGuncl.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnMusGuncl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMusGuncl.Location = new System.Drawing.Point(65, 551);
            this.BtnMusGuncl.Margin = new System.Windows.Forms.Padding(30);
            this.BtnMusGuncl.Name = "BtnMusGuncl";
            this.BtnMusGuncl.Size = new System.Drawing.Size(154, 64);
            this.BtnMusGuncl.TabIndex = 7;
            this.BtnMusGuncl.Text = "Güncelle";
            this.BtnMusGuncl.UseVisualStyleBackColor = false;
            this.BtnMusGuncl.Click += new System.EventHandler(this.BtnMusGuncl_Click);
            // 
            // BtnMusSıl
            // 
            this.BtnMusSıl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnMusSıl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMusSıl.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnMusSıl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMusSıl.Location = new System.Drawing.Point(65, 479);
            this.BtnMusSıl.Margin = new System.Windows.Forms.Padding(30);
            this.BtnMusSıl.Name = "BtnMusSıl";
            this.BtnMusSıl.Size = new System.Drawing.Size(154, 64);
            this.BtnMusSıl.TabIndex = 6;
            this.BtnMusSıl.Text = "Sil";
            this.BtnMusSıl.UseVisualStyleBackColor = false;
            this.BtnMusSıl.Click += new System.EventHandler(this.BtnMusSıl_Click);
            // 
            // BtnMusKydt
            // 
            this.BtnMusKydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnMusKydt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMusKydt.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnMusKydt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMusKydt.Location = new System.Drawing.Point(65, 406);
            this.BtnMusKydt.Margin = new System.Windows.Forms.Padding(30);
            this.BtnMusKydt.Name = "BtnMusKydt";
            this.BtnMusKydt.Size = new System.Drawing.Size(154, 64);
            this.BtnMusKydt.TabIndex = 5;
            this.BtnMusKydt.Text = "Kaydet";
            this.BtnMusKydt.UseVisualStyleBackColor = false;
            this.BtnMusKydt.Click += new System.EventHandler(this.BtnMusKydt_Click);
            // 
            // BtnUrunLıst
            // 
            this.BtnUrunLıst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnUrunLıst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunLıst.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnUrunLıst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUrunLıst.Location = new System.Drawing.Point(65, 335);
            this.BtnUrunLıst.Margin = new System.Windows.Forms.Padding(30);
            this.BtnUrunLıst.Name = "BtnUrunLıst";
            this.BtnUrunLıst.Size = new System.Drawing.Size(154, 64);
            this.BtnUrunLıst.TabIndex = 4;
            this.BtnUrunLıst.Text = "Listele";
            this.BtnUrunLıst.UseVisualStyleBackColor = false;
            this.BtnUrunLıst.Click += new System.EventHandler(this.BtnUrunLıst_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGeri.BackgroundImage = global::Urun_Takip.Properties.Resources.geriButon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGeri.Location = new System.Drawing.Point(1186, 1);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(64, 57);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Selam";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "?";
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Urun_Takip.Properties.Resources.arkaplanmusteri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUrunLıst;
        private System.Windows.Forms.Button BtnMusKydt;
        private System.Windows.Forms.Button BtnMusSıl;
        private System.Windows.Forms.Button BtnMusAra;
        private System.Windows.Forms.Button BtnMusGuncl;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox MusSehirTxt;
        private System.Windows.Forms.TextBox MusSoyadTxt;
        private System.Windows.Forms.TextBox MusAdTxt;
        private System.Windows.Forms.TextBox MusIdTxt;
        private System.Windows.Forms.TextBox MusAramaTxt;
        private System.Windows.Forms.RadioButton radioButtonSehir;
        private System.Windows.Forms.RadioButton radioButtonSoyad;
        private System.Windows.Forms.RadioButton radioButtonAd;
        private System.Windows.Forms.TextBox MusTelefonTxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}