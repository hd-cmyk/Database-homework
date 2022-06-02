
namespace login
{
    partial class MySC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet = new login.StuDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.courseTableAdapter = new login.StuDataSetTableAdapters.CourseTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCTableAdapter = new login.StuDataSetTableAdapters.SCTableAdapter();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(22, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(560, 290);
            this.dataGridView1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(215, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "所有课程";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(883, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "已选课程";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn1,
            this.Cname,
            this.Cpno,
            this.Ccredit});
            this.dataGridView2.DataSource = this.courseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(660, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(560, 290);
            this.dataGridView2.TabIndex = 3;
            // 
            // cnoDataGridViewTextBoxColumn1
            // 
            this.cnoDataGridViewTextBoxColumn1.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn1.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn1.Name = "cnoDataGridViewTextBoxColumn1";
            this.cnoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Cname
            // 
            this.Cname.DataPropertyName = "Cname";
            this.Cname.HeaderText = "Cname";
            this.Cname.MinimumWidth = 6;
            this.Cname.Name = "Cname";
            this.Cname.Width = 125;
            // 
            // Cpno
            // 
            this.Cpno.DataPropertyName = "Cpno";
            this.Cpno.HeaderText = "Cpno";
            this.Cpno.MinimumWidth = 6;
            this.Cpno.Name = "Cpno";
            this.Cpno.Width = 125;
            // 
            // Ccredit
            // 
            this.Ccredit.DataPropertyName = "Ccredit";
            this.Ccredit.HeaderText = "Ccredit";
            this.Ccredit.MinimumWidth = 6;
            this.Ccredit.Name = "Ccredit";
            this.Ccredit.Width = 125;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.stuDataSet;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(874, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "退课";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1142, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入想选课程的编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 25);
            this.textBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(383, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(492, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "选课";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "学号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.stuDataSet;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.stuDataSet;
            // 
            // MySC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MySC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySC";
            this.Load += new System.EventHandler(this.MySC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private StuDataSet stuDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private StuDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private StuDataSetTableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccredit;
        private System.Windows.Forms.BindingSource courseBindingSource2;
    }
}