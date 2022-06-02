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
    public partial class MySC : Form
    {
        public MySC()
        {
            InitializeComponent();
        }
        String id = Sign1.id;
        private void MySC_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            // TODO: 这行代码将数据加载到表“stuDataSet.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
            con.Open();
            String select_by_id = "select * from Course";
            SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            dataGridView1.DataSource = bindingSource;
            sqlDataReader.Close();
            String select_by_id2 = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + id + "'";
            SqlCommand sqlCommand2 = new SqlCommand(select_by_id2, con);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = sqlDataReader2;
            dataGridView2.DataSource = bindingSource2;
            con.Close();
            
            label5.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)//退课
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {
                con.Open();
                string Cno = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from SC where Sno=" + id + "and Cno='" + Cno + "'";//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
            finally
            {
                
                con.Close();
            }
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
            con.Open();
            String select_by_id2 = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + id + "'";
            SqlCommand sqlCommand2 = new SqlCommand(select_by_id2, con);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = sqlDataReader2;
            dataGridView2.DataSource = bindingSource2;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)//查询
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            String Cno = textBox1.Text.Trim();
            try
            {
                con.Open();
                String select_by_id = "select * from Course where Cno='" + Cno + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("不存在该课程");
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)//选课
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            String Cno = textBox1.Text.Trim();
            con.Open();
            string insertStr = "INSERT INTO  SC (Sno,Cno,Grade)" +
                    "VALUES ('" + id + "','" + Cno + "',"+ "NULL)";
            try { 
            SqlCommand cmd = new SqlCommand(insertStr,con);
            cmd.ExecuteNonQuery();        
            }
            catch
            {
                MessageBox.Show("查询语句错误"+insertStr);
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
            String conn2 = "Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456";
            SqlConnection con2 = new SqlConnection(conn2);  //实例化连接对象
            con2.Open();
            String select_by_id2 = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + id + "'";
            SqlCommand sqlCommand2 = new SqlCommand(select_by_id2, con2);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = sqlDataReader2;
            dataGridView2.DataSource = bindingSource2;
            con2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)//刷新
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            String select_by_id = "select * from Course";
            SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            dataGridView1.DataSource = bindingSource;
            sqlDataReader.Close();
            String select_by_id2 = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + id + "'";
            SqlCommand sqlCommand2 = new SqlCommand(select_by_id2, con);
            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = sqlDataReader2;
            dataGridView2.DataSource = bindingSource2;
        }
    }
}
