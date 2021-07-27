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
    public partial class MainWindow : Form
    {
        string work;
        string firstname;
        string lastname;
        string IID;
        string login_mine;
        string data_start;

        bool ValueExit;
        bool chekExit;

        //SqlConnection sqlConnection;
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
        SqlDataReader sqlReader = null;

        public string WorkType
        {
            get { return work; }
            set { work = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string IdentificationID
        {
            get { return IID; }
            set { IID = value; }
        }
        public string Login
        {
            get { return login_mine; }
            set { login_mine = value; }
        }
        public string Data_Start
        {
            get { return data_start; }
            set { data_start = value; }
        }

        //Form Auth_form;
        public MainWindow()
        {
            InitializeComponent();
            //Form Auth_form = form;
            ValueExit = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Update_table();
        }
        public void Update_table()
        {
            this.dataGridView1.Rows.Clear();
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = GetDataBase();
            if (WorkType == "Admin")
            {
                reportToolStripMenuItem.Enabled = false;
                TeamToolStripMenuItem.Enabled = false;
                selfInfoToolStripMenuItem.Text = "Изменить данные";
                groupBox1.Text = "Список всех сотрудников";
                for (int i = 0; i < FirstN.Count; i++)
                {
                    var tempboss = "Нет";
                    if (B[i] != "")
                    {
                        for (int n = 0; n < FirstN.Count; n++)
                        {
                            if (B[i] == IID[n])
                            {
                                tempboss = FirstN[n] + " " + LastN[n];
                            }
                        }

                    }

                    var date = DateTime.Parse(DataE[i]);
                    dataGridView1.Rows.Add(FirstN[i], LastN[i], TypeW[i], 
                        Calculated(Sal[i], B, DataE[i], TypeW[i]), Sal[i], DataE[i],
                        CalcData(DataE[i]), tempboss);
                }
            }
            if (WorkType == "Manager" || WorkType == "Salesman")
            {
                selfInfoToolStripMenuItem.Text = "Изменить данные о себе";
                groupBox1.Text = "Список подчененных вам сотрудников";
                for (int i = 0; i < FirstN.Count; i++)
                {
                    Console.WriteLine("IdentificationID = " + IdentificationID);
                    Console.WriteLine("Boss = " + B[i]);
                    if (B[i] == IdentificationID)
                    {
                        
                        dataGridView1.Rows.Add(FirstN[i], LastN[i], TypeW[i],
                            Calculated(Sal[i], B, DataE[i], TypeW[i]), Sal[i], DataE[i],
                            CalcData(DataE[i]), FirstName + " " + LastName);
                    }
                }
            }
            if (WorkType == "Employee")
            {
                employeeReportToolStripMenuItem.Enabled = false;
                TeamToolStripMenuItem.Enabled = false;
                selfInfoToolStripMenuItem.Text = "Изменить данные о себе";
                groupBox1.Text = "Ваши данные: ";
                for (int i = 0; i < FirstN.Count; i++)
                {
                    if (LoginChar[i] == Login)
                    {

                        dataGridView1.Rows.Add(FirstN[i], LastN[i], TypeW[i],
                            Calculated(Sal[i], B, DataE[i], TypeW[i]), Sal[i], DataE[i],
                            CalcData(DataE[i]), B[i]);
                    }
                }
            }

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (Login == LoginChar[i])
                {
                    data_start = DataE[i];
                    label2.Text = "Ваш трудовой стаж - " + Convert.ToString(CalcData(DataE[i]) + " (лет)");
                    label3.Text = "Текущий пользователь - " + FirstN[i]+ " " + LastN[i] + " " + TypeW[i];
                }
            }
        }
        public int CalcData(string DataE)
        {
            var date = DateTime.Parse(DataE);
            int age;
            if ((DateTime.Now.Month >= date.Month) && (DateTime.Now.Day >= date.Day))
                age = DateTime.Now.Year - date.Year;
            else
                age = DateTime.Now.Year - date.Year - 1;
            if (age < 0) age = 0;
            return age;
        }
        private double Calculated(int Sal_calc, List<string> B_calc, string DataE_calc, string TypeW_calc)
        {
            var count = 0;
            if (TypeW_calc == "Employee" || TypeW_calc == "Admin")
            {
                int countData = CalcData(DataE_calc);
                double proc = (Sal_calc / 100.0) * 3.0;

                if (countData > 10)
                {
                    proc = proc * 10;
                }
                else
                {
                    proc = proc * countData;
                }

                var result = Sal_calc + proc;
                //return Convert.ToString(Math.Round(result, 2));
                return Math.Round(result, 2);

            }
            else if (TypeW_calc == "Manager")
            {
                int countData = CalcData(DataE_calc);
                double proc = (Sal_calc / 100.0) * 5.0;
                double old_proc = (Sal_calc / 100.0) * 0.5;

                if (countData > 8)
                {
                    proc = proc * 8;
                }
                else
                {
                    proc = proc * countData;
                }

                for (int i = 0; i < B_calc.Count; i++)
                {
                    if (B_calc[i] == IdentificationID)
                    {
                        count++;
                    }

                }
                var result = Sal_calc + proc + (old_proc * count);
                //return Convert.ToString(Math.Round(result, 2));
                return Math.Round(result, 2);
            }
            else if (TypeW_calc == "Salesman")
            {
                int countData = CalcData(DataE_calc);
                double proc = (Sal_calc / 100.0) * 1.0;
                double old_proc = (Sal_calc / 100.0) * 0.3;

                if (countData > 35)
                {
                    proc = proc * 35;
                }
                else
                {
                    proc = proc * countData;
                }

                for (int i = 0; i < B_calc.Count; i++)
                {
                    if (B_calc[i] == IdentificationID)
                    {
                        count++;
                    }

                }
                var result = Sal_calc + proc + (old_proc * count);
                //return Convert.ToString(Math.Round(result, 2));
                return Math.Round(result, 2);
            }
            else
            {
                return 0;
            }
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Добро пожаловать " + FirstName + " " + LastName,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
     
        }

        public static (List<string> FirstN, List<string> LastN, List<string> TypeW, List<int> Sal, List<string> DataE, List<string> B, List<string> IID, List<string> LoginChar) GetDataBase()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [CharacterData]", sqlConnection);
            sqlConnection.Open();

            try
            {
                sqlReader = command.ExecuteReader();
                
                var templist1 = new List<string>();
                var templist2 = new List<string>();
                var templist3 = new List<string>();
                var templist4 = new List<int>();
                var templist5 = new List<string>();
                var templist6 = new List<string>();
                var templist7 = new List<string>();
                var templist8 = new List<string>();

                var DataBaseList = (templist1, templist2, templist3, templist4, templist5, templist6, templist7, templist8);

                while (sqlReader.Read())
                {
                    templist1.Add(Convert.ToString(sqlReader["FirstName"]));
                    templist2.Add(Convert.ToString(sqlReader["LastName"]));
                    templist3.Add(Convert.ToString(sqlReader["TypeWork"]));
                    templist4.Add(Convert.ToInt32(sqlReader["Salary"]));
                    templist5.Add(Convert.ToDateTime(sqlReader["DataEnjoy"]).ToShortDateString());
                    templist6.Add(Convert.ToString(sqlReader["Boss"]));
                    templist7.Add(Convert.ToString(sqlReader["IdentificationID"]));
                    templist8.Add(Convert.ToString(sqlReader["LoginCharacter"]));
                    DataBaseList = (templist1, templist2, templist3,
                                    templist4, templist5, templist6, 
                                    templist7, templist8);
                }
                    return DataBaseList;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), error.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
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

        public static (List<string> Log, List<string> Pass) GetDataBasePass()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [CharacterData]", sqlConnection);
            sqlConnection.Open();

            try
            {
                sqlReader = command.ExecuteReader();

                var templist1 = new List<string>();
                var templist2 = new List<string>();
                var DataBaseList = (templist1, templist2);

                while (sqlReader.Read())
                {
                    templist1.Add(Convert.ToString(sqlReader["LoginCharacter"]));
                    templist2.Add(Convert.ToString(sqlReader["Pass"]));
                    DataBaseList = (templist1, templist2);
                }
                return DataBaseList;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), error.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chekExit = true;
            this.Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValueExit == false)
            {

                DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
                                        "Сообщение",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes && chekExit == true)
                {
                    ValueExit = true;
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                    Authorization NewAuthorization = new Authorization();
                    this.Hide();
                    NewAuthorization.Show();

                }
                else if (result == DialogResult.Yes && chekExit == false)
                {
                    ValueExit = true;
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    chekExit = false;
                }
                else
                {
                    e.Cancel = true;
                    chekExit = false;
                }

                if (sqlReader != null)
                    sqlReader.Close();

            }            
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_table();
        }

        private void TeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamManagement team = new TeamManagement();
            team.Login = login_mine;
            team.ShowDialog(this);
            Update_table();
        }

        private void selfInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (work == "Admin") 
            {
                AdminTool window = new AdminTool();
                //team.Login = login_mine;
                window.ShowDialog(this);
                Update_table();
            }
            else
            {
                ChangeSelfInfo team = new ChangeSelfInfo();
                team.Login = login_mine;
                team.ShowDialog(this);
                Update_table();
            }
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report window_rep = new Report();
            window_rep.Login = login_mine;
            
            if (WorkType == "Admin")
            {
                window_rep.TypeWork = "Admin";
            }
            window_rep.Show(this);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report window_rep2 = new Report();
            window_rep2.Login = login_mine;
            window_rep2.Void = true;
            window_rep2.Void_data = data_start;
            window_rep2.label1.Visible = false;
            window_rep2.comboBox_ChangePerson.Visible = false;
            window_rep2.Show(this);
        }
    }
}