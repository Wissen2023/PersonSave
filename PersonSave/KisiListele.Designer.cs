namespace PersonSave
{
    partial class KisiListele
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
            this.dtGridV = new System.Windows.Forms.DataGridView();
            this.btnKisiAktar = new System.Windows.Forms.Button();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtPersonAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonSehir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridV
            // 
            this.dtGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridV.Location = new System.Drawing.Point(29, 30);
            this.dtGridV.Name = "dtGridV";
            this.dtGridV.RowHeadersWidth = 51;
            this.dtGridV.RowTemplate.Height = 24;
            this.dtGridV.Size = new System.Drawing.Size(727, 318);
            this.dtGridV.TabIndex = 0;
            // 
            // btnKisiAktar
            // 
            this.btnKisiAktar.Location = new System.Drawing.Point(29, 418);
            this.btnKisiAktar.Name = "btnKisiAktar";
            this.btnKisiAktar.Size = new System.Drawing.Size(134, 57);
            this.btnKisiAktar.TabIndex = 1;
            this.btnKisiAktar.Text = "Kişi Aktar";
            this.btnKisiAktar.UseVisualStyleBackColor = true;
            this.btnKisiAktar.Click += new System.EventHandler(this.btnKisiAktar_Click);
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(218, 418);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(134, 57);
            this.btnKisiGuncelle.TabIndex = 2;
            this.btnKisiGuncelle.Text = "Kişi Güncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(422, 418);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(134, 57);
            this.btnKisiSil.TabIndex = 3;
            this.btnKisiSil.Text = "Kişi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(622, 418);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 57);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(789, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PersonID:";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(935, 30);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(100, 22);
            this.txtPersonID.TabIndex = 6;
            // 
            // txtPersonAd
            // 
            this.txtPersonAd.Location = new System.Drawing.Point(935, 122);
            this.txtPersonAd.Name = "txtPersonAd";
            this.txtPersonAd.Size = new System.Drawing.Size(100, 22);
            this.txtPersonAd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Person Ad:";
            // 
            // txtPersonSoyad
            // 
            this.txtPersonSoyad.Location = new System.Drawing.Point(935, 210);
            this.txtPersonSoyad.Name = "txtPersonSoyad";
            this.txtPersonSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtPersonSoyad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Person Soyad:";
            // 
            // txtPersonAccount
            // 
            this.txtPersonAccount.Location = new System.Drawing.Point(935, 289);
            this.txtPersonAccount.Name = "txtPersonAccount";
            this.txtPersonAccount.Size = new System.Drawing.Size(100, 22);
            this.txtPersonAccount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Person Account";
            // 
            // txtPersonSehir
            // 
            this.txtPersonSehir.Location = new System.Drawing.Point(935, 375);
            this.txtPersonSehir.Name = "txtPersonSehir";
            this.txtPersonSehir.Size = new System.Drawing.Size(100, 22);
            this.txtPersonSehir.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Person Şehir";
            // 
            // txtPersonTel
            // 
            this.txtPersonTel.Location = new System.Drawing.Point(935, 459);
            this.txtPersonTel.Name = "txtPersonTel";
            this.txtPersonTel.Size = new System.Drawing.Size(100, 22);
            this.txtPersonTel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Person Tel:";
            // 
            // KisiListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 524);
            this.Controls.Add(this.txtPersonTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersonSehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersonAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersonSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKisiSil);
            this.Controls.Add(this.btnKisiGuncelle);
            this.Controls.Add(this.btnKisiAktar);
            this.Controls.Add(this.dtGridV);
            this.Name = "KisiListele";
            this.Text = "KisiListele";
            this.Load += new System.EventHandler(this.KisiListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridV;
        private System.Windows.Forms.Button btnKisiAktar;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.TextBox txtPersonAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonTel;
        private System.Windows.Forms.Label label6;
    }
}