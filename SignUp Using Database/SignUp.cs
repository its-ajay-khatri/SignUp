using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SignUp_Using_Database
{
    public partial class btnSignUp : Form
    {
        DBAccess objdBAccess = new DBAccess();
        public btnSignUp()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string useremail = txtEmail.Text;
            string userpassword = txtPassword.Text;
            string userconnpas = txtCPassword.Text;
            string usercountry = txtCountry.Text;


            if (username == "")
            {
                lblusername.Text = "UserName is Required";
            }

            else if (useremail == "")
            {
                lblemail.Text = "Email is required";
            }
            else if (userpassword == "")
            {
                lblpass.Text = "Pass Is required";
            }
            else if(userconnpas == "")
            {
                lblconpass.Text = "Please reenter your password";
            }
            else if(userpassword != userconnpas)
            {
               
                MessageBox.Show("Password and confirm password didnt match");
                
            }
            else if (userpassword == "" || userconnpas == "")
            {
               
                MessageBox.Show("Password or confirm password must not be empty");
               
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("Insert into Users(Name,Email,Password,Country) values(@username, @useremail, @userpassword, @usercountry)");

                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@useremail", useremail);
                sqlCommand.Parameters.AddWithValue("@userpassword", userpassword);
                sqlCommand.Parameters.AddWithValue("@usercountry", usercountry);

                int row = objdBAccess.executeQuery(sqlCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account Created Successfully!");
                    this.Hide();

                    Dashboard d1 = new Dashboard();
                    d1.Show();
                }
                else
                {
                    MessageBox.Show("Something went Wring :(, please try again");
                }
            }
        }

        private void signupbtnclick(object sender, EventArgs e)
        {

            this.Hide();
            Signin new1 = new Signin();
            new1.Show();
        }
    }
}
