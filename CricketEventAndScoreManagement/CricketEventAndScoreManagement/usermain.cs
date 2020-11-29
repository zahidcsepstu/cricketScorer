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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace CricketEventAndScoreManagement
{
    public partial class usermain : Form
    {
        public usermain()
        {
            InitializeComponent();
        }

        private void userregisterbutton_Click(object sender, EventArgs e)
        {
            
            string name = usernameregistertext.Text;
            string email = emailregistertext.Text;
            string password = password1registertext.Text;
            string confirmPassword = password2registertext.Text;

            Console.WriteLine(name + email + password + confirmPassword);
            SqlConnection connection = new SqlConnection("Data Source=ASPIRE-F15\\SQLEXPRESS; Initial Catalog= CricketDB; Integrated Security=true");
            connection.Open();
            String SelectString = "Select * from tbl_registration_user where username = '" + name + "'";
            SqlCommand SelectUser = new SqlCommand(SelectString, connection);
            SqlDataReader userFromDb = SelectUser.ExecuteReader();

            if (userFromDb.HasRows||!name.Any(char.IsLower) || !name.Any(char.IsUpper))
            {
                userregisterusername.ForeColor = Color.Red;
            }
            else
            {
                userregisterusername.ForeColor = Color.Blue;
            }

            if ((!email.Contains("@")) || (!email.Contains(".com")))
            {
                userregisteremail.ForeColor = Color.Red;
            }
            else
            {
                userregisteremail.ForeColor = Color.Blue;
            }

            if (password != confirmPassword || !password.Any(char.IsLetter) || !password.Any(char.IsDigit) )
            {
                userregisterpassword1.ForeColor = Color.Red;
                userregisterpassword2.ForeColor = Color.Red;
            }

            else
            {
                userregisterpassword1.ForeColor = Color.Blue;
                userregisterpassword2.ForeColor = Color.Blue;
            }

            if (!userFromDb.HasRows && name.Any(char.IsLower) && name.Any(char.IsUpper) && password.Any(char.IsLetter) && password.Any(char.IsDigit) && password == confirmPassword && email.Contains("@") && email.Contains(".com") && name != null)
            {

                
                Console.WriteLine(connection.State);
                String insertString = "insert into tbl_registration_user(username,email,password) values('"+name+"','"+email+"','"+password+"')";
                userFromDb.Close();
                SqlCommand insertCommand = new SqlCommand(insertString, connection);
                insertCommand.ExecuteNonQuery(); 

                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 300000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("zahidcsepstu@gmail.com", "Zahid01834520200");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(emailregistertext.Text);
                    msg.From = new MailAddress(email);
                    msg.Subject = "Cricket Event Admin Panel";
                    msg.Body = "Congratulation " +name+ " your registration has been successfully completed";
                    client.Send(msg);
                    MessageBox.Show("successully send message");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Failed");
            }


            
        }

        private void userloginbutton_Click(object sender, EventArgs e)
        {
            string username = userloginusernametext.Text;
            string password = userloginpasswordtext.Text;

            SqlConnection connection = new SqlConnection("Data Source=ASPIRE-F15\\SQLEXPRESS; Initial Catalog= CricketDB; Integrated Security=true");
            connection.Open();
            Console.WriteLine(connection.State);
            String SelectString = "Select * from tbl_registration_user where username = '" + username + "' and password = '" + password + "'";
            SqlCommand SelectCommand = new SqlCommand(SelectString, connection);
            SqlDataReader dataFromDb = SelectCommand.ExecuteReader();


            if (true)
            {

                this.Hide();
                events admin = new events();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void emailregistertext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
