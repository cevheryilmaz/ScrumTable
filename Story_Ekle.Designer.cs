namespace Scrum_Table
{
    partial class Story_Ekle
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
            this.txtStoryAra = new System.Windows.Forms.TextBox();
            this.btnStoryGuncelle = new System.Windows.Forms.Button();
            this.btnStorySil = new System.Windows.Forms.Button();
            this.txtStoryTarih = new System.Windows.Forms.TextBox();
            this.dgvStoryEkle = new System.Windows.Forms.DataGridView();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.txtStoryMetni = new System.Windows.Forms.TextBox();
            this.txtStoryKullanici = new System.Windows.Forms.TextBox();
            this.txtStoryBaslik = new System.Windows.Forms.TextBox();
            this.txtStorykey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoryEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStoryAra
            // 
            this.txtStoryAra.Location = new System.Drawing.Point(423, 207);
            this.txtStoryAra.Multiline = true;
            this.txtStoryAra.Name = "txtStoryAra";
            this.txtStoryAra.Size = new System.Drawing.Size(264, 26);
            this.txtStoryAra.TabIndex = 30;
            this.txtStoryAra.TextChanged += new System.EventHandler(this.txtStoryAra_TextChanged);
            // 
            // btnStoryGuncelle
            // 
            this.btnStoryGuncelle.BackColor = System.Drawing.Color.Khaki;
            this.btnStoryGuncelle.Location = new System.Drawing.Point(438, 366);
            this.btnStoryGuncelle.Name = "btnStoryGuncelle";
            this.btnStoryGuncelle.Size = new System.Drawing.Size(252, 23);
            this.btnStoryGuncelle.TabIndex = 29;
            this.btnStoryGuncelle.Text = "GÜNCELLE";
            this.btnStoryGuncelle.UseVisualStyleBackColor = false;
            this.btnStoryGuncelle.Click += new System.EventHandler(this.btnStoryGuncelle_Click);
            // 
            // btnStorySil
            // 
            this.btnStorySil.BackColor = System.Drawing.Color.Khaki;
            this.btnStorySil.Location = new System.Drawing.Point(65, 377);
            this.btnStorySil.Name = "btnStorySil";
            this.btnStorySil.Size = new System.Drawing.Size(251, 23);
            this.btnStorySil.TabIndex = 28;
            this.btnStorySil.Text = "SİL";
            this.btnStorySil.UseVisualStyleBackColor = false;
            this.btnStorySil.Click += new System.EventHandler(this.btnStorySil_Click);
            // 
            // txtStoryTarih
            // 
            this.txtStoryTarih.Location = new System.Drawing.Point(159, 100);
            this.txtStoryTarih.Name = "txtStoryTarih";
            this.txtStoryTarih.Size = new System.Drawing.Size(119, 20);
            this.txtStoryTarih.TabIndex = 27;
            // 
            // dgvStoryEkle
            // 
            this.dgvStoryEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoryEkle.Location = new System.Drawing.Point(65, 239);
            this.dgvStoryEkle.Name = "dgvStoryEkle";
            this.dgvStoryEkle.Size = new System.Drawing.Size(625, 121);
            this.dgvStoryEkle.TabIndex = 26;
            this.dgvStoryEkle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoryEkle_CellClick);
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnStoryEkle.Location = new System.Drawing.Point(159, 175);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(119, 23);
            this.btnStoryEkle.TabIndex = 25;
            this.btnStoryEkle.Text = "EKLE";
            this.btnStoryEkle.UseVisualStyleBackColor = false;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtStoryMetni
            // 
            this.txtStoryMetni.Location = new System.Drawing.Point(159, 128);
            this.txtStoryMetni.Multiline = true;
            this.txtStoryMetni.Name = "txtStoryMetni";
            this.txtStoryMetni.Size = new System.Drawing.Size(119, 41);
            this.txtStoryMetni.TabIndex = 24;
            // 
            // txtStoryKullanici
            // 
            this.txtStoryKullanici.Location = new System.Drawing.Point(159, 70);
            this.txtStoryKullanici.Name = "txtStoryKullanici";
            this.txtStoryKullanici.Size = new System.Drawing.Size(119, 20);
            this.txtStoryKullanici.TabIndex = 23;
            // 
            // txtStoryBaslik
            // 
            this.txtStoryBaslik.Location = new System.Drawing.Point(159, 39);
            this.txtStoryBaslik.Name = "txtStoryBaslik";
            this.txtStoryBaslik.Size = new System.Drawing.Size(119, 20);
            this.txtStoryBaslik.TabIndex = 22;
            // 
            // txtStorykey
            // 
            this.txtStorykey.Location = new System.Drawing.Point(159, 10);
            this.txtStorykey.Name = "txtStorykey";
            this.txtStorykey.Size = new System.Drawing.Size(119, 20);
            this.txtStorykey.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(72, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Story Metni :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(72, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(72, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kullanıcı Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(72, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Story Başlık :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Story Key :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Location = new System.Drawing.Point(373, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ara  :";
            // 
            // Story_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrum_Table.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(778, 414);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStoryAra);
            this.Controls.Add(this.btnStoryGuncelle);
            this.Controls.Add(this.btnStorySil);
            this.Controls.Add(this.txtStoryTarih);
            this.Controls.Add(this.dgvStoryEkle);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.txtStoryMetni);
            this.Controls.Add(this.txtStoryKullanici);
            this.Controls.Add(this.txtStoryBaslik);
            this.Controls.Add(this.txtStorykey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Story_Ekle";
            this.Text = "Story_Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoryEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStoryAra;
        private System.Windows.Forms.Button btnStoryGuncelle;
        private System.Windows.Forms.Button btnStorySil;
        private System.Windows.Forms.TextBox txtStoryTarih;
        private System.Windows.Forms.DataGridView dgvStoryEkle;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.TextBox txtStoryMetni;
        private System.Windows.Forms.TextBox txtStoryKullanici;
        private System.Windows.Forms.TextBox txtStoryBaslik;
        private System.Windows.Forms.TextBox txtStorykey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}