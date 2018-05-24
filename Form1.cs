using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum_Table
{
    public partial class FormBaslangic : Form
    {
        
        public FormBaslangic()
        {
               
            InitializeComponent();
           
        }

     
         private void FormScrumTable_Load(object sender, EventArgs e)
        {
           
            
        }

        private void storyEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Story_Ekle se = new Story_Ekle();
            se.MdiParent = this;
            se.Show();

        }

        private void taskEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskEkle te = new TaskEkle();
            te.MdiParent = this;
            te.Show();
        }

        private void kişiTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisi_Takip kt = new Kisi_Takip();
            kt.MdiParent = this;
            kt.Show();
        }

        private void sprintGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma_Plan fp = new Firma_Plan();
            fp.MdiParent = this;
            fp.Show();
        }

        private void baslangıçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
