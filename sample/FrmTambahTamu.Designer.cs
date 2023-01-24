
namespace sample
{
    partial class FrmTambahTamu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTamu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTamu
            // 
            this.btnAddTamu.Location = new System.Drawing.Point(249, 244);
            this.btnAddTamu.Name = "btnAddTamu";
            this.btnAddTamu.Size = new System.Drawing.Size(75, 39);
            this.btnAddTamu.TabIndex = 19;
            this.btnAddTamu.Text = "SIMPAN";
            this.btnAddTamu.UseVisualStyleBackColor = true;
            this.btnAddTamu.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 18;
            this.button4.Text = "BATAL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
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
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Data Tamu";
            // 
            // cmbJk
            // 
            this.cmbJk.FormattingEnabled = true;
            this.cmbJk.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJk.Location = new System.Drawing.Point(106, 98);
            this.cmbJk.Name = "cmbJk";
            this.cmbJk.Size = new System.Drawing.Size(121, 21);
            this.cmbJk.TabIndex = 10;
            // 
            // pekerjaan
            // 
            this.pekerjaan.Location = new System.Drawing.Point(106, 124);
            this.pekerjaan.Name = "pekerjaan";
            this.pekerjaan.Size = new System.Drawing.Size(196, 20);
            this.pekerjaan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pekerjaan :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // telpon
            // 
            this.telpon.Location = new System.Drawing.Point(106, 72);
            this.telpon.Name = "telpon";
            this.telpon.Size = new System.Drawing.Size(196, 20);
            this.telpon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Telpon :";
            // 
            // alamatTamu
            // 
            this.alamatTamu.Location = new System.Drawing.Point(106, 46);
            this.alamatTamu.Name = "alamatTamu";
            this.alamatTamu.Size = new System.Drawing.Size(196, 20);
            this.alamatTamu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat Tamu :";
            // 
            // nmTamu
            // 
            this.nmTamu.Location = new System.Drawing.Point(106, 20);
            this.nmTamu.Name = "nmTamu";
            this.nmTamu.Size = new System.Drawing.Size(196, 20);
            this.nmTamu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Tamu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::sample.Properties.Resources.tel;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTambahTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(329, 288);
            this.Controls.Add(this.btnAddTamu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahTamu";
            this.Text = "FrmTambahTamu";
            this.Load += new System.EventHandler(this.FrmTambahTamu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTamu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbJk;
        private System.Windows.Forms.TextBox pekerjaan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telpon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alamatTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nmTamu;
        private System.Windows.Forms.Label label1;
    }
}