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
    public partial class Kisi_Takip : Form
    {
        SqlCommand kmt = new SqlCommand();
        SqlConnection conn = new SqlConnection("Data Source=CEVHER\\SQLSERVER2017; Initial Catalog=ScrumTable; User Id=sa; password=15710;");
        DataTable tbl = new DataTable();
        public Kisi_Takip()
        {
            InitializeComponent();
            DataGridYenile();
        }

        protected void DataGridYenile()
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT kisi_id,kisi_key,kisi_ad,kisi_bolum FROM table_KisiTakip", conn);
            adptr.Fill(tbl);
            conn.Close();
            dgvKisiTakip.DataSource = tbl;
            dgvKisiTakip.BackgroundColor = Color.Yellow;
        }
        private void btnKisiTakip_Click(object sender, EventArgs e)
        {
            if (txtKisiKey.Text == "" || txtKisiAd.Text == "" || cbBolum.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("INSERT into table_KisiTakip VALUES  ('" + txtKisiKey.Text + "','" + txtKisiAd.Text + "','" + cbBolum.Text + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }

        }

        private void Kisi_Takip_Load(object sender, EventArgs e)
        {
            cbBolum.Items.Add("Story");
            cbBolum.Items.Add("Not Started");
            cbBolum.Items.Add("In Progress");
            cbBolum.Items.Add("Done");
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE table_KisiTakip where kisi_key=@kisi_key", conn);
            kmt.Parameters.AddWithValue("@kisi_key", dgvKisiTakip.CurrentRow.Cells[1].Value);
            kmt.ExecuteNonQuery();
            conn.Close();
            DataGridYenile();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {

            if (txtKisiKey.Text == "" || txtKisiAd.Text == "" || cbBolum.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE table_KisiTakip set kisi_key='" + txtKisiKey.Text + "',kisi_ad='" + txtKisiAd.Text + "',kisi_bolum='" + cbBolum.Text + "' where kisi_id=" + dgvKisiTakip.CurrentRow.Cells["kisi_id"].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }
        }

        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            dv.RowFilter = "kisi_ad like '%" + txtKisiAra.Text + "%'";
            dgvKisiTakip.DataSource = dv;
        }

        private void dgvKisiTakip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKisiKey.Text = dgvKisiTakip.Rows[dgvKisiTakip.CurrentRow.Index].Cells["kisi_key"].Value.ToString();
            txtKisiAd.Text = dgvKisiTakip.Rows[dgvKisiTakip.CurrentRow.Index].Cells["kisi_ad"].Value.ToString();
            cbBolum.Text = dgvKisiTakip.Rows[dgvKisiTakip.CurrentRow.Index].Cells["kisi_bolum"].Value.ToString();
        }
    }
}
