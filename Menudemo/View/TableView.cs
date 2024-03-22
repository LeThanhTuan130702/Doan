using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo.View
{
    public partial class TableView : FSample
    {
        private Account Account;

        public Account Account1 { get => Account; set => Account = value; }
        MenuForm mn;

        public TableView(Account acc)
        {
            InitializeComponent();
            Loaddata();
            DataGridViewImageColumn cDelete = new DataGridViewImageColumn();
            DataGridViewImageColumn cEdit = new DataGridViewImageColumn();
            cEdit.Image = Properties.Resources.edit;
            cDelete.Image = Properties.Resources.delete;
            Account1 = acc;
             mn = new MenuForm(Account1);
            dtgv1.Columns.AddRange(cEdit, cDelete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddViewTable at=new AddViewTable (0);
            //at.ShowDialog();
            effec(new AddViewTable(0));
            Loaddata();
        }
        public void Loaddata()
        {

            dtgv1.DataSource = TableDAO.Instance.GetTableList(textBox1.Text);

        }
        public void effec(Form model)
        {
            Form Backround = new Form();
            using(model)
            {
                
                Backround.StartPosition= FormStartPosition.Manual;
                Backround.FormBorderStyle= FormBorderStyle.None;
                Backround.Opacity= 0.5;
                Backround.BackColor = Color.Black;
                Backround.Size =mn.Size;
                Backround.Location = mn.Location;
                Backround.ShowInTaskbar= false;
                Backround.Show();
                model.Owner=Backround;
                model.ShowDialog(Backround);
                Backround.Dispose();
            }
        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (dtgv1.CurrentCell.OwningColumn.DisplayIndex == 3)
            {

                DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "RMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    int id = (int)(dtgv1.CurrentRow.Cells["id"].Value);
                    
                    int rs = TableDAO.Instance.Delete_Table(id);

                    if (rs != 0)
                    {
                       
                        MessageBox.Show("Delete Successfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Loaddata();
                    }
                }


            }
            if (dtgv1.CurrentCell.OwningColumn.DisplayIndex == 2)
            {
                int id = (int)(dtgv1.CurrentRow.Cells["id"].Value);
                string name = (string)dtgv1.CurrentRow.Cells["name"].Value;
                //AddViewTable v = new AddViewTable(id);
                //v.ShowDialog();
                effec(new AddViewTable(id, name));
                Loaddata();


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            dtgv1.DataSource = TableDAO.Instance.GetTableList(textBox1.Text);
        }
    }
}
