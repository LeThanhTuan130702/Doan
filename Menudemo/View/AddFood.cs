using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo.View
{
    public partial class AddFood : FAddSample
    {
        string type;
        float GiaBan;
        float GiaNhap;

        public AddFood(string type)
        {
            InitializeComponent();
            this.type = type; 
            LoadCB();
        }
        public AddFood(string MaHang,string Tenhang,int SL,object GiaBan,object GiaNhap,string Anh,string GhiChu,string MaNCC,string NG)
        {
            InitializeComponent();
            LoadCB();
            this.GiaBan=float.Parse(GiaBan.ToString());
            this.GiaNhap = float.Parse(GiaNhap.ToString());

            this.type = MaHang;       
            
        }
        
       
       public void LoadCB()

        {
            string query = "select MaNCC,TenNCC from NhaCungCap";
            cbMaNCC.DisplayMember= "TenNCC";
            cbMaNCC.ValueMember= "MaNCC";
           
            cbMaNCC.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbMaNCC.SelectedIndex=-1;
          
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (type == "0")
                {


                    int a = FoodDAO.Instance.Insert_Food(txtCode.Text, txtname.Text,int.Parse( txtSL.Text),GiaBan,GiaNhap,txtAnh.Text,txtGhiChu.Text,cbMaNCC.SelectedValue.ToString(),txtNguonGoc.Text);
                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                    }
                }
                else
                {

                    int a = FoodDAO.Instance.Update_Food(txtCode.Text, txtname.Text, int.Parse(txtSL.Text), GiaBan, GiaNhap, txtAnh.Text, txtGhiChu.Text, cbMaNCC.SelectedValue.ToString(), txtNguonGoc.Text);

                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);


                    }
                }
            }
            catch(Exception ex )
            { 
                        MessageBox.Show("Lỗi cập nhật ", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
