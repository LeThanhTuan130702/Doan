using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Menudemo.CONNECT;
using Menudemo.DAO;

namespace Menudemo.View
{
    public partial class AddViewTable : FAddSample
    {
        int type;
        string Name;
       
        public AddViewTable(int Type,string name)
        {
            InitializeComponent();
            this.type = Type;
            Name= name;
            txt_table.Text = Name;
        }
        public AddViewTable(int Type)
        {
            this.type = Type;
            InitializeComponent();
        }



        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (type == 0)
            {
                
               if(txt_table.Text.Count()<5||txt_table.Text.Contains("Bàn ")==false)
                {
                    MessageBox.Show("Bàn phải theo định dạng : ( Bàn x) ", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    return;
                }
                try
                {
                    int a = TableDAO.Instance.Insert_Table(txt_table.Text);
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
                    DataTable data = new DataTable();
                    data = TableDAO.Instance.checkavai(txt_table.Text);
                    if (data.Rows.Count > 0)
                    {
                        TableDAO.Instance.ReUpTable(txt_table.Text);
                        MessageBox.Show("Bàn đã được tạo thành công", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                    else
                    {
                        MessageBox.Show("Trùng tên bàn", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }


                }
            }
            else
            {
                try
                {
                   
                    if (txt_table.Text.Count() < 5 || txt_table.Text.Contains("Bàn ") == false)
                    {
                        MessageBox.Show("Bàn phải theo định dạng : ( Bàn x) ", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        return;
                    }
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    int a = TableDAO.Instance.Update_Table(txt_table.Text, type);
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
                    MessageBox.Show("Trùng tên bàn", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    

                }
            }
        }
    }
}
