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
    public partial class TeamManagement : Form
    {
        string login_mine;
        public string Login
        {
            get { return login_mine; }
            set { login_mine = value; }
        }

        List<string> freeChar = new List<string>();
        List<string> teamChar = new List<string>();

        public TeamManagement()
        {
            InitializeComponent();
        }
        private void TeamManagement_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();

            listBox_freeChar.Items.Clear();
            listBox_inTeamChar.Items.Clear();
            freeChar.Clear();
            teamChar.Clear();

            for (int i = 0; i < FirstN.Count; i++)
            {
                if (B[i] == login_mine)
                {
                    listBox_inTeamChar.Items.Add(FirstN[i]+ " " + LastN[i]);
                    teamChar.Add(LoginChar[i]);
                }
                if (B[i] == "Нет" && LoginChar[i] != login_mine)
                {
                    listBox_freeChar.Items.Add(FirstN[i] + " " + LastN[i]);
                    freeChar.Add(LoginChar[i]);
                }
            }
            //teamChar.Sort();
            //freeChar.Sort();
        }

        private void button_LeaveOnTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_inTeamChar.SelectedItems.Count; i++)
            {
                var temp = listBox_inTeamChar.SelectedIndex;
                
                freeChar.Add(teamChar[temp]);
                teamChar.Remove(teamChar[temp]);

                listBox_freeChar.Items.Add(listBox_inTeamChar.SelectedItems[i]);
                listBox_inTeamChar.Items.Remove(listBox_inTeamChar.SelectedItems[i]);

                for (int n = 0; n < freeChar.Count; n++)
                {
                    Console.WriteLine("FreeChar = " + Convert.ToString(freeChar[n]));
                }
                Console.WriteLine("Длинна Free  = " + Convert.ToString(freeChar.Count));

                Console.WriteLine("ИНДЕКС  = " + Convert.ToString(temp));
            }
        }

        private void button_GoToTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_freeChar.SelectedItems.Count; i++)
            {
                var temp = listBox_freeChar.SelectedIndex;
                
                teamChar.Add(freeChar[temp]);
                freeChar.Remove(freeChar[i]);

                listBox_inTeamChar.Items.Add(listBox_freeChar.SelectedItems[i]);
                listBox_freeChar.Items.Remove(listBox_freeChar.SelectedItems[i]);

                for (int n = 0; n < teamChar.Count; n++)
                {
                    Console.WriteLine("teamChar = " + Convert.ToString(teamChar[n])); 
                }
                Console.WriteLine("Длинна teamChar  = " + Convert.ToString(teamChar.Count));

                Console.WriteLine("ИНДЕКС  = " + Convert.ToString(temp));
            }
        }

        private void button_accept_Click(object sender, EventArgs e)
        {
            var (FirstN, LastN, TypeW, Sal, DataE, B, IID, LoginChar) = MainWindow.GetDataBase();

            for(int i = 0; i < freeChar.Count; i++)
            {
                for (int n = 0; n < LoginChar.Count; n++)
                {
                    if (LoginChar[n] == freeChar[i])
                    {
                        UpdateDataWork("Нет", LoginChar[n]);
                    }
                }
            }

            for (int i = 0; i < teamChar.Count; i++)
            {
                for (int n = 0; n < LoginChar.Count; n++)
                {
                    if (LoginChar[n] == teamChar[i])
                    {
                        UpdateDataWork(login_mine, LoginChar[n]);
                    }
                }
            }
            DialogResult result = MessageBox.Show("Изменения прошли успешно", "Уведомление", MessageBoxButtons.OK);
            Update();
        }

        private void UpdateDataWork(string Boss, string Loginn)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Convert.ToString(Environment.CurrentDirectory) + @"\Database.mdf;Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [CharacterData] SET [Boss]=@Boss WHERE [LoginCharacter]=@LoginCharacter", sqlConnection);

            command.Parameters.AddWithValue("Boss", Boss);
            command.Parameters.AddWithValue("LoginCharacter", Loginn);
            command.ExecuteNonQuery();

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }

        }
    }
}
