using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo
{
    public partial class fchangepass : Form
    {
        private Account Account;
        public Account Account1 { get => Account; set => Account = value; }

        public fchangepass(Account account)
        {
            InitializeComponent();
            Account1 = account;
            
        }
        


        private void faccount_Load(object sender, EventArgs e)
        {
            Displayname.Text = Account1.Displayname;
            username.Text = Account1.Username;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (newpass.Text.Equals(checkpass.Text))
            {if(newpass.Text.Equals(password.Text))
                {
                    MessageBox.Show("Mật khẩu mới và cũ không được trùng ", "Thông báo");
                    return;

                }
                int check = AccountDAO.Instance.ChangePassword(password.Text, newpass.Text, username.Text);
                if (check != 0)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công ", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật ", "Thông báo");

                }

            }
            else
            {
                MessageBox.Show("không trùng khớp mật khẩu mời nhập lại ", "Thông báo");
            }
        }
    }   
}
