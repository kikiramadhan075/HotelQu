/*
 * Created by Zhafran.
 * User: Zhafran
 * Date: Date: 22/01/2023
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
    public partial class FrmUbahPsWord : Form
    {
        public string id_user, namaUser, userName;
        public FrmUbahPsWord()
        {
            InitializeComponent();
        }

        private void pnlGantiPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGantiPsWord_Click(object sender, EventArgs e)
        {
            string lama = pswLama.Text.ToString();
            string baru = pswBaru.Text.ToString();
            string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
            MySqlConnection koneksiB = new MySqlConnection(koneksi);
            MySqlCommand com = new MySqlCommand("select * from tbl_user where id_user='" + id_user + "'", koneksiB);
            MySqlCommand com2 = new MySqlCommand("update tbl_user set password='" 
                + baru + "' where id_user='" + id_user + "'", koneksiB);
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                MySqlDataAdapter adap2 = new MySqlDataAdapter(com2);
                DataTable table = new DataTable();
                DataTable table2 = new DataTable();
                adap.Fill(table);
                adap2.Fill(table2);
                MessageBox.Show("Data berhasil disimpan!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
