namespace Menudemo
{
    partial class fsetting
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.btnkt = new System.Windows.Forms.Label();
            this.btnde = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnset = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(18, 16);
            this.dgvA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 51;
            this.dgvA.RowTemplate.Height = 24;
            this.dgvA.Size = new System.Drawing.Size(412, 401);
            this.dgvA.TabIndex = 0;
            this.dgvA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvA_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.dgvA);
            this.panel4.Controls.Add(this.txtKT);
            this.panel4.Controls.Add(this.btnkt);
            this.panel4.Controls.Add(this.btnde);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Controls.Add(this.txt3);
            this.panel4.Controls.Add(this.txt2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnset);
            this.panel4.Controls.Add(this.txt4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 129);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 535);
            this.panel4.TabIndex = 4;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Image = global::Menudemo.Properties.Resources.update;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(160, 430);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 36);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtKT
            // 
            this.txtKT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtKT.Location = new System.Drawing.Point(765, 205);
            this.txtKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKT.Multiline = true;
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(244, 37);
            this.txtKT.TabIndex = 24;
            // 
            // btnkt
            // 
            this.btnkt.AutoSize = true;
            this.btnkt.BackColor = System.Drawing.Color.Transparent;
            this.btnkt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkt.Location = new System.Drawing.Point(498, 217);
            this.btnkt.Name = "btnkt";
            this.btnkt.Size = new System.Drawing.Size(204, 25);
            this.btnkt.TabIndex = 23;
            this.btnkt.Text = "Nhập lại mật khẩu:";
            // 
            // btnde
            // 
            this.btnde.BackColor = System.Drawing.SystemColors.Menu;
            this.btnde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnde.Image = global::Menudemo.Properties.Resources.delete1;
            this.btnde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnde.Location = new System.Drawing.Point(668, 402);
            this.btnde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnde.Name = "btnde";
            this.btnde.Size = new System.Drawing.Size(107, 46);
            this.btnde.TabIndex = 22;
            this.btnde.Text = "Xóa";
            this.btnde.UseVisualStyleBackColor = false;
            this.btnde.Click += new System.EventHandler(this.btnde_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.Menu;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = global::Menudemo.Properties.Resources.add;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(518, 402);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 46);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt3.Location = new System.Drawing.Point(766, 148);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(241, 37);
            this.txt3.TabIndex = 20;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt2.Location = new System.Drawing.Point(765, 93);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(244, 37);
            this.txt2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mật khẩu:";
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.SystemColors.Menu;
            this.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnset.Image = global::Menudemo.Properties.Resources.pas1;
            this.btnset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnset.Location = new System.Drawing.Point(816, 402);
            this.btnset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(152, 46);
            this.btnset.TabIndex = 4;
            this.btnset.Text = "  Đặt lại mật khẩu";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt4.Location = new System.Drawing.Point(766, 261);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(243, 37);
            this.txt4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại tài khoản:";
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt5.Location = new System.Drawing.Point(766, 313);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(243, 37);
            this.txt5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên hiển thị:";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt1.Location = new System.Drawing.Point(766, 41);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(243, 37);
            this.txt1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tài khoản:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gray;
            this.button4.Image = global::Menudemo.Properties.Resources.edit;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(309, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Sửa";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::Menudemo.Properties.Resources.delete1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(166, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 46);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Menudemo.Properties.Resources.add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thêm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(530, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 70);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "ACCOUNT SETTING";
            // 
            // fsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 675);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fsetting";
            this.Text = "Cài đặt tài khoản";
            this.Load += new System.EventHandler(this.fsetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnde;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.Label btnkt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}