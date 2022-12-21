namespace Urun_Takip
{
    partial class FrmGırıs
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
            this.TxtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.BtnGırıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtKullanıcıAd
            // 
            this.TxtKullanıcıAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKullanıcıAd.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanıcıAd.Location = new System.Drawing.Point(520, 267);
            this.TxtKullanıcıAd.MaxLength = 50;
            this.TxtKullanıcıAd.Multiline = true;
            this.TxtKullanıcıAd.Name = "TxtKullanıcıAd";
            this.TxtKullanıcıAd.Size = new System.Drawing.Size(264, 36);
            this.TxtKullanıcıAd.TabIndex = 0;
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.AcceptsTab = true;
            this.TxtSıfre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSıfre.Location = new System.Drawing.Point(520, 343);
            this.TxtSıfre.MaxLength = 10;
            this.TxtSıfre.Multiline = true;
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.PasswordChar = '•';
            this.TxtSıfre.Size = new System.Drawing.Size(264, 36);
            this.TxtSıfre.TabIndex = 1;
            // 
            // BtnGırıs
            // 
            this.BtnGırıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnGırıs.BackgroundImage = global::Urun_Takip.Properties.Resources.Buton;
            this.BtnGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGırıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGırıs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGırıs.FlatAppearance.BorderSize = 0;
            this.BtnGırıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGırıs.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGırıs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGırıs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGırıs.Location = new System.Drawing.Point(549, 434);
            this.BtnGırıs.Margin = new System.Windows.Forms.Padding(30);
            this.BtnGırıs.Name = "BtnGırıs";
            this.BtnGırıs.Size = new System.Drawing.Size(154, 64);
            this.BtnGırıs.TabIndex = 2;
            this.BtnGırıs.Text = "GİRİŞ YAP";
            this.BtnGırıs.UseVisualStyleBackColor = false;
            this.BtnGırıs.Click += new System.EventHandler(this.BtnGırıs_Click);
            // 
            // FrmGırıs
            // 
            this.AcceptButton = this.BtnGırıs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Urun_Takip.Properties.Resources.LoginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.BtnGırıs);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.TxtKullanıcıAd);
            this.MaximizeBox = false;
            this.Name = "FrmGırıs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmGırıs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKullanıcıAd;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Button BtnGırıs;
    }
}