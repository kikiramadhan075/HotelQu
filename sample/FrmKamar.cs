/*
 * Created by Kiki Ramadhan.
 * User: kikiramadhan075
 * Date: 22/01/2023
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
    public partial class FrmKamar : Form
    {
        public FrmKamar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddKamar_Click(object sender, EventArgs e)
        {
            FrmTambahKamar tambahKamar = new FrmTambahKamar();
            tambahKamar.ShowDialog();
        }

        private void btnRefreshKamar_Click(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_kamar", koneksiB);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            dgvkamar.Columns.Clear(); 
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvkamar.DataSource = table;
            dgvkamar.AllowUserToAddRows = false; 
            dgvkamar.ReadOnly = true;
            dgvkamar.Columns[0].HeaderText = "Nomor Kamar";
            dgvkamar.Columns[0].Width = 110;
            dgvkamar.Columns[1].HeaderText = "Tipe Kamar";
            dgvkamar.Columns[1].Width = 100;
            dgvkamar.Columns[2].HeaderText = "Deskripsi";
            dgvkamar.Columns[2].Width = 400;
            dgvkamar.Columns[3].HeaderText = "Harga";
            dgvkamar.Columns[3].Width = 80;
     

        }

       
        private void dgvkamar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
