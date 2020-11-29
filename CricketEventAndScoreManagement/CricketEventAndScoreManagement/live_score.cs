using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketEventAndScoreManagement
{
    public partial class live_score : Form
    {
        public live_score()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BattingTeamLabel.Text = Match.BattingTeamName;
            Batting1Name.Text = Match.Batsman12;
            Batting2Name.Text = Match.Batsman13;
            BowlerNameLvl.Text = Match.BowlerNamee;
        }

        private void Batting1Name_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public int GetRun()
        {
            int run = 0 ;
            if(run6.Checked || run4.Checked || run3.Checked || run2.Checked || run1.Checked || run0.Checked)
            {
                if (run6.Checked)
                    run = 6;
                if (run4.Checked)
                    run = 4;
                if (run3.Checked)
                    run = 3;
                if (run2.Checked)
                    run = 2;
                if (run1.Checked)
                    run = 1;
                if (run0.Checked)
                    run = 0;
                return run;
            }
            else
            {
                run = -1;
                return run;
            }
        }


        public String GetBatsman()
        {
            string BatsmanName = "";
            if (Batting1Name.Checked || Batting2Name.Checked)
            {
                if (Batting1Name.Checked)
                {
                    BatsmanName = Batting1Name.Text;
                }
                if (Batting2Name.Checked)
                {
                    BatsmanName = Batting2Name.Text;
                }
                return BatsmanName;


            }
            else
                return BatsmanName = "-1";
        }

        public int GetBall()
        {
            int Ball = 0;

            if (LegalDelivery.Checked || WD.Checked || NB.Checked)
            {
                if (LegalDelivery.Checked)
                {
                    Ball = 1;
                }
                if (WD.Checked)
                {
                    Ball = 0;
                }
                if (NB.Checked)
                {
                    Ball = 0;
                }
                return Ball;
            }
            else
                Ball = -1;
            return Ball;
        }


        public void CompleteBall(int CBall,int CRun)
        {
            String Batsmanname = GetBatsman();
            
            if(Batsmanname == "-1" || CRun ==-1 || CBall ==-1)
            {
                MessageBox.Show("Please select run,ball and batsman name");
            }
            else
            {
                String BowlerName = BowlerNameLvl.Text;
                SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
                connection.Open();

                String BattingTeamName = Match.MatchNameBatting;
                String FieldingTeamName = Match.MatchNameFielding;
                String Extras = Match.MatchNameExtras;
                String MatchName = Match.matchname;


                SqlCommand SelectOver = new SqlCommand("Select MatchOver from "+MatchName+"",connection);
               
                SqlDataReader userFromDb = SelectOver.ExecuteReader();

                userFromDb.Read();


                int MatchBall = userFromDb.GetInt32(0) * 6;
                userFromDb.Close();
                SqlCommand SelectBatting = new SqlCommand("Select Run,Ball,IsOut from " + BattingTeamName + " where Name = '" + Batsmanname + "'", connection);

                SqlDataReader userFromDb2 = SelectBatting.ExecuteReader();
                userFromDb2.Read();
                int BatsmanRun = userFromDb2.GetInt32(0);
                int BatsmanBall = userFromDb2.GetInt32(1);
                int IsOut = userFromDb2.GetInt32(2);

                userFromDb2.Close();


                SqlCommand SelectExtra = new SqlCommand("Select Value from " + Extras + " where name = 'Extra'", connection);
                 SqlCommand ExtraBall = new SqlCommand("Select Value from " + Extras + " where name = 'Ball'", connection);
                 SqlCommand ExtraRun = new SqlCommand("Select Value from " + Extras + " where name = 'Run'", connection);
                 SqlCommand ExtraWicket = new SqlCommand("Select Value from " + Extras + " where name = 'Wicket'", connection);


                
                 
              
                
                SqlDataReader userFromDb3 = SelectExtra.ExecuteReader();
                userFromDb3.Read();
                int TotalExtra = userFromDb3.GetInt32(0);
                userFromDb3.Close();


                SqlDataReader userFromDb4 = ExtraBall.ExecuteReader();
                userFromDb4.Read();
                int TotalBall = userFromDb4.GetInt32(0);
                userFromDb4.Close();


                SqlDataReader userFromDb5 = ExtraRun.ExecuteReader();
                userFromDb5.Read();
                int TotalRun = userFromDb5.GetInt32(0);
                userFromDb5.Close();


                SqlDataReader userFromDb6 = ExtraWicket.ExecuteReader();
                userFromDb6.Read();
                int TotalWicket = userFromDb6.GetInt32(0);
                userFromDb6.Close();
                
                
               




                SqlCommand SelectBall = new SqlCommand("Select Ball,Run from " + FieldingTeamName + "", connection);
                SqlDataReader userFromDb7 = SelectBall.ExecuteReader();
                userFromDb7.Read();
                int BowlerBall = userFromDb7.GetInt32(0);
                int BowlerRun = userFromDb7.GetInt32(1);
                userFromDb7.Close();
                
                TotalBall = TotalBall + CBall;
                if (CBall == 0)
                    TotalRun = TotalRun + CRun + 1;
                else
                    TotalRun = TotalRun + CRun;

                BatsmanRun = BatsmanRun + CRun;
                BatsmanBall = BatsmanBall + CBall;
                BowlerBall = BowlerBall + CBall;
                BowlerRun += CRun;
                if(CBall == 0)
                {
                    TotalExtra = TotalExtra + 1;
                }
                if(MatchBall > TotalBall)
                {
       
                    RunLabel.Text = Convert.ToString(TotalRun);
                    WicketLabel.Text = Convert.ToString(TotalWicket);
                    int Over = TotalBall / 6;
                    int Ball = TotalBall % 6;
                    
                    labelOver.Text = Convert.ToString(Over);
                    labelBall.Text = Convert.ToString(Ball);


                    SqlCommand UpdateBatting = new SqlCommand("Update  " + BattingTeamName + " Set Run = @BatsmanRun ,Ball = @BatsmanBall where Name = '" + Batsmanname + "' ", connection);

                    UpdateBatting.Parameters.AddWithValue("@BatsmanRun", BatsmanRun);
                    UpdateBatting.Parameters.AddWithValue("@BatsmanBall", BatsmanBall);
                    UpdateBatting.ExecuteNonQuery();
                    SqlCommand UpdateBall = new SqlCommand("Update  " + FieldingTeamName + " Set Ball = @BowlerBall, Run= @run where Name = '" + BowlerName + "' ", connection);

                    UpdateBall.Parameters.AddWithValue("@BowlerBall", BowlerBall);
                    UpdateBall.Parameters.AddWithValue("@run", BowlerRun);

                    UpdateBall.ExecuteNonQuery();


                    SqlCommand UpdateExtra = new SqlCommand("Update " + Extras + " Set Value = @TotalExtra where name = 'Extra'", connection);
                    SqlCommand UpdateBall1 = new SqlCommand("Update " + Extras + " Set Value = @TotalBall where name = 'Ball'", connection);
                    SqlCommand UpdateRun = new SqlCommand("Update " + Extras + " Set Value = @TotalRun where name = 'Run'", connection);

                    UpdateExtra.Parameters.AddWithValue("@TotalExtra", TotalExtra);
                    UpdateBall1.Parameters.AddWithValue("@TotalBall", TotalBall);
                    UpdateRun.Parameters.AddWithValue("@TotalRun", TotalRun);
                    

                    UpdateExtra.ExecuteNonQuery();
                    UpdateBall1.ExecuteNonQuery();
                    UpdateRun.ExecuteNonQuery();
                }

               

            }
        }

        public void uncheckedAll()
        {
            Batting1Name.Checked = false;
            Batting2Name.Checked = false;
            run6.Checked = false;
            run4.Checked = false;
            run3.Checked = false;
            run2.Checked = false;
            run1.Checked = false;
            run0.Checked = false;
            WD.Checked = false;
            NB.Checked = false;
            LegalDelivery.Checked = false;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            
            int ball = GetBall();
            int run = GetRun();
            CompleteBall(ball, run);
            uncheckedAll();
            ScoreCard.PerformClick();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ScoreCard_Click(object sender, EventArgs e)
        {
            dataGridViewBall.Enabled = false;
            dataGridViewBat.Enabled = false;
            String BattingTeamName = Match.MatchNameBatting;
            String FieldingTeamName = Match.MatchNameFielding;

            SqlConnection connection = new SqlConnection("Data Source = ASPIRE-F15\\SQLEXPRESS; Initial Catalog = MatchDB; Integrated Security = True");
            connection.Open();


            SqlCommand selectCommand = new SqlCommand("select * from " + BattingTeamName + "", connection);
            SqlCommand selectCommand2 = new SqlCommand("select * from " + FieldingTeamName + "", connection);

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            dataGridViewBat.Rows.Clear();
            while (dataFromDb.Read())
            {

                try
                {

                   
                    var index = dataGridViewBat.Rows.Add();
                    

                    dataGridViewBat.Rows[index].Cells[0].Value = dataFromDb["Name"].ToString();
                    dataGridViewBat.Rows[index].Cells[1].Value = dataFromDb["Run"].ToString();
                    dataGridViewBat.Rows[index].Cells[2].Value = dataFromDb["Ball"].ToString();
}
                catch
                {
                    MessageBox.Show("this Team is empty");

                }
            }

            dataFromDb.Close();

            SqlDataReader dataFromDb2 = selectCommand2.ExecuteReader();
            dataGridViewBall.Rows.Clear();
            while (dataFromDb2.Read())
            {

                    var index = dataGridViewBall.Rows.Add();
                    

                    dataGridViewBall.Rows[index].Cells[0].Value = dataFromDb2["Name"].ToString();
                    dataGridViewBall.Rows[index].Cells[1].Value = dataFromDb2["Ball"].ToString();
                    dataGridViewBall.Rows[index].Cells[2].Value = dataFromDb2["Run"].ToString();
                    dataGridViewBall.Rows[index].Cells[3].Value = dataFromDb2["Wicket"].ToString();
               
         
                
            }
            dataFromDb2.Close();
        }
    }
}
