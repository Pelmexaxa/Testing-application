
namespace TestingApplication
{
    partial class Report
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox_age = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ChangePerson = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column_Mouth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SalaryAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CountSlave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SalarySlave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_OtherSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_AllMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_age);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_ChangePerson);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(744, 321);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 5;
            // 
            // comboBox_age
            // 
            this.comboBox_age.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_age.FormattingEnabled = true;
            this.comboBox_age.Location = new System.Drawing.Point(386, 9);
            this.comboBox_age.Name = "comboBox_age";
            this.comboBox_age.Size = new System.Drawing.Size(68, 21);
            this.comboBox_age.TabIndex = 10;
            this.comboBox_age.SelectedIndexChanged += new System.EventHandler(this.comboBox_age_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите сотрудника";
            // 
            // comboBox_ChangePerson
            // 
            this.comboBox_ChangePerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_ChangePerson.FormattingEnabled = true;
            this.comboBox_ChangePerson.Location = new System.Drawing.Point(136, 9);
            this.comboBox_ChangePerson.Name = "comboBox_ChangePerson";
            this.comboBox_ChangePerson.Size = new System.Drawing.Size(164, 21);
            this.comboBox_ChangePerson.TabIndex = 5;
            this.comboBox_ChangePerson.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChangePerson_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Mouth,
            this.Column_BaseSalary,
            this.Column_SalaryAge,
            this.Column_CountSlave,
            this.Column_SalarySlave,
            this.Column_OtherSalary,
            this.Column_AllMoney});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(744, 284);
            this.dataGridView.TabIndex = 3;
            // 
            // Column_Mouth
            // 
            this.Column_Mouth.HeaderText = "Месяц";
            this.Column_Mouth.Name = "Column_Mouth";
            // 
            // Column_BaseSalary
            // 
            this.Column_BaseSalary.HeaderText = "Базовая ставка";
            this.Column_BaseSalary.Name = "Column_BaseSalary";
            this.Column_BaseSalary.ReadOnly = true;
            // 
            // Column_SalaryAge
            // 
            this.Column_SalaryAge.HeaderText = "Надбавка со стажа";
            this.Column_SalaryAge.Name = "Column_SalaryAge";
            this.Column_SalaryAge.ReadOnly = true;
            // 
            // Column_CountSlave
            // 
            this.Column_CountSlave.HeaderText = "Кол-во подчинённых";
            this.Column_CountSlave.Name = "Column_CountSlave";
            // 
            // Column_SalarySlave
            // 
            this.Column_SalarySlave.HeaderText = "Надбавка за руководство";
            this.Column_SalarySlave.Name = "Column_SalarySlave";
            this.Column_SalarySlave.ReadOnly = true;
            // 
            // Column_OtherSalary
            // 
            this.Column_OtherSalary.HeaderText = "Прочие надбавки";
            this.Column_OtherSalary.Name = "Column_OtherSalary";
            // 
            // Column_AllMoney
            // 
            this.Column_AllMoney.HeaderText = "Общий заработок";
            this.Column_AllMoney.Name = "Column_AllMoney";
            this.Column_AllMoney.ReadOnly = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 321);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(760, 360);
            this.Name = "Report";
            this.ShowIcon = false;
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.Report_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Mouth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SalaryAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CountSlave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SalarySlave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_OtherSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_AllMoney;
        public System.Windows.Forms.ComboBox comboBox_ChangePerson;
        public System.Windows.Forms.Label label1;
    }
}