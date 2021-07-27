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
    public partial class AdminTool : Form
    {
        public AdminTool()
        {
            InitializeComponent();
        }

        private List<bool> chek = new List<bool>() { false, false, false, false, false, false };
        private string log = "";

        public void getListPersons()
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();
            listBox1.Items.Clear();

            for (int i = 0; i < FirstN.Count; i++)
            {
                listBox1.Items.Add(FirstN[i] + " " + LastN[i]);
            }
        }

        public void getInfo(int name_index)
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();
            var (Login, Pass) = MainWindow.GetDataBasePass();

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (LoginChar[name_index] == LoginChar[i])
                {
                    textBox_name.Text = FirstN[i];
                    textBox_second_name.Text = LastN[i];
                    if (TypeW[i] == "Employee") { radioButton_em.Checked = true; }
                    if (TypeW[i] == "Manager") { radioButton_ma.Checked = true; }
                    if (TypeW[i] == "Salesman") { radioButton_sa.Checked = true; }
                    if (TypeW[i] == "Admin") { radioButtonAdmin.Checked = true; }
                    dateTimePicker1.Value = Convert.ToDateTime(DataE[i]);
                    textBox_sal.Text = Convert.ToString(Sal[i]);
                    textBox_login.Text = Login[i];
                    textBox_password.Text = Pass[i];

                    log = Login[i];
                }
            }
        }

        public void deletePersonOnBD()
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();
            var (Login, Pass) = MainWindow.GetDataBasePass();

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (LoginChar[listBox1.SelectedIndex] == LoginChar[i])
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM [CharacterData] WHERE [LoginCharacter]=@LoginCharacterWHERE", sqlConnection);

                    command.Parameters.AddWithValue("LoginCharacterWHERE", LoginChar[i]);

                    command.ExecuteNonQuery();

                    getListPersons();

                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            getInfo(listBox1.SelectedIndex);
        }

        private void AdminTool_Load(object sender, EventArgs e)
        {
            getListPersons();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            var Work = "";

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

            if (radioButton_em.Checked == false && radioButton_ma.Checked == false && radioButton_sa.Checked == false && radioButtonAdmin.Checked == false)
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
                if (radioButtonAdmin.Checked) { Work = "Admin"; }
            }

            if (string.IsNullOrEmpty(textBox_sal.Text))
            {
                label_salary.ForeColor = Color.Red;
                chek[3] = false;
            }
            else
            {
                label_salary.ForeColor = Color.Black;
                chek[3] = true;
            }

            if (string.IsNullOrEmpty(textBox_login.Text))
            {
                label_login.ForeColor = Color.Red;
                chek[4] = false;
            }
            else
            {
                label_login.ForeColor = Color.Black;
                chek[4] = true;
            }

            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                label_password.ForeColor = Color.Red;
                chek[5] = false;
            }
            else
            {
                label_password.ForeColor = Color.Black;
                chek[5] = true;
            }

            if (chek[0] == true && chek[1] == true && chek[2] == true && chek[3] == true)
            {
                ChangeInfoInDataBase(Work, log);
            }
        }

        private void ChangeInfoInDataBase(string Work, string login)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [CharacterData] SET [FirstName]=@FirstName, [LastName]=@LastName, [TypeWork]=@TypeWork, [DataEnjoy]=@DataEnjoy, [Salary]=@Salary WHERE [LoginCharacter]=@LoginCharacterWHERE", sqlConnection);

            command.Parameters.AddWithValue("FirstName", textBox_name.Text);
            command.Parameters.AddWithValue("LastName", textBox_second_name.Text);
            command.Parameters.AddWithValue("TypeWork", Work);
            Console.WriteLine("DATA - " + dateTimePicker1.Value.ToLongTimeString());
            command.Parameters.AddWithValue("DataEnjoy", dateTimePicker1.Value);
            command.Parameters.AddWithValue("Salary", textBox_sal.Text);
            command.Parameters.AddWithValue("LoginCharacter", textBox_login.Text);
            command.Parameters.AddWithValue("Pass", textBox_password.Text);
            command.Parameters.AddWithValue("LoginCharacterWHERE", login);


            command.ExecuteNonQuery();

            getListPersons();

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Registration team = new Registration();
            //team.ShowDialog(this);
            //team.FormClosed += (obj, args) => getListPersons();

            team.Owner = this;
            team.FormClosed += new FormClosedEventHandler(NotifyAboutClosedChildForm);
            team.Show();

        }
        private void NotifyAboutClosedChildForm(object sender, FormClosedEventArgs args)
        {
            getListPersons();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            deletePersonOnBD();
        }
    }
}
