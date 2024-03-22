using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;
using Menudemo.View;

namespace Menudemo
{
    public partial class MenuForm : Form
    {
        bool SidebarExpand;
        Button btn=null;
        private Account loginaccount;

        public Account Loginaccount { get => loginaccount; set => loginaccount = value; }

        private void OpenChild(Form ChildForm, Button btn)
        {
            
            if(this.btn==null)
            {
                btn.BackColor= ChildForm.BackColor;
            }
            else
            {
                this.btn.BackColor= Color.Transparent;
            }
            btn.BackColor = ChildForm.BackColor;
            this.btn = btn;
            pn_body.Controls.Clear();
            ChildForm.Dock= DockStyle.Fill;
            ChildForm.TopLevel = false;
            pn_body.Controls.Add(ChildForm);
            ChildForm.Show();
        }
        void ChangeAccount()
        {
            if(Loginaccount.Type1==1)
            {
                btn_Cate.Hide();
                btn_Setting.Hide();
                btn_Products.Hide();
                btn_Staff.Hide();
                //btn_Table.Hide();
                lb_name.Text = "Xin chào bạn "+Loginaccount.Role+" : "+Loginaccount.Displayname;
            }
            else
            {
                lb_name.Text = "Xin chào bạn quản lý: " + Loginaccount.Displayname;

            }
        }    

        public MenuForm(Account loginaccount)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            SidebarTimer.Start();
            
            Loginaccount = loginaccount;
            OpenChild(new HomeView(Loginaccount,this), btn_Home);
            ChangeAccount();
        }




        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(SidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width==sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        

        private void btn_Max_Click_1(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Maximized)
            {
                WindowState= FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Min_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            OpenChild(new HomeView(Loginaccount,this), btn_Home);
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {

        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            OpenChild(new DoanhThu(),btn_Setting);
        }

        

        private void btn_Products_Click(object sender, EventArgs e)
        {
            OpenChild(new FoodViews(Loginaccount),btn_Products);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            OpenChild(new StaffView(Loginaccount), btn_Staff);
        }

        private void btn_Cate_Click(object sender, EventArgs e)
        {
            OpenChild(new FCategory(Loginaccount), btn_Cate);

        }

        

        private void btn_Pos_Click(object sender, EventArgs e)
        {
            //OpenChild(new TableManager(Loginaccount));

        }
    }
}
