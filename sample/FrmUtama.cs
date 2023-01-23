using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class FrmUtama : Form
    {
        public string id_user, namaUser, userName;

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
         
        
            
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

        }

        private void btnLainnya_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            blHover.Visible = true;
            lblSeleted1.Visible = false;
            lblSeleted2.Visible = false;
            lblSeleted3.Visible = false;
            lblSeleted4.Visible = false;
            lblSeleted5.Visible = false;

            // tampilkan panel konten
            pnlDataMaster.Visible = true;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = false;
        }

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            blHover.Visible = false;
            lblSeleted1.Visible = true;
            lblSeleted2.Visible = false;
            lblSeleted3.Visible = false;
            lblSeleted4.Visible = false;
            lblSeleted5.Visible = false;

            // tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = true;
            pnlLaporan.Visible = false;
            pnlLainnya.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnLaporan_Click_1(object sender, EventArgs e)
        {
            blHover.Visible = false;
            lblSeleted1.Visible = false;
            lblSeleted2.Visible = true;
            lblSeleted3.Visible = false;
            lblSeleted4.Visible = false;
            lblSeleted5.Visible = false;

            // tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = true;
            pnlLainnya.Visible = false;
            pnlAbout.Visible = false;
        }

        private void btnLainnya_Click_1(object sender, EventArgs e)
        {
            blHover.Visible = false;
            lblSeleted1.Visible = false;
            lblSeleted2.Visible = false;
            lblSeleted3.Visible = true;
            lblSeleted4.Visible = false;
            lblSeleted5.Visible = false;

            // tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = false;
            pnlLainnya.Visible = true;
            pnlAbout.Visible = false;
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            blHover.Visible = false;
            lblSeleted1.Visible = false;
            lblSeleted2.Visible = false;
            lblSeleted3.Visible = false;
            lblSeleted4.Visible = true;
            lblSeleted5.Visible = false;

            // tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = false;
            pnlLainnya.Visible = false;
            pnlAbout.Visible = true;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnCekIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn cekIn = new FrmCheckIn();
            cekIn.idUser = id_user;
            cekIn.Show();
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            // tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = false;
            pnlLainnya.Visible = false;
            pnlAbout.Visible = false;
            pnlKamar.Visible = true; 
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
 
        }

        private void btnReservasi_Click_1(object sender, EventArgs e)
        {
            FrmReservasi reservasi = new FrmReservasi();

            reservasi.ShowDialog();
        }

        private void btnTamu_Click(object sender, EventArgs e)
        {
            FrmTamu tamu = new FrmTamu();
            tamu.ShowDialog();
        }

        private void btnKamar_Click_1(object sender, EventArgs e)
        {
            FrmKamar kamar = new FrmKamar();
            kamar.ShowDialog();
        }

        private void btnTipeKamar_Click(object sender, EventArgs e)
        {
            FrmTipeKamar tipeKamar = new FrmTipeKamar();
            tipeKamar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmUbahPsWord ubahPsWord = new FrmUbahPsWord();
            ubahPsWord.ShowDialog();
        }

        public FrmUtama()
        {
            InitializeComponent();
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
