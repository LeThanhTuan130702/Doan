using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.DTO;

namespace Menudemo.View
{
    public partial class HomeView : Form
    {
        private Account account;
        private MenuForm menu;
        public HomeView(Account account, MenuForm menuForm)
        {
            InitializeComponent();
            Account = account;
            menu = menuForm;
        }
            
        public Account Account { get => account; set => account = value; }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            fProfile profile=new fProfile(Account);
            profile.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            fchangepass fchangepass = new fchangepass(Account);
            fchangepass.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("bạn có muốn đăng xuất chương trình ", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                flogin flogin = new flogin();
                flogin.Show();
                menu.Dispose();
            }


        }
    }
}
