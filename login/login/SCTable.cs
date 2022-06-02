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
    public partial class SCTable: Form
    {
        public SCTable()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuDataSet.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.stuDataSet.SC);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)//增加
        {
            String Sno = textBox1.Text.Trim();
            String Cno = textBox2.Text.Trim();
            String Grade = textBox3.Text.Trim();
            if (Sno == "")
            {
                MessageBox.Show("学号不可为空");
                return;
            }
            else if (Cno == "")
            {
                MessageBox.Show("课程号不可为空");
                return;
            }
            else if (Grade == ""){
                MessageBox.Show("成绩不可为空");
                return;
            }
            else if (int.Parse(Grade) < 0)
            {
                MessageBox.Show("成绩不可小于0");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
             String select_by_id1 = "select * from Course where Cno='" + Cno + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (!m1.HasRows)
            {
                MessageBox.Show("该课程号不存在");
                return;
            }
            m1.Close();
            String select_by_id2 = "select * from Student where Sno='" + Sno + "'";
            SqlCommand cmd2 = new SqlCommand(select_by_id2, con);
            SqlDataReader m2 = cmd2.ExecuteReader();
            if (!m2.HasRows)
            {
                MessageBox.Show("该学号不存在");
                return;
            }
            m2.Close();
            String select_by_id3 = "select * from SC where Cno='" + Cno + "'AND Sno='"+Sno+"'";
            SqlCommand cmd3 = new SqlCommand(select_by_id3, con);
            SqlDataReader m3 = cmd3.ExecuteReader();
            if (m3.HasRows)
            {
                MessageBox.Show("该选课已经存在");
                return;
            }
            m3.Close();
            try
            {
                
                string insertStr = "INSERT INTO  SC (Sno,Cno,Grade)" +
                    "VALUES ('" + Sno + "','" + Cno + "'," + Grade + ")";
                SqlCommand cmd = new SqlCommand(insertStr, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!");
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
        }

        private void button3_Click_1(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {
                con.Open();
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string select_cno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string delete_by_id = "delete from SC where Sno=" + select_id + "and Cno=" + select_cno;//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行! ");
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
            refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)//修改
        {
            String Sno = textBox4.Text.Trim();
            String Cno = textBox5.Text.Trim();
            String Grade = textBox6.Text.Trim();
            if (Sno == "")
            {
                MessageBox.Show("学号不可为空");
                return;
            }
            else if (Cno == "")
            {
                MessageBox.Show("课程号不可为空");
                return;
            }
            else if (Grade == "")
            {
                MessageBox.Show("成绩不可为空");
                return;
            }
            else if (int.Parse(Grade) < 0)
            {
                MessageBox.Show("成绩不可小于0");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            string insertStr = "UPDATE SC SET Grade = " + Grade + " WHERE Sno = '" + Sno + "' AND Cno = '"+Cno+"'";
            String select_by_id1 = "select * from Course where Cno='" + Cno + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (!m1.HasRows)
            {
                MessageBox.Show("该课程号不存在");
                return;
            }
            m1.Close();
            String select_by_id2 = "select * from Student where Sno='" + Sno + "'";
            SqlCommand cmd2 = new SqlCommand(select_by_id2, con);
            SqlDataReader m2 = cmd2.ExecuteReader();
            if (!m2.HasRows)
            {
                MessageBox.Show("该学号不存在");
                return;
            }
            m2.Close();
            String select_by_id3 = "select * from SC where Sno='" + Sno + "'AND Cno='"+Cno+"'";
            SqlCommand cmd3 = new SqlCommand(select_by_id3, con);
            SqlDataReader m3 = cmd3.ExecuteReader();
            if (!m3.HasRows)
            {
                MessageBox.Show("该选课不存在");
                return;
            }
            m3.Close();
            try
            {
               
                SqlCommand cmd = new SqlCommand(insertStr, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("不存在该项选课");
            }
            finally
            {
                con.Dispose();
            }
            this.sCTableAdapter.Fill(this.stuDataSet.SC);
        }

        private void button4_Click_1(object sender, EventArgs e)//查询
        {
            String Sno = textBox7.Text.Trim();
            String Cno = textBox8.Text.Trim();
            String select_by_id;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {
                con.Open();
                if(Sno!=""&&Cno=="")  select_by_id = "select * from SC where Sno='" + Sno + "'";
                else if(Sno==""&&Cno!="") select_by_id = "select * from SC where Cno='" + Cno + "'";
                else if (Sno == "" && Cno == "")
                {
                    MessageBox.Show("请输入学号或者课程号");
                    return;
                }
                else
                {
                    select_by_id= "select * from SC where Sno='" + Sno + "' AND Cno ='"+Cno+"'";
                }
               
                SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("查询语句有误!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)//刷新
        {
            refresh();
        }
         private void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            String select_by_id = "select * from SC";
            SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
