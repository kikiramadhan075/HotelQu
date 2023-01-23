
namespace sample
{
    partial class FrmTipeKamar
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
            this.pnlTipeKamar = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.hargaTipe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.namaTipe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshTipeKamar = new System.Windows.Forms.Button();
            this.btnAddTipe = new System.Windows.Forms.Button();
            this.dgvtipekamar = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlTipeKamar.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipekamar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTipeKamar
            // 
            this.pnlTipeKamar.Controls.Add(this.btnKembali);
            this.pnlTipeKamar.Controls.Add(this.groupBox5);
            this.pnlTipeKamar.Controls.Add(this.dgvtipekamar);
            this.pnlTipeKamar.Controls.Add(this.label20);
            this.pnlTipeKamar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTipeKamar.Location = new System.Drawing.Point(0, 0);
            this.pnlTipeKamar.Name = "pnlTipeKamar";
            this.pnlTipeKamar.Size = new System.Drawing.Size(675, 457);
            this.pnlTipeKamar.TabIndex = 9;
            this.pnlTipeKamar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTipeKamar_Paint);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(538, 422);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 29;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.hargaTipe);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.namaTipe);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.refreshTipeKamar);
            this.groupBox5.Controls.Add(this.btnAddTipe);
            this.groupBox5.Location = new System.Drawing.Point(42, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(571, 86);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Tipe Kamar";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(360, 56);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(73, 13);
            this.label41.TabIndex = 7;
            this.label41.Text = "Tambah Tipe ";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(481, 56);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 13);
            this.label40.TabIndex = 6;
            this.label40.Text = "Refresh";
            // 
            // hargaTipe
            // 
            this.hargaTipe.Location = new System.Drawing.Point(151, 53);
            this.hargaTipe.Name = "hargaTipe";
            this.hargaTipe.Size = new System.Drawing.Size(189, 20);
            this.hargaTipe.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Harga Kamar Per Hari :";
            // 
            // namaTipe
            // 
            this.namaTipe.Location = new System.Drawing.Point(151, 25);
            this.namaTipe.Name = "namaTipe";
            this.namaTipe.Size = new System.Drawing.Size(189, 20);
            this.namaTipe.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nama Tipe Kamar :";
            // 
            // refreshTipeKamar
            // 
            this.refreshTipeKamar.BackColor = System.Drawing.Color.White;
            this.refreshTipeKamar.Image = global::sample.Properties.Resources.refresh_button2;
            this.refreshTipeKamar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshTipeKamar.Location = new System.Drawing.Point(452, 19);
            this.refreshTipeKamar.Name = "refreshTipeKamar";
            this.refreshTipeKamar.Size = new System.Drawing.Size(100, 60);
            this.refreshTipeKamar.TabIndex = 1;
            this.refreshTipeKamar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refreshTipeKamar.UseVisualStyleBackColor = false;
            this.refreshTipeKamar.Click += new System.EventHandler(this.refreshTipeKamar_Click);
            // 
            // btnAddTipe
            // 
            this.btnAddTipe.BackColor = System.Drawing.Color.White;
            this.btnAddTipe.Image = global::sample.Properties.Resources.bedblue1;
            this.btnAddTipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTipe.Location = new System.Drawing.Point(346, 19);
            this.btnAddTipe.Name = "btnAddTipe";
            this.btnAddTipe.Size = new System.Drawing.Size(100, 60);
            this.btnAddTipe.TabIndex = 0;
            this.btnAddTipe.UseVisualStyleBackColor = false;
            this.btnAddTipe.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvtipekamar
            // 
            this.dgvtipekamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipekamar.Location = new System.Drawing.Point(42, 183);
            this.dgvtipekamar.Name = "dgvtipekamar";
            this.dgvtipekamar.Size = new System.Drawing.Size(571, 217);
            this.dgvtipekamar.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(42, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(540, 35);
            this.label20.TabIndex = 26;
            this.label20.Text = "Manajemen Tipe Kamar";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTipeKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.pnlTipeKamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipeKamar";
            this.Text = "FrmTipeKamar";
            this.Load += new System.EventHandler(this.FrmTipeKamar_Load);
            this.pnlTipeKamar.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipekamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTipeKamar;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox hargaTipe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox namaTipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refreshTipeKamar;
        private System.Windows.Forms.Button btnAddTipe;
        private System.Windows.Forms.DataGridView dgvtipekamar;
        private System.Windows.Forms.Label label20;
    }
}