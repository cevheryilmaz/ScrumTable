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
    public partial class TaskEkle : Form
    {
        SqlCommand kmt = new SqlCommand();
        SqlConnection conn = new SqlConnection("Data Source=CEVHER\\SQLSERVER2017; Initial Catalog=ScrumTable; User Id=sa; password=15710;");
        DataTable tbl = new DataTable();
        public TaskEkle()
        {
            InitializeComponent();
            DataGridYenile();
        }

        protected void DataGridYenile()
        {
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("SELECT task_key,task_baslik,task_kullanici,task_tarih,task_tur,task_metni FROM table_EklenenTask", conn);
            adptr.Fill(tbl);
            conn.Close();
            dgvTaskGoster.DataSource = tbl;
            dgvTaskGoster.BackgroundColor = Color.Yellow;
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            if(txtTaskkey.Text=="" || txtTaskBaslik.Text=="" || txtTaskKullanici.Text=="" || txtTaskTarih.Text=="" || cbTaskTur.Text=="" || txtTaskMetni.Text=="")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("INSERT into table_EklenenTask VALUES  ('" + txtTaskkey.Text + "','" + txtTaskBaslik.Text + "','" + txtTaskKullanici.Text + "','" + txtTaskTarih.Text + "','" + cbTaskTur.Text + "','" + txtTaskMetni.Text + "')", conn);
                kmt.ExecuteNonQuery();
                conn.Close();
               
            }
            DataGridYenile();

        }

        private void TaskEkle_Load(object sender, EventArgs e)
        {   cbTaskTur.Items.Add("Not Started");
            cbTaskTur.Items.Add("In Progress");
            cbTaskTur.Items.Add("Done");

        }

        private void btnTaskSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("DELETE table_EklenenTask where task_key=@task_key", conn);
            kmt.Parameters.AddWithValue("@task_key", dgvTaskGoster.CurrentRow.Cells[0].Value);
            kmt.ExecuteNonQuery();
            conn.Close();
            DataGridYenile();
        }

        private void btnTaskGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTaskkey.Text == "" || txtTaskBaslik.Text == "" || txtTaskKullanici.Text == "" || txtTaskTarih.Text == "" || cbTaskTur.Text == "" || txtTaskMetni.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz!!!");
            }
            else
            {
                conn.Open();
                SqlCommand kmt = new SqlCommand("UPDATE table_EklenenTask set task_key='" + txtTaskkey.Text + "',task_baslik='" + txtTaskBaslik.Text + "',task_kullanici='" + txtTaskKullanici.Text + "',task_tarih='" + txtTaskTarih.Text + "',task_tur='" + cbTaskTur.Text + "',task_metni='" + txtTaskMetni.Text + "' where task_key=" + dgvTaskGoster.CurrentRow.Cells[0].Value.ToString(), conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                DataGridYenile();
            }

        }

        
        private void txtTaskAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tbl);
            dv.RowFilter = "task_key like '%" + txtTaskAra.Text + "%'";
            dgvTaskGoster.DataSource = dv;
        }

       

        private void dgvTaskGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaskkey.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_key"].Value.ToString();
            txtTaskBaslik.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_baslik"].Value.ToString();
            txtTaskKullanici.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_kullanici"].Value.ToString();
            txtTaskTarih.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_tarih"].Value.ToString();
            cbTaskTur.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_tur"].Value.ToString();
            txtTaskMetni.Text = dgvTaskGoster.Rows[dgvTaskGoster.CurrentRow.Index].Cells["task_metni"].Value.ToString();
        }
    }
}
