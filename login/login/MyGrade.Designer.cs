
namespace login
{
    partial class MyGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGrade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuDataSet = new login.StuDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.sCTableAdapter = new login.StuDataSetTableAdapters.SCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(494, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的成绩";
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // MyGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::login.Properties.Resources._13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private StuDataSet stuDataSet;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private StuDataSetTableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}