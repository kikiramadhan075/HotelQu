﻿
namespace sample
{
    partial class FrmTambahKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTambahKamar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnAddKamar = new System.Windows.Forms.Button();
            this.cmbCariTipeKamar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnBatal);
            this.groupBox1.Controls.Add(this.btnAddKamar);
            this.groupBox1.Controls.Add(this.cmbCariTipeKamar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Data Kamar";
            // 
            // btnBatal
            // 
            this.btnBatal.ForeColor = System.Drawing.Color.Black;
            this.btnBatal.Location = new System.Drawing.Point(239, 154);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(54, 42);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddKamar
            // 
            this.btnAddKamar.ForeColor = System.Drawing.Color.Black;
            this.btnAddKamar.Location = new System.Drawing.Point(301, 154);
            this.btnAddKamar.Name = "btnAddKamar";
            this.btnAddKamar.Size = new System.Drawing.Size(97, 42);
            this.btnAddKamar.TabIndex = 4;
            this.btnAddKamar.Text = "Tambah Data";
            this.btnAddKamar.UseVisualStyleBackColor = true;
            this.btnAddKamar.Click += new System.EventHandler(this.btnAddKamar_Click);
            // 
            // cmbCariTipeKamar
            // 
            this.cmbCariTipeKamar.FormattingEnabled = true;
            this.cmbCariTipeKamar.Location = new System.Drawing.Point(113, 18);
            this.cmbCariTipeKamar.Name = "cmbCariTipeKamar";
            this.cmbCariTipeKamar.Size = new System.Drawing.Size(180, 21);
            this.cmbCariTipeKamar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deskripsi Kamar :";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(113, 42);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(285, 103);
            this.des.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipe Kamar :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTambahKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTambahKamar";
            this.Text = "FrmTambahKamar";
            this.Load += new System.EventHandler(this.FrmTambahKamar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnAddKamar;
        private System.Windows.Forms.ComboBox cmbCariTipeKamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label1;
    }
}