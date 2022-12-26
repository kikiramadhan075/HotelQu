namespace penginapan
{
	partial class FrmTambahTamu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTambahTamu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbJk = new System.Windows.Forms.ComboBox();
            this.pekerjaan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telpon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alamatTamu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTamu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbJk);
            this.groupBox1.Controls.Add(this.pekerjaan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telpon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alamatTamu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmTamu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(427, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Data Tamu";
            // 
            // cmbJk
            // 
            this.cmbJk.FormattingEnabled = true;
            this.cmbJk.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJk.Location = new System.Drawing.Point(141, 121);
            this.cmbJk.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJk.Name = "cmbJk";
            this.cmbJk.Size = new System.Drawing.Size(160, 24);
            this.cmbJk.TabIndex = 10;
            // 
            // pekerjaan
            // 
            this.pekerjaan.Location = new System.Drawing.Point(141, 153);
            this.pekerjaan.Margin = new System.Windows.Forms.Padding(4);
            this.pekerjaan.Name = "pekerjaan";
            this.pekerjaan.Size = new System.Drawing.Size(260, 22);
            this.pekerjaan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pekerjaan :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // telpon
            // 
            this.telpon.Location = new System.Drawing.Point(141, 89);
            this.telpon.Margin = new System.Windows.Forms.Padding(4);
            this.telpon.Name = "telpon";
            this.telpon.Size = new System.Drawing.Size(260, 22);
            this.telpon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Telpon :";
            // 
            // alamatTamu
            // 
            this.alamatTamu.Location = new System.Drawing.Point(141, 57);
            this.alamatTamu.Margin = new System.Windows.Forms.Padding(4);
            this.alamatTamu.Name = "alamatTamu";
            this.alamatTamu.Size = new System.Drawing.Size(260, 22);
            this.alamatTamu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat Tamu :";
            // 
            // nmTamu
            // 
            this.nmTamu.Location = new System.Drawing.Point(141, 25);
            this.nmTamu.Margin = new System.Windows.Forms.Padding(4);
            this.nmTamu.Name = "nmTamu";
            this.nmTamu.Size = new System.Drawing.Size(260, 22);
            this.nmTamu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Tamu :";
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(343, 287);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(100, 48);
            this.btnsimpan.TabIndex = 15;
            this.btnsimpan.Text = "SIMPAN";
            this.btnsimpan.UseVisualStyleBackColor = true;
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(235, 287);
            this.btnbatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(100, 48);
            this.btnbatal.TabIndex = 14;
            this.btnbatal.Text = "BATAL";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTambahTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(464, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTambahTamu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTambahTamu";
            this.Load += new System.EventHandler(this.FrmTambahTamu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnbatal;
		private System.Windows.Forms.Button btnsimpan;
		private System.Windows.Forms.TextBox nmTamu;
		private System.Windows.Forms.TextBox alamatTamu;
		private System.Windows.Forms.TextBox telpon;
		private System.Windows.Forms.TextBox pekerjaan;
        private System.Windows.Forms.ComboBox cmbJk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
