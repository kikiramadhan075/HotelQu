
namespace sample
{
    partial class FrmPesanan
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
            this.pnlPesanan = new System.Windows.Forms.Panel();
            this.btnBatal = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.dgvmenu = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.btnRefreshPesanan = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.pnlPesanan.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPesanan
            // 
            this.pnlPesanan.Controls.Add(this.btnBatal);
            this.pnlPesanan.Controls.Add(this.groupBox9);
            this.pnlPesanan.Controls.Add(this.groupBox8);
            this.pnlPesanan.Controls.Add(this.dgvmenu);
            this.pnlPesanan.Controls.Add(this.label19);
            this.pnlPesanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesanan.Location = new System.Drawing.Point(0, 0);
            this.pnlPesanan.Name = "pnlPesanan";
            this.pnlPesanan.Size = new System.Drawing.Size(656, 445);
            this.pnlPesanan.TabIndex = 8;
            this.pnlPesanan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPesanan_Paint);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(538, 410);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 30;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.btnRefreshPesanan);
            this.groupBox9.Controls.Add(this.button24);
            this.groupBox9.Location = new System.Drawing.Point(384, 73);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(229, 86);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Pesanan Makanan - Minuman";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(34, 62);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(49, 13);
            this.label49.TabIndex = 4;
            this.label49.Text = "Pesanan";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(23, 50);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 13);
            this.label48.TabIndex = 3;
            this.label48.Text = "Tambah Data";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(143, 60);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 13);
            this.label44.TabIndex = 2;
            this.label44.Text = "Refresh";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label47);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.btnRefresh);
            this.groupBox8.Controls.Add(this.btnAddMenu);
            this.groupBox8.Location = new System.Drawing.Point(42, 73);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(229, 86);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Data Menu Makanan - Minuman";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(42, 63);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(34, 13);
            this.label47.TabIndex = 4;
            this.label47.Text = "Menu";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(25, 50);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(72, 13);
            this.label46.TabIndex = 3;
            this.label46.Text = "Tambah Data";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(144, 59);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 13);
            this.label45.TabIndex = 2;
            this.label45.Text = "Refresh";
            // 
            // dgvmenu
            // 
            this.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmenu.Location = new System.Drawing.Point(42, 183);
            this.dgvmenu.Name = "dgvmenu";
            this.dgvmenu.Size = new System.Drawing.Size(571, 217);
            this.dgvmenu.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(42, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(540, 35);
            this.label19.TabIndex = 26;
            this.label19.Text = "Manajemen Pesanan";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshPesanan
            // 
            this.btnRefreshPesanan.BackColor = System.Drawing.Color.White;
            this.btnRefreshPesanan.Image = global::sample.Properties.Resources.refresh_button;
            this.btnRefreshPesanan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshPesanan.Location = new System.Drawing.Point(115, 20);
            this.btnRefreshPesanan.Name = "btnRefreshPesanan";
            this.btnRefreshPesanan.Size = new System.Drawing.Size(100, 60);
            this.btnRefreshPesanan.TabIndex = 1;
            this.btnRefreshPesanan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshPesanan.UseVisualStyleBackColor = false;
            this.btnRefreshPesanan.Click += new System.EventHandler(this.btnRefreshPesanan_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Image = global::sample.Properties.Resources.note;
            this.button24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button24.Location = new System.Drawing.Point(9, 19);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(100, 60);
            this.button24.TabIndex = 0;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::sample.Properties.Resources.refresh_button2;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(115, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 60);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.White;
            this.btnAddMenu.Image = global::sample.Properties.Resources.addmenu;
            this.btnAddMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMenu.Location = new System.Drawing.Point(9, 19);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(100, 60);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // FrmPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.pnlPesanan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesanan";
            this.Text = "FrmPesanan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPesanan.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPesanan;
        private System.Windows.Forms.DataGridView dgvmenu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnRefreshPesanan;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddMenu;
    }
}