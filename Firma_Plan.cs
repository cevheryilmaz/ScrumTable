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
    
    public partial class Firma_Plan : Form
    {
        SqlCommand kmt = new SqlCommand();
        SqlConnection conn = new SqlConnection("Data Source=CEVHER\\SQLSERVER2017; Initial Catalog=ScrumTable; User Id=sa; password=15710;");
        DataTable tbl = new DataTable();
        public Firma_Plan()
        {
            InitializeComponent();
            DataGridYenile();
        }

        protected void DataGridYenile()
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT firma_id,firma_isim,firma_calisan,firma_Scrum,firma_tarih,firma_hedef FROM table_EklenenFirma", conn);
            adptr.Fill(tbl);
            conn.Close();
            dgvFirmaBilgi.DataSource = tbl;
            dgvFirmaBilgi.BackgroundColor = Color.Yellow;
        }


        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            if (txtFirmaAd.Text == "" || txtFirmaCalisan.Text == "" || txtOlusanScrum.Text == "" || txtFirmaTarih.Text == "" || txtFirmaHedef.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("INSERT into table_EklenenFirma VALUES  ('" + txtFirmaAd.Text + "','" + txtFirmaCalisan.Text + "','" + txtOlusanScrum.Text + "','" + txtFirmaTarih.Text + "','" + txtFirmaHedef.Text + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }

        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE table_EklenenFirma where firma_id=@firma_id", conn);
            kmt.Parameters.AddWithValue("@firma_id", dgvFirmaBilgi.CurrentRow.Cells[0].Value);
            kmt.ExecuteNonQuery();
            conn.Close();
            DataGridYenile();
        }

        private void btnFİrmaGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFirmaAd.Text == "" || txtFirmaCalisan.Text == "" || txtOlusanScrum.Text == "" || txtFirmaTarih.Text == "" || txtFirmaHedef.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE table_EklenenFirma set firma_isim='" + txtFirmaAd.Text + "',firma_calisan='" + txtFirmaCalisan.Text + "',firma_Scrum='" + txtOlusanScrum.Text + "',firma_tarih='" + txtFirmaTarih.Text + "',firma_hedef='" + txtFirmaHedef.Text + "' where firma_id=" + dgvFirmaBilgi.CurrentRow.Cells[0].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            dv.RowFilter = "firma_isim like '%" + txtFirmaAra.Text + "%'";
            dgvFirmaBilgi.DataSource = dv;
        }

        private void dgvFirmaBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirmaAd.Text = dgvFirmaBilgi.Rows[dgvFirmaBilgi.CurrentRow.Index].Cells["firma_isim"].Value.ToString();
            txtFirmaCalisan.Text = dgvFirmaBilgi.Rows[dgvFirmaBilgi.CurrentRow.Index].Cells["firma_calisan"].Value.ToString();
            txtOlusanScrum.Text = dgvFirmaBilgi.Rows[dgvFirmaBilgi.CurrentRow.Index].Cells["firma_Scrum"].Value.ToString();
            txtFirmaTarih.Text = dgvFirmaBilgi.Rows[dgvFirmaBilgi.CurrentRow.Index].Cells["firma_tarih"].Value.ToString();
            txtFirmaHedef.Text = dgvFirmaBilgi.Rows[dgvFirmaBilgi.CurrentRow.Index].Cells["firma_hedef"].Value.ToString();
        }
    }
}
