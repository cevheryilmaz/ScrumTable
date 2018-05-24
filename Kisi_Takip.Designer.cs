namespace Scrum_Table
{
    partial class Kisi_Takip
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
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.txtKisiAra = new System.Windows.Forms.TextBox();
            this.dgvKisiTakip = new System.Windows.Forms.DataGridView();
            this.btnKisiTakip = new System.Windows.Forms.Button();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.txtKisiKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.BackColor = System.Drawing.Color.Khaki;
            this.btnKisiGuncelle.Location = new System.Drawing.Point(372, 316);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(132, 23);
            this.btnKisiGuncelle.TabIndex = 21;
            this.btnKisiGuncelle.Text = "GÜNCELLE";
            this.btnKisiGuncelle.UseVisualStyleBackColor = false;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.BackColor = System.Drawing.Color.Khaki;
            this.btnKisiSil.Location = new System.Drawing.Point(60, 316);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(123, 23);
            this.btnKisiSil.TabIndex = 20;
            this.btnKisiSil.Text = "SİL";
            this.btnKisiSil.UseVisualStyleBackColor = false;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // txtKisiAra
            // 
            this.txtKisiAra.Location = new System.Drawing.Point(372, 182);
            this.txtKisiAra.Multiline = true;
            this.txtKisiAra.Name = "txtKisiAra";
            this.txtKisiAra.Size = new System.Drawing.Size(132, 21);
            this.txtKisiAra.TabIndex = 19;
            this.txtKisiAra.TextChanged += new System.EventHandler(this.txtKisiAra_TextChanged);
            // 
            // dgvKisiTakip
            // 
            this.dgvKisiTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiTakip.Location = new System.Drawing.Point(60, 212);
            this.dgvKisiTakip.Name = "dgvKisiTakip";
            this.dgvKisiTakip.Size = new System.Drawing.Size(444, 98);
            this.dgvKisiTakip.TabIndex = 18;
            this.dgvKisiTakip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKisiTakip_CellClick);
            // 
            // btnKisiTakip
            // 
            this.btnKisiTakip.BackColor = System.Drawing.Color.Khaki;
            this.btnKisiTakip.Location = new System.Drawing.Point(188, 124);
            this.btnKisiTakip.Name = "btnKisiTakip";
            this.btnKisiTakip.Size = new System.Drawing.Size(123, 28);
            this.btnKisiTakip.TabIndex = 17;
            this.btnKisiTakip.Text = "EKLE";
            this.btnKisiTakip.UseVisualStyleBackColor = false;
            this.btnKisiTakip.Click += new System.EventHandler(this.btnKisiTakip_Click);
            // 
            // cbBolum
            // 
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Location = new System.Drawing.Point(188, 97);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(123, 21);
            this.cbBolum.TabIndex = 16;
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(188, 66);
            this.txtKisiAd.Multiline = true;
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(123, 21);
            this.txtKisiAd.TabIndex = 15;
            // 
            // txtKisiKey
            // 
            this.txtKisiKey.Location = new System.Drawing.Point(188, 37);
            this.txtKisiKey.Multiline = true;
            this.txtKisiKey.Name = "txtKisiKey";
            this.txtKisiKey.Size = new System.Drawing.Size(123, 21);
            this.txtKisiKey.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yer alınan Bölüm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Key :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(334, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ara  :";
            // 
            // Kisi_Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrum_Table.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(645, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKisiGuncelle);
            this.Controls.Add(this.btnKisiSil);
            this.Controls.Add(this.txtKisiAra);
            this.Controls.Add(this.dgvKisiTakip);
            this.Controls.Add(this.btnKisiTakip);
            this.Controls.Add(this.cbBolum);
            this.Controls.Add(this.txtKisiAd);
            this.Controls.Add(this.txtKisiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kisi_Takip";
            this.Text = "Kisi_Takip";
            this.Load += new System.EventHandler(this.Kisi_Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiTakip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.TextBox txtKisiAra;
        private System.Windows.Forms.DataGridView dgvKisiTakip;
        private System.Windows.Forms.Button btnKisiTakip;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.TextBox txtKisiKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}