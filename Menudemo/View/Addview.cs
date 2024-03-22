using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DAO;

namespace Menudemo.View
{
    public partial class Addview : FAddSample
    {
        string type;
        string name;
        public Addview(string type,string name)
        {
            InitializeComponent();

            this.type = type;
            this.name = name;
            txtCode.Text = type;
            txtName.Text = name;
            
        }
        public Addview(string type)
        {
            this.type = type;
            InitializeComponent();
            
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (type == "0")
                {
                    if (txtCode.Text.Trim() == "")
                    {
                        return;
                    }
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    int a = CategoryDAO.Instance.Insert_Cate(txtName.Text,txtCode.Text);
                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                }
                else
                {
                    
                    if (txtCode.Text.Trim() == "")
                    {
                        return;
                    }
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    int a = CategoryDAO.Instance.Update_Cate(txtName.Text,txtCode.Text);
                    if (a != 0)
                    {
                        MessageBox.Show("Save Succeessfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Save Failure", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi cập nhật", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
