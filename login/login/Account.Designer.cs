
namespace login
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.button1 = new System.Windows.Forms.Button();
            this.stuDataSet1 = new login.StuDataSet1();
            this.managerAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_AccountTableAdapter = new login.StuDataSet1TableAdapters.Manager_AccountTableAdapter();
            this.stuDataSet2 = new login.StuDataSet2();
            this.stuDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_AccountTableAdapter = new login.StuDataSet2TableAdapters.Student_AccountTableAdapter();
            this.managerAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_AccountTableAdapter1 = new login.StuDataSet2TableAdapters.Manager_AccountTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerAccountBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet3 = new login.StuDataSet3();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.accountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerAccountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.managerAccountBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.managerAccountBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerAccountBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.managerAccountBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_AccountTableAdapter2 = new login.StuDataSet3TableAdapters.Manager_AccountTableAdapter();
            this.studentAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_AccountTableAdapter1 = new login.StuDataSet3TableAdapters.Student_AccountTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(494, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除用户";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stuDataSet1
            // 
            this.stuDataSet1.DataSetName = "StuDataSet1";
            this.stuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerAccountBindingSource
            // 
            this.managerAccountBindingSource.DataMember = "Manager_Account";
            this.managerAccountBindingSource.DataSource = this.stuDataSet1;
            // 
            // manager_AccountTableAdapter
            // 
            this.manager_AccountTableAdapter.ClearBeforeFill = true;
            // 
            // stuDataSet2
            // 
            this.stuDataSet2.DataSetName = "StuDataSet2";
            this.stuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuDataSet2BindingSource
            // 
            this.stuDataSet2BindingSource.DataSource = this.stuDataSet2;
            this.stuDataSet2BindingSource.Position = 0;
            // 
            // studentAccountBindingSource
            // 
            this.studentAccountBindingSource.DataMember = "Student_Account";
            this.studentAccountBindingSource.DataSource = this.stuDataSet2BindingSource;
            // 
            // student_AccountTableAdapter
            // 
            this.student_AccountTableAdapter.ClearBeforeFill = true;
            // 
            // managerAccountBindingSource1
            // 
            this.managerAccountBindingSource1.DataMember = "Manager_Account";
            this.managerAccountBindingSource1.DataSource = this.stuDataSet2BindingSource;
            // 
            // manager_AccountTableAdapter1
            // 
            this.manager_AccountTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(33, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 367);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员用户";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managerAccountBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(636, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "account";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 125;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerAccountBindingSource7
            // 
            this.managerAccountBindingSource7.DataMember = "Manager_Account";
            this.managerAccountBindingSource7.DataSource = this.stuDataSet3;
            // 
            // stuDataSet3
            // 
            this.stuDataSet3.DataSetName = "StuDataSet3";
            this.stuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "学生用户";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.questionDataGridViewTextBoxColumn1,
            this.answerDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.studentAccountBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(640, 329);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // accountDataGridViewTextBoxColumn1
            // 
            this.accountDataGridViewTextBoxColumn1.DataPropertyName = "account";
            this.accountDataGridViewTextBoxColumn1.HeaderText = "account";
            this.accountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.accountDataGridViewTextBoxColumn1.Name = "accountDataGridViewTextBoxColumn1";
            this.accountDataGridViewTextBoxColumn1.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.Width = 125;
            // 
            // questionDataGridViewTextBoxColumn1
            // 
            this.questionDataGridViewTextBoxColumn1.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn1.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.questionDataGridViewTextBoxColumn1.Name = "questionDataGridViewTextBoxColumn1";
            this.questionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // answerDataGridViewTextBoxColumn1
            // 
            this.answerDataGridViewTextBoxColumn1.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn1.HeaderText = "answer";
            this.answerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.answerDataGridViewTextBoxColumn1.Name = "answerDataGridViewTextBoxColumn1";
            this.answerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // managerAccountBindingSource2
            // 
            this.managerAccountBindingSource2.DataMember = "Manager_Account";
            this.managerAccountBindingSource2.DataSource = this.stuDataSet2BindingSource;
            // 
            // managerAccountBindingSource3
            // 
            this.managerAccountBindingSource3.DataMember = "Manager_Account";
            this.managerAccountBindingSource3.DataSource = this.stuDataSet2BindingSource;
            // 
            // managerAccountBindingSource4
            // 
            this.managerAccountBindingSource4.DataMember = "Manager_Account";
            this.managerAccountBindingSource4.DataSource = this.stuDataSet2BindingSource;
            // 
            // stuDataSet2BindingSource1
            // 
            this.stuDataSet2BindingSource1.DataSource = this.stuDataSet2;
            this.stuDataSet2BindingSource1.Position = 0;
            // 
            // managerAccountBindingSource5
            // 
            this.managerAccountBindingSource5.DataMember = "Manager_Account";
            this.managerAccountBindingSource5.DataSource = this.stuDataSet2BindingSource1;
            // 
            // managerAccountBindingSource6
            // 
            this.managerAccountBindingSource6.DataMember = "Manager_Account";
            this.managerAccountBindingSource6.DataSource = this.stuDataSet3;
            // 
            // manager_AccountTableAdapter2
            // 
            this.manager_AccountTableAdapter2.ClearBeforeFill = true;
            // 
            // studentAccountBindingSource1
            // 
            this.studentAccountBindingSource1.DataMember = "Student_Account";
            this.studentAccountBindingSource1.DataSource = this.stuDataSet3;
            // 
            // student_AccountTableAdapter1
            // 
            this.student_AccountTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(175, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "增加用户";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(749, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAccountBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private StuDataSet1 stuDataSet1;
        private System.Windows.Forms.BindingSource managerAccountBindingSource;
        private StuDataSet1TableAdapters.Manager_AccountTableAdapter manager_AccountTableAdapter;
        private System.Windows.Forms.BindingSource stuDataSet2BindingSource;
        private StuDataSet2 stuDataSet2;
        private System.Windows.Forms.BindingSource studentAccountBindingSource;
        private StuDataSet2TableAdapters.Student_AccountTableAdapter student_AccountTableAdapter;
        private System.Windows.Forms.BindingSource managerAccountBindingSource1;
        private StuDataSet2TableAdapters.Manager_AccountTableAdapter manager_AccountTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource managerAccountBindingSource2;
        private System.Windows.Forms.BindingSource managerAccountBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource managerAccountBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource managerAccountBindingSource5;
        private System.Windows.Forms.BindingSource stuDataSet2BindingSource1;
        private StuDataSet3 stuDataSet3;
        private System.Windows.Forms.BindingSource managerAccountBindingSource6;
        private StuDataSet3TableAdapters.Manager_AccountTableAdapter manager_AccountTableAdapter2;
        private System.Windows.Forms.BindingSource studentAccountBindingSource1;
        private StuDataSet3TableAdapters.Student_AccountTableAdapter student_AccountTableAdapter1;
        private System.Windows.Forms.BindingSource managerAccountBindingSource7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}