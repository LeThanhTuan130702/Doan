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
    public partial class fProfile : Form
    {
        private Account account;
        public fProfile(Account account)
        {
            InitializeComponent();
            this.account = account;
            name.Text = account.Displayname;
            Phone.Text = account.Phone1.ToString();
            Role.Text = account.Role.ToString();
        }

     

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
