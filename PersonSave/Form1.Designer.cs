namespace PersonSave
{
    partial class Form1
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
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.btnKisiListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.Location = new System.Drawing.Point(104, 51);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(137, 71);
            this.btnYeniKisi.TabIndex = 0;
            this.btnYeniKisi.Text = "Yeni Kişi";
            this.btnYeniKisi.UseVisualStyleBackColor = true;
            this.btnYeniKisi.Click += new System.EventHandler(this.btnYeniKisi_Click);
            // 
            // btnKisiListele
            // 
            this.btnKisiListele.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKisiListele.Location = new System.Drawing.Point(104, 160);
            this.btnKisiListele.Name = "btnKisiListele";
            this.btnKisiListele.Size = new System.Drawing.Size(137, 71);
            this.btnKisiListele.TabIndex = 1;
            this.btnKisiListele.Text = "Kişi Listele";
            this.btnKisiListele.UseVisualStyleBackColor = false;
            this.btnKisiListele.Click += new System.EventHandler(this.btnKisiListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(104, 261);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(137, 71);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 415);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKisiListele);
            this.Controls.Add(this.btnYeniKisi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.Button btnKisiListele;
        private System.Windows.Forms.Button btnCikis;
    }
}

