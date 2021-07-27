
namespace TestingApplication
{
    partial class Registration
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_second_name = new System.Windows.Forms.Label();
            this.textBox_second_name = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.groupBox_work = new System.Windows.Forms.GroupBox();
            this.radioButton_sa = new System.Windows.Forms.RadioButton();
            this.radioButton_ma = new System.Windows.Forms.RadioButton();
            this.radioButton_em = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_sal = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.groupBox_work.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(74, 37);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Имя";
            // 
            // label_second_name
            // 
            this.label_second_name.AutoSize = true;
            this.label_second_name.Location = new System.Drawing.Point(47, 63);
            this.label_second_name.Name = "label_second_name";
            this.label_second_name.Size = new System.Drawing.Size(56, 13);
            this.label_second_name.TabIndex = 1;
            this.label_second_name.Text = "Фамилия";
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(110, 60);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_second_name.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(110, 34);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(11, 187);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(92, 26);
            this.label_data.TabIndex = 7;
            this.label_data.Text = "Дата\r\nтрудоустройства";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(109, 287);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(164, 20);
            this.textBox_login.TabIndex = 7;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(109, 327);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(164, 20);
            this.textBox_password.TabIndex = 8;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(5, 327);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 26);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Пароль для входа\r\nв систему";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(11, 287);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(91, 26);
            this.label_login.TabIndex = 8;
            this.label_login.Text = "Логин для входа\r\nв систему";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(67, 372);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(166, 60);
            this.button_reg.TabIndex = 9;
            this.button_reg.Text = "Зарегистрироваться";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // groupBox_work
            // 
            this.groupBox_work.Controls.Add(this.radioButton_sa);
            this.groupBox_work.Controls.Add(this.radioButton_ma);
            this.groupBox_work.Controls.Add(this.radioButton_em);
            this.groupBox_work.Location = new System.Drawing.Point(109, 86);
            this.groupBox_work.Name = "groupBox_work";
            this.groupBox_work.Size = new System.Drawing.Size(164, 89);
            this.groupBox_work.TabIndex = 2;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 26, 0, 0, 0, 0);
            // 
            // textBox_sal
            // 
            this.textBox_sal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_sal.Location = new System.Drawing.Point(109, 232);
            this.textBox_sal.Name = "textBox_sal";
            this.textBox_sal.Size = new System.Drawing.Size(163, 20);
            this.textBox_sal.TabIndex = 6;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(35, 232);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(68, 26);
            this.label_salary.TabIndex = 18;
            this.label_salary.Text = "Базовая ЗП\r\n(руб)";
            this.label_salary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 462);
            this.Controls.Add(this.textBox_sal);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox_work);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_second_name);
            this.Controls.Add(this.label_second_name);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.groupBox_work.ResumeLayout(false);
            this.groupBox_work.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_second_name;
        private System.Windows.Forms.TextBox textBox_second_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.GroupBox groupBox_work;
        private System.Windows.Forms.RadioButton radioButton_sa;
        private System.Windows.Forms.RadioButton radioButton_ma;
        private System.Windows.Forms.RadioButton radioButton_em;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_sal;
        private System.Windows.Forms.Label label_salary;
    }
}