using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace Menudemo
{
    public partial class DoanhThu : Form
    {
        
        public DoanhThu()
        {
            InitializeComponent();
            LoadDatetimepicker();
            dataGridView1.DataSource = BillDAO.Instance.ListBill(Checkin.Value, Checkout.Value, txtSearch);
            

        }

        void LoadDatetimepicker()
        {
            DateTime today = DateTime.Now;
            Checkin.Value = new DateTime(today.Year, today.Month, 1);
            Checkout.Value = Checkin.Value.AddMonths(1).AddDays(-1);
        }
      void loadBill()
        {

           dataGridView1.DataSource= BillDAO.Instance.ListBill(Checkin.Value, Checkout.Value.AddDays(1),txtSearch);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadBill();
            this.uSP_GetListBillByDateTableAdapter.Fill(this.khachHangDataSet1.USP_GetListBillByDate, Checkin.Value, Checkout.Value.AddDays(1));
            
            this.reportViewer2.RefreshReport();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachHangDataSet1.USP_GetListBillByDate' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'khachHangDataSet.Table_Food' table. You can move, or remove it, as needed.
            this.uSP_GetListBillByDateTableAdapter.Fill(this.khachHangDataSet1.USP_GetListBillByDate, Checkin.Value, Checkout.Value);
            

            //string connectionSTR = @"Data Source=LAPTOP-B9O6DJP3;Initial Catalog=KhachHang;Integrated Security=True";

            //string query= "select t.name,b.DateCheckIN,b.DateCheckOut,b.discount,b.totalprice\r\nfrom Bill as b,Table_Food as t\r\nwhere b.status=1 and t.id=b.idTable_Food and DateCheckIN>='" + Checkin.Value + "' and DateCheckOut<='" + Checkout.Value + "'and t.name like N'%" + txtSearch + "%'";
            //SqlConnection cn = new SqlConnection(connectionSTR);
            //SqlCommand command = new SqlCommand(query, cn);
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //da.Fill(data);
            //            DataTable data = new DataTable();
            //            data= BillDAO.Instance.ListBill(Checkin.Value, Checkout.Value, txtSearch);

            //;

            //            ReportDataSource report = new ReportDataSource("Billlist", data);
            //           this.reportViewer2.LocalReport.DataSources.Clear();
            //            this. reportViewer2.LocalReport.DataSources.Add(report);
            //            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBIll.Text);
                DataTable data = BillInfoDAO.Instance.loadBillInfoByIDBill(id);
                if(data.Rows.Count >0) {
                dtgvBillinfo.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không đúng số hóa đơn", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("nhập mã số !!","RMS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
