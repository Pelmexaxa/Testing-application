
namespace TestingApplication
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бухгалтерияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TypeWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BasisZP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DataEnjoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DataCalcNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Boss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менеджментToolStripMenuItem,
            this.бухгалтерияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выходToolStripMenuItem.Text = "Выход из учетной записи";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // менеджментToolStripMenuItem
            // 
            this.менеджментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeamToolStripMenuItem,
            this.selfInfoToolStripMenuItem});
            this.менеджментToolStripMenuItem.Name = "менеджментToolStripMenuItem";
            this.менеджментToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.менеджментToolStripMenuItem.Text = "Менеджмент";
            // 
            // TeamToolStripMenuItem
            // 
            this.TeamToolStripMenuItem.Name = "TeamToolStripMenuItem";
            this.TeamToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.TeamToolStripMenuItem.Text = "Команда";
            this.TeamToolStripMenuItem.Click += new System.EventHandler(this.TeamToolStripMenuItem_Click);
            // 
            // selfInfoToolStripMenuItem
            // 
            this.selfInfoToolStripMenuItem.Name = "selfInfoToolStripMenuItem";
            this.selfInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.selfInfoToolStripMenuItem.Text = "Изменить данные о себе";
            this.selfInfoToolStripMenuItem.Click += new System.EventHandler(this.selfInfoToolStripMenuItem_Click);
            // 
            // бухгалтерияToolStripMenuItem
            // 
            this.бухгалтерияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeReportToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.бухгалтерияToolStripMenuItem.Name = "бухгалтерияToolStripMenuItem";
            this.бухгалтерияToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.бухгалтерияToolStripMenuItem.Text = "Бухгалтерия";
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.employeeReportToolStripMenuItem.Text = "Отчёты по сотрудникам";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.reportToolStripMenuItem.Text = "Отчёт";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список подчененных вам сотрудников";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_LastName,
            this.Column_TypeWork,
            this.Column_Salary,
            this.Column_BasisZP,
            this.Column_DataEnjoy,
            this.Column_DataCalcNow,
            this.Column_Boss});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(658, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Имя";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column_LastName
            // 
            this.Column_LastName.HeaderText = "Фамилия";
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            // 
            // Column_TypeWork
            // 
            this.Column_TypeWork.HeaderText = "Класс рабочего";
            this.Column_TypeWork.Name = "Column_TypeWork";
            this.Column_TypeWork.ReadOnly = true;
            // 
            // Column_Salary
            // 
            this.Column_Salary.HeaderText = "Зарплата";
            this.Column_Salary.Name = "Column_Salary";
            this.Column_Salary.ReadOnly = true;
            // 
            // Column_BasisZP
            // 
            this.Column_BasisZP.HeaderText = "Базовая ставка";
            this.Column_BasisZP.Name = "Column_BasisZP";
            this.Column_BasisZP.ReadOnly = true;
            // 
            // Column_DataEnjoy
            // 
            this.Column_DataEnjoy.HeaderText = "Дата принятия на работу";
            this.Column_DataEnjoy.Name = "Column_DataEnjoy";
            this.Column_DataEnjoy.ReadOnly = true;
            // 
            // Column_DataCalcNow
            // 
            this.Column_DataCalcNow.HeaderText = "Лет стажа";
            this.Column_DataCalcNow.Name = "Column_DataCalcNow";
            this.Column_DataCalcNow.ReadOnly = true;
            // 
            // Column_Boss
            // 
            this.Column_Boss.HeaderText = "Начальник";
            this.Column_Boss.Name = "Column_Boss";
            this.Column_Boss.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label3.Location = new System.Drawing.Point(380, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(664, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(680, 290);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Центр управления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бухгалтерияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TypeWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BasisZP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DataEnjoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DataCalcNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Boss;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}