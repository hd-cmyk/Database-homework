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
    public partial class CourseTable : Form
    {
        public CourseTable()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuDataSet.Course”中。您可以根据需要移动或删除它。

            this.courseTableAdapter.Fill(this.stuDataSet.Course);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
               
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//增加
        {
            String Cno = textBox1.Text.Trim();
            String Cname = textBox2.Text.Trim();
            String Cpno = textBox3.Text.Trim();
            String Ccredit = textBox4.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            string insertStr;
            if (Cno == "")
            {
                MessageBox.Show("课程号不可为空");
                return;
            }
            else if (Cname == "")
            {
                MessageBox.Show("课程名称不可为空");
                return;
            }
            else if (Ccredit == "")
            {
                MessageBox.Show("学分不可为空");
                return;
            }
            else if (int.Parse(Ccredit) <= 0)
            {
                MessageBox.Show("学分必须大于0");
                return;
            }
            if (Cpno !="") {//不为空值
                insertStr = "INSERT INTO  Course (Cno,Cname,Cpno,Ccredit)" +
                    "VALUES ('" + Cno + "','" + Cname + "','" + Cpno + "'," + Ccredit + ")";
            }
            else
            {
                insertStr = "INSERT INTO  Course (Cno,Cname,Cpno,Ccredit)" +
                    "VALUES ('" + Cno + "','" + Cname + "',NULL," + Ccredit + ")";
            }
            String select_by_id1 = "select * from Course where Cno='" + Cno + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (m1.HasRows)
            {
                MessageBox.Show("该课程号已存在");
                return;
            }
            m1.Close();
            if (Cpno != Cno&&Cpno!="")
            {
                String select_by_id2 = "select * from Course where Cno='" + Cpno + "'";
                SqlCommand cmd2 = new SqlCommand(select_by_id2, con);
                SqlDataReader m2 = cmd2.ExecuteReader();
                if (!m2.HasRows)
                {
                    MessageBox.Show("该先行课不存在");
                    return;
                }
                m2.Close();
            }
            
            try
            {
                SqlCommand cmd = new SqlCommand(insertStr, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求! ");
            }
            finally
            {
                con.Dispose();
            }
            this.courseTableAdapter.Fill(this.stuDataSet.Course);
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
            String select_by_id1 = "select * from SC where Cno='" + select_id + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (m1.HasRows)
            {
                MessageBox.Show("该课程号已经在选课表被引用");
                return;
            }
            m1.Close();


            try
            {              
                string delete_by_id = "delete from Course where Cno=" + select_id;//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_id, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
            finally
            {
                con.Dispose();
            }
            this.courseTableAdapter.Fill(this.stuDataSet.Course);
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)//修改
        {

            String Cno = textBox5.Text.Trim();
            String select = comboBox1.Text.Trim();
            String change = textBox6.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            if (Cno == "")
            {
                MessageBox.Show("课程号不可为空");
                return;
            }
            else if (select == "")
            {
                MessageBox.Show("修改项不可为空");
                return;
            }
            else if (change == ""&&select!="Cpno")
            {
                MessageBox.Show("修改内容不可为空");
                return;
            }
            if (select == "Cpno"&&change!="")
            {
                
                String select_by_id2 = "select * from Course where Cno='" + change + "'";
                SqlCommand cmd2 = new SqlCommand(select_by_id2, con);
                SqlDataReader m2 = cmd2.ExecuteReader();
                if (!m2.HasRows)
                {
                    MessageBox.Show("该先行课不存在");
                    return;
                }
                m2.Close();
            }
            else if (select == "Ccredit"&& int.Parse(change) <= 0)
            {
                MessageBox.Show("学分必须大于0");
                return;
            }
            try
            {
               
                string insertStr;
                if(select=="Ccredit") insertStr="UPDATE Course SET " + select + " = " + change + "WHERE Cno = '" + Cno + "'";
                else insertStr = "UPDATE Course SET "+select+" = '" + change + "'WHERE Cno = '" + Cno + "'";
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
            this.courseTableAdapter.Fill(this.stuDataSet.Course);
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//查询
        {
            String Cno = textBox7.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
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

        private void 课程表_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//刷新
        {
            refresh();
        }
        private void refresh()
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
            con.Close();
        }
    }   
}
