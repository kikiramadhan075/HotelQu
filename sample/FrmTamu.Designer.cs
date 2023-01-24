
namespace sample
{
    partial class FrmTamu
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
            this.pnlTamu = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvtamu = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnRefreshTamu = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.btnAddTamu = new System.Windows.Forms.Button();
            this.pnlTamu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtamu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTamu
            // 
            this.pnlTamu.Controls.Add(this.btnKembali);
            this.pnlTamu.Controls.Add(this.dgvtamu);
            this.pnlTamu.Controls.Add(this.label25);
            this.pnlTamu.Controls.Add(this.label28);
            this.pnlTamu.Controls.Add(this.btnRefreshTamu);
            this.pnlTamu.Controls.Add(this.label29);
            this.pnlTamu.Controls.Add(this.btnAddTamu);
            this.pnlTamu.Location = new System.Drawing.Point(0, 0);
            this.pnlTamu.Name = "pnlTamu";
            this.pnlTamu.Size = new System.Drawing.Size(678, 450);
            this.pnlTamu.TabIndex = 11;
            this.pnlTamu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTamu_Paint);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(539, 424);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 28;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvtamu
            // 
            this.dgvtamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtamu.Location = new System.Drawing.Point(42, 183);
            this.dgvtamu.Name = "dgvtamu";
            this.dgvtamu.Size = new System.Drawing.Size(571, 217);
            this.dgvtamu.TabIndex = 27;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Location = new System.Drawing.Point(42, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(540, 35);
            this.label25.TabIndex = 26;
            this.label25.Text = "Manajemen Tamu";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(187, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 26);
            this.label28.TabIndex = 17;
            this.label28.Text = "Lihat Tamu";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshTamu
            // 
            this.btnRefreshTamu.BackColor = System.Drawing.Color.Silver;
            this.btnRefreshTamu.FlatAppearance.BorderSize = 0;
            this.btnRefreshTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTamu.Image = global::sample.Properties.Resources.refresh_button;
            this.btnRefreshTamu.Location = new System.Drawing.Point(187, 56);
            this.btnRefreshTamu.Name = "btnRefreshTamu";
            this.btnRefreshTamu.Size = new System.Drawing.Size(70, 70);
            this.btnRefreshTamu.TabIndex = 16;
            this.btnRefreshTamu.UseVisualStyleBackColor = false;
            this.btnRefreshTamu.Click += new System.EventHandler(this.btnRefreshTamu_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(42, 117);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 26);
            this.label29.TabIndex = 15;
            this.label29.Text = "Tambah Tamu";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTamu
            // 
            this.btnAddTamu.BackColor = System.Drawing.Color.Silver;
            this.btnAddTamu.FlatAppearance.BorderSize = 0;
            this.btnAddTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTamu.Image = global::sample.Properties.Resources.bedblue;
            this.btnAddTamu.Location = new System.Drawing.Point(42, 56);
            this.btnAddTamu.Name = "btnAddTamu";
            this.btnAddTamu.Size = new System.Drawing.Size(70, 70);
            this.btnAddTamu.TabIndex = 14;
            this.btnAddTamu.UseVisualStyleBackColor = false;
            this.btnAddTamu.Click += new System.EventHandler(this.btnAddTamu_Click);
            // 
            // FrmTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.pnlTamu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTamu";
            this.Text = "FrmTamu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTamu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtamu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTamu;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.DataGridView dgvtamu;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnRefreshTamu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnAddTamu;
    }
}