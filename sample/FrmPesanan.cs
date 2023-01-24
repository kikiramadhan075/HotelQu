/*
 * Created by Muhammad Subhan Mahendrasyah.
 * User: Mahendrasyah
 * Date: 23/01/2023
 * 
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
    public partial class FrmPesanan : Form
    {
        public FrmPesanan()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
			string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_menu", koneksiB);
			try
			{
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				DataTable table = new DataTable();
				dgvmenu.Columns.Clear();
				adap.Fill(table);
				dgvmenu.DataSource = table;
				dgvmenu.AllowUserToAddRows = false; 
				dgvmenu.ReadOnly = true;
				dgvmenu.Columns[0].HeaderText = "ID";
				dgvmenu.Columns[0].Width = 100;
				dgvmenu.Columns[1].HeaderText = "Nama Makanan";
				dgvmenu.Columns[1].Width = 540;
				dgvmenu.Columns[2].HeaderText = "Harga Makanan";
				dgvmenu.Columns[2].Width = 200;
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());
			}
		}

        private void btnRefreshPesanan_Click(object sender, EventArgs e)
        {
			string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_pesanan", koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
			dgvmenu.Columns.Clear(); 
			DataTable table = new DataTable();
			adap.Fill(table);
			dgvmenu.DataSource = table;
			dgvmenu.AllowUserToAddRows = false; 
			dgvmenu.ReadOnly = true;
			dgvmenu.Columns[0].HeaderText = "ID Reservasi";
			dgvmenu.Columns[0].Width = 100;
			dgvmenu.Columns[1].HeaderText = "No Kamar";
			dgvmenu.Columns[1].Width = 90;
			dgvmenu.Columns[2].HeaderText = "Pesanan";
			dgvmenu.Columns[2].Width = 300;
			dgvmenu.Columns[3].HeaderText = "Tgl Cek In";
			dgvmenu.Columns[3].Width = 100;
			dgvmenu.Columns[4].HeaderText = "Tgl Cek Out";
			dgvmenu.Columns[4].Width = 100;
			dgvmenu.Columns[5].HeaderText = "Tgl Pesan";
			dgvmenu.Columns[5].Width = 100;
		}

        private void pnlPesanan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
			FrmTambahMenu tambahMenu = new FrmTambahMenu();
			tambahMenu.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
			FrmTambahPesanan tambahPesanan = new FrmTambahPesanan();
			tambahPesanan.ShowDialog();
        }
    }
}
