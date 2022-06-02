using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Register1 : Form
    {
        public Register1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';//输入密码以 * 展示
            textBox3.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string table = "Student_Account";
            string account = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string password1 = textBox3.Text.Trim();
            string question = textBox4.Text.Trim();
            string answer = textBox5.Text.Trim();
            if (account == "")
            {
                MessageBox.Show("学号不可为空");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("新密码不可为空");
                return;
            }
            if (question == "")
            {
                MessageBox.Show("密钥问题不可为空");
                return;
            }
            if (answer == "")
            {
                MessageBox.Show("密钥答案不可为空");
            }
            if (picturePath == "")
            {
                MessageBox.Show("请上传图片！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (password1 != password) MessageBox.Show("两次密码输入不一致");
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象 
                con.Open();
                String select = "select * from Student where Sno ='" + textBox1.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(select, con);
                SqlDataReader m = sqlCommand.ExecuteReader();
                if (!m.HasRows)
                {
                    MessageBox.Show("不存在该学号！");
                    m.Close();
                    con.Close();
                    return;
                }
                m.Close();
                String id = "select * from " + table + " where Account ='" + textBox1.Text + "'";
                SqlCommand sqlCommand1 = new SqlCommand(id, con);
                SqlDataReader m1 = sqlCommand1.ExecuteReader();
                if (m1.HasRows)
                {
                    MessageBox.Show("学生账户已存在！");
                    m1.Close();
                    con.Close();
                    return;
                }
                m1.Close();
                string sql = "insert into Student_Account (account,password,question,answer,photo) " +
                                                        "values (@account, @password,@question,@answer,@photo)";
                SqlCommand command = new SqlCommand(sql, con);
                SqlParameter sqlParameter = new SqlParameter("@account", account);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@password", EncryptWithMD5(password));
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@question",question);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@answer", answer);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@photo", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                command.Parameters.Add(sqlParameter);
                command.ExecuteNonQuery();

                MessageBox.Show("注册成功");
                this.Close();
            }
        }
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

        public Byte[] mybyte = new byte[0];
        string picturePath = "";
        private void button2_Click(object sender, EventArgs e)//头像
        {
            //打开浏览图片对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            picturePath = openFileDialog.FileName;//获取图片路径
                                                  //文件的名称，每次必须更换图片的名称，这里很为不便
                                                  //创建FileStream对象
            if (picturePath == "")
            {
                return;
            }
            FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
            //声明Byte数组
            mybyte = new byte[fs.Length];
            //读取数据
            fs.Read(mybyte, 0, mybyte.Length);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
        }
       
    }
}
