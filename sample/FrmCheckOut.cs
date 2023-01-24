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
    public partial class FrmCheckOut : Form
    {
		public string id_rs, id_tm, id_tp_kmr, nm_tm, tp_kmr, nmr_kmr, cek_in, cek_out, id_user;

        private void btnSimpanBayar_Click(object sender, EventArgs e)
        {
			string id_res = idRs.Text.ToString();
			string id_tam = id_tm;
			string id_kam = nmr_kmr;
			string id_tip = id_tm;
			string id_use = id_user;
			string tot = ttlBiayaSemua.Text.ToString();
			string bln = DateTime.Today.Month.ToString();
			string thn = DateTime.Today.Year.ToString();
			string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call CekOut(" + id_res + "," + id_tam + "," + id_kam + "," + id_tip + "," + id_use + "," + tot + ", '" + bln + "', '" + thn + "')", koneksiB);
			MySqlCommand com2 = new MySqlCommand("update tbl_kamar set status='N' where id_kamar='" + id_kam + "'", koneksiB);
			MySqlCommand com3 = new MySqlCommand("update tbl_reservasi set status='Y' where id_reservasi='" + id_res + "'", koneksiB);
			try
			{
				MySqlDataAdapter adap = new MySqlDataAdapter(com);
				MySqlDataAdapter adap2 = new MySqlDataAdapter(com2);
				MySqlDataAdapter adap3 = new MySqlDataAdapter(com3);
				DataTable table = new DataTable();
				DataTable table2 = new DataTable();
				DataTable table3 = new DataTable();
				adap.Fill(table);
				adap2.Fill(table2);
				adap3.Fill(table3);
				MessageBox.Show("Data berhasil disimpan!!!\nTerima Kasih sudah menginap di HotelQu.");
				this.Close();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());
			}
		}

        private void btnDataPesanan_Click(object sender, EventArgs e)
        {
			string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			MySqlCommand com = new MySqlCommand("call LihatPesananPerTamu(" + id_rs + ")", koneksiB);
			MySqlDataAdapter adap = new MySqlDataAdapter(com);
			tampil.Columns.Clear(); 
			DataTable table = new DataTable();
			adap.Fill(table);
			koneksiB.Open();
			tampil.DataSource = null;
			tampil.DataSource = table;
			tampil.AllowUserToAddRows = false; 
			tampil.ReadOnly = true;

			tampil.Columns[0].HeaderText = "Nomor Kamar";
			tampil.Columns[0].Width = 100; 
			tampil.Columns[1].HeaderText = "Pesanan";
			tampil.Columns[1].Width = 200; 
			tampil.Columns[2].HeaderText = "Total";
			tampil.Columns[2].Width = 100; 
			tampil.Columns[3].HeaderText = "Tanggal Pesan";
			tampil.Columns[3].Width = 120;
			koneksiB.Close();
		}

        private void button8_Click(object sender, EventArgs e)
        {
			int bnykData;
			int total = 0;
			bnykData = tampil.Rows.Count;
			for (int i = 0; i < bnykData; i++)
			{
				total = Convert.ToInt32(total + Convert.ToInt32(tampil[2, i].Value));
			}
			totalSemua.Text = total.ToString();
			int ttlSmw = Convert.ToInt32(Convert.ToInt32(ttlBiaya.Text.ToString()) + total);
			ttlBiayaPesanan.Text = total.ToString();
			ttlBiayaSemua.Text = ttlSmw.ToString();
		}

        public int ttl_biaya, hrg_kmr, lm_inap;
		public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
			DateTime cek_in = Convert.ToDateTime(cekIn.Text);
			DateTime cek_out = Convert.ToDateTime(cekOut.Text);
			TimeSpan lama = cek_out.Subtract(cek_in);
			lmInap.Text = lama.Days.ToString();
			int total = Convert.ToInt32(hrg_kmr * Convert.ToInt32(lmInap.Text));
			ttlBiaya.Text = total.ToString();
			ttlBiayaInap.Text = total.ToString();

			string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
			MySqlConnection koneksiB = new MySqlConnection(koneksi);
			string query = String.Format("update tbl_reservasi set tgl_cek_in='" + cekIn.Text.ToString() + "', tgl_cek_out='" + cekOut.Text.ToString() + "', lama_menginap='" + lama.Days.ToString() + "' where id_reservasi='" + id_rs + "'");
			MySqlCommand com2 = new MySqlCommand(query, koneksiB);
			try
			{
				MySqlDataAdapter adap2 = new MySqlDataAdapter(com2);
				DataTable table2 = new DataTable();
				adap2.Fill(table2);
				MessageBox.Show("Data berhasil disimpan!!!");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());
			}

			int bnykData;
			int total2 = 0;
			bnykData = tampil.Rows.Count;
			for (int i = 0; i < bnykData; i++)
			{
				total2 = Convert.ToInt32(total2 + Convert.ToInt32(tampil[2, i].Value));
			}
			totalSemua.Text = total2.ToString();
			int ttlSmw = Convert.ToInt32(Convert.ToInt32(ttlBiaya.Text.ToString()) + total2);
			ttlBiayaPesanan.Text = total2.ToString();
			ttlBiayaSemua.Text = ttlSmw.ToString();
		}
    }
}
