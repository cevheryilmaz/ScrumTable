namespace Scrum_Table
{
    partial class TaskEkle
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
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTaskMetni = new System.Windows.Forms.TextBox();
            this.txtTaskTarih = new System.Windows.Forms.TextBox();
            this.txtTaskKullanici = new System.Windows.Forms.TextBox();
            this.txtTaskBaslik = new System.Windows.Forms.TextBox();
            this.txtTaskkey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaskGuncelle = new System.Windows.Forms.Button();
            this.btnTaskSil = new System.Windows.Forms.Button();
            this.txtTaskAra = new System.Windows.Forms.TextBox();
            this.cbTaskTur = new System.Windows.Forms.ComboBox();
            this.dgvTaskGoster = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnTaskEkle.Location = new System.Drawing.Point(165, 221);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(119, 23);
            this.btnTaskEkle.TabIndex = 21;
            this.btnTaskEkle.Text = "EKLE";
            this.btnTaskEkle.UseVisualStyleBackColor = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTaskMetni
            // 
            this.txtTaskMetni.Location = new System.Drawing.Point(165, 163);
            this.txtTaskMetni.Multiline = true;
            this.txtTaskMetni.Name = "txtTaskMetni";
            this.txtTaskMetni.Size = new System.Drawing.Size(119, 41);
            this.txtTaskMetni.TabIndex = 20;
            // 
            // txtTaskTarih
            // 
            this.txtTaskTarih.Location = new System.Drawing.Point(165, 105);
            this.txtTaskTarih.Name = "txtTaskTarih";
            this.txtTaskTarih.Size = new System.Drawing.Size(119, 20);
            this.txtTaskTarih.TabIndex = 19;
            // 
            // txtTaskKullanici
            // 
            this.txtTaskKullanici.Location = new System.Drawing.Point(165, 78);
            this.txtTaskKullanici.Name = "txtTaskKullanici";
            this.txtTaskKullanici.Size = new System.Drawing.Size(119, 20);
            this.txtTaskKullanici.TabIndex = 18;
            // 
            // txtTaskBaslik
            // 
            this.txtTaskBaslik.Location = new System.Drawing.Point(165, 47);
            this.txtTaskBaslik.Name = "txtTaskBaslik";
            this.txtTaskBaslik.Size = new System.Drawing.Size(119, 20);
            this.txtTaskBaslik.TabIndex = 17;
            // 
            // txtTaskkey
            // 
            this.txtTaskkey.Location = new System.Drawing.Point(165, 18);
            this.txtTaskkey.Name = "txtTaskkey";
            this.txtTaskkey.Size = new System.Drawing.Size(119, 20);
            this.txtTaskkey.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(78, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Task Metni :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(78, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(78, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kullanıcı Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(78, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Task Başlık :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Task Key :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label6.Location = new System.Drawing.Point(78, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Task Tür :";
            // 
            // btnTaskGuncelle
            // 
            this.btnTaskGuncelle.BackColor = System.Drawing.Color.Khaki;
            this.btnTaskGuncelle.Location = new System.Drawing.Point(461, 392);
            this.btnTaskGuncelle.Name = "btnTaskGuncelle";
            this.btnTaskGuncelle.Size = new System.Drawing.Size(252, 23);
            this.btnTaskGuncelle.TabIndex = 27;
            this.btnTaskGuncelle.Text = "GÜNCELLE";
            this.btnTaskGuncelle.UseVisualStyleBackColor = false;
            this.btnTaskGuncelle.Click += new System.EventHandler(this.btnTaskGuncelle_Click);
            // 
            // btnTaskSil
            // 
            this.btnTaskSil.BackColor = System.Drawing.Color.Khaki;
            this.btnTaskSil.Location = new System.Drawing.Point(81, 392);
            this.btnTaskSil.Name = "btnTaskSil";
            this.btnTaskSil.Size = new System.Drawing.Size(251, 23);
            this.btnTaskSil.TabIndex = 26;
            this.btnTaskSil.Text = "SİL";
            this.btnTaskSil.UseVisualStyleBackColor = false;
            this.btnTaskSil.Click += new System.EventHandler(this.btnTaskSil_Click);
            // 
            // txtTaskAra
            // 
            this.txtTaskAra.Location = new System.Drawing.Point(461, 252);
            this.txtTaskAra.Multiline = true;
            this.txtTaskAra.Name = "txtTaskAra";
            this.txtTaskAra.Size = new System.Drawing.Size(252, 26);
            this.txtTaskAra.TabIndex = 28;
            this.txtTaskAra.TextChanged += new System.EventHandler(this.txtTaskAra_TextChanged);
            // 
            // cbTaskTur
            // 
            this.cbTaskTur.FormattingEnabled = true;
            this.cbTaskTur.Location = new System.Drawing.Point(165, 136);
            this.cbTaskTur.Name = "cbTaskTur";
            this.cbTaskTur.Size = new System.Drawing.Size(119, 21);
            this.cbTaskTur.TabIndex = 29;
            // 
            // dgvTaskGoster
            // 
            this.dgvTaskGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskGoster.Location = new System.Drawing.Point(81, 284);
            this.dgvTaskGoster.Name = "dgvTaskGoster";
            this.dgvTaskGoster.Size = new System.Drawing.Size(632, 102);
            this.dgvTaskGoster.TabIndex = 30;
            this.dgvTaskGoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskGoster_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label7.Location = new System.Drawing.Point(412, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ara  :";
            // 
            // TaskEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scrum_Table.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(832, 441);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTaskGoster);
            this.Controls.Add(this.cbTaskTur);
            this.Controls.Add(this.txtTaskAra);
            this.Controls.Add(this.btnTaskGuncelle);
            this.Controls.Add(this.btnTaskSil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.txtTaskMetni);
            this.Controls.Add(this.txtTaskTarih);
            this.Controls.Add(this.txtTaskKullanici);
            this.Controls.Add(this.txtTaskBaslik);
            this.Controls.Add(this.txtTaskkey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskEkle";
            this.Text = "Task Ekle";
            this.Load += new System.EventHandler(this.TaskEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtTaskMetni;
        private System.Windows.Forms.TextBox txtTaskTarih;
        private System.Windows.Forms.TextBox txtTaskKullanici;
        private System.Windows.Forms.TextBox txtTaskBaslik;
        private System.Windows.Forms.TextBox txtTaskkey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTaskGuncelle;
        private System.Windows.Forms.Button btnTaskSil;
        private System.Windows.Forms.TextBox txtTaskAra;
        private System.Windows.Forms.ComboBox cbTaskTur;
        private System.Windows.Forms.DataGridView dgvTaskGoster;
        private System.Windows.Forms.Label label7;
    }
}