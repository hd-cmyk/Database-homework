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

    public partial class Sign1 : Form
    {
       bool showPW = false;
       public static string user = "";
       public static string id = "201215121";
       public static string yzm = "";
        public Sign1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';//输入密码以 * 展示
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random1();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "学生") user = "学生";
            else if (comboBox1.Text.Trim() == "管理员") user = "管理员";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (user == "")
            {
                MessageBox.Show("请选择身份");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号/学号");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入账号/学号");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入验证码");
                return;
            }
            if (textBox3.Text != yzm)
            {
                MessageBox.Show("验证码输入错误");
                return;
            }
            string table = "";
            if (user == "学生") table = "Student_Account";
            else if (user == "管理员") table = "Manager_Account";
            id = textBox1.Text.Trim();
            string password = EncryptWithMD5(textBox2.Text.Trim());
            String select1 = "select * from "+table+" where account='" + id + "'";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(select1, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//读取数据
            if (sqlDataReader.HasRows)//判断账号是否存在
            {
                sqlDataReader.Close();
                String select2= "select * from " + table + " where account='" + id + "' AND password='"+password+"'";
                SqlCommand sqlCommand2 = new SqlCommand(select2, con);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
                if (sqlDataReader2.HasRows)
                {
                    MessageBox.Show("登录成功");
                    if (user == "学生")
                    {
                        Student s = new Student();
                        s.Show();
                    }
                    else
                    {
                        Manager m = new Manager();
                        m.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("密码输入错误");
                    return;
                }
            }
            else
            {
                MessageBox.Show("不存在该账号");
                return ;
            }

            Sign1.id = textBox1.Text.Trim();
        }
        private void Random1()
        {
            Bitmap map = new Bitmap(100, 35);
            Graphics c = Graphics.FromImage(map);
            
            Random myrandom = new Random();
            string str = "";
            for (int i = 0; i < 5; i++)
            {
                int x = myrandom.Next(0, 10);
                str += x;
            }
            yzm = str;
            string[] myfont = { "宋体", "楷体", "仿宋", "隶书", "微软雅黑" };
            Color[] mycolor = { Color.Red, Color.Black, Color.Blue, Color.Green, Color.Brown };

            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 20, 0);
                c.DrawString(str[i].ToString(), new Font(myfont[i], 16, FontStyle.Bold), new SolidBrush(mycolor[i]), p);

            }


            for (int i = 0; i < 500; i++)
            {
                Point p = new Point(myrandom.Next(0, map.Width), myrandom.Next(0, map.Height));
                map.SetPixel(p.X, p.Y, Color.Black);
            }
            pictureBox1.Image=map;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random1();
        }


        private void button2_Click(object sender, EventArgs e)//注册
        {
            if (user == "管理员")
            {
                Register f3 = new Register();
                f3.Show();
            }
            else
            {
                Register1 ff = new Register1();
                ff.Show();
            }   
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showPW = !showPW;
            if (showPW)
            {
                textBox2.PasswordChar = '\0';//输入密码以实际输入结果展示
               
            }
            else
            {
                textBox2.PasswordChar = '*';//输入密码以 * 展示
               
            }


        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (user == "") MessageBox.Show("请选择身份");
            else
            {
                Forget fg = new Forget();
                fg.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random1();
        }
    }
}
