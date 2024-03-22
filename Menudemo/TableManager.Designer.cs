namespace Menudemo
{
    partial class TableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_HoaDon = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_TT = new System.Windows.Forms.Panel();
            this.total_price = new System.Windows.Forms.TextBox();
            this.cb_switch = new System.Windows.Forms.ComboBox();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.nb_Discount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nb_FoodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_Themmon = new System.Windows.Forms.Button();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.fl_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            this.panel_TT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Discount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_FoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lv_HoaDon);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(639, 109);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 606);
            this.panel2.TabIndex = 1;
            // 
            // lv_HoaDon
            // 
            this.lv_HoaDon.BackColor = System.Drawing.Color.White;
            this.lv_HoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_HoaDon.GridLines = true;
            this.lv_HoaDon.HideSelection = false;
            this.lv_HoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.lv_HoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_HoaDon.Name = "lv_HoaDon";
            this.lv_HoaDon.Size = new System.Drawing.Size(438, 605);
            this.lv_HoaDon.TabIndex = 1;
            this.lv_HoaDon.UseCompatibleStateImageBehavior = false;
            this.lv_HoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Món ăn";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lương";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá tiền";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng cộng";
            this.columnHeader5.Width = 139;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 710);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 78);
            this.panel4.TabIndex = 0;
            // 
            // panel_TT
            // 
            this.panel_TT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_TT.Controls.Add(this.total_price);
            this.panel_TT.Controls.Add(this.cb_switch);
            this.panel_TT.Controls.Add(this.btn_SwitchTable);
            this.panel_TT.Controls.Add(this.nb_Discount);
            this.panel_TT.Controls.Add(this.button1);
            this.panel_TT.Controls.Add(this.btn_CheckOut);
            this.panel_TT.Location = new System.Drawing.Point(639, 722);
            this.panel_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_TT.Name = "panel_TT";
            this.panel_TT.Size = new System.Drawing.Size(438, 76);
            this.panel_TT.TabIndex = 2;
            // 
            // total_price
            // 
            this.total_price.AcceptsReturn = true;
            this.total_price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.ForeColor = System.Drawing.Color.Red;
            this.total_price.Location = new System.Drawing.Point(217, 20);
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Size = new System.Drawing.Size(126, 38);
            this.total_price.TabIndex = 9;
            this.total_price.Text = "0";
            this.total_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_price.TextChanged += new System.EventHandler(this.total_price_TextChanged);
            // 
            // cb_switch
            // 
            this.cb_switch.FormattingEnabled = true;
            this.cb_switch.Location = new System.Drawing.Point(3, 46);
            this.cb_switch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_switch.Name = "cb_switch";
            this.cb_switch.Size = new System.Drawing.Size(100, 28);
            this.cb_switch.TabIndex = 8;
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btn_SwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SwitchTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SwitchTable.Location = new System.Drawing.Point(3, 4);
            this.btn_SwitchTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(100, 40);
            this.btn_SwitchTable.TabIndex = 6;
            this.btn_SwitchTable.Text = "Chuyển Bàn";
            this.btn_SwitchTable.UseVisualStyleBackColor = false;
            this.btn_SwitchTable.Click += new System.EventHandler(this.btn_SwitchTable_Click);
            // 
            // nb_Discount
            // 
            this.nb_Discount.Location = new System.Drawing.Point(121, 47);
            this.nb_Discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nb_Discount.Name = "nb_Discount";
            this.nb_Discount.Size = new System.Drawing.Size(90, 27);
            this.nb_Discount.TabIndex = 5;
            this.nb_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(121, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giảm Giá";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut.Location = new System.Drawing.Point(349, 4);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(86, 68);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Thanh Toán";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nb_FoodCount);
            this.panel1.Controls.Add(this.btn_Themmon);
            this.panel1.Controls.Add(this.cb_Food);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Location = new System.Drawing.Point(639, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 86);
            this.panel1.TabIndex = 3;
            // 
            // nb_FoodCount
            // 
            this.nb_FoodCount.Location = new System.Drawing.Point(382, 25);
            this.nb_FoodCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nb_FoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nb_FoodCount.Name = "nb_FoodCount";
            this.nb_FoodCount.Size = new System.Drawing.Size(56, 27);
            this.nb_FoodCount.TabIndex = 3;
            this.nb_FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Themmon
            // 
            this.btn_Themmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btn_Themmon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Themmon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Themmon.Location = new System.Drawing.Point(289, 4);
            this.btn_Themmon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Themmon.Name = "btn_Themmon";
            this.btn_Themmon.Size = new System.Drawing.Size(86, 68);
            this.btn_Themmon.TabIndex = 2;
            this.btn_Themmon.Text = "Thêm Món";
            this.btn_Themmon.UseVisualStyleBackColor = false;
            this.btn_Themmon.Click += new System.EventHandler(this.btn_Themmon_Click);
            // 
            // cb_Food
            // 
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(0, 41);
            this.cb_Food.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(283, 28);
            this.cb_Food.TabIndex = 1;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(0, 4);
            this.cb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(283, 28);
            this.cb_category.TabIndex = 0;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // fl_Table
            // 
            this.fl_Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fl_Table.AutoScroll = true;
            this.fl_Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fl_Table.Location = new System.Drawing.Point(14, 15);
            this.fl_Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fl_Table.Name = "fl_Table";
            this.fl_Table.Size = new System.Drawing.Size(620, 788);
            this.fl_Table.TabIndex = 4;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 818);
            this.Controls.Add(this.fl_Table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_TT);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableManager";
            this.Text = "TableManager";
            this.panel2.ResumeLayout(false);
            this.panel_TT.ResumeLayout(false);
            this.panel_TT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Discount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nb_FoodCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_HoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_TT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Themmon;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.NumericUpDown nb_FoodCount;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.FlowLayoutPanel fl_Table;
        private System.Windows.Forms.NumericUpDown nb_Discount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_switch;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox total_price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}