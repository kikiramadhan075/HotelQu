
namespace sample
{
    partial class MainLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrName = new System.Windows.Forms.TextBox();
            this.psWord = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usrName
            // 
            this.usrName.Location = new System.Drawing.Point(137, 61);
            this.usrName.Name = "usrName";
            this.usrName.Size = new System.Drawing.Size(136, 20);
            this.usrName.TabIndex = 2;
            // 
            // psWord
            // 
            this.psWord.Location = new System.Drawing.Point(137, 102);
            this.psWord.Name = "psWord";
            this.psWord.Size = new System.Drawing.Size(136, 20);
            this.psWord.TabIndex = 3;
            this.psWord.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(180, 147);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(269, 147);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(75, 23);
            this.btnbatal.TabIndex = 5;
            this.btnbatal.Text = "BATAL";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 43);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 182);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.psWord);
            this.Controls.Add(this.usrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MainLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrName;
        private System.Windows.Forms.TextBox psWord;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

