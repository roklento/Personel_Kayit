namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.LblKullaniciAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKullaniciAd
            // 
            this.LblKullaniciAd.AutoSize = true;
            this.LblKullaniciAd.Location = new System.Drawing.Point(33, 105);
            this.LblKullaniciAd.Name = "LblKullaniciAd";
            this.LblKullaniciAd.Size = new System.Drawing.Size(95, 19);
            this.LblKullaniciAd.TabIndex = 0;
            this.LblKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Informal Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli ";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(156, 105);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(153, 27);
            this.TxtKullaniciAd.TabIndex = 3;
            // 
            // Txtsifre
            // 
            this.Txtsifre.Location = new System.Drawing.Point(156, 150);
            this.Txtsifre.Name = "Txtsifre";
            this.Txtsifre.Size = new System.Drawing.Size(153, 27);
            this.Txtsifre.TabIndex = 4;
            this.Txtsifre.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(156, 195);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(153, 28);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(451, 343);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.Txtsifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblKullaniciAd);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.Button BtnGiris;
    }
}