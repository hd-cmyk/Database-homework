
namespace login
{
    partial class CourseTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TabPage tabPage1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseTable));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet = new login.StuDataSet();
            this.courseTableAdapter = new login.StuDataSetTableAdapters.CourseTableAdapter();
            this.stuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCTableAdapter = new login.StuDataSetTableAdapters.SCTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new login.StuDataSetTableAdapters.StudentTableAdapter();
            this.sCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sCBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.课程表 = new System.Windows.Forms.Label();
            this.m_tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource2)).BeginInit();
            this.m_tabCtrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label3.Location = new System.Drawing.Point(391, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 19);
            label3.TabIndex = 10;
            label3.Text = "Cpno";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabPage1.Controls.Add(this.button1);
            tabPage1.Controls.Add(this.label1);
            tabPage1.Controls.Add(this.textBox1);
            tabPage1.Controls.Add(this.label2);
            tabPage1.Controls.Add(this.textBox4);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(this.textBox3);
            tabPage1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Size = new System.Drawing.Size(664, 144);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "增加";
            tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(361, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cno";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(50, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(177, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cname";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 75);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ccredit";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(255, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 11);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.stuDataSet;
            // 
            // stuDataSet
            // 
            this.stuDataSet.DataSetName = "StuDataSet";
            this.stuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // stuDataSetBindingSource
            // 
            this.stuDataSetBindingSource.DataSource = this.stuDataSet;
            this.stuDataSetBindingSource.Position = 0;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.stuDataSetBindingSource;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cpnoDataGridViewTextBoxColumn,
            this.ccreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(656, 372);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "Cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpnoDataGridViewTextBoxColumn
            // 
            this.cpnoDataGridViewTextBoxColumn.DataPropertyName = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.HeaderText = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpnoDataGridViewTextBoxColumn.Name = "cpnoDataGridViewTextBoxColumn";
            this.cpnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ccreditDataGridViewTextBoxColumn
            // 
            this.ccreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.HeaderText = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ccreditDataGridViewTextBoxColumn.Name = "ccreditDataGridViewTextBoxColumn";
            this.ccreditDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.stuDataSetBindingSource;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // sCBindingSource1
            // 
            this.sCBindingSource1.DataMember = "SC";
            this.sCBindingSource1.DataSource = this.stuDataSetBindingSource;
            // 
            // sCBindingSource2
            // 
            this.sCBindingSource2.DataMember = "SC";
            this.sCBindingSource2.DataSource = this.stuDataSet;
            // 
            // 课程表
            // 
            this.课程表.AutoSize = true;
            this.课程表.BackColor = System.Drawing.Color.Transparent;
            this.课程表.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.课程表.ForeColor = System.Drawing.Color.Black;
            this.课程表.Location = new System.Drawing.Point(12, 18);
            this.课程表.Name = "课程表";
            this.课程表.Size = new System.Drawing.Size(103, 30);
            this.课程表.TabIndex = 14;
            this.课程表.Text = "课程表";
            this.课程表.Click += new System.EventHandler(this.课程表_Click);
            // 
            // m_tabCtrl
            // 
            this.m_tabCtrl.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.m_tabCtrl.Controls.Add(tabPage1);
            this.m_tabCtrl.Controls.Add(this.tabPage2);
            this.m_tabCtrl.Controls.Add(this.tabPage3);
            this.m_tabCtrl.Controls.Add(this.tabPage4);
            this.m_tabCtrl.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_tabCtrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_tabCtrl.ItemSize = new System.Drawing.Size(125, 30);
            this.m_tabCtrl.Location = new System.Drawing.Point(32, 464);
            this.m_tabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_tabCtrl.Name = "m_tabCtrl";
            this.m_tabCtrl.SelectedIndex = 0;
            this.m_tabCtrl.Size = new System.Drawing.Size(672, 182);
            this.m_tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.m_tabCtrl.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(664, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(526, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(300, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "修改为";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(408, 67);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "选择修改项";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cname",
            "Cpno",
            "Ccredit"});
            this.comboBox1.Location = new System.Drawing.Point(160, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(316, 10);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "输入要修改课程的课程号";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(664, 144);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "删除";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(248, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(132, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "在上面的表中选中想要删除的项";
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(664, 144);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(737, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(361, 27);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 28);
            this.textBox7.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(282, 73);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(88, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "输入想查询课程号";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.stuDataSetBindingSource;
            // 
            // CourseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 673);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.m_tabCtrl);
            this.Controls.Add(this.课程表);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseTable";
            this.Load += new System.EventHandler(this.Form6_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource2)).EndInit();
            this.m_tabCtrl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StuDataSet stuDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StuDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource stuDataSetBindingSource;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private StuDataSetTableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StuDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource sCBindingSource1;
        private System.Windows.Forms.BindingSource sCBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label 课程表;
        private System.Windows.Forms.TabControl m_tabCtrl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Button button5;
    }
}