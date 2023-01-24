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
    public partial class FrmTambahMenu : Form
    {
        public FrmTambahMenu()
        {
            InitializeComponent();
        }

        private void Button2Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_menu", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvmenu.DataSource = table;
                dgvmenu.AllowUserToAddRows = false; 
                dgvmenu.ReadOnly = true;
                dgvmenu.Columns[0].HeaderText = "ID";
                dgvmenu.Columns[0].Width = 30;
                dgvmenu.Columns[1].HeaderText = "Nama Makanan";
                dgvmenu.Columns[1].Width = 200;
                dgvmenu.Columns[2].HeaderText = "Harga Makanan";
                dgvmenu.Columns[2].Width = 120;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nm = nama.Text.ToString();
            string hrg = harga.Text.ToString();
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("INSERT INTO tbl_menu(nama, harga) VALUES('" + nm + "','" + hrg + "')", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                MessageBox.Show("Data berhasil disimpan!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            string nm = cariMenu.Text.ToString();
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("select * from tbl_menu where nama like '%" + nm + "%'", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvmenu.DataSource = table;
                dgvmenu.AllowUserToAddRows = false; // remove the null line
                dgvmenu.ReadOnly = true;
                dgvmenu.Columns[0].HeaderText = "ID";
                dgvmenu.Columns[0].Width = 30;
                dgvmenu.Columns[1].HeaderText = "Nama Makanan";
                dgvmenu.Columns[1].Width = 200;
                dgvmenu.Columns[2].HeaderText = "Harga Makanan";
                dgvmenu.Columns[2].Width = 120;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
