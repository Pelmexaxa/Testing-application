
namespace TestingApplication
{
    partial class AdminTool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_sal = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_work = new System.Windows.Forms.GroupBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButton_sa = new System.Windows.Forms.RadioButton();
            this.radioButton_ma = new System.Windows.Forms.RadioButton();
            this.radioButton_em = new System.Windows.Forms.RadioButton();
            this.button_reg = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_second_name = new System.Windows.Forms.TextBox();
            this.label_second_name = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox_work.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_sal);
            this.panel1.Controls.Add(this.label_salary);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.groupBox_work);
            this.panel1.Controls.Add(this.button_reg);
            this.panel1.Controls.Add(this.textBox_login);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_login);
            this.panel1.Controls.Add(this.label_data);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_second_name);
            this.panel1.Controls.Add(this.label_second_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Location = new System.Drawing.Point(241, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 426);
            this.panel1.TabIndex = 0;
            // 
            // textBox_sal
            // 
            this.textBox_sal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_sal.Location = new System.Drawing.Point(117, 216);
            this.textBox_sal.Name = "textBox_sal";
            this.textBox_sal.Size = new System.Drawing.Size(163, 20);
            this.textBox_sal.TabIndex = 39;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(43, 216);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(68, 26);
            this.label_salary.TabIndex = 46;
            this.label_salary.Text = "Базовая ЗП\r\n(руб)";
            this.label_salary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 26, 0, 0, 0, 0);
            // 
            // groupBox_work
            // 
            this.groupBox_work.Controls.Add(this.radioButtonAdmin);
            this.groupBox_work.Controls.Add(this.radioButton_sa);
            this.groupBox_work.Controls.Add(this.radioButton_ma);
            this.groupBox_work.Controls.Add(this.radioButton_em);
            this.groupBox_work.Location = new System.Drawing.Point(117, 70);
            this.groupBox_work.Name = "groupBox_work";
            this.groupBox_work.Size = new System.Drawing.Size(164, 89);
            this.groupBox_work.TabIndex = 37;
            this.groupBox_work.TabStop = false;
            this.groupBox_work.Text = "Категория рабочего";
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(83, 19);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 5;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
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
            this.button_reg.Location = new System.Drawing.Point(75, 356);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(166, 60);
            this.button_reg.TabIndex = 44;
            this.button_reg.Text = "Изменить";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(117, 271);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(164, 20);
            this.textBox_login.TabIndex = 40;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(117, 311);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(164, 20);
            this.textBox_password.TabIndex = 42;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(13, 311);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 26);
            this.label_password.TabIndex = 45;
            this.label_password.Text = "Пароль для входа\r\nв систему";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(19, 271);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(91, 26);
            this.label_login.TabIndex = 43;
            this.label_login.Text = "Логин для входа\r\nв систему";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(19, 171);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(92, 26);
            this.label_data.TabIndex = 41;
            this.label_data.Text = "Дата\r\nтрудоустройства";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(118, 18);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_name.TabIndex = 33;
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(118, 44);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(163, 20);
            this.textBox_second_name.TabIndex = 35;
            // 
            // label_second_name
            // 
            this.label_second_name.AutoSize = true;
            this.label_second_name.Location = new System.Drawing.Point(55, 47);
            this.label_second_name.Name = "label_second_name";
            this.label_second_name.Size = new System.Drawing.Size(56, 13);
            this.label_second_name.TabIndex = 36;
            this.label_second_name.Text = "Фамилия";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(82, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 34;
            this.label_name.Text = "Имя";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 369);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список пользователей";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 350);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(38, 387);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(69, 51);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(141, 387);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(69, 51);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // AdminTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 451);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminTool";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.AdminTool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_work.ResumeLayout(false);
            this.groupBox_work.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_sal;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox_work;
        private System.Windows.Forms.RadioButton radioButton_sa;
        private System.Windows.Forms.RadioButton radioButton_ma;
        private System.Windows.Forms.RadioButton radioButton_em;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_second_name;
        private System.Windows.Forms.Label label_second_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}