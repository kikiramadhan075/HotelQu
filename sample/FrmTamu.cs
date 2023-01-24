/*
 * Created by Muhammad Subhan Mahendrasyah.
 * User: Mahendrasyah
 * Date: 22/01/2023
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sample
{
    public partial class FrmTamu : Form
    {
        DataGridViewButtonColumn CekOut;
        DataGridViewButtonColumn EditTamu;
        DataGridViewButtonColumn DeleteTamu;
        public FrmTamu()
        {
            InitializeComponent();
        }

        private void pnlTamu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTamu_Click(object sender, EventArgs e)
        {
            FrmTambahTamu tambahTamu = new FrmTambahTamu();
            tambahTamu.ShowDialog();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefreshTamu_Click(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiQ = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_tamu", koneksiQ);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            dgvtamu.Columns.Clear(); 
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvtamu.DataSource = table;
            dgvtamu.AllowUserToAddRows = false;
            dgvtamu.ReadOnly = true;
            dgvtamu.Columns[0].Visible = false;
            dgvtamu.Columns[1].HeaderText = "Nama Tamu";
            dgvtamu.Columns[1].Width = 150;
            dgvtamu.Columns[2].HeaderText = "Alamat Tamu";
            dgvtamu.Columns[2].Width = 300;
            dgvtamu.Columns[3].HeaderText = "No Telepon";
            dgvtamu.Columns[3].Width = 140;
            dgvtamu.Columns[4].HeaderText = "Jenis Kelamin";
            dgvtamu.Columns[4].Width = 100;
            dgvtamu.Columns[5].HeaderText = "Pekerjaan";
            dgvtamu.Columns[5].Width = 100;
            EditTamu = new DataGridViewButtonColumn();
            EditTamu.HeaderText = "Update";
            EditTamu.Text = "Updatet";
            EditTamu.UseColumnTextForButtonValue = true;
            EditTamu.Width = 40;
            dgvtamu.Columns.Add(EditTamu);
            DeleteTamu = new DataGridViewButtonColumn();
            DeleteTamu.HeaderText = "Hapus";
            DeleteTamu.Text = "Hapus";
            DeleteTamu.UseColumnTextForButtonValue = true;
            DeleteTamu.Width = 50;
            dgvtamu.Columns.Add(DeleteTamu);
            

        }
    }
}
