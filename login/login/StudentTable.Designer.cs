
namespace login
{
    partial class StudentTable
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
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTable));
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet = new login.StuDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new login.StuDataSetTableAdapters.CourseTableAdapter();
            this.sCTableAdapter = new login.StuDataSetTableAdapters.SCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new login.StuDataSetTableAdapters.StudentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.m_tabCtrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.White;
            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tabPage1.Controls.Add(this.radioButton2);
            tabPage1.Controls.Add(this.radioButton1);
            tabPage1.Controls.Add(this.textBox8);
            tabPage1.Controls.Add(this.label6);
            tabPage1.Controls.Add(this.button1);
            tabPage1.Controls.Add(this.label2);
            tabPage1.Controls.Add(this.textBox1);
            tabPage1.Controls.Add(this.label3);
            tabPage1.Controls.Add(this.textBox4);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.textBox2);
            tabPage1.Controls.Add(label5);
            tabPage1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage1.Size = new System.Drawing.Size(664, 144);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "增加";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(540, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 23);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(473, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 23);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(255, 79);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 28);
            this.textBox8.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sdept";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(454, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sno";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(60, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sname";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 80);
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
            this.label4.Location = new System.Drawing.Point(5, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sage";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label5.Location = new System.Drawing.Point(391, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 19);
            label5.TabIndex = 10;
            label5.Text = "Ssex";
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.stuDataSet;
            // 
            // stuDataSet
            // 
            this.stuDataSet.DataSetName = "StuDataSet";
            this.stuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.stuDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生表";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.stuDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(807, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            this.ssexDataGridViewTextBoxColumn.Width = 125;
            // 
            // sageDataGridViewTextBoxColumn
            // 
            this.sageDataGridViewTextBoxColumn.DataPropertyName = "Sage";
            this.sageDataGridViewTextBoxColumn.HeaderText = "Sage";
            this.sageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sageDataGridViewTextBoxColumn.Name = "sageDataGridViewTextBoxColumn";
            this.sageDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdeptDataGridViewTextBoxColumn
            // 
            this.sdeptDataGridViewTextBoxColumn.DataPropertyName = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.HeaderText = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdeptDataGridViewTextBoxColumn.Name = "sdeptDataGridViewTextBoxColumn";
            this.sdeptDataGridViewTextBoxColumn.Width = 125;
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
            this.m_tabCtrl.Location = new System.Drawing.Point(38, 470);
            this.m_tabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_tabCtrl.Name = "m_tabCtrl";
            this.m_tabCtrl.SelectedIndex = 0;
            this.m_tabCtrl.Size = new System.Drawing.Size(672, 182);
            this.m_tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.m_tabCtrl.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(664, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(317, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "修改为";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "选择修改项";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(13, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "输入要修改学生的学号";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(471, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(421, 69);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sname",
            "Ssex",
            "Sage",
            "Sdept"});
            this.comboBox1.Location = new System.Drawing.Point(163, 71);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(321, 21);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button3);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(146, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "在上面的表中选中想要删除的项";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(238, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label10);
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(411, 17);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 28);
            this.textBox7.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(301, 67);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(879, 79);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 45);
            this.button5.TabIndex = 3;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(117, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "输入想查询学生的学号";
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 673);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.m_tabCtrl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentTable";
            this.Load += new System.EventHandler(this.StudentTable_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.m_tabCtrl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StuDataSet stuDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StuDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private StuDataSetTableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StuDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl m_tabCtrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
    }
}