using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Menudemo.CONNECT;
using Menudemo.DAO;

namespace Menudemo.View
{
    public partial class AddStaff : FAddSample
    {
        int type;
        string username;    
        string password;
        string displayname;
        int phone;
        string role;
        int type1;
        public AddStaff(int type,string username,string password,string displayname,int phone,string role,int type1)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.displayname = displayname;
            this.phone = phone;
            this.role = role;
            this.type1 = type1;
            txt_Name.Text = username;
            txt_Displayname.Text = displayname;
            txtpass.Text = password;
            txtPhone.Text = phone.ToString();
            txtRole.Text = role;
            txt_Type.Text = type1.ToString();




        }
        public AddStaff(int type, string username)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtpass.Text);
            byte[] Hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in Hasdata)
            {
                hasPass += item;
            }
            if (type == 0)
            {
               
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                try
                {
                    int a = AccountDAO.Instance.Insert_Staff(txt_Name.Text, txt_Displayname.Text, hasPass, int.Parse(txt_Type.Text), int.Parse(txtPhone.Text), txtRole.Text);
                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                }
                catch(Exception ex)
                {
                    
                    MessageBox.Show("Lỗi cập nhật kiểm tra lại tên tài khoản hoặc dữ liệu ", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                   
                }
               
            }
            else

            {
                


                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                try
                {
                  
                    int a = AccountDAO.Instance.Update_Staff(txt_Name.Text, txt_Displayname.Text, hasPass, int.Parse(txt_Type.Text), int.Parse(txtPhone.Text), txtRole.Text,this.username);

                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật kiểm tra lại tên tài khoản hoặc dữ liệu ", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                }

            }
        }
    }
}
