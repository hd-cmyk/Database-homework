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
    public partial class MyCourse : Form
    {

        public MyCourse()
        {
            InitializeComponent();
        }
        private void MyCourse_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stu;User ID=sa;Password=123456");  //实例化连接对象
            // TODO: 这行代码将数据加载到表“stuDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.stuDataSet.Course);
            String id = Sign1.id;
            try
            {
                con.Open();
                String select_by_id = "Select Course.Cno,Cname,Cpno,Ccredit from Course,SC where SC.Cno = Course.Cno AND SC.Sno = '" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(select_by_id, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
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
    }
}
