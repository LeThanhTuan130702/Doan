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
using Menudemo.CONNECT;
using Menudemo.DAO;
using Menudemo.DTO;

namespace Menudemo.View
{
    public partial class FCategory : FSample
       
    {   
        
        
        private Account Account;

        public Account Account1 { get => Account; set => Account = value; }
        MenuForm mn;

        public FCategory(Account acc)
        {
            InitializeComponent();
            Loaddata();
            DataGridViewImageColumn cDelete = new DataGridViewImageColumn();
            DataGridViewImageColumn cEdit = new DataGridViewImageColumn();
            cEdit.Image = Properties.Resources.edit;
            cDelete.Image = Properties.Resources.delete;
            dtgv1.Columns.AddRange(cEdit, cDelete);
            Account1 = acc;
             mn = new MenuForm(Account1);
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



        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Loaddata()
        {


            dtgv1.DataSource = CategoryDAO.Instance.GetCateList(textBox1.Text);

        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         if(dtgv1.CurrentCell.OwningColumn.DisplayIndex==4)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "RMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog ==DialogResult.Yes)
                {
                    string id = (string)(dtgv1.CurrentRow.Cells["MaNCC"].Value);

                    int rs = CategoryDAO.Instance.Delete_Cate(id);
                    
                    if (rs!=0)
                    {
                        MessageBox.Show("Delete Successfully", "RMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loaddata();
                    }
                }    
               
               
            }
         if(dtgv1.CurrentCell.OwningColumn.DisplayIndex == 3)
            {
                string id = (string)(dtgv1.CurrentRow.Cells["MaNCC"].Value);
                string name=(string)dtgv1.CurrentRow.Cells["TenNCC"].Value;
                //Addview v = new Addview(id);
                //v.ShowDialog();
                effec(new Addview(id,name));
                Loaddata();
               
                
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Addview v=new Addview(0);
            //v.ShowDialog();
            effec(new Addview("0"));
            Loaddata();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            dtgv1.DataSource=CategoryDAO.Instance.GetCateList(textBox1.Text);
        }
    }
}
