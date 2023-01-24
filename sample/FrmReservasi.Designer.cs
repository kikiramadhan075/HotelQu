
namespace sample
{
    partial class FrmReservasi
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
            this.pnlReservasi = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvreservasi = new System.Windows.Forms.DataGridView();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btnRefreshReservasi = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.btnCekIn = new System.Windows.Forms.Button();
            this.pnlReservasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreservasi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReservasi
            // 
            this.pnlReservasi.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReservasi.Controls.Add(this.btnKembali);
            this.pnlReservasi.Controls.Add(this.dgvreservasi);
            this.pnlReservasi.Controls.Add(this.label37);
            this.pnlReservasi.Controls.Add(this.label38);
            this.pnlReservasi.Controls.Add(this.btnRefreshReservasi);
            this.pnlReservasi.Controls.Add(this.label39);
            this.pnlReservasi.Controls.Add(this.btnCekIn);
            this.pnlReservasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservasi.Location = new System.Drawing.Point(0, 0);
            this.pnlReservasi.Name = "pnlReservasi";
            this.pnlReservasi.Size = new System.Drawing.Size(800, 450);
            this.pnlReservasi.TabIndex = 13;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(525, 414);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(88, 24);
            this.btnKembali.TabIndex = 28;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvreservasi
            // 
            this.dgvreservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreservasi.Location = new System.Drawing.Point(42, 183);
            this.dgvreservasi.Name = "dgvreservasi";
            this.dgvreservasi.Size = new System.Drawing.Size(571, 217);
            this.dgvreservasi.TabIndex = 27;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label37.Location = new System.Drawing.Point(42, 8);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(540, 35);
            this.label37.TabIndex = 26;
            this.label37.Text = "Reservasi Center";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(187, 119);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 26);
            this.label38.TabIndex = 17;
            this.label38.Text = "Refresh";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshReservasi
            // 
            this.btnRefreshReservasi.BackColor = System.Drawing.Color.Silver;
            this.btnRefreshReservasi.FlatAppearance.BorderSize = 0;
            this.btnRefreshReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshReservasi.Image = global::sample.Properties.Resources.refresh_button;
            this.btnRefreshReservasi.Location = new System.Drawing.Point(187, 56);
            this.btnRefreshReservasi.Name = "btnRefreshReservasi";
            this.btnRefreshReservasi.Size = new System.Drawing.Size(70, 70);
            this.btnRefreshReservasi.TabIndex = 16;
            this.btnRefreshReservasi.UseVisualStyleBackColor = false;
            this.btnRefreshReservasi.Click += new System.EventHandler(this.button3_Click);
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(42, 117);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(70, 26);
            this.label39.TabIndex = 15;
            this.label39.Text = "Check In";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCekIn
            // 
            this.btnCekIn.BackColor = System.Drawing.Color.Silver;
            this.btnCekIn.FlatAppearance.BorderSize = 0;
            this.btnCekIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekIn.Image = global::sample.Properties.Resources.check_in__1_;
            this.btnCekIn.Location = new System.Drawing.Point(42, 56);
            this.btnCekIn.Name = "btnCekIn";
            this.btnCekIn.Size = new System.Drawing.Size(70, 70);
            this.btnCekIn.TabIndex = 14;
            this.btnCekIn.UseVisualStyleBackColor = false;
            this.btnCekIn.Click += new System.EventHandler(this.btnCekIn_Click);
            // 
            // FrmReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlReservasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservasi";
            this.Text = "FrmReservasi";
            this.pnlReservasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreservasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReservasi;
        private System.Windows.Forms.DataGridView dgvreservasi;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnRefreshReservasi;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnCekIn;
        private System.Windows.Forms.Button btnKembali;
    }
}