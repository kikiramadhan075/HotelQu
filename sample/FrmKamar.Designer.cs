
namespace sample
{
    partial class FrmKamar
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
            this.pnlKamar = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvkamar = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnRefreshKamar = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAddKamar = new System.Windows.Forms.Button();
            this.pnlKamar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkamar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKamar
            // 
            this.pnlKamar.Controls.Add(this.btnKembali);
            this.pnlKamar.Controls.Add(this.dgvkamar);
            this.pnlKamar.Controls.Add(this.label19);
            this.pnlKamar.Controls.Add(this.label26);
            this.pnlKamar.Controls.Add(this.btnRefreshKamar);
            this.pnlKamar.Controls.Add(this.label27);
            this.pnlKamar.Controls.Add(this.btnAddKamar);
            this.pnlKamar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKamar.Location = new System.Drawing.Point(0, 0);
            this.pnlKamar.Name = "pnlKamar";
            this.pnlKamar.Size = new System.Drawing.Size(800, 450);
            this.pnlKamar.TabIndex = 8;
            this.pnlKamar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKamar_Paint);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(537, 415);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 28;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvkamar
            // 
            this.dgvkamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkamar.Location = new System.Drawing.Point(42, 183);
            this.dgvkamar.Name = "dgvkamar";
            this.dgvkamar.Size = new System.Drawing.Size(571, 217);
            this.dgvkamar.TabIndex = 27;
            this.dgvkamar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkamar_CellContentClick);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(42, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(540, 35);
            this.label19.TabIndex = 26;
            this.label19.Text = "Manajemen Kamar";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(187, 119);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 26);
            this.label26.TabIndex = 17;
            this.label26.Text = "Lihat Kamar";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshKamar
            // 
            this.btnRefreshKamar.BackColor = System.Drawing.Color.Silver;
            this.btnRefreshKamar.FlatAppearance.BorderSize = 0;
            this.btnRefreshKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshKamar.Image = global::sample.Properties.Resources.refresh_button;
            this.btnRefreshKamar.Location = new System.Drawing.Point(187, 56);
            this.btnRefreshKamar.Name = "btnRefreshKamar";
            this.btnRefreshKamar.Size = new System.Drawing.Size(70, 70);
            this.btnRefreshKamar.TabIndex = 16;
            this.btnRefreshKamar.UseVisualStyleBackColor = false;
            this.btnRefreshKamar.Click += new System.EventHandler(this.btnRefreshKamar_Click);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(42, 117);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 26);
            this.label27.TabIndex = 15;
            this.label27.Text = "Tambah Kamar";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddKamar
            // 
            this.btnAddKamar.BackColor = System.Drawing.Color.Silver;
            this.btnAddKamar.FlatAppearance.BorderSize = 0;
            this.btnAddKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKamar.Image = global::sample.Properties.Resources.bedblue;
            this.btnAddKamar.Location = new System.Drawing.Point(42, 56);
            this.btnAddKamar.Name = "btnAddKamar";
            this.btnAddKamar.Size = new System.Drawing.Size(70, 70);
            this.btnAddKamar.TabIndex = 14;
            this.btnAddKamar.UseVisualStyleBackColor = false;
            this.btnAddKamar.Click += new System.EventHandler(this.btnAddKamar_Click);
            // 
            // FrmKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlKamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKamar";
            this.Text = "FrmKamar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlKamar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKamar;
        private System.Windows.Forms.DataGridView dgvkamar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnRefreshKamar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnAddKamar;
        private System.Windows.Forms.Button btnKembali;
    }
}