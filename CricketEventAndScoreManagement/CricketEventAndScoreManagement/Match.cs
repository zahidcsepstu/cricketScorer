using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CricketEventAndScoreManagement
{
    public partial class Match : Form
    {

            
        public Match()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            
            TeamACombo.Items.Clear();
            

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                TeamACombo.Items.Add(item);
            }
            userFromDb.Close();
            connection.Close();
        }

        private void TeamACombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String teamA = TeamACombo.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from TeamList where name<>'" + teamA + "';";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            TeamBCombo.SelectedIndex = -1;
            TeamBCombo.Items.Clear();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                TeamBCombo.Items.Add(item);
                labelMatchName.Text = "" + teamA + " vs ";
            }
            userFromDb.Close();
            connection.Close();
        }

        private void TeamBCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String teamB = TeamBCombo.Text;
            String teamA = TeamACombo.Text;
            labelMatchName.Text = "" + teamA + " vs " + teamB + "";
        }

       

        private void CreateButton_Click(object sender, EventArgs e)
        {


            try
            {

                String teamB = TeamBCombo.Text;
                String teamA = TeamACombo.Text;
                String matchover = MatchOver.Text;
                String matchvenue = MatchVenue.Text;
                string matchdate = MatchDate.Text;

                String matchname = "" + teamA + "vs" + teamB + "info1";

                SqlConnection connection1 = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True ");
                connection1.Open();

                while (true)
                {

                    SqlCommand command = new SqlCommand("select * from MatchList where name='" + matchname + "'", connection1);
                    SqlDataReader matchnamedb = command.ExecuteReader();
                    if (matchnamedb.HasRows)
                    {
                        var prefix = Regex.Match(matchname, "^\\D+").Value;
                        var number = Regex.Replace(matchname, "^\\D+", "");
                        var i = int.Parse(number) + 1;
                        matchname = prefix + i.ToString(new string('0', number.Length));
                        matchnamedb.Close();
                        Console.Write(matchname);
                    }
                    else
                    {
                        matchnamedb.Close();

                        break;
                    }

                }


                if (teamB == "" || teamA == "" || matchover == "" || matchvenue == "" || matchdate == "")
                {
                    MessageBox.Show("Please,enter valid team name or other data");
                }
                else
                {
                    String creatematch = "Create table " + matchname + " ( Id int not null identity(1, 1) primary key(ID), TeamA varchar(50), TeamB varchar(50), MatchOver int, Venue varchar(50), MatchDate date)";
                    SqlCommand command1 = new SqlCommand(creatematch, connection1);
                    SqlCommand command2 = new SqlCommand("insert into MatchList (name) VALUES ('" + matchname + "')", connection1);

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    String insertString = "insert into " + matchname + " (TeamA,TeamB,MatchOver,Venue,MatchDate) values('" + teamA + "','" + teamB + "','" + matchover + "','" + matchvenue + "','" + matchdate + "')";
                    SqlCommand insertcommand = new SqlCommand(insertString, connection1);
                    insertcommand.ExecuteNonQuery();
                    MessageBox.Show("1 Match is Created");

                    if (Selectamatchgroupbox.Visible == true)
                        Selectamatchgroupbox.Visible = false;

                }
            }
            catch
            {
                MessageBox.Show("Please enter value in valid format");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            events events = new events();
            events.Show();
        }

        private void DeleteMatch_Click(object sender, EventArgs e)
        {
            string deletetable = matchcombobox.Text;

     
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();

  

            String DeleteString1 = "DROP table  " + deletetable + "";
            String DeleteString2 = "Delete from MatchList where name = '" + deletetable + "'";
            SqlCommand DeleteTeam1 = new SqlCommand(DeleteString1, connection);
            SqlCommand DeleteTeam2 = new SqlCommand(DeleteString2, connection);
            DeleteTeam1.ExecuteNonQuery();
            DeleteTeam2.ExecuteNonQuery();
            matchcombobox.SelectedIndex = -1;
            matchcombobox.Items.Clear();

            String SelectString = "Select * from MatchList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                matchcombobox.Items.Add(item);
            }


            MessageBox.Show("Data deleted successfully!!");
        }

        private void matchcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TossGroupBox.Visible = false;
            PlayerNameGroupBox.Visible = false;

            BattingComboBox.Items.Clear();

            String MatchName = matchcombobox.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from MatchList where name<>'" + MatchName + "';";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            


            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();
                MatchNameLabel.Text = "" + MatchName + " vs ";
            }
            userFromDb.Close();
            connection.Close();
        }

        private void CreateamatchGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void MatchListBtn_Click(object sender, EventArgs e)
        {
            if (Selectamatchgroupbox.Visible == false)
                Selectamatchgroupbox.Visible = true;
            


            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select * from MatchList";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
            DataTable dt = new DataTable();
            matchcombobox.Items.Clear();

            while (userFromDb.Read())
            {
                string item = userFromDb[1].ToString();

                matchcombobox.Items.Add(item);
            }
        }

        private void Continuematch_Click(object sender, EventArgs e)
        {

            if (TossGroupBox.Visible == true)
                TossGroupBox.Visible = false;
            else
                TossGroupBox.Visible = true;


            string matchName = matchcombobox.Text; 

            


            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select TeamA,TeamB from "+matchName+"";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
           
            DataTable dt = new DataTable();

            BattingComboBox.Items.Clear();

            while (userFromDb.Read())
            {
               
                string item = userFromDb[1].ToString();

                BattingComboBox.Items.Add(item);
                string item2 = userFromDb[0].ToString();
                BattingComboBox.Items.Add(item2);
            }
          
            userFromDb.Close();
            connection.Close();

        }
        public static string BattingTeamName;
        
        
        


        private void BattingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            BattingTeamName = BattingComboBox.Text;
            

            string matchName = matchcombobox.Text; 
            String Batting = BattingComboBox.Text;
            FieldingComboBox.SelectedIndex = -1;
            FieldingComboBox.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select TeamA,TeamB from " + matchName + " ";
  
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
 
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
     
           
           

            while (userFromDb.Read())
            {

                string item = userFromDb[1].ToString();
                if(item!=Batting)
               {
                   FieldingComboBox.Items.Add(item);
               }

                
                string item2 = userFromDb[0].ToString();
               if (item2 != Batting)
                {
                    FieldingComboBox.Items.Add(item2);
               }
                
            }

           
            userFromDb.Close();
            connection.Close();
        }

        private void FieldingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayerNameGroupBox.Visible == true)
                PlayerNameGroupBox.Visible = false;
            else
                PlayerNameGroupBox.Visible = true;


            String Fielding = FieldingComboBox.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();
            String SelectString = "Select Name from  " + Fielding + " ";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();
  
          

            while (userFromDb.Read())
            {
                String item = userFromDb[0].ToString();


                BowlerComboBox.Items.Add(item);



            }
            userFromDb.Close();

            String Batting1 = BattingComboBox.Text;

            String SelectString2 = "Select Name from  " + Batting1 + " ";
            SqlCommand SelectUser2 = new SqlCommand(SelectString2, connection);
            SqlDataReader userFromDb2 = SelectUser2.ExecuteReader();

            while (userFromDb2.Read())
            {
                String item = userFromDb2[0].ToString();


                Batting1ComboBox.Items.Add(item);



            }



            userFromDb2.Close();
            connection.Close();




        }

        private void TossGroupBox_Enter(object sender, EventArgs e)
        {

        }
        public static string Batsman12;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Batsman12 = Batting1ComboBox.Text;
           

            
            
            string Batting1 = BattingComboBox.Text;
            string Batting2 = Batting1ComboBox.Text;
            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = TeamDB; Integrated Security = True");
            connection.Open();

            String SelectString2 = "Select Name from  " + Batting1 + " where name <> '" + Batting2 + "' ";
            SqlCommand SelectUser2 = new SqlCommand(SelectString2, connection);
            SqlDataReader userFromDb2 = SelectUser2.ExecuteReader();

            while (userFromDb2.Read())
            {
                String item = userFromDb2[0].ToString();


                Batting2ComboBox.Items.Add(item);



            }

            userFromDb2.Close();
            connection.Close();
        }
        public static string Batsman13;
        private void Batting2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Batsman13 = Batting2ComboBox.Text;
        }

        public static string MatchNameBatting;
        public static string MatchNameFielding;
        public static string MatchNameExtras;
        public static string matchname;

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
            live_score lvsc = new live_score();
            lvsc.Show();

            matchname = matchcombobox.Text;
            string BattingName = BattingComboBox.Text;
            string FieldingName = FieldingComboBox.Text;
             string Batting1 = Batting1ComboBox.Text;
            string Batting2 = Batting2ComboBox.Text;
            string Bowler = BowlerComboBox.Text;


            MatchNameBatting = ""+ matchname +"Batting"+ BattingName +"";

            MatchNameFielding = ""+ matchname +"Fielding"+ FieldingName +"";

             MatchNameExtras = "" + matchname + "Extras";

            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();

            
            if (Batting1 == "" || Batting2 == "" || FieldingName == "" || BattingName == "" || Bowler == "")
            {
                MessageBox.Show("Please,enter valid batting team name or other data");
            }
            else
            {
                String MatchBatting = "Create table " + MatchNameBatting + " ( Id int not null identity(1, 1) primary key(ID), Name varchar(50), Run int, Ball int, IsOut int)";
                SqlCommand command1 = new SqlCommand(MatchBatting, connection);

                 String MatchFielding = "Create table " + MatchNameFielding + " ( Id int not null identity(1, 1) primary key(ID), Name varchar(50), Ball int, Run int, Wicket int)";
                 SqlCommand command2 = new SqlCommand(MatchFielding, connection);

                 String MatchExtras = "Create table " + MatchNameExtras + " ( Id int not null identity(1, 1) primary key(ID),Name varchar(50), Value int)";
                 SqlCommand command3 = new SqlCommand(MatchExtras, connection);

                 try
                 {
                     command1.ExecuteNonQuery();
                     command2.ExecuteNonQuery();
                     command3.ExecuteNonQuery();
                 }
                catch
                 {

                 }
                
                

                String insertString = "insert into " + MatchNameBatting + " (Name,Run,Ball,IsOut) values('" + Batting1 + "',0,0,0)";
                String insertString2 = "insert into " + MatchNameBatting + " (Name,Run,Ball,IsOut) values('" + Batting2 + "',0,0,0)";
                String insertString3 = "insert into " + MatchNameFielding + " (Name,Ball,Run,Wicket) values('" + Bowler + "',0,0,0)";
                String insertString4 = "insert into " + MatchNameExtras + " (Name,Value) values('Extra',0)";
                String insertString5 = "insert into " + MatchNameExtras + " (Name,Value) values('Run',0)";
                String insertString6 = "insert into " + MatchNameExtras + " (Name,Value) values('Ball',0)";
                String insertString7 = "insert into " + MatchNameExtras + " (Name,Value) values('Wicket',0)";



                SqlCommand insertcommand = new SqlCommand(insertString, connection);
                SqlCommand insertcommand2 = new SqlCommand(insertString2, connection);
                SqlCommand insertcommand3 = new SqlCommand(insertString3, connection);
                SqlCommand insertcomman4 = new SqlCommand(insertString4, connection);
                SqlCommand insertcommand5 = new SqlCommand(insertString5, connection);
                SqlCommand insertcommand6 = new SqlCommand(insertString6, connection);
                SqlCommand insertcommand7 = new SqlCommand(insertString7, connection);

               insertcommand.ExecuteNonQuery();
                insertcommand2.ExecuteNonQuery();
                insertcommand3.ExecuteNonQuery();
                  insertcomman4.ExecuteNonQuery();
                  insertcommand5.ExecuteNonQuery();
                  insertcommand6.ExecuteNonQuery();
                  insertcommand7.ExecuteNonQuery();
               
            
        }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string BowlerNamee;
        private void BowlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BowlerNamee = BowlerComboBox.Text;
        }
    }
}
