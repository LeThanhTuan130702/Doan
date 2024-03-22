namespace Menudemo
{
    partial class MenuForm
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
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_home = new System.Windows.Forms.Label();
            this.pb_collapse = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Cate = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_Min = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pn_body = new System.Windows.Forms.Panel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_collapse)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(61)))), ((int)(((byte)(94)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btn_Home);
            this.sidebar.Controls.Add(this.btn_Staff);
            this.sidebar.Controls.Add(this.btn_Products);
            this.sidebar.Controls.Add(this.btn_Cate);
            this.sidebar.Controls.Add(this.btn_Setting);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sidebar.MaximumSize = new System.Drawing.Size(272, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 845);
            this.sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_home);
            this.panel1.Controls.Add(this.pb_collapse);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 151);
            this.panel1.TabIndex = 7;
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.White;
            this.lb_home.Location = new System.Drawing.Point(120, 58);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(65, 28);
            this.lb_home.TabIndex = 1;
            this.lb_home.Text = "Home";
            // 
            // pb_collapse
            // 
            this.pb_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_collapse.Image = global::Menudemo.Properties.Resources.icons8_category_50;
            this.pb_collapse.Location = new System.Drawing.Point(10, 41);
            this.pb_collapse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pb_collapse.Name = "pb_collapse";
            this.pb_collapse.Size = new System.Drawing.Size(60, 51);
            this.pb_collapse.TabIndex = 0;
            this.pb_collapse.TabStop = false;
            this.pb_collapse.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Home.Image = global::Menudemo.Properties.Resources.icons8_home_501;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(3, 166);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(225, 90);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click_1);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Staff.Image = global::Menudemo.Properties.Resources.icons8_staff_50;
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staff.Location = new System.Drawing.Point(3, 266);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(225, 90);
            this.btn_Staff.TabIndex = 12;
            this.btn_Staff.Text = "Nhân Viên";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.BackColor = System.Drawing.Color.Transparent;
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Products.Image = global::Menudemo.Properties.Resources.icons8_product_50__1_;
            this.btn_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.Location = new System.Drawing.Point(3, 366);
            this.btn_Products.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(225, 90);
            this.btn_Products.TabIndex = 10;
            this.btn_Products.Text = "Hàng Hóa";
            this.btn_Products.UseVisualStyleBackColor = false;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Cate
            // 
            this.btn_Cate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cate.FlatAppearance.BorderSize = 0;
            this.btn_Cate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cate.Image = global::Menudemo.Properties.Resources.icons8_medium_priority_64__1_;
            this.btn_Cate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cate.Location = new System.Drawing.Point(3, 466);
            this.btn_Cate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Cate.Name = "btn_Cate";
            this.btn_Cate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Cate.Size = new System.Drawing.Size(263, 90);
            this.btn_Cate.TabIndex = 16;
            this.btn_Cate.Text = "Nhà Cung Cấp";
            this.btn_Cate.UseVisualStyleBackColor = false;
            this.btn_Cate.Click += new System.EventHandler(this.btn_Cate_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Setting.Image = global::Menudemo.Properties.Resources.icons8_report_50;
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(3, 566);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(225, 90);
            this.btn_Setting.TabIndex = 15;
            this.btn_Setting.Text = "Báo Cáo";
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.guna2Panel1.Controls.Add(this.lb_name);
            this.guna2Panel1.Controls.Add(this.btn_Min);
            this.guna2Panel1.Controls.Add(this.btn_close);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(272, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1257, 62);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.DimGray;
            this.lb_name.Location = new System.Drawing.Point(38, 18);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 28);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Home";
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Min.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btn_Min.CustomClick = true;
            this.btn_Min.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btn_Min.IconColor = System.Drawing.Color.White;
            this.btn_Min.Location = new System.Drawing.Point(1127, 18);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(50, 26);
            this.btn_Min.TabIndex = 4;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_close.CustomClick = true;
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1195, 18);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 26);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // pn_body
            // 
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_body.Location = new System.Drawing.Point(272, 62);
            this.pn_body.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1257, 783);
            this.pn_body.TabIndex = 5;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1529, 845);
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_collapse)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.PictureBox pb_collapse;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Setting;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lb_name;
        private Guna.UI2.WinForms.Guna2ControlBox btn_Min;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private System.Windows.Forms.Panel pn_body;
        private System.Windows.Forms.Button btn_Cate;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}