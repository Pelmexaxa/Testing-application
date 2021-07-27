
namespace TestingApplication
{
    partial class ChangeSelfInfo
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
            this.textBox_sal = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_work = new System.Windows.Forms.GroupBox();
            this.radioButton_sa = new System.Windows.Forms.RadioButton();
            this.radioButton_ma = new System.Windows.Forms.RadioButton();
            this.radioButton_em = new System.Windows.Forms.RadioButton();
            this.button_reg = new System.Windows.Forms.Button();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_second_name = new System.Windows.Forms.TextBox();
            this.label_second_name = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox_work.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_sal
            // 
            this.textBox_sal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_sal.Location = new System.Drawing.Point(121, 224);
            this.textBox_sal.Name = "textBox_sal";
            this.textBox_sal.Size = new System.Drawing.Size(163, 20);
            this.textBox_sal.TabIndex = 25;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(47, 224);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(68, 26);
            this.label_salary.TabIndex = 32;
            this.label_salary.Text = "Базовая ЗП\r\n(руб)";
            this.label_salary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 26, 0, 0, 0, 0);
            // 
            // groupBox_work
            // 
            this.groupBox_work.Controls.Add(this.radioButton_sa);
            this.groupBox_work.Controls.Add(this.radioButton_ma);
            this.groupBox_work.Controls.Add(this.radioButton_em);
            this.groupBox_work.Location = new System.Drawing.Point(121, 78);
            this.groupBox_work.Name = "groupBox_work";
            this.groupBox_work.Size = new System.Drawing.Size(164, 89);
            this.groupBox_work.TabIndex = 23;
            this.groupBox_work.TabStop = false;
            this.groupBox_work.Text = "Категория рабочего";
            // 
            // radioButton_sa
            // 
            this.radioButton_sa.AutoSize = true;
            this.radioButton_sa.Location = new System.Drawing.Point(6, 64);
            this.radioButton_sa.Name = "radioButton_sa";
            this.radioButton_sa.Size = new System.Drawing.Size(71, 17);
            this.radioButton_sa.TabIndex = 4;
            this.radioButton_sa.TabStop = true;
            this.radioButton_sa.Text = "Salesman";
            this.radioButton_sa.UseVisualStyleBackColor = true;
            // 
            // radioButton_ma
            // 
            this.radioButton_ma.AutoSize = true;
            this.radioButton_ma.Location = new System.Drawing.Point(6, 41);
            this.radioButton_ma.Name = "radioButton_ma";
            this.radioButton_ma.Size = new System.Drawing.Size(67, 17);
            this.radioButton_ma.TabIndex = 3;
            this.radioButton_ma.TabStop = true;
            this.radioButton_ma.Text = "Manager";
            this.radioButton_ma.UseVisualStyleBackColor = true;
            // 
            // radioButton_em
            // 
            this.radioButton_em.AutoSize = true;
            this.radioButton_em.Location = new System.Drawing.Point(6, 18);
            this.radioButton_em.Name = "radioButton_em";
            this.radioButton_em.Size = new System.Drawing.Size(71, 17);
            this.radioButton_em.TabIndex = 2;
            this.radioButton_em.TabStop = true;
            this.radioButton_em.Text = "Employee";
            this.radioButton_em.UseVisualStyleBackColor = true;
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(89, 273);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(166, 60);
            this.button_reg.TabIndex = 30;
            this.button_reg.Text = "Изменить";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(23, 179);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(92, 26);
            this.label_data.TabIndex = 27;
            this.label_data.Text = "Дата\r\nтрудоустройства";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(122, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_name.TabIndex = 19;
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(122, 52);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_second_name.TabIndex = 21;
            // 
            // label_second_name
            // 
            this.label_second_name.AutoSize = true;
            this.label_second_name.Location = new System.Drawing.Point(59, 55);
            this.label_second_name.Name = "label_second_name";
            this.label_second_name.Size = new System.Drawing.Size(56, 13);
            this.label_second_name.TabIndex = 22;
            this.label_second_name.Text = "Фамилия";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(86, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Имя";
            // 
            // ChangeSelfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 361);
            this.Controls.Add(this.textBox_sal);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox_work);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_second_name);
            this.Controls.Add(this.label_second_name);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeSelfInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.ChangeSelfInfo_Load);
            this.groupBox_work.ResumeLayout(false);
            this.groupBox_work.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sal;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox_work;
        private System.Windows.Forms.RadioButton radioButton_sa;
        private System.Windows.Forms.RadioButton radioButton_ma;
        private System.Windows.Forms.RadioButton radioButton_em;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_second_name;
        private System.Windows.Forms.Label label_second_name;
        private System.Windows.Forms.Label label_name;
    }
}