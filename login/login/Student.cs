using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Student : Form
    {
        
        public Student()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            InitializeComponent();
            label6.Text = Sign1.id;
            String select_by_id = "select * from Student_Account where Account='" + Sign1.id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(select_by_id, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Byte[] picture = new Byte[0];
            picture = (Byte[])(dt.Rows[0][4]);
            MemoryStream stream = new MemoryStream(picture);
            pictureBox1.Image = Image.FromStream(stream);
           
        }
        public static string id = Sign1.id;
        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            try
            {
                con.Open();
                String select_by_id = "Select * from Student where Sno = '" + label6.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(select_by_id, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string name = dt.Rows[0][1].ToString();
                string sex = dt.Rows[0][2].ToString();
                string age = dt.Rows[0][3].ToString();
                string dept=dt.Rows[0][4].ToString();
                label7.Text = name.Trim();
                label8.Text = sex.Trim();
                label9.Text = age.Trim();
                label10.Text = dept.Trim();
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)//课表
        {
            MyCourse M1 = new MyCourse();
            M1.Show();
        }

        private void button4_Click(object sender, EventArgs e)//成绩
        {
            MyGrade g = new MyGrade();
            g.Show();
        }

        private void button5_Click(object sender, EventArgs e)//选课退课
        {
            MySC c = new MySC();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign1 f1 = new Sign1();
            f1.Show();
        }
       
    
    }
}
