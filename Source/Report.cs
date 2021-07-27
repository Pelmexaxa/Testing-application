using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApplication
{
    public partial class Report : Form
    {
        List<string> thisLog = new List<string>();
        List<int> helpIndexCheck = new List<int>();
        string login_mine;
        string chekLogin;
        int index_start_work;
        int Salary;
        string typework;
        bool void_on;
        string void_data;

        public string Login
        {
            get { return login_mine; }
            set { login_mine = value; }
        }
        public string TypeWork
        {
            get { return typework; }
            set { typework = value; }
        }
        public string Void_data
        {
            get { return void_data; }
            set { void_data = value; }
        }
        
        public bool Void
        {
            get { return void_on; }
            set { void_on = value; }
        }
        public Report()
        {
            InitializeComponent();
            void_on = false;
        }

        public void getListPersons()
        {
            thisLog.Clear();
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();
            comboBox_ChangePerson.Items.Clear();

            if (typework == "Admin")
            {
                for (int i = 0; i < FirstN.Count; i++)
                {
                    thisLog.Add(LoginChar[i]);
                    comboBox_ChangePerson.Items.Add(FirstN[i] + " " + LastN[i]);
                }
            }
            else
            {
                for (int i = 0; i < FirstN.Count; i++)
                {
                    if (login_mine == B[i])
                    {
                        thisLog.Add(LoginChar[i]);
                        comboBox_ChangePerson.Items.Add(FirstN[i] + " " + LastN[i]);
                    }
                }
            }

        }
          
        public void getInfo(int login_index)
        {
            Console.WriteLine(login_index);
            Console.WriteLine("login_index");
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (thisLog[login_index] == LoginChar[i]) // ????????
                {
                    chekLogin = thisLog[login_index];
                    getAgeInForm(DataE[i]);
                }
            }

        }

        private void getAgeInForm(string DataE)
        {
            comboBox_age.Items.Clear();
            var date = DateTime.Parse(DataE);
            int age;
            if ((DateTime.Now.Month >= date.Month) && (DateTime.Now.Day >= date.Day))
                age = DateTime.Now.Year - date.Year;
            else
                age = DateTime.Now.Year - date.Year - 1;
            if (age < 0) age = 0;

            int age_count = age;
            for (int i = 0; i < age_count; i++)
            {
                comboBox_age.Items.Add(DateTime.Now.Year - i);
            }
            if (age_count <= 0) { comboBox_age.Items.Add(DateTime.Now.Year); }
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

        private void showTable(int index_age)
        {

            dataGridView.Rows.Clear();

            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();
            double[] Calc = {0,0,0,};

            for (int i = 0; i < comboBox_age.Items.Count; i++)
            {
                helpIndexCheck.Add(i);
            }
            helpIndexCheck.Reverse();

            string[] name_mounth = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сеньтябрь", "Октябрь", "Ноябрь", "Декабрь"};
            var Mounth_count = DateTime.Now.Month;
            //List<String> Calc; helpIndexCheck

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (chekLogin == LoginChar[i]) 
                {
                    var date = DateTime.Parse(DataE[i]);
                    index_start_work = date.Month;
                    Salary = Sal[i];
                    TypeWork = TypeW[i];
                    var q = Calculated(Sal[i], B, helpIndexCheck[comboBox_age.SelectedIndex], TypeW[i]);
                    Calc[0] = q.AddMoneyAge; Calc[1] = q.CountSlave; Calc[2] = q.AddMoneySlave;
                }
            }
            Console.WriteLine(Calc[0].GetType());
            Console.WriteLine(Calc[1].GetType());
            Console.WriteLine(Calc[2].GetType());
            var Sum = Salary + Calc[0] + Calc[2];
            double FinalySum = 0;

            //Последний но не первый
            if (index_age == comboBox_age.Items.Count - 1 && comboBox_age.Items.Count - 1 != 0)
            {
                for (int i = 12; i >= index_start_work; i--)
                {
                    dataGridView.Rows.Add(name_mounth[i - 1], Salary, Math.Round(Calc[0], 2), Calc[1], Math.Round(Calc[2], 2), 0, Sum);
                }
                for (int n = 0; n < dataGridView.Rows.Count-1; n++)
                {
                    FinalySum += Convert.ToDouble(dataGridView.Rows[n].Cells[6].Value);
                }
                dataGridView.Rows.Add("", "", "", "", "", "Всего за год:", Math.Round(FinalySum, 2));
            }

            //Первый но не последний
            else if (index_age == 0 && comboBox_age.Items.Count-1 != 0)
            {
                for (int i = Mounth_count-1; i >= 0; i--)
                {
                    dataGridView.Rows.Add(name_mounth[i], Salary, Math.Round(Calc[0], 2), Calc[1], Math.Round(Calc[2], 2), 0, Sum);
                }
                for (int n = 0; n < dataGridView.Rows.Count - 1; n++)
                {
                    FinalySum += Convert.ToDouble(dataGridView.Rows[n].Cells[6].Value);
                }
                dataGridView.Rows.Add("", "", "", "", "", "Всего за год:", Math.Round(FinalySum, 2));
            }

            //Первый и последний
            else if (index_age == 0 && comboBox_age.Items.Count-1 == 0)
            {
                for (int i = index_start_work; i <= Mounth_count; i++)
                {
                    dataGridView.Rows.Add(name_mounth[i], Salary, Math.Round(Calc[0], 2), Calc[1], Math.Round(Calc[2], 2), 0, Sum);
                }
                for (int n = 0; n < dataGridView.Rows.Count - 1; n++)
                {
                    FinalySum += Convert.ToDouble(dataGridView.Rows[n].Cells[6].Value);
                }
                dataGridView.Rows.Add("", "", "", "", "", "Всего за год:", Math.Round(FinalySum, 2));
            }

            //Любой кроме первого(елси больше 2)
            else if (comboBox_age.Items.Count > 2)
            {
                for (int i = 11; i > -1; i--)
                {
                    dataGridView.Rows.Add(name_mounth[i], Salary, Math.Round(Calc[0], 2), Calc[1], Math.Round(Calc[2], 2), 0, Sum);
                }
                for (int n = 0; n < dataGridView.Rows.Count - 1; n++)
                {
                    FinalySum += Convert.ToDouble(dataGridView.Rows[n].Cells[6].Value);
                }
                dataGridView.Rows.Add("", "", "", "", "", "Всего за год:", Math.Round(FinalySum, 2));
            }
        }

        private (double AddMoneyAge, double CountSlave, double AddMoneySlave) Calculated(int Sal_calc, List<string> B_calc, int index_age, string TypeW_calc)
        {
            var count = 0;
            if (TypeW_calc == "Employee" || TypeW_calc == "Admin")
            {
                int countData = index_age;
                double AddMoneyAge = (Sal_calc / 100.0) * 3.0;

                if (countData > 10)
                {
                    AddMoneyAge = AddMoneyAge * 10;
                }
                else
                {
                    AddMoneyAge = AddMoneyAge * countData;
                }

                return (AddMoneyAge, 0, 0);

            }
            else if (TypeW_calc == "Manager")
            {
                int countData = index_age;
                double AddMoneyAge = (Sal_calc / 100.0) * 5.0;
                double AddMoneySlave = (Sal_calc / 100.0) * 0.5;

                if (countData > 8)
                {
                    AddMoneyAge = AddMoneyAge * 8;
                }
                else
                {
                    AddMoneyAge = AddMoneyAge * countData;
                }

                for (int i = 0; i < B_calc.Count; i++)
                {
                    if (B_calc[i] == chekLogin)
                    {
                        count++;
                    }

                }

                return (AddMoneyAge, count,count * AddMoneySlave);
            }
            else if (TypeW_calc == "Salesman")
            {
                int countData = index_age;
                double AddMoneyAge = (Sal_calc / 100.0) * 1.0;
                double AddMoneySlave = (Sal_calc / 100.0) * 0.3;

                if (countData > 35)
                {
                    AddMoneyAge = AddMoneyAge * 35;
                }
                else
                {
                    AddMoneyAge = AddMoneyAge * countData;
                }

                for (int i = 0; i < B_calc.Count; i++)
                {
                    if (B_calc[i] == chekLogin)
                    {
                        count++;
                    }

                }

                return (AddMoneyAge, count, count * AddMoneySlave);
            }
            else
            {
                return (0,0,0);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            if (void_on == true)
            {
                chekLogin = login_mine;
                getAgeInForm(void_data);
            }
            else
            {
                getListPersons();
            }
        }

        private void comboBox_ChangePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox_ChangePerson.SelectedIndex >= 0)
                    getInfo(comboBox_ChangePerson.SelectedIndex);
        }

        private void comboBox_age_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ChangePerson.SelectedIndex >= 0)
            {
                showTable(comboBox_age.SelectedIndex);
            }
            else
            {
                showTable(comboBox_age.SelectedIndex);
            }
                    
        }
    }
}
