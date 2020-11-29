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

namespace CricketEventAndScoreManagement
{
    public partial class adminmain : Form
    {
        public adminmain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text;
            string password = passwordtext.Text;

            SqlConnection connection = new SqlConnection("Data Source=ASPIRE-F15\\SQLEXPRESS; Initial Catalog= CricketDB; Integrated Security=true");
            connection.Open();
            Console.WriteLine(connection.State);
            String SelectString = "Select * from admin_login where username = '"+username+"' and password = '"+password+"'";
            SqlCommand SelectCommand = new SqlCommand(SelectString, connection);
            SqlDataReader dataFromDb = SelectCommand.ExecuteReader();

            


            if (true)
            {
              
                this.Hide();
                usermain featureForm = new usermain();
                featureForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
