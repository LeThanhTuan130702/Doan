using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo
{
    public partial class TableManager : Form
    {
        private Account Account;

        public TableManager(Account account)
        {
            InitializeComponent();
            this.Account = account;
            LoadTable();
            LoadCategory();
            loadcbSwitch();
            
        }
        void loadcbSwitch()
        {
            cb_switch.DataSource= TableDAO.Instance.LoadTableList();
            cb_switch.DisplayMember= "Name";
        }
        void LoadTable()
        {
            fl_Table.Controls.Clear();

            List<Table> tablelist= TableDAO.Instance.LoadTableList();
            foreach (Table table in tablelist)
            {
                Button button=new Button() { Width=TableDAO.TableWidth,Height=TableDAO.TableHeight};
                bool Isempty= MenuDAO.Instance.IsEmpty(table.Id);
                if(Isempty )
                {
                    table.Status="Trống";
                }    
                button.Text = table.Name +Environment.NewLine + table.Status;
                button.Click += Button_Click;
                button.Tag = table;
                switch (table.Status)
                {
                    case "Trống":
                        button.BackColor=Color.Aqua; break;
                    default: button.BackColor=Color.Gray; break;
                }

                fl_Table.Controls.Add(button);


            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int TableId = ((sender as Button).Tag as Table).Id;
            lv_HoaDon.Tag = (sender as Button).Tag;
            ShowBill(TableId);
        }

        private void ShowBill(int id )
        {
            lv_HoaDon.Items.Clear();
            List<Menu1> billInfos = MenuDAO.Instance.GetMenubyTable(id);
            double TotalPrice = 0;
            foreach(Menu1 item in billInfos)
            {
                ListViewItem listViewItem= new ListViewItem(item.Foodname.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Totalprice.ToString());
                TotalPrice += item.Totalprice;
                lv_HoaDon.Items.Add(listViewItem);

            }
            CultureInfo cultureInfo = new CultureInfo("vi");
            total_price.Text = TotalPrice.ToString("c",cultureInfo);
        }

        private void total_price_TextChanged(object sender, EventArgs e)
        {

        }
        void LoadCategory()
        {
            List<Category> categories = CategoryDAO.Instance.GetCategory();
            cb_category.DataSource= categories;
            cb_category.DisplayMember="name";

        }
        void LoadFoodByCategory(int id)
        {
            List<Food> foods=FoodDAO.Instance.GetFoodByCategory(id);
            if (foods.Count <=0 )
            {
                cb_Food.Text = "Không có món ";
                return;
            }
            cb_Food.DataSource= foods;
            cb_Food.DisplayMember="name";
            
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null) {
                return;
            }
            Category selected=cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodByCategory(id);
        }

        private void btn_Themmon_Click(object sender, EventArgs e)
        {
              
                if(cb_Food.Text== "Không có món ")
                {
                    MessageBox.Show("Không có món mời chọn món khác","RMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }   
                
                Table table = lv_HoaDon.Tag as Table;
            if (table==null)
            {
                MessageBox.Show("Chọn bàn", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                int  idFood = (cb_Food.SelectedItem as Food).Id;
                int count = (int)nb_FoodCount.Value;
                string status = table.Status;
                if (idBill == -1)
                {
                    BillDAO.Instance.insertBill(table.Id);
                    BillInfoDAO.Instance.Insert_UpdateBillinfo(BillDAO.Instance.GetMaxid(), idFood, count);
                    TableDAO.Instance.checkin(table.Id, BillDAO.Instance.GetMaxid());


                }
                else
                {
                    BillInfoDAO.Instance.Insert_UpdateBillinfo(idBill, idFood, count);
                    TableDAO.Instance.checkin(table.Id, idBill);

                }

                LoadTable();

                ShowBill(table.Id);
            
            
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            Table table = lv_HoaDon.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int discount = (int)nb_Discount.Value;

            double price = Convert.ToDouble(total_price.Text.Split(',')[0]);
            double totalprice =(float) price - (float)price / 100 * (float) discount;


            //double totalpricefinal = totalprice - (totalprice/100)*discount;
            if (idBill!=-1)
            {
                if(BillInfoDAO.Instance.checkBillInfo(idBill)!=0)
                {
                    if (MessageBox.Show(String.Format("Bạn có chắc muốn thanh toán hóa đơn cho bàn {0} với giảm giá là {1}% = {2} ", table.Name, discount, totalprice * 1000), "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        PrintBill();

                        BillDAO.Instance.Checkout(idBill, discount, (float)(totalprice * 1000));
                        TableDAO.Instance.checkout(table.Id);
                        LoadTable();
                        ShowBill(table.Id);
                    }
                }    
               
            }
        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("Bạn có muốn chuyển bàn từ bàn {0} đến bàn {1} không ", 
                (lv_HoaDon.Tag as Table).Name, (cb_switch.SelectedItem as Table).Name), 
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if((lv_HoaDon.Tag as Table).Name== (cb_switch.SelectedItem as Table).Name)
                {
                    MessageBox.Show("Trùng bàn","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }    
                int idtable1 = (lv_HoaDon.Tag as Table).Id;
                int idtable2 = (cb_switch.SelectedItem as Table).Id;
                int idbillold = BillDAO.Instance.GetUncheckBillIDByTableID(idtable1);
                int idbillnew = BillDAO.Instance.GetUncheckBillIDByTableID(idtable2);
                if (idbillold != -1)                         
                {
                    if (idbillnew == -1)
                    {
                        BillDAO.Instance.insertBill(idtable2);
                        BillInfoDAO.Instance.SwitchBillInfo(idbillold, BillDAO.Instance.GetMaxid());
                        TableDAO.Instance.checkin(idtable2, BillDAO.Instance.GetMaxid());
                        TableDAO.Instance.checkout(idtable1);
                    }
                    else
                    {
                        BillInfoDAO.Instance.SwitchBillInfo(idbillold, idbillnew);
                        TableDAO.Instance.checkout(idtable1);
                        TableDAO.Instance.checkin(idtable2, idbillnew);
                        BillInfoDAO.Instance.Checkavailable(idbillnew);

                    }
                    LoadTable();
                    
                }
                
            }
           



        }
        void PrintBill()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }    

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Table table = lv_HoaDon.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int discount = (int)nb_Discount.Value;
            double price = Convert.ToDouble(total_price.Text.Split(',')[0]);
            double totalprice = ((float)price - (float)price / 100 * (float)discount)*1000;

            int w = printDocument1.DefaultPageSettings.PaperSize.Width;
           int y = 20;
            e.Graphics.DrawString("Phiếu Thanh Toán", new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(280, y));
            y += 35;
            e.Graphics.DrawString(String.Format("Số Phiếu {0}", idBill), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(340, y));
            y += 50;
            e.Graphics.DrawString("Nhà hàng bình dân", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            y += 25;
            e.Graphics.DrawString(String.Format("{0}", table.Name), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));

            e.Graphics.DrawString(String.Format("{0}-{1}", "141 Điện Biên Phủ","0933431391"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            y += 30;
            e.Graphics.DrawString(String.Format("{0} {1}", "Nhân viên thanh toán :", Account.Displayname), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("Ngày Tạo :{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2 , y));
            Pen blackpen = new Pen(Color.Black, 1);
             y +=25 ;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w-10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);
            y += 10;


            // 
            e.Graphics.DrawString("STT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Món ăn", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+100, y));
            e.Graphics.DrawString("Thành Tiền", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2-200, y));
            y+= 20;
            List<Menu1> billInfos = MenuDAO.Instance.GetMenubyTable(table.Id);
            double TotalPrice = 0;
            int STT = 0;
            foreach (Menu1 item in billInfos)
            {
                 STT+= 1;

                e.Graphics.DrawString(String.Format("{0}",STT.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(String.Format("{0}", item.Foodname.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(String.Format("{0:N0}", item.Count.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
                e.Graphics.DrawString(String.Format("{0:N0}",item.Totalprice.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+100, y));
                e.Graphics.DrawString(String.Format("{0:N0}", item.Price.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2-200 , y));

                TotalPrice += item.Totalprice;
                y += 30;

            }
            y += 20;

            Point p3 = new Point(10, y);
            Point p4 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p3, p4);
            y += 20;

            e.Graphics.DrawString(String.Format("{0}" , "Tổng Tiền"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("{0:N0}", TotalPrice.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+100, y));
            y += 30;
            e.Graphics.DrawString(String.Format("{0}", "Khuyến mãi :"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("{0}%", discount.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            y += 30;
            e.Graphics.DrawString(String.Format("{0}", "Giá sau khuyến mãi :"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("{0:N0}", totalprice.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            y += 30;
            e.Graphics.DrawString(String.Format("{0}:", "Thành chữ"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("{0}",Convertnumber.NumberToText(totalprice)), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));

            y += 30;
            e.Graphics.DrawString(String.Format("{0}", "Mọi thắc mắc xin liên hệ quản lý theo số :0933431391"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));




















        }


    }
}
