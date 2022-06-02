using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Manager : Form
    {
        public static string table = "";
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentTable f1 = new StudentTable();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseTable f3 = new CourseTable();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SCTable f4 = new SCTable();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign1 f5 = new Sign1();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)//账户信息管理
        {
            Account ac = new Account();
            ac.Show();
        }
    }
}
