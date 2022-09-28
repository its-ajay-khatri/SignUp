using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_Using_Database
{
    public partial class Signin : Form
    {

        public static string id, name, email, password, country;

        DBAccess objDBAccess = new DBAccess();
        DataTable dt1 = new DataTable();
        public Signin()
        {
            InitializeComponent();
        }
        private void btntxtsignin_Click(object sender, EventArgs e)
        {
            string useremail = txtEmaillogin.Text;
            string userpassword = txtPasswordlogin.Text;

            if(useremail == "")
            {
                lblemail.Text = "Email is Required";
            }
            else if (userpassword == "")
            {
                lblusername.Text = "Password is Required";
            }
            else
            {
                string query = "Select * from USers Where Email= '" + useremail + "' AND Password = '" + userpassword + "'";

                objDBAccess.readDatathroughAdapter(query, dt1);

                if(dt1.Rows.Count == 1)
                {
                    id = dt1.Rows[0]["ID"].ToString(); 
                    name = dt1.Rows[0]["Name"].ToString();
                    email = dt1.Rows[0]["Email"].ToString();
                    password = dt1.Rows[0]["Password"].ToString();
                    country = dt1.Rows[0]["COuntry"].ToString();

                    MessageBox.Show("You are logged in Successfully!!", "COngratulations!!");
                    this.Hide();
                    Dashboard dtt1 = new Dashboard();
                    dtt1.Show();
                }
                else
                {
                    MessageBox.Show("Email or Password Didn't Match");
                }
            }
        }

        private void btnredrectaigniup(object sender, EventArgs e)
        {
            this.Hide();
            btnSignUp si = new btnSignUp();
            si.Show();
        }
    }
}
