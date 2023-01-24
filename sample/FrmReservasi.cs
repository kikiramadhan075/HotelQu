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
    public partial class FrmReservasi : Form

    {
        DataGridViewButtonColumn CekOut;
        public FrmReservasi()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCekIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn cekIn = new FrmCheckIn();
            cekIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("SELECT * FROM tbl_reservasi", koneksiB);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            dgvreservasi.Columns.Clear();
            DataTable table = new DataTable();
            adap.Fill(table);
            koneksiB.Open();
            dgvreservasi.DataSource = null;
            dgvreservasi.DataSource = table;
            dgvreservasi.AllowUserToAddRows = false;
            dgvreservasi.ReadOnly = true;
            dgvreservasi.Columns[0].Visible = false; //id cd
            dgvreservasi.Columns[1].HeaderText = "Nomor Kamar";
            dgvreservasi.Columns[1].Width = 80; //nama cd
            dgvreservasi.Columns[2].HeaderText = "Nama Tamu";
            dgvreservasi.Columns[2].Width = 150; //nama cd
            dgvreservasi.Columns[3].HeaderText = "Tipe Kamar";
            dgvreservasi.Columns[3].Width = 80; //tipe cd
            dgvreservasi.Columns[4].HeaderText = "Harga Per Hari";
            dgvreservasi.Columns[4].Width = 80; //produsen
            dgvreservasi.Columns[5].HeaderText = "Tanggal Cek In";
            dgvreservasi.Columns[5].Width = 110; //tahun
            dgvreservasi.Columns[6].HeaderText = "Tanggal Cek Out";
            dgvreservasi.Columns[6].Width = 110; //harga
            dgvreservasi.Columns[7].HeaderText = "Lama Inap";
            dgvreservasi.Columns[7].Width = 70; //harga
            dgvreservasi.Columns[8].HeaderText = "Total";
            dgvreservasi.Columns[8].Width = 70; //harga
            dgvreservasi.Columns[9].Visible = false; //id cd
            dgvreservasi.Columns[10].Visible = false; //id cd
            CekOut = new DataGridViewButtonColumn();
            CekOut.HeaderText = "Cek Out";
            CekOut.Text = "Cek Out";
            CekOut.UseColumnTextForButtonValue = true;
            CekOut.Width = 80;
            dgvreservasi.Columns.Add(CekOut);
            koneksiB.Close();
        }
    }
}
