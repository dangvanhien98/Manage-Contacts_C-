namespace KiemTra
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvnhom = new System.Windows.Forms.DataGridView();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvlienlac = new System.Windows.Forms.DataGridView();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoalienlac = new System.Windows.Forms.Button();
            this.btnthemlienlac = new System.Windows.Forms.Button();
            this.btnxoanhom = new System.Windows.Forms.Button();
            this.btnthemnhom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhom)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlienlac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnxoalienlac);
            this.panel1.Controls.Add(this.btnthemlienlac);
            this.panel1.Controls.Add(this.btnxoanhom);
            this.panel1.Controls.Add(this.btnthemnhom);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 44);
            this.panel1.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(650, 12);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(132, 20);
            this.txttimkiem.TabIndex = 5;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvnhom);
            this.panel2.Location = new System.Drawing.Point(6, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 336);
            this.panel2.TabIndex = 1;
            // 
            // dtgvnhom
            // 
            this.dtgvnhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dtgvnhom.Location = new System.Drawing.Point(3, 3);
            this.dtgvnhom.Name = "dtgvnhom";
            this.dtgvnhom.Size = new System.Drawing.Size(192, 327);
            this.dtgvnhom.TabIndex = 0;
            this.dtgvnhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvnhom_CellClick);
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Thêm nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvlienlac);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(221, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 221);
            this.panel3.TabIndex = 2;
            // 
            // dtgvlienlac
            // 
            this.dtgvlienlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlienlac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.dtgvlienlac.Location = new System.Drawing.Point(3, 3);
            this.dtgvlienlac.Name = "dtgvlienlac";
            this.dtgvlienlac.Size = new System.Drawing.Size(564, 214);
            this.dtgvlienlac.TabIndex = 4;
            this.dtgvlienlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvlienlac_CellClick);
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "Tên gọi";
            this.TenGoi.Name = "TenGoi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Emai";
            this.Email.Name = "Email";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 107);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "[Tên gọi]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // txttengoi
            // 
            this.txttengoi.Location = new System.Drawing.Point(356, 294);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(176, 20);
            this.txttengoi.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(356, 334);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(176, 20);
            this.txtemail.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(356, 370);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(176, 20);
            this.txtsdt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(525, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ cần tìm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnxoalienlac
            // 
            this.btnxoalienlac.Image = global::KiemTra.Properties.Resources.icons8_delete_16;
            this.btnxoalienlac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoalienlac.Location = new System.Drawing.Point(421, 6);
            this.btnxoalienlac.Name = "btnxoalienlac";
            this.btnxoalienlac.Size = new System.Drawing.Size(89, 35);
            this.btnxoalienlac.TabIndex = 3;
            this.btnxoalienlac.Text = "Xóa liên lạc";
            this.btnxoalienlac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoalienlac.UseVisualStyleBackColor = true;
            this.btnxoalienlac.Click += new System.EventHandler(this.Btnxoalienlac_Click);
            // 
            // btnthemlienlac
            // 
            this.btnthemlienlac.Image = global::KiemTra.Properties.Resources.icons8_add_50;
            this.btnthemlienlac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemlienlac.Location = new System.Drawing.Point(277, 6);
            this.btnthemlienlac.Name = "btnthemlienlac";
            this.btnthemlienlac.Size = new System.Drawing.Size(114, 35);
            this.btnthemlienlac.TabIndex = 2;
            this.btnthemlienlac.Text = "Thêm liên lạc";
            this.btnthemlienlac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemlienlac.UseVisualStyleBackColor = true;
            this.btnthemlienlac.Click += new System.EventHandler(this.Btnthemlienlac_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = global::KiemTra.Properties.Resources.icons8_delete_16;
            this.btnxoanhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoanhom.Location = new System.Drawing.Point(162, 6);
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(92, 35);
            this.btnxoanhom.TabIndex = 1;
            this.btnxoanhom.Text = "Xóa nhóm";
            this.btnxoanhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoanhom.UseVisualStyleBackColor = true;
            this.btnxoanhom.Click += new System.EventHandler(this.Btnxoanhom_Click);
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Image = global::KiemTra.Properties.Resources.icons8_add_50;
            this.btnthemnhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemnhom.Location = new System.Drawing.Point(15, 6);
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(110, 35);
            this.btnthemnhom.TabIndex = 0;
            this.btnthemnhom.Text = "Thêm nhóm";
            this.btnthemnhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemnhom.UseVisualStyleBackColor = true;
            this.btnthemnhom.Click += new System.EventHandler(this.Btnthemnhom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttengoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - ĐẶNG VĂN HIỀN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhom)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlienlac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoalienlac;
        private System.Windows.Forms.Button btnthemlienlac;
        private System.Windows.Forms.Button btnxoanhom;
        private System.Windows.Forms.Button btnthemnhom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvnhom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvlienlac;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.TextBox txttengoi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}

