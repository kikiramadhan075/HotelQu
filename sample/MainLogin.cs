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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usr = usrName.Text.ToString();
                string psw = psWord.Text.ToString();
                string id_usr = "";
                string nm_usr = "";
                string username = "";
                string koneksi = "server=localhost;database=db_hotelqu;uid=root;password=";
                MySqlConnection koneksiB = new MySqlConnection(koneksi);
                MySqlCommand com = new MySqlCommand("select * from tbl_user where username='" 
                    + usr + "' and password='" + psw + "'", koneksiB);
                MySqlDataAdapter adap = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adap.Fill(table);
                koneksiB.Open();
                foreach (DataRow kolom in table.Rows)
                {
                    id_usr = kolom["id_user"].ToString();
                    nm_usr = kolom["nama_lengkap"].ToString();
                    username = kolom["username"].ToString();
                }
                if (table.Rows.Count > 0)
                {
                    FrmUtama f1 = new FrmUtama();
                    f1.id_user = id_usr;
                    f1.namaUser = nm_usr;
                    f1.userName = username;
                    f1.Show();
                    this.Hide();
                }

                if(usrName.Text.TrimStart()== string.Empty)
                {
                    MessageBox.Show("Mohon Masukkan Username", "Error");
                   
                }else if (psWord.Text.TrimStart()== string.Empty)
                {
                    MessageBox.Show("Mohon Masukkan Password", "Error");
                }
               
                else
                {
                    MessageBox.Show("Uppppzzzz...!!!!\nUsername dan Password salah....!!!!", "Terjadi Error!!!!");
                    
                }
                koneksiB.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
       
        }
    }
}
