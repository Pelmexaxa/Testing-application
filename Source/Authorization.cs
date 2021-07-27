using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApplication
{

    public partial class Authorization : Form
    {

        SqlConnection sqlConnection;
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True";

        SqlDataReader sqlReader;

        public Authorization()
        {
            TopMost = true;
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlReader = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {

                SqlCommand command = new SqlCommand("SELECT * FROM [CharacterData]", sqlConnection);
                sqlConnection.Open();

                try
                {
                    sqlReader = command.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        string login = Convert.ToString(sqlReader["LoginCharacter"]);
                        string pass = Convert.ToString(sqlReader["Pass"]);
                        string work = Convert.ToString(sqlReader["TypeWork"]);
                        string firstname = Convert.ToString(sqlReader["FirstName"]);
                        string lastname = Convert.ToString(sqlReader["LastName"]);
                        string IdentificationID = Convert.ToString(sqlReader["IdentificationID"]);

                        if (login == textBox1.Text && pass == textBox2.Text)
                        {
                            Console.WriteLine("Вход выполнен");

                            MainWindow NextWindow = new MainWindow();
                            NextWindow.FirstName = firstname;
                            NextWindow.LastName = lastname;
                            NextWindow.WorkType = work;
                            NextWindow.IdentificationID = IdentificationID;
                            NextWindow.Login = login;
                            NextWindow.Show();
                            Hide();
                        }
                        else
                        {
                            label3.Visible = true;
                            label3.Text = "Не верный логин или пароль!";
                        }
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
            }
            
            else
            {
                label3.Visible = true;
                label3.Text = "Вы не ввели логин или пароль!";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            Application.Exit();
        }

        private void Authorization_Shown(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog(this);
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
