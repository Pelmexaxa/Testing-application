using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApplication
{
    public partial class Registration : Form
    {
        
        SqlConnection sqlConnection;
        private string connectionString = "";
        SqlDataReader sqlReader;

        private List<bool> chek = new List<bool>() {false, false, false, false, false };
        public Registration()
        {
            InitializeComponent();
            //var path = Convert.ToString(Environment.CurrentDirectory);
            //FileInfo file = new FileInfo(path);
            //DirectoryInfo fileBD = file.Directory.Parent.Parent;
            //Console.WriteLine("FILE BF = " + fileBD);
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlReader = null;
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            var Access = true;
            var Work = "";
            List<string> access_list = new List<string>() { };

            sqlConnection.Open();

            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                label_name.ForeColor = Color.Red;
                chek[0] = false;
            }
            else
            {
                label_name.ForeColor = Color.Black;
                chek[0] = true;
            }

            if (string.IsNullOrEmpty(textBox_second_name.Text))
            {
                label_second_name.ForeColor = Color.Red;
                chek[1] = false;
            }
            else
            {
                label_second_name.ForeColor = Color.Black;
                chek[1] = true;
            }

            if (radioButton_em.Checked == false && radioButton_ma.Checked == false && radioButton_sa.Checked == false)
            {
                groupBox_work.ForeColor = Color.Red;
                chek[2] = false;
            }
            else
            {
                groupBox_work.ForeColor = Color.Black;
                chek[2] = true;
                if (radioButton_em.Checked) { Work = "Employee"; }
                if (radioButton_ma.Checked) { Work = "Manager"; }
                if (radioButton_sa.Checked) { Work = "Salesman"; }
            }

            if (string.IsNullOrEmpty(textBox_login.Text))
            {
                label_login.ForeColor = Color.Red;
                chek[3] = false;
            }
            else
            {
                label_login.ForeColor = Color.Black;
                chek[3] = true;
            }

            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                label_password.ForeColor = Color.Red;
                chek[4] = false;
            }
            else
            {
                label_password.ForeColor = Color.Black;
                chek[4] = true;
            }


            //for (int i = 0; i < chek.Count; i++)
            //    Console.WriteLine(chek[i]);

            if (chek[0] == true && chek[1] == true && chek[2] == true && chek[3] == true && chek[4] == true)
            {
                SqlCommand command_get = new SqlCommand("SELECT LoginCharacter FROM [CharacterData]", sqlConnection);
                try
                {
                    sqlReader = command_get.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        string login = Convert.ToString(sqlReader["LoginCharacter"]);
                        access_list.Add(login);

                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString(), error.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }

                sqlConnection.Open();
                for (int i = 0; i < access_list.Count; i++)
                {
                    if (access_list[i] == textBox_login.Text)
                    {
                        DialogResult err = MessageBox.Show("Данный логин - занят", "Уведомление", MessageBoxButtons.OK);
                        Access = false;

                        if (err == DialogResult.OK)
                        {
                            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                            {
                                sqlConnection.Close();
                            }
                        }
                    }
                }

                if (Access == true)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO [CharacterData] (FirstName, LastName, TypeWork, DataEnjoy, Salary, LoginCharacter, Pass, Boss)VALUES(@FirstName, @LastName, @TypeWork, @DataEnjoy, @Salary, @LoginCharacter, @Pass, @Boss)", sqlConnection);
                    command.Parameters.AddWithValue("FirstName", textBox_name.Text);
                    command.Parameters.AddWithValue("LastName", textBox_second_name.Text);
                    command.Parameters.AddWithValue("TypeWork", Work);
                    command.Parameters.AddWithValue("DataEnjoy", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("Salary", textBox_sal.Text);
                    command.Parameters.AddWithValue("LoginCharacter", textBox_login.Text);
                    command.Parameters.AddWithValue("Pass", textBox_password.Text);

                    command.Parameters.AddWithValue("Boss", "Нет");

                    command.ExecuteNonQuery();

                    DialogResult result = MessageBox.Show("Регистрация прошла успешно", "Уведомление", MessageBoxButtons.OK);

                    if (sqlReader != null)
                        sqlReader.Close();
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }

                    if (result == DialogResult.OK) { this.Close(); }
                }
            }

            if (sqlReader != null)
                sqlReader.Close();
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
