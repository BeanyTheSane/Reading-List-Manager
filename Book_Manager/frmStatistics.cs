//Project Name:     Personal Project: Better Book Manager
//Description:      This Application provides a GUI to manage a Book reading list.  It can also show reading suggestions and reading statistics based
//                  on data in the DB.
//Written For:      CISS 222
//Written By:       Adam Knitter
//Date Began:       02/21/2019
//Date Complete:    03/31/2019
//Dates Edited:     4/7/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Book_Manager
{
    
    public partial class frmStatistics : Form
    {
        //creates a reference point to a central location containing the connection string to the database.
        public const string myConnString = Program.ComPubVar.myConnString;

        public frmStatistics()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //I originally Set this up under a button but decided to do it on the form laod instead.  I left the code here in case I needed it again.
            //
            //string constr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= Book_List.accdb";
            //string cmdstrTotalRead = "SELECT COUNT(*) FROM Book_List WHERE Complete = True";
            //string cmdstrTotalUnread = "SELECT COUNT(*) FROM Book_List WHERE Complete = False";
            //string cmdstrThisYear = "SELECT COUNT(*) FROM Book_List WHERE Year([Date Read]) = Year(Date())";
            //OleDbConnection con = new OleDbConnection(constr);
            //OleDbCommand comTotalRead = new OleDbCommand(cmdstrTotalRead, con);
            //OleDbCommand comTotalUnread = new OleDbCommand(cmdstrTotalUnread, con);
            //OleDbCommand comThisYear = new OleDbCommand(cmdstrThisYear, con);
            //con.Open();
            //DataSet data = new DataSet();
            //int i = (int)comTotalRead.ExecuteScalar();
            //int j = (int)comTotalUnread.ExecuteScalar();
            //int k = (int)comThisYear.ExecuteScalar();
            //lblTotalRead.Text = i.ToString();
            //lblTotalUnread.Text = j.ToString();
            //lblThisYear.Text = k.ToString();
            //con.Close();
        }

        //this loads the updated stats on the form load
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            //creates some strings that will be used in the constructors foor the database commands
            string cmdstrTotalRead = "SELECT COUNT(*) FROM Book_List WHERE Complete = True";
            string cmdstrTotalUnread = "SELECT COUNT(*) FROM Book_List WHERE Complete = False";
            string cmdstrThisYear = "SELECT COUNT(*) FROM Book_List WHERE Year([Date Read]) = Year(Date())";

            //creates the SQL commands that will be used to count the user stats
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = myConnString;
            OleDbCommand comTotalRead = new OleDbCommand(cmdstrTotalRead, conn);
            OleDbCommand comTotalUnread = new OleDbCommand(cmdstrTotalUnread, conn);
            OleDbCommand comThisYear = new OleDbCommand(cmdstrThisYear, conn);
            conn.Open();//opens database
            if (conn.State == ConnectionState.Open)
            {
                //displays the results of the queries to the user
                lblTotalRead.Text = ((int)comTotalRead.ExecuteScalar()).ToString();
                lblTotalUnread.Text = ((int)comTotalUnread.ExecuteScalar()).ToString();
                lblThisYear.Text = ((int)comThisYear.ExecuteScalar()).ToString();
                conn.Close();//close database
            }
            else//drop here if DB connection fails
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();//closes the stats form
        }
    }
}
