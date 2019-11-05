namespace KiemTra
{
    partial class Addlienlac
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
            this.txtmanhom = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtema = new System.Windows.Forms.TextBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmanhom
            // 
            this.txtmanhom.AutoSize = true;
            this.txtmanhom.Location = new System.Drawing.Point(54, 29);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(51, 13);
            this.txtmanhom.TabIndex = 0;
            this.txtmanhom.Text = "Mã nhóm";
            // 
            // txttengoi
            // 
            this.txttengoi.AutoSize = true;
            this.txttengoi.Location = new System.Drawing.Point(54, 76);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(45, 13);
            this.txttengoi.TabIndex = 1;
            this.txttengoi.Text = "Tên Gọi";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(54, 140);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(32, 13);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "Email";
            // 
            // txtsdt
            // 
            this.txtsdt.AutoSize = true;
            this.txtsdt.Location = new System.Drawing.Point(54, 194);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(29, 13);
            this.txtsdt.TabIndex = 3;
            this.txtsdt.Text = "SDT";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(197, 29);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(197, 76);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 5;
            // 
            // txtema
            // 
            this.txtema.Location = new System.Drawing.Point(197, 133);
            this.txtema.Name = "txtema";
            this.txtema.Size = new System.Drawing.Size(100, 20);
            this.txtema.TabIndex = 6;
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(197, 191);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 7;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(118, 245);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Cập Nhập";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(222, 245);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 9;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // Addlienlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 290);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.txtema);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttengoi);
            this.Controls.Add(this.txtmanhom);
            this.Name = "Addlienlac";
            this.Text = "Addlienlac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Addlienlac_FormClosed);
            this.Load += new System.EventHandler(this.Addlienlac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtmanhom;
        private System.Windows.Forms.Label txttengoi;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtsdt;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtema;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnhuy;
    }
}