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
    public partial class FrmTambahKamar : Form
    {
        public FrmTambahKamar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTambahKamar_Load(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_tipe_kamar", koneksiB);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adap.Fill(table);
            foreach (DataRow kolom in table.Rows)
            {
                string id_tipe = kolom["id_tipe_kamar"].ToString();
                string nama = kolom["nama"].ToString();
                string gabung = id_tipe + " - " + nama;
                cmbCariTipeKamar.Items.Add(gabung);
            }
        }

        private void btnAddKamar_Click(object sender, EventArgs e)
        {
            string deskripsi = des.Text.ToString();
            string id = cmbCariTipeKamar.Text.ToString();
            string tipe = id.Substring(0, 1);
            string status = "N";
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("INSERT INTO tbl_kamar(id_tipe_kamar, deskripsi, status) VALUES(" + tipe + ",'" + deskripsi + "','" + status + "')", koneksiB);
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
