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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menudemo.DAO;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txt_log.Text;
            string password = txt_pas.Text;
            if (Login(username, password))
            {
               Account loginaccount=AccountDAO.Instance.GetAccountbyUsername(username);
                this.Hide();
                MenuForm f = new MenuForm(loginaccount);
                
                f.ShowDialog();
        
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu","RMS", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát chương trình ", "RMS", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void showpass_Click(object sender, EventArgs e)
        {
            if (txt_pas.PasswordChar == '\0')
            {
                hidepass.BringToFront();
                txt_pas.PasswordChar = '*';
            }
        }

        private void hidepass_Click(object sender, EventArgs e)
        {
            if(txt_pas.PasswordChar=='*')
            {
                showpass.BringToFront();
                txt_pas.PasswordChar= '\0';
            }    
        }

        private void lbMiss_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0933431391", "Liên hệ");
        }

     
    }
}
