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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menudemo
{
    public partial class fsetting : Form
    {
        public fsetting()
        {
            InitializeComponent();
            btnset.Enabled = false;
            btnadd.Enabled = false;
            btnde.Enabled = false;
            txt3.Enabled = false;
        }
        string connectionSTR = DataProvider.Instance.connectionSTR;

        private void fsetting_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.Account ";
            
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dgvA.DataSource = data;
                connection.Close();


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txtKT.Text = string.Empty;
            btnde.Enabled = true;




        }

     

        private void dgvA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvA.CurrentRow.Index;
            txt1.Text = dgvA.Rows[i].Cells[0].Value.ToString();
            txt2.Text = dgvA.Rows[i].Cells[1].Value.ToString();
            txt4.Text = dgvA.Rows[i].Cells[2].Value.ToString();
            txt5.Text = dgvA.Rows[i].Cells[3].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txtKT.
                Text = string.Empty;
            btnadd.Enabled = true;


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
           {
                int a = int.Parse(txt4.Text);
                string query = "insert into dbo.Account values(N'" + txt1.Text + "',N'" + txt2.Text + "'," + a + ",N'" + txt5.Text + "')";
                if (txt2.Text.Equals(txtKT.Text))
                {
                    DataProvider.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Tạo thành công  ", "Thông Báo");
                }
                else
                    MessageBox.Show("Mật khẩu không khớp ", "Chú ý");
            }
            catch(Exception ex) {
                MessageBox.Show("lỗi kiểu dữ liệu kiểm tra lại ", "Thông Báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnset.Enabled = true;
            txt3.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from dbo.Account ";
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    dgvA.DataSource = data;
                    connection.Close();


                }
            }
            catch(Exception ex )
            {
                MessageBox.Show("lỗi kiểu dữ liệu kiểm tra lại ", "Thông Báo");
            }
        }

        private void btnde_Click(object sender, EventArgs e)
        {
            string query = "delete from dbo.Account where username = N'" + dgvA.CurrentCell.Value + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            MessageBox.Show("Đã xóa ", "Thông Báo");
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            if (txt3.Text.Equals(txtKT.Text))
            {
                string query = "update dbo.Account set password =N'" + txt3.Text + "'where username =N'" + txt1.Text + "' and password=N'" + txt2.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật mật khẩu thành công ", "Thông báo");

            }
            else
            {
                MessageBox.Show("Không trùng khớp mật khẩu mời nhập lại ", "Thông báo");
            }
        }
    }
}
