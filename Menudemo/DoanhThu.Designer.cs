namespace Menudemo
{
    partial class DoanhThu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.USP_GetListBillByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSPGetListBillByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangDataSet1 = new Menudemo.KhachHangDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_bill = new System.Windows.Forms.TabPage();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.DateTimePicker();
            this.Checkin = new System.Windows.Forms.DateTimePicker();
            this.tc_father = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txtBIll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvBillinfo = new System.Windows.Forms.DataGridView();
            this.uSP_GetListBillByDateTableAdapter = new Menudemo.KhachHangDataSet1TableAdapters.USP_GetListBillByDateTableAdapter();
            this.uSPGetListBillByDateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataSet1)).BeginInit();
            this.tab_bill.SuspendLayout();
            this.panel_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tc_father.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPGetListBillByDateBindingSource
            // 
            this.uSPGetListBillByDateBindingSource.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource.DataSource = this.khachHangDataSet1;
            // 
            // khachHangDataSet1
            // 
            this.khachHangDataSet1.DataSetName = "KhachHangDataSet1";
            this.khachHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 578);
            this.panel1.TabIndex = 0;
            // 
            // tab_bill
            // 
            this.tab_bill.Controls.Add(this.panel_admin);
            this.tab_bill.Controls.Add(this.panel5);
            this.tab_bill.Location = new System.Drawing.Point(4, 29);
            this.tab_bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_bill.Name = "tab_bill";
            this.tab_bill.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_bill.Size = new System.Drawing.Size(1107, 546);
            this.tab_bill.TabIndex = 0;
            this.tab_bill.Text = "Doanh Thu";
            // 
            // panel_admin
            // 
            this.panel_admin.BackColor = System.Drawing.Color.White;
            this.panel_admin.Controls.Add(this.txtSearch);
            this.panel_admin.Controls.Add(this.lb_Search);
            this.panel_admin.Controls.Add(this.button9);
            this.panel_admin.Controls.Add(this.dataGridView1);
            this.panel_admin.Location = new System.Drawing.Point(0, 72);
            this.panel_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(1111, 835);
            this.panel_admin.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(680, 27);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 39);
            this.txtSearch.TabIndex = 42;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(676, 4);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(53, 20);
            this.lb_Search.TabIndex = 41;
            this.lb_Search.Text = "Search";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(63, 685);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(476, 129);
            this.button9.TabIndex = 40;
            this.button9.Text = "Chi Tiết Đơn Hàng";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 401);
            this.dataGridView1.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnThongKe);
            this.panel5.Controls.Add(this.Checkout);
            this.panel5.Controls.Add(this.Checkin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1101, 538);
            this.panel5.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(497, 1);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(86, 59);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Checkout
            // 
            this.Checkout.CustomFormat = "";
            this.Checkout.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkout.Location = new System.Drawing.Point(589, 15);
            this.Checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(497, 43);
            this.Checkout.TabIndex = 1;
            // 
            // Checkin
            // 
            this.Checkin.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Checkin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkin.Location = new System.Drawing.Point(25, 15);
            this.Checkin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(466, 43);
            this.Checkin.TabIndex = 0;
            // 
            // tc_father
            // 
            this.tc_father.Controls.Add(this.tab_bill);
            this.tc_father.Controls.Add(this.tabPage1);
            this.tc_father.Controls.Add(this.tabPage2);
            this.tc_father.Location = new System.Drawing.Point(13, 15);
            this.tc_father.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tc_father.Multiline = true;
            this.tc_father.Name = "tc_father";
            this.tc_father.SelectedIndex = 0;
            this.tc_father.Size = new System.Drawing.Size(1115, 579);
            this.tc_father.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1107, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "BillList";
            reportDataSource1.Value = this.uSPGetListBillByDateBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Menudemo.RMS.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1108, 550);
            this.reportViewer2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txtBIll);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtgvBillinfo);
            this.panel2.Location = new System.Drawing.Point(-2, -144);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 835);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(938, 211);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(166, 39);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtBIll
            // 
            this.txtBIll.Location = new System.Drawing.Point(323, 211);
            this.txtBIll.Multiline = true;
            this.txtBIll.Name = "txtBIll";
            this.txtBIll.Size = new System.Drawing.Size(428, 39);
            this.txtBIll.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số phiếu hóa đơn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(680, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 39);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search";
            // 
            // dtgvBillinfo
            // 
            this.dtgvBillinfo.AllowUserToAddRows = false;
            this.dtgvBillinfo.AllowUserToDeleteRows = false;
            this.dtgvBillinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBillinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillinfo.Location = new System.Drawing.Point(3, 293);
            this.dtgvBillinfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvBillinfo.Name = "dtgvBillinfo";
            this.dtgvBillinfo.ReadOnly = true;
            this.dtgvBillinfo.RowHeadersWidth = 51;
            this.dtgvBillinfo.RowTemplate.Height = 24;
            this.dtgvBillinfo.Size = new System.Drawing.Size(1101, 401);
            this.dtgvBillinfo.TabIndex = 39;
            // 
            // uSP_GetListBillByDateTableAdapter
            // 
            this.uSP_GetListBillByDateTableAdapter.ClearBeforeFill = true;
            // 
            // uSPGetListBillByDateBindingSource1
            // 
            this.uSPGetListBillByDateBindingSource1.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource1.DataSource = this.khachHangDataSet1;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 661);
            this.Controls.Add(this.tc_father);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataSet1)).EndInit();
            this.tab_bill.ResumeLayout(false);
            this.panel_admin.ResumeLayout(false);
            this.panel_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tc_father.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_bill;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker Checkout;
        private System.Windows.Forms.DateTimePicker Checkin;
        private System.Windows.Forms.TabControl tc_father;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lb_Search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateBindingSource;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateBindingSource;
        private KhachHangDataSet1 khachHangDataSet1;
        private KhachHangDataSet1TableAdapters.USP_GetListBillByDateTableAdapter uSP_GetListBillByDateTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        public System.Windows.Forms.TextBox txtBIll;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvBillinfo;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateBindingSource1;
    }
}