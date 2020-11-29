using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketEventAndScoreManagement
{
    public partial class events : Form
    {
       
        public events()
        {
            InitializeComponent();
        }

        private void Manageteamandplayers_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            addteamgb.Visible = false;
            DeleteTeamComboBox.Visible = false;
            TeamDataGrid.Visible = false;
            viewcomboBox.Visible = false;
           // view.Visible = false;
            teamlistComboBox.Visible = false;
            
            
            
            
            
            
            if (Addteambtn.Visible == true )
                Addteambtn.Visible = false;
            else
                Addteambtn.Visible = true;
            if (UpdateTeambtn.Visible == true)
                UpdateTeambtn.Visible = false;
            else
                UpdateTeambtn.Visible = true;
            if (DeleteTeamBtn.Visible == true)
                DeleteTeamBtn.Visible = false;
            else
                DeleteTeamBtn.Visible = true;


        }

        private void Addteambtn_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            teamlistComboBox.Visible = false;
            DeleteTeamComboBox.Visible = false;
            dltteambtn.Visible = false;
            teamnametext.Clear();
            
            if (addteamgb.Visible == true)
                addteamgb.Visible = false;
            else
                addteamgb.Visible = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;




            String addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList where name = '" + addtable + "'";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();

            if (userFromDb.HasRows || addtable=="")
            {
                teamname.ForeColor = Color.Red;
            }
            else
           {
                teamname.ForeColor = Color.Blue;
            }

            if (userFromDb.HasRows || addtable == "")
            {
                MessageBox.Show("Please enter an unique name");
            }
            else
            {
                userFromDb.Close();
                String createtable = "Create table " + addtable + " ( Id int not null identity(1, 1) primary key(ID), Name varchar(50) ,DateofBirth date, Roles varchar(50))";
                SqlCommand command1 = new SqlCommand(createtable, connection);
                SqlCommand command2 = new SqlCommand("insert into TeamList (name) VALUES ('" + addtable + "')", connection);
                command2.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                MessageBox.Show("Team added");
                if (AddPlayerbtn1.Visible == true)
                    AddPlayerbtn1.Visible = false;
                else
                    AddPlayerbtn1.Visible = true;

                if (UpdatePlayerBtn.Visible == true)
                    UpdatePlayerBtn.Visible = false;
                else
                    UpdatePlayerBtn.Visible = true;
               
            }
            
        }

 

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddPlayerbtn_Click(object sender, EventArgs e)
        {
            String addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            String PlayerName = PlayerNameText.Text;
            String PlayerDateOfBirth = PlayerDateTime.Text;
            String PlayerRoles = Playercombobox.Text;

            SqlConnection connection = new SqlConnection("Data Source=ASPIRE-F15\\SQLEXPRESS; Initial Catalog= TeamDB; Integrated Security=true");
            connection.Open();
            

            if(PlayerName == "" || PlayerDateOfBirth == "" || PlayerRoles == "")
            {
                MessageBox.Show("Please,enter valid name , date and role");
            }
            else 
            {
                String insertString = "insert into " + addtable + " (Name,DateofBirth,Roles) values('" + PlayerName + "','" + PlayerDateOfBirth + "','" + PlayerRoles + "')";
                SqlCommand insertcommand = new SqlCommand(insertString, connection);
                insertcommand.ExecuteNonQuery();
                MessageBox.Show("1 Player is added");
            }
            
        }

        private void Tname_Click(object sender, EventArgs e)
        {
           
        }

        private void AddPlayerbtn1_Click(object sender, EventArgs e)
        {
            if (AddPlayerGroupBox.Visible == true)
                AddPlayerGroupBox.Visible = false;
            else
                AddPlayerGroupBox.Visible = true;

            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;


            string addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            Tname.Text = "Team Name: " + addtable + "";
        }

        private void teamnametext_TextChanged(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
        }

        private void UpdatePlayerBtn_Click(object sender, EventArgs e)
        {
            

            if (comboBoxUpdatePlayer.Visible == true)
                comboBoxUpdatePlayer.Visible = false;
            else
                comboBoxUpdatePlayer.Visible = true;


            AddPlayerGroupBox.Visible = false;
            



            string addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            UpdatedTeamNameLabel.Text = "Team Name: " + addtable + "";

            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select name from  " + addtable + "";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();
            comboBoxUpdatePlayer.SelectedIndex = -1;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Items.Clear();

           while (userFromDb.Read())
            {
                string item = userFromDb[0].ToString();

                comboBoxUpdatePlayer.Items.Add(item);
            }
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                UpdatePlayerGroupBox.Visible = true;

            string addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            string player = comboBoxUpdatePlayer.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from  " + addtable + " where name = '" + player + "'";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();



            while (userFromDb.Read())
            {

                string name = userFromDb["Name"].ToString();
                string dateofbirth = userFromDb["DateofBirth"].ToString();
                string role = userFromDb["Roles"].ToString();


                UpdatePlayerNameTextBox.Text = name;
                UpdatePlayerdateTimePicker.Text = dateofbirth;
                UpdatePlayerCombobox.Text = role;

            }
        }

        private void addteamgb_Enter(object sender, EventArgs e)
        {

        }

        private void ViewTeambtn_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            addteamgb.Visible = false;
            teamlistComboBox.Visible = true;
            DeleteTeamComboBox.Visible = false;
            dltteambtn.Visible = false;


            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();
            teamlistComboBox.Items.Clear();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                teamlistComboBox.Items.Add(item);
            }





        }

        private void UpdatePBtn_Click(object sender, EventArgs e)
        {
            string addtable = teamnametext.Text;
            if (addtable == "")
            {
                addtable = teamlistComboBox.Text;
            }
            String PlayerName = UpdatePlayerNameTextBox.Text;
            String PlayerDateOfBirth = UpdatePlayerdateTimePicker.Text;
            String PlayerRoles = UpdatePlayerCombobox.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            if (PlayerName == "" || PlayerDateOfBirth == "" || PlayerRoles =="")
            {
                MessageBox.Show("Please,enter valid name , date and role");
            }
            else
            {
                     String insertString = "Update " + addtable + " set Name='" + PlayerName + "' ,DateofBirth='" + PlayerDateOfBirth + "',Roles = '" + PlayerRoles + "'";
                     SqlCommand insertcommand = new SqlCommand(insertString, connection);
                     insertcommand.ExecuteNonQuery();
                     MessageBox.Show("Information Updated");
            }
           
        }

        private void teamlistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            teamnametext.Text = "";

                AddPlayerbtn1.Visible = true;

            
                UpdatePlayerBtn.Visible = true;
                AddPlayerGroupBox.Visible = false;
               
                UpdatePlayerGroupBox.Visible = false;
                comboBoxUpdatePlayer.Visible = false;

            
               
        }

        private void DeleteTeamBtn_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            addteamgb.Visible = false;
            teamlistComboBox.Visible = false;

            if (DeleteTeamComboBox.Visible == false)
                DeleteTeamComboBox.Visible = true;
            else
                DeleteTeamComboBox.Visible = false;


            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();
            DeleteTeamComboBox.Items.Clear();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                DeleteTeamComboBox.Items.Add(item);
            }
            
        }

        private void DeleteTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddPlayerbtn1.Visible = false;

            dltteambtn.Visible = true;
            UpdatePlayerBtn.Visible = false;
            AddPlayerGroupBox.Visible = false;

            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
        }

        private void dltteambtn_Click(object sender, EventArgs e)
        {
          
            string deletetable = DeleteTeamComboBox.Text;
            

            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String DeleteString1 = "DROP table  " + deletetable + "";
            String DeleteString2 = "Delete from TeamList where name = '" + deletetable + "'";
            SqlCommand DeleteTeam1 = new SqlCommand(DeleteString1, connection);
            SqlCommand DeleteTeam2 = new SqlCommand(DeleteString2, connection);
            DeleteTeam1.ExecuteNonQuery();
            DeleteTeam2.ExecuteNonQuery();
            DeleteTeamComboBox.SelectedIndex = -1;
            DeleteTeamComboBox.Items.Clear();
           
            String SelectString = "Select * from TeamList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                DeleteTeamComboBox.Items.Add(item);
            }
            

            MessageBox.Show("Data deleted successfully!!");
           
        }

        private void Startamatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Match match = new Match();
            match.Show();



        }

        private void Playercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePlayerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPlayerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ViewTeam_Click(object sender, EventArgs e)
        {
            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            addteamgb.Visible = false;
            teamlistComboBox.Visible = true;
            DeleteTeamComboBox.Visible = false;
            dltteambtn.Visible = false;
            teamlistComboBox.Visible = false;
            viewcomboBox.Visible = true;


            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();
            teamlistComboBox.Items.Clear();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                viewcomboBox.Items.Add(item);
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
           
            }

        private void viewcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view.Visible = true;


            if(TeamDataGrid.Visible == true)
            TeamDataGrid.Visible = false;

            AddPlayerGroupBox.Visible = false;
            AddPlayerbtn1.Visible = false;
            UpdatePlayerBtn.Visible = false;
            UpdatePlayerGroupBox.Visible = false;
            comboBoxUpdatePlayer.Visible = false;
            addteamgb.Visible = false;
            teamlistComboBox.Visible = true;
            DeleteTeamComboBox.Visible = false;
            dltteambtn.Visible = false;
            TeamDataGrid.Visible = true;
            teamlistComboBox.Visible = false;
            TeamDataGrid.Enabled = false;


            TeamDataGrid.Rows.Clear();
            string CBox = viewcomboBox.Text;

            SqlConnection connection = new SqlConnection("Data Source=ASPIRE-F15\\SQLEXPRESS; Initial Catalog= TeamDB; Integrated Security=true");
            connection.Open();


            SqlCommand selectCommand = new SqlCommand("select * from " + CBox + "", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    var index = TeamDataGrid.Rows.Add();


                    TeamDataGrid.Rows[index].Cells[0].Value = dataFromDb["Name"].ToString();
                    TeamDataGrid.Rows[index].Cells[1].Value = dataFromDb["DateofBirth"].ToString();
                    TeamDataGrid.Rows[index].Cells[2].Value = dataFromDb["Roles"].ToString();






                }
                catch
                {
                    MessageBox.Show("this Team is empty");

                }
            }
        }





            
            
            
        }



        

      

       
    
}
