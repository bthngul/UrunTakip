namespace Urun_Takip
{
    partial class frmUrun
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
            this.UrunIdTxt = new System.Windows.Forms.TextBox();
            this.UrunAdıTxt = new System.Windows.Forms.TextBox();
            this.UrunAlsTxt = new System.Windows.Forms.TextBox();
            this.UrunStsTxt = new System.Windows.Forms.TextBox();
            this.BtnUrunKydt = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUrunLıst = new System.Windows.Forms.Button();
            this.BtnUrunGuncl = new System.Windows.Forms.Button();
            this.BtnUrunSıl = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunIdTxt
            // 
            this.UrunIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UrunIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrunIdTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIdTxt.Location = new System.Drawing.Point(1083, 106);
            this.UrunIdTxt.Multiline = true;
            this.UrunIdTxt.Name = "UrunIdTxt";
            this.UrunIdTxt.Size = new System.Drawing.Size(160, 31);
            this.UrunIdTxt.TabIndex = 0;
            // 
            // UrunAdıTxt
            // 
            this.UrunAdıTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UrunAdıTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrunAdıTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunAdıTxt.Location = new System.Drawing.Point(1083, 165);
            this.UrunAdıTxt.Multiline = true;
            this.UrunAdıTxt.Name = "UrunAdıTxt";
            this.UrunAdıTxt.Size = new System.Drawing.Size(160, 31);
            this.UrunAdıTxt.TabIndex = 1;
            // 
            // UrunAlsTxt
            // 
            this.UrunAlsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UrunAlsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrunAlsTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAlsTxt.Location = new System.Drawing.Point(1083, 284);
            this.UrunAlsTxt.Multiline = true;
            this.UrunAlsTxt.Name = "UrunAlsTxt";
            this.UrunAlsTxt.Size = new System.Drawing.Size(160, 31);
            this.UrunAlsTxt.TabIndex = 3;
            // 
            // UrunStsTxt
            // 
            this.UrunStsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UrunStsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrunStsTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunStsTxt.Location = new System.Drawing.Point(1083, 341);
            this.UrunStsTxt.Multiline = true;
            this.UrunStsTxt.Name = "UrunStsTxt";
            this.UrunStsTxt.Size = new System.Drawing.Size(160, 31);
            this.UrunStsTxt.TabIndex = 4;
            // 
            // BtnUrunKydt
            // 
            this.BtnUrunKydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnUrunKydt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunKydt.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnUrunKydt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUrunKydt.Location = new System.Drawing.Point(1100, 500);
            this.BtnUrunKydt.Margin = new System.Windows.Forms.Padding(30);
            this.BtnUrunKydt.Name = "BtnUrunKydt";
            this.BtnUrunKydt.Size = new System.Drawing.Size(154, 64);
            this.BtnUrunKydt.TabIndex = 7;
            this.BtnUrunKydt.Text = "Kaydet";
            this.BtnUrunKydt.UseVisualStyleBackColor = false;
            this.BtnUrunKydt.Click += new System.EventHandler(this.BtnUrunKydt_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGeri.BackgroundImage = global::Urun_Takip.Properties.Resources.geriButon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGeri.Location = new System.Drawing.Point(1167, 8);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(87, 77);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 701);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnUrunLıst
            // 
            this.BtnUrunLıst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnUrunLıst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunLıst.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnUrunLıst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUrunLıst.Location = new System.Drawing.Point(939, 500);
            this.BtnUrunLıst.Margin = new System.Windows.Forms.Padding(30);
            this.BtnUrunLıst.Name = "BtnUrunLıst";
            this.BtnUrunLıst.Size = new System.Drawing.Size(154, 64);
            this.BtnUrunLıst.TabIndex = 6;
            this.BtnUrunLıst.Text = "Listele";
            this.BtnUrunLıst.UseVisualStyleBackColor = false;
            this.BtnUrunLıst.Click += new System.EventHandler(this.BtnUrunLıst_Click);
            // 
            // BtnUrunGuncl
            // 
            this.BtnUrunGuncl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnUrunGuncl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunGuncl.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnUrunGuncl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUrunGuncl.Location = new System.Drawing.Point(1100, 582);
            this.BtnUrunGuncl.Margin = new System.Windows.Forms.Padding(30);
            this.BtnUrunGuncl.Name = "BtnUrunGuncl";
            this.BtnUrunGuncl.Size = new System.Drawing.Size(154, 64);
            this.BtnUrunGuncl.TabIndex = 9;
            this.BtnUrunGuncl.Text = "Güncelle";
            this.BtnUrunGuncl.UseVisualStyleBackColor = false;
            this.BtnUrunGuncl.Click += new System.EventHandler(this.BtnUrunGuncl_Click);
            // 
            // BtnUrunSıl
            // 
            this.BtnUrunSıl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnUrunSıl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUrunSıl.Font = new System.Drawing.Font("Tahoma", 18F);
            this.BtnUrunSıl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUrunSıl.Location = new System.Drawing.Point(939, 582);
            this.BtnUrunSıl.Margin = new System.Windows.Forms.Padding(30);
            this.BtnUrunSıl.Name = "BtnUrunSıl";
            this.BtnUrunSıl.Size = new System.Drawing.Size(154, 64);
            this.BtnUrunSıl.TabIndex = 8;
            this.BtnUrunSıl.Text = "Sil";
            this.BtnUrunSıl.UseVisualStyleBackColor = false;
            this.BtnUrunSıl.Click += new System.EventHandler(this.BtnUrunSıl_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(1083, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.numericUpDown1.Location = new System.Drawing.Point(1083, 227);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImage = global::Urun_Takip.Properties.Resources.UrunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnUrunSıl);
            this.Controls.Add(this.BtnUrunGuncl);
            this.Controls.Add(this.BtnUrunLıst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.BtnUrunKydt);
            this.Controls.Add(this.UrunStsTxt);
            this.Controls.Add(this.UrunAlsTxt);
            this.Controls.Add(this.UrunAdıTxt);
            this.Controls.Add(this.UrunIdTxt);
            this.MaximizeBox = false;
            this.Name = "frmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URUNLER";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrunIdTxt;
        private System.Windows.Forms.TextBox UrunAdıTxt;
        private System.Windows.Forms.TextBox UrunAlsTxt;
        private System.Windows.Forms.TextBox UrunStsTxt;
        private System.Windows.Forms.Button BtnUrunKydt;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUrunLıst;
        private System.Windows.Forms.Button BtnUrunGuncl;
        private System.Windows.Forms.Button BtnUrunSıl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}