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
    }
}
