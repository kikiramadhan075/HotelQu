
namespace sample
{
    partial class FrmUbahPsWord
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
            this.pnlGantiPassword = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.pswBaru = new System.Windows.Forms.TextBox();
            this.pswLama = new System.Windows.Forms.TextBox();
            this.usrNameDefault = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnGantiPsWord = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlGantiPassword.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGantiPassword
            // 
            this.pnlGantiPassword.Controls.Add(this.btnBatal);
            this.pnlGantiPassword.Controls.Add(this.groupBox14);
            this.pnlGantiPassword.Controls.Add(this.label33);
            this.pnlGantiPassword.Controls.Add(this.btnGantiPsWord);
            this.pnlGantiPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGantiPassword.Location = new System.Drawing.Point(0, 0);
            this.pnlGantiPassword.Name = "pnlGantiPassword";
            this.pnlGantiPassword.Size = new System.Drawing.Size(605, 436);
            this.pnlGantiPassword.TabIndex = 12;
            this.pnlGantiPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGantiPassword_Paint);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.pswBaru);
            this.groupBox14.Controls.Add(this.pswLama);
            this.groupBox14.Controls.Add(this.usrNameDefault);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Location = new System.Drawing.Point(42, 60);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(473, 91);
            this.groupBox14.TabIndex = 27;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Data Password";
            // 
            // pswBaru
            // 
            this.pswBaru.Location = new System.Drawing.Point(193, 65);
            this.pswBaru.Name = "pswBaru";
            this.pswBaru.Size = new System.Drawing.Size(244, 20);
            this.pswBaru.TabIndex = 6;
            // 
            // pswLama
            // 
            this.pswLama.Location = new System.Drawing.Point(193, 39);
            this.pswLama.Name = "pswLama";
            this.pswLama.Size = new System.Drawing.Size(244, 20);
            this.pswLama.TabIndex = 5;
            // 
            // usrNameDefault
            // 
            this.usrNameDefault.Location = new System.Drawing.Point(193, 13);
            this.usrNameDefault.Name = "usrNameDefault";
            this.usrNameDefault.ReadOnly = true;
            this.usrNameDefault.Size = new System.Drawing.Size(244, 20);
            this.usrNameDefault.TabIndex = 4;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(6, 66);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "Password Baru      :";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(6, 42);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 17);
            this.label35.TabIndex = 2;
            this.label35.Text = "Password Lama     :";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(6, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "Username              :";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label33.Location = new System.Drawing.Point(42, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(540, 35);
            this.label33.TabIndex = 26;
            this.label33.Text = "Ganti Password";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGantiPsWord
            // 
            this.btnGantiPsWord.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGantiPsWord.FlatAppearance.BorderSize = 0;
            this.btnGantiPsWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGantiPsWord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGantiPsWord.Location = new System.Drawing.Point(415, 168);
            this.btnGantiPsWord.Name = "btnGantiPsWord";
            this.btnGantiPsWord.Size = new System.Drawing.Size(100, 35);
            this.btnGantiPsWord.TabIndex = 14;
            this.btnGantiPsWord.Text = "Ganti Password";
            this.btnGantiPsWord.UseVisualStyleBackColor = false;
            this.btnGantiPsWord.Click += new System.EventHandler(this.btnGantiPsWord_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(334, 168);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 35);
            this.btnBatal.TabIndex = 28;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FrmUbahPsWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 436);
            this.Controls.Add(this.pnlGantiPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUbahPsWord";
            this.Text = "FrmUbahPsWord";
            this.pnlGantiPassword.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGantiPassword;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox pswBaru;
        private System.Windows.Forms.TextBox pswLama;
        private System.Windows.Forms.TextBox usrNameDefault;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnGantiPsWord;
        private System.Windows.Forms.Button btnBatal;
    }
}