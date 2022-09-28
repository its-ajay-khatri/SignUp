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
    public partial class CommandBuildForm : Form

    {
        DBAccess dbaccessobj = new DBAccess();
        DataTable dt = new DataTable();
        public CommandBuildForm()
        {
            InitializeComponent();
        }

        private void CommandBuildForm_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            dbaccessobj.readDatathroughAdapter(query,dt);

            dataGridView1.DataSource = dt;
            dbaccessobj.closeConn();
        }

        private void PerformOperationBtn_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users";

            int changes = dbaccessobj.executeDataAdapter(dt, query);

            MessageBox.Show("count = " + changes);
        }
    }
}
