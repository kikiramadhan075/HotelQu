
namespace sample
{
    partial class FrmTambahMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCariData = new System.Windows.Forms.Button();
            this.cariMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshMenu = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmenu = new System.Windows.Forms.DataGridView();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 398);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 110);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCariData);
            this.tabPage1.Controls.Add(this.cariMenu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 84);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cari Daftar Menu Makanan - Minuman";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(316, 38);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(75, 39);
            this.btnCariData.TabIndex = 16;
            this.btnCariData.Text = "CARI DATA";
            this.btnCariData.UseVisualStyleBackColor = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // cariMenu
            // 
            this.cariMenu.Location = new System.Drawing.Point(162, 12);
            this.cariMenu.Name = "cariMenu";
            this.cariMenu.Size = new System.Drawing.Size(229, 20);
            this.cariMenu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Makanan / Minuman :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRefreshMenu);
            this.groupBox1.Controls.Add(this.btnSimpan);
            this.groupBox1.Controls.Add(this.harga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 116);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Menu Makanan - Minuman";
            // 
            // btnRefreshMenu
            // 
            this.btnRefreshMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshMenu.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshMenu.Location = new System.Drawing.Point(215, 71);
            this.btnRefreshMenu.Name = "btnRefreshMenu";
            this.btnRefreshMenu.Size = new System.Drawing.Size(99, 39);
            this.btnRefreshMenu.TabIndex = 15;
            this.btnRefreshMenu.Text = "REFRESH DATA";
            this.btnRefreshMenu.UseVisualStyleBackColor = false;
            this.btnRefreshMenu.Click += new System.EventHandler(this.btnRefreshMenu_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.Location = new System.Drawing.Point(320, 71);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 39);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(166, 46);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(229, 20);
            this.harga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga Makanan / Minuman :";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(166, 20);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(229, 20);
            this.nama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Makanan / Minuman :";
            // 
            // dgvmenu
            // 
            this.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmenu.Location = new System.Drawing.Point(16, 219);
            this.dgvmenu.Name = "dgvmenu";
            this.dgvmenu.Size = new System.Drawing.Size(412, 160);
            this.dgvmenu.TabIndex = 22;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(353, 514);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 35);
            this.btnBatal.TabIndex = 23;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(0, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(450, 43);
            this.label19.TabIndex = 27;
            this.label19.Text = "Tambah Menu";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 561);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dgvmenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahMenu";
            this.Text = "FrmTambahMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCariData;
        private System.Windows.Forms.TextBox cariMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshMenu;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvmenu;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label19;
    }
}