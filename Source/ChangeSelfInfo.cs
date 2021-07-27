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
    public partial class ChangeSelfInfo : Form
    {
        string login_mine;
        public ChangeSelfInfo()
        {
            InitializeComponent();
        }

        private List<bool> chek = new List<bool>() { false, false, false, false};
        public string Login
        {
            get { return login_mine; }
            set { login_mine = value; }
        }
        public void getInfo()
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (login_mine == LoginChar[i])
                {
                    textBox_name.Text = FirstN[i];
                    textBox_second_name.Text = LastN[i];
                    if (TypeW[i] == "Employee") { radioButton_em.Checked = true; }
                    if (TypeW[i] == "Manager") { radioButton_ma.Checked = true; }
                    if (TypeW[i] == "Salesman") { radioButton_sa.Checked = true; }
                    dateTimePicker1.Value = Convert.ToDateTime(DataE[i]);
                    textBox_sal.Text = Convert.ToString(Sal[i]);
                }
            }
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

            if (chek[0] == true && chek[1] == true && chek[2] == true && chek[3] == true)
            {
                ChangeInfoInDataBase(Work);
                DialogResult result = MessageBox.Show("Изменения пришли успешно", "Уведомление", MessageBoxButtons.OK);
            }
        }

        private void ChangeInfoInDataBase(string Work)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [CharacterData] SET [FirstName]=@FirstName, [LastName]=@LastName, [TypeWork]=@TypeWork, [DataEnjoy]=@DataEnjoy, [Salary]=@Salary WHERE [LoginCharacter]=@LoginCharacter", sqlConnection);

            command.Parameters.AddWithValue("FirstName", textBox_name.Text);
            command.Parameters.AddWithValue("LastName", textBox_second_name.Text);
            command.Parameters.AddWithValue("TypeWork", Work);
            Console.WriteLine("DATA - " + dateTimePicker1.Value.ToLongTimeString());
            command.Parameters.AddWithValue("DataEnjoy", dateTimePicker1.Value);
            command.Parameters.AddWithValue("Salary", textBox_sal.Text);
            command.Parameters.AddWithValue("LoginCharacter", login_mine);

            command.ExecuteNonQuery();

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void ChangeSelfInfo_Load(object sender, EventArgs e)
        {
            getInfo();
        }
    }
}
