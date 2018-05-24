using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum_Table
{
    public partial class Story_Ekle : Form
    {
        SqlCommand kmt = new SqlCommand();
        SqlConnection conn = new SqlConnection("Data Source=CEVHER\\SQLSERVER2017; Initial Catalog=ScrumTable; User Id=sa; password=15710;");
        DataTable tbl = new DataTable();
        public Story_Ekle()
        {
            InitializeComponent();
            DataGridYenile();
        }

        protected void DataGridYenile()
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT story_id,story_key,story_kullanici,story_baslik,story_tarih,story_metni FROM table_EklenenStory", conn);
            adptr.Fill(tbl);
            conn.Close();
            dgvStoryEkle.DataSource = tbl;
            dgvStoryEkle.BackgroundColor = Color.Yellow;
        }
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            if (txtStorykey.Text == "" || txtStoryBaslik.Text == "" || txtStoryKullanici.Text == "" || txtStoryTarih.Text == "" || txtStoryMetni.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("INSERT into table_EklenenStory VALUES  ('" + txtStorykey.Text + "','" + txtStoryBaslik.Text + "','" + txtStoryKullanici.Text + "','" + txtStoryTarih.Text + "','" + txtStoryMetni.Text + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }
        }

        private void btnStorySil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE table_EklenenStory where story_key=@story_key", conn);
            kmt.Parameters.AddWithValue("@story_key", dgvStoryEkle.CurrentRow.Cells[1].Value);
            kmt.ExecuteNonQuery();
            conn.Close();
            DataGridYenile();
        }

        private void btnStoryGuncelle_Click(object sender, EventArgs e)
        {
            if (txtStorykey.Text == "" || txtStoryBaslik.Text == "" || txtStoryKullanici.Text == "" || txtStoryTarih.Text == "" || txtStoryMetni.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE table_EklenenStory set story_key='" + txtStorykey.Text + "',story_baslik='" + txtStoryBaslik.Text + "',story_kullanici='" + txtStoryKullanici.Text + "',story_tarih='" + txtStoryTarih.Text + "',story_metni='" + txtStoryMetni.Text + "' where story_key=" + dgvStoryEkle.CurrentRow.Cells[1].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }
        }

        private void txtStoryAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            dv.RowFilter = "story_key like '%" + txtStoryAra.Text + "%'";
            dgvStoryEkle.DataSource = dv;
        }

        

        private void dgvStoryEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStorykey.Text = dgvStoryEkle.Rows[dgvStoryEkle.CurrentRow.Index].Cells["story_key"].Value.ToString();
            txtStoryBaslik.Text = dgvStoryEkle.Rows[dgvStoryEkle.CurrentRow.Index].Cells["story_baslik"].Value.ToString();
            txtStoryKullanici.Text = dgvStoryEkle.Rows[dgvStoryEkle.CurrentRow.Index].Cells["story_kullanici"].Value.ToString();
            txtStoryTarih.Text = dgvStoryEkle.Rows[dgvStoryEkle.CurrentRow.Index].Cells["story_tarih"].Value.ToString();
            txtStoryMetni.Text = dgvStoryEkle.Rows[dgvStoryEkle.CurrentRow.Index].Cells["story_metni"].Value.ToString();
        }
    }
}
