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

namespace login
{
    public partial class Account : Form
    {
 
       
        public Account()
        {
            InitializeComponent();
            refresh();
            
        }
        private void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            String select_by_id = "select * from Manager_Account";
            SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            dataGridView1.DataSource = bindingSource;
            sqlDataReader.Close();
            String select_by_id2 = "Select account,password,question,answer from Student_Account";
            SqlCommand sqlCommand2 = new SqlCommand(select_by_id2, con);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = sqlDataReader2;
            dataGridView2.DataSource = bindingSource2;
            con.Close();
        }
        String table = "Manager_Account";
        private void Account_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuDataSet3.Student_Account”中。您可以根据需要移动或删除它。
            this.student_AccountTableAdapter1.Fill(this.stuDataSet3.Student_Account);
            // TODO: 这行代码将数据加载到表“stuDataSet3.Manager_Account”中。您可以根据需要移动或删除它。
            this.manager_AccountTableAdapter2.Fill(this.stuDataSet3.Manager_Account); 
        }

        private void button1_Click(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {

                con.Open();
                string select_id = "";
                if(table=="Manager_Account") select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                else select_id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string delete_by_id = "delete from "+table+" where Account=" + select_id;//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!"+table);
            }
            finally
            {
                con.Dispose();
            }
            this.manager_AccountTableAdapter.Fill(this.stuDataSet1.Manager_Account);
            refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
     

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) table = "Manager_Account";
            else if (tabControl1.SelectedTab == tabPage2) table = "Student_Account";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (table == "Student_Account")
            {
                Register1 r = new Register1();
                r.Show();
            }
            else
            {
                Register r1 = new Register();
                r1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
