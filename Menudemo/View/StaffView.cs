using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Guna.UI2.WinForms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo.View
{
    public partial class StaffView : FSample
    {
        private Account Account;

        public Account Account1 { get => Account; set => Account = value; }
        MenuForm mn;

        public StaffView(Account acc)
        {
            InitializeComponent();
            Loaddata();
            DataGridViewImageColumn cDelete = new DataGridViewImageColumn();
            DataGridViewImageColumn cEdit = new DataGridViewImageColumn();
            cEdit.Image = Properties.Resources.edit;
            cDelete.Image = Properties.Resources.delete;
            Account1 = acc;
             mn = new MenuForm(Account1);
            dataGridView1.Columns.AddRange(cEdit, cDelete);
        }
        public void Loaddata()
        {
           

            dataGridView1.DataSource = AccountDAO.Instance.GetStaffList(textBox1.Text);
        }
        public void effec(Form model)
        {
            Form Backround = new Form();
            using (model)
            {
                Backround.StartPosition = FormStartPosition.Manual;
                Backround.FormBorderStyle = FormBorderStyle.None;
                Backround.Opacity = 0.5;
                Backround.BackColor = Color.Black;
                Backround.Size = mn.Size;
                Backround.Location = mn.Location;
                Backround.ShowInTaskbar = false;
                Backround.Show();
                model.Owner = Backround;
                model.ShowDialog(Backround);
                Backround.Dispose();
            }
        }
   


        private void button1_Click(object sender, EventArgs e)
        {
            effec(new AddStaff(0, null));
            Loaddata();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccountDAO.Instance.GetStaffList(textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.DisplayIndex == 7)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "RMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    string username = (string)(dataGridView1.CurrentRow.Cells["username"].Value);
                    int rs = AccountDAO.Instance.Delete_Staff(username);

                    if (rs != 0)
                    {
                        MessageBox.Show("Delete Successfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loaddata();
                    }
                }


            }
            if (dataGridView1.CurrentCell.OwningColumn.DisplayIndex == 6)
            {
                string username = (string)(dataGridView1.CurrentRow.Cells["username"].Value);
                string password = (string)(dataGridView1.CurrentRow.Cells["password"].Value);
                string displayname = (string)(dataGridView1.CurrentRow.Cells["displayname"].Value);
                string Role = (string)(dataGridView1.CurrentRow.Cells["role"].Value);

                int type1 = (int)(dataGridView1.CurrentRow.Cells["type"].Value);
                int Phone = (int)(dataGridView1.CurrentRow.Cells["Phone"].Value);


                //Addview v = new Addview(id);
                //v.ShowDialog();
                effec(new AddStaff(1, username,password,displayname, Phone,Role,type1));
                Loaddata();


            }
        }
    }
}
