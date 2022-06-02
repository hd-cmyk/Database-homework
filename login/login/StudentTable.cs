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
    public partial class StudentTable : Form
    {
        public StudentTable()
        {
            InitializeComponent();
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.stuDataSet.Student);
        }

        private void button1_Click(object sender, EventArgs e)//增加
        {
            String Sno = textBox1.Text.Trim();
            String Sname = textBox2.Text.Trim();
            String Ssex = "";
            String Sage = textBox4.Text.Trim();
            String Sdept = textBox8.Text.Trim();
            if (radioButton1.Checked) Ssex = "男";
            else  if(radioButton2.Checked)Ssex = "女";
            if (Sno == "")
            {
                MessageBox.Show("学号不可为空");
                return;
            }
            else if (Sname == "")
            {
                MessageBox.Show("学生姓名称不可为空");
                return;
            }
            else if (Sage == "")
            {
                MessageBox.Show("学生年龄不可为空");
                return;
            }
            else if(int.Parse(Sage) <= 0)
            {
                MessageBox.Show("学生年龄必须大于0");
                return;
            }
            else if (Sdept == "")
            {
                MessageBox.Show("系名不可为空");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");
            con.Open();
            String select_by_id1 = "select * from Student where Sno='" + Sno + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (m1.HasRows)
            {
                MessageBox.Show("该学号已存在");
                return;
            }
            m1.Close();
            string insertStr = "INSERT INTO  Student (Sno,Sname,Ssex,Sdept,Sage)" +
                    "VALUES ('" + Sno + "','" + Sname + "','" + Ssex + "','" + Sdept + "'," + Sage + ")";

            try
            {
                
                SqlCommand cmd = new SqlCommand(insertStr,con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!"+insertStr);
            }
            finally
            {
                con.Dispose();
            }
            this.studentTableAdapter.Fill(this.stuDataSet.Student);
            refresh(); 
        }

        private void button2_Click(object sender, EventArgs e)//修改
        {
            String Sno = textBox5.Text.Trim();
            String select = comboBox1.Text.Trim();
            String change = textBox6.Text.Trim();
            if (Sno == "")
            {
                MessageBox.Show("学号不可为空");
                return;
            }
            else if (select == "")
            {
                MessageBox.Show("修改项不可为空");
                return;
            }
            else if (change == "")
            {
                MessageBox.Show("修改内容不可为空");
                return;
            }
            if(select=="Sage"&&int.Parse(change) < 0)
            {
                MessageBox.Show("学生年龄必须大于0");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");
            String select_by_id1 = "select * from Student where Sno='" + Sno + "'";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (!m1.HasRows)
            {
                MessageBox.Show("该学号不存在");
                return;
            }
            m1.Close();
            String insertStr;
            try
            {
                if (select != "Sage") insertStr = "UPDATE Student SET " + select + " = '" + change + "' WHERE Sno = '" + Sno + "'";
                else insertStr = "UPDATE Student SET " + select + " = " + change + " WHERE Sno = '" + Sno + "'";
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
            this.studentTableAdapter.Fill(this.stuDataSet.Student);
            refresh();
        }
        private void button3_Click(object sender, EventArgs e)//删除
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            string select_id1 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
            String select_by_id1 = "select * from SC where Sno='" + select_id1 + "'";
            SqlCommand cmd1 = new SqlCommand(select_by_id1, con);
            SqlDataReader m1 = cmd1.ExecuteReader();
            if (m1.HasRows)
            {
                MessageBox.Show("该学号已经在选课表被引用中");
                return;
            }
            m1.Close();
            try
            {
                string select_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from Student where Sno=" + select_id;//sql删除语句
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
            this.studentTableAdapter.Fill(this.stuDataSet.Student);
            refresh();
        }
        private void button4_Click(object sender, EventArgs e)//查询
        {
            String StuID = textBox7.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {
                con.Open();
                String select_by_id = "select * from Student where Sno='" + StuID + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("该学号不存在");
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            String select_by_id = "select * from Student";
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
