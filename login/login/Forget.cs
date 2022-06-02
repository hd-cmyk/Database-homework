using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Forget : Form
    {
        String table;
        int flag=0;
        public Forget()
        {
            InitializeComponent();
            if (Sign1.user == "学生") label1.Text = "学生重置密码";
            else if (Sign1.user == "管理员") label1.Text = "管理员重置密码";
            label7.Text = "";
        }

        private void Forget_Load(object sender, EventArgs e)
        {
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String account = textBox1.Text.Trim();
            String password = textBox4.Text.Trim();
            String password1 = textBox5.Text.Trim();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();           
            if (flag == 1)//存在账号
            {
                if (password == "")
                {
                    MessageBox.Show("请输入新密码");
                    return;
                }
                if (password == password1)
                {
                    string ans = "select * from " + table + " where account ='" + textBox1.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(ans, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    String s = dt.Rows[0][3].ToString();
                    if (string.Compare(textBox3.Text.Trim(), s.Trim()) != 0)
                    {
                        MessageBox.Show("答案错误！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    string updateStr = "UPDATE "+table+" SET password = '" + EncryptWithMD5(password) + 
                    "' WHERE account = '" + account + "'";
                     SqlCommand cmd = new SqlCommand(updateStr, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("修改密码成功");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("两次密码输入不一致");
                    return;
                }
               
            }
            else
            {
                MessageBox.Show("未获取密匙问题");
            }
            
           
            

        }
        //密码使用MD5加密
        public static string EncryptWithMD5(string source)
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            if (textBox1.Text == "")
            {
                MessageBox.Show("账号不能为空", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
                return;
            }
            con.Open();
            if (Sign1.user == "学生") table = "Student_Account";
            else table = "Manager_Account";
            String id = "select * from "+table+" where account ='" + textBox1.Text + "'";
            SqlCommand comm = new SqlCommand(id, con);
            SqlDataReader m = comm.ExecuteReader();
            if (!m.HasRows)
            {
                MessageBox.Show("不存在该账号！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                m.Close();
                con.Close();
                return;
            }
            m.Close();
            SqlDataAdapter sda = new SqlDataAdapter(id, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label7.Text = dt.Rows[0][2].ToString();
            con.Close();
           
            flag = 1;//存在账号
        }
    }
}
