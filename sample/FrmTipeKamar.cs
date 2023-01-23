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
    public partial class FrmTipeKamar : Form
    {
        public FrmTipeKamar()
        {
            InitializeComponent();
        }

        private void FrmTipeKamar_Load(object sender, EventArgs e)
        {

        }



        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void refreshTipeKamar_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_tipe_kamar", con);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            dgvtipekamar.Columns.Clear();
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvtipekamar.DataSource = table;
            dgvtipekamar.AllowUserToAddRows = false;
            dgvtipekamar.ReadOnly = true;
            dgvtipekamar.Columns[0].HeaderText = "ID Tipe Kamar";
            dgvtipekamar.Columns[0].Width = 110;
            dgvtipekamar.Columns[1].HeaderText = "Nama Tipe Kamar";
            dgvtipekamar.Columns[1].Width = 300;
            dgvtipekamar.Columns[2].HeaderText = "Harga";
            dgvtipekamar.Columns[2].Width = 200;
        }

        private void pnlTipeKamar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (namaTipe.Text == "" || hargaTipe.Text == "")
            {
                MessageBox.Show("Gagal menambah data!!!");
            }
            else
            {
                string nama = namaTipe.Text.ToString();
                string harga = hargaTipe.Text.ToString();
                string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
                MySqlConnection koneksiZ = new MySqlConnection(koneksi);
                MySqlCommand com = new MySqlCommand("INSERT INTO tbl_tipe_kamar(nama, harga) VALUES('" + nama + "','" + harga + "')", koneksiZ);
                try
                {
                    MySqlDataAdapter adap = new MySqlDataAdapter(com);
                    dgvtipekamar.Columns.Clear();
                    DataTable table = new DataTable();
                    adap.Fill(table);
                    MessageBox.Show("Data berhasil disimpan!!!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
    }
}
