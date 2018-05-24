namespace Scrum_Table
{
    partial class FormBaslangic
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baslangıcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baslangıcToolStripMenuItem,
            this.storyEkleToolStripMenuItem,
            this.taskEkleToolStripMenuItem,
            this.kişiTakipToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baslangıcToolStripMenuItem
            // 
            this.baslangıcToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.baslangıcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprintGörüntüleToolStripMenuItem});
            this.baslangıcToolStripMenuItem.Name = "baslangıcToolStripMenuItem";
            this.baslangıcToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.baslangıcToolStripMenuItem.Text = "Başlangıç";
            this.baslangıcToolStripMenuItem.Click += new System.EventHandler(this.baslangıçToolStripMenuItem_Click);
            // 
            // sprintGörüntüleToolStripMenuItem
            // 
            this.sprintGörüntüleToolStripMenuItem.Name = "sprintGörüntüleToolStripMenuItem";
            this.sprintGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sprintGörüntüleToolStripMenuItem.Text = "Firma Plan";
            this.sprintGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.sprintGörüntüleToolStripMenuItem_Click);
            // 
            // storyEkleToolStripMenuItem
            // 
            this.storyEkleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.storyEkleToolStripMenuItem.Name = "storyEkleToolStripMenuItem";
            this.storyEkleToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.storyEkleToolStripMenuItem.Text = "Story Ekle";
            this.storyEkleToolStripMenuItem.Click += new System.EventHandler(this.storyEkleToolStripMenuItem_Click);
            // 
            // taskEkleToolStripMenuItem
            // 
            this.taskEkleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.taskEkleToolStripMenuItem.Name = "taskEkleToolStripMenuItem";
            this.taskEkleToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.taskEkleToolStripMenuItem.Text = "Task Ekle";
            this.taskEkleToolStripMenuItem.Click += new System.EventHandler(this.taskEkleToolStripMenuItem_Click);
            // 
            // kişiTakipToolStripMenuItem
            // 
            this.kişiTakipToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.kişiTakipToolStripMenuItem.Name = "kişiTakipToolStripMenuItem";
            this.kişiTakipToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.kişiTakipToolStripMenuItem.Text = "Kişi Takip";
            this.kişiTakipToolStripMenuItem.Click += new System.EventHandler(this.kişiTakipToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem,
            this.yardımToolStripMenuItem1});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.yardımToolStripMenuItem.Text = "Sık Sorulan Sorular";
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.yardımToolStripMenuItem1.Text = "Yardım";
            // 
            // FormBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Scrum_Table.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(1142, 505);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBaslangic";
            this.Text = "SCRUM TABLE";
            this.Load += new System.EventHandler(this.FormScrumTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baslangıcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storyEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
    }
}

