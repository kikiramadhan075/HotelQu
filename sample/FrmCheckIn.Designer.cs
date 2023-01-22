
namespace sample
{
    partial class FrmCheckIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noTelpon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alamatTamu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namaTamu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTamu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deskripsiKamar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNoKamar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hargaKamar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.namaTipe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idTipe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateCekOut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateCekIn = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.noTelpon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.alamatTamu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.namaTamu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idTamu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 94);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Tamu";
            // 
            // noTelpon
            // 
            this.noTelpon.Location = new System.Drawing.Point(74, 49);
            this.noTelpon.Name = "noTelpon";
            this.noTelpon.ReadOnly = true;
            this.noTelpon.Size = new System.Drawing.Size(137, 20);
            this.noTelpon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telpon    :";
            // 
            // alamatTamu
            // 
            this.alamatTamu.Location = new System.Drawing.Point(471, 50);
            this.alamatTamu.Name = "alamatTamu";
            this.alamatTamu.ReadOnly = true;
            this.alamatTamu.Size = new System.Drawing.Size(165, 20);
            this.alamatTamu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(340, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alamat         :";
            // 
            // namaTamu
            // 
            this.namaTamu.Location = new System.Drawing.Point(471, 18);
            this.namaTamu.Name = "namaTamu";
            this.namaTamu.ReadOnly = true;
            this.namaTamu.Size = new System.Drawing.Size(165, 20);
            this.namaTamu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(338, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Tamu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idTamu
            // 
            this.idTamu.Location = new System.Drawing.Point(74, 19);
            this.idTamu.Name = "idTamu";
            this.idTamu.Size = new System.Drawing.Size(100, 20);
            this.idTamu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tamu  :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = global::sample.Properties.Resources.refresh_button1;
            this.button1.Location = new System.Drawing.Point(180, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::sample.Properties.Resources.tel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.deskripsiKamar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbNoKamar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.hargaKamar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.namaTipe);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idTipe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 169);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Kamar";
            // 
            // deskripsiKamar
            // 
            this.deskripsiKamar.Location = new System.Drawing.Point(118, 78);
            this.deskripsiKamar.Multiline = true;
            this.deskripsiKamar.Name = "deskripsiKamar";
            this.deskripsiKamar.ReadOnly = true;
            this.deskripsiKamar.Size = new System.Drawing.Size(518, 66);
            this.deskripsiKamar.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Deskripsi Kamar      :";
            // 
            // cmbNoKamar
            // 
            this.cmbNoKamar.FormattingEnabled = true;
            this.cmbNoKamar.Location = new System.Drawing.Point(117, 46);
            this.cmbNoKamar.Name = "cmbNoKamar";
            this.cmbNoKamar.Size = new System.Drawing.Size(94, 21);
            this.cmbNoKamar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "No Kamar Tersedia :";
            // 
            // hargaKamar
            // 
            this.hargaKamar.Location = new System.Drawing.Point(489, 45);
            this.hargaKamar.Name = "hargaKamar";
            this.hargaKamar.ReadOnly = true;
            this.hargaKamar.Size = new System.Drawing.Size(147, 20);
            this.hargaKamar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(342, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga per hari :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Image = global::sample.Properties.Resources.refresh_button;
            this.button2.Location = new System.Drawing.Point(180, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // namaTipe
            // 
            this.namaTipe.Location = new System.Drawing.Point(489, 19);
            this.namaTipe.Name = "namaTipe";
            this.namaTipe.ReadOnly = true;
            this.namaTipe.Size = new System.Drawing.Size(147, 20);
            this.namaTipe.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(340, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipe Kamar      :";
            // 
            // idTipe
            // 
            this.idTipe.Location = new System.Drawing.Point(117, 19);
            this.idTipe.Name = "idTipe";
            this.idTipe.Size = new System.Drawing.Size(57, 20);
            this.idTipe.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID Tipe                    :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dateCekOut);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateCekIn);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 83);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Cek In - Cek Out";
            // 
            // dateCekOut
            // 
            this.dateCekOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCekOut.Location = new System.Drawing.Point(118, 49);
            this.dateCekOut.Name = "dateCekOut";
            this.dateCekOut.Size = new System.Drawing.Size(279, 20);
            this.dateCekOut.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tanggal Cek Out :";
            // 
            // dateCekIn
            // 
            this.dateCekIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCekIn.Location = new System.Drawing.Point(118, 19);
            this.dateCekIn.Name = "dateCekIn";
            this.dateCekIn.Size = new System.Drawing.Size(279, 20);
            this.dateCekIn.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tanggal Cek In :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "SIMPAN";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = "BATAL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(698, 568);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCheckIn";
            this.Text = "FrmCheckIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox noTelpon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alamatTamu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox namaTamu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTamu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox deskripsiKamar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNoKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hargaKamar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox namaTipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTipe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateCekOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateCekIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}