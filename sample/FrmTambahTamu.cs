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
    public partial class FrmTambahTamu : Form
    {
        public FrmTambahTamu()
        {
            InitializeComponent();
        }

        private void FrmTambahTamu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nama = nmTamu.Text.ToString();
            string alamat = alamatTamu.Text.ToString();
            string tlpn = telpon.Text.ToString();
            string jk = cmbJk.Text.ToString();
            string kerja = pekerjaan.Text.ToString();
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("INSERT INTO tbl_tamu(nama_tamu, alamat, no_telpon, jk, pekerjaan) VALUES('" + nama + "','" + alamat + "','" + tlpn + "','" + jk + "','" + kerja + "')", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                MessageBox.Show("Data berhasil disimpan!!!");
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
