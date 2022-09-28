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
    public partial class Dashboard : Form
    {
        Signin si = new Signin();
        DBAccess objdBAccess = new DBAccess(); 
    
        public Dashboard()
        {
            InitializeComponent();
        }
       
        private void Dashboard_Load(object sender, EventArgs e)
        {
            txttopnamelbl.Text = Signin.name + "! :)";
            txtNameDash.Text = Signin.name;
            txtEmailDash.Text = Signin.email;
            txtPasswordDash.Text = Signin.password;
            txtCountryDash.Text = Signin.country;



        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string newUsername = txtNameDash.Text;
            string newEmail = txtEmailDash.Text;
            string newpassword = txtPasswordDash.Text;
            string newcountry = txtCountryDash.Text;


            if(newUsername == "")
            {
                lblusername.Text = "Uname is required";
            }
            else if(newEmail == "")
            {
                lblemail.Text = "Email is required";
            }
            else if(newpassword == "") 
            {
                lblpass.Text = "Pass is req";
            }
            else
            {
                string query = "Update Users SET Name = '" + @newUsername + "', Email = '" + @newEmail + "', Password = '" + @newpassword + "', Country = '" + @newcountry + "' where ID = '" + Signin.id + "'";

                SqlCommand updatecommand = new SqlCommand(query);

                updatecommand.Parameters.AddWithValue("@newUsername", @newUsername);
                updatecommand.Parameters.AddWithValue("@newEmail", @newEmail);
                updatecommand.Parameters.AddWithValue("@newpassword", @newpassword);
                updatecommand.Parameters.AddWithValue("@newcountry", @newcountry);

                int row = objdBAccess.executeQuery(updatecommand);

                if (row == 1)
                {
                    MessageBox.Show("Data Updated Successfully!");
                    this.Hide();

                    Signin s123 = new Signin();
                    s123.Show();
                }
                else
                {
                    MessageBox.Show("Something went Wring :(, please try again");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult df1 =  MessageBox.Show("Are you sure you want to delete all your data?, Data won't restore later!", "Erase Everything?!",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

           if(df1 == DialogResult.Yes)
            {
                string query1 = "Delete from Users Where ID = '" + Signin.id + "'";

                SqlCommand deletecommand = new SqlCommand(query1);

                int row = objdBAccess.executeQuery(deletecommand);

                if (row == 1)
                {
                    MessageBox.Show("Data Deleted Successfully!");
                    this.Hide();

                    btnSignUp s1234 = new btnSignUp();
                    s1234.Show();
                }
                else
                {
                    MessageBox.Show("Something went Wring :(, please try again");
                }
            }
        }
    }
}
