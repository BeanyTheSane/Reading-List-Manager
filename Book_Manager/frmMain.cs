//Project Name:     Personal Project: Better Book Manager
//Description:      This Application provides a GUI to manage a Book reading list.  It can also show reading suggestions and reading statistics based
//                  on data in the DB.
//Written For:      CISS 222
//Written By:       Adam Knitter
//Date Began:       02/21/2019
//Date Complete:    03/31/2019
//Dates Edited:     04/06/2019
//                  04/07/2019
//
//References:       I did a lot of my research on how to use C# to interact with a MS Access DB on stackoverflow.com and the reference documents at
//                  docs.microsoft.com
//  Reference 1:    https://stackoverflow.com/questions/47110024/how-do-i-add-textbox-values-to-access-database
//                  I modified a section of code from a comment made by 'ryguy72' on Stackoverflow to work with my program to add text inserted into a
//                  textbox by the user to a new record in the attached MS Access DB.
//
//  Reference 2:    https://www.c-sharpcorner.com/UploadFile/b846a8/database-updation-from-datagridview/
//                  I modified a section of code from a blog post by 'Uma Shankar Patel' on the above site to work with my program to update the DB
//                  changes made in the DataGridView with a button click
//
//  Reference 3:    http://csharphelper.com/blog/2014/11/handle-datagridview-errors-in-c/
//                  I learned how to build an more friendly error handler for database errors from this site

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
using System.IO;

namespace Book_Manager
{
    public partial class frmMain : Form
    {
        //creates a reference point to a central location containing the connection string to the database.
        public const string myConnString = Program.ComPubVar.myConnString;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this would show the first random selection when the form loads if used
            // TODO: This line of code loads data into the 'random_Book.Book_List_Query' table. You can move, or remove it, as needed.
            //this.book_List_QueryTableAdapter.Fill(this.random_Book.Book_List_Query);

            //Creates a series of helpful tooltips as the form loads
            ToolTip toolTip1 = new ToolTip();
            ToolTip toolTip2 = new ToolTip();
            ToolTip toolTip3 = new ToolTip();
            ToolTip toolTip4 = new ToolTip();
            ToolTip toolTip5 = new ToolTip();

            //defines the previous tooltips
            toolTip1.SetToolTip(this.btnUpdate, "This button will save any changes made in the above window");
            toolTip2.SetToolTip(this.btnAdd_Book, "This button will add the data entered above into the database and save it");
            toolTip3.SetToolTip(this.btnLucky, "This button will display a random book from your unread list in the above window");
            toolTip4.SetToolTip(this.btnStats, "This button will open a new window to display various stats about your reading list");
            toolTip5.SetToolTip(this.btnDeleteRow, "This button will delete a single row from the above window");

            //this fills the main datagrid as the form loads
            // TODO: This line of code loads data into the 'book_ListDataSet.Book_List' table. You can move, or remove it, as needed.
            this.book_ListTableAdapter.Fill(this.book_ListDataSet.Book_List);
            tbTitle.Focus();//sets starting focus to the book title text box 


            //this creates an object that will handle database errors made in the datagridview in a more friendly manner tahn the default
            this.dagdBook_List.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dagdBook_List_DataError);

        }


        //this click event will update the datagrid to display only read books
        private void readBooksToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //loads the readbooks query into the data set
                this.book_ListTableAdapter.ReadBooks(this.book_ListDataSet.Book_List);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);//error message
            }

        }

        //this click event will update the datagrid to display only unread books
        private void unreadListToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //loads the unreadbooks query into the data set
                this.book_ListTableAdapter.UnreadList(this.book_ListDataSet.Book_List);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //this click event will update the datagrid to display all of the books
        private void allBooksToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //loads the all books query into the data set
                this.book_ListTableAdapter.AllBooks(this.book_ListDataSet.Book_List);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //this handles the new book add button click.  It will open a connection to the database, verify user input, update the databse, then close it.
        private void button1_Click(object sender, EventArgs e)
        {

            //creates a new instance of a Connection for our database
            OleDbConnection conn = new OleDbConnection();
            //sets that connection to point to the Book_List database.  This call should point to the current file location no matter whose machine, but I'm not sure.
            //Also unsure if version 12 of the provider must be installed on the local machine or not.  this all works on my machine.
            conn.ConnectionString = myConnString;


            //Variables created and filled with input from the user
            string myAuthor = tbAuthor.Text.Trim();
            string myTitle = tbTitle.Text.Trim();
            string mySeries = tbSeries.Text.Trim();
            string myGenre = tbGenre.Text.Trim();
            string myDate = dtpDateRead.Text;
            string myComplete = ckbxComplete.Checked.ToString().ToLower();
            string myAddBookSQL = "INSERT INTO Book_List (Author, Title, Series, Genre, [Date Read], Complete) VALUES (myAuthor, myTitle, mySeries, myGenre, myDate, myComplete)";

            //Input verification
            //Checks if a name was entered properly for the author
            while (true)
            {
                //Checks if a name was entered properly for the Title
                if (myTitle == "" || myTitle.Length > 255)
                {
                    //Informs the user of the input error
                    MessageBox.Show("You must enter a title that is less than 255 characters.");
                    //sets focus on the errored textbox
                    tbTitle.Focus();
                    break;
                }
                if (myAuthor == "" || myAuthor.Length > 255)
                {
                    //Informs the user of the input error
                    MessageBox.Show("You must enter an author name that is less than 255 characters.");
                    //sets focus on the errored textbox
                    tbAuthor.Focus();
                    break;
                }
                //Checks if a name was entered properly for the Genre
                if (myGenre.Length > 255)
                {
                    //Informs the user of the input error
                    MessageBox.Show("You must enter a Genre Type that is less than 255 characters.");
                    //sets focus on the errored textbox
                    tbGenre.Focus();
                    break;
                }
                //Checks if a name was entered properly for the Series
                if (mySeries.Length > 255)
                {
                    //Informs the user of the input error
                    MessageBox.Show("You must enter a Series Title that is less than 255 characters.");
                    //sets focus on the errored textbox
                    tbSeries.Focus();
                    break;
                }


                //>>>>>>>>>>>>>>>>>>>> Reference 1 <<<<<<<<<<<<<<<<<

                //changes the command if book has not been read
                if (myComplete == "false")
                {
                    myAddBookSQL = "INSERT INTO Book_List (Author, Title, Series, Genre) VALUES (myAuthor, myTitle, mySeries, myGenre)";
                }

                //creates a command that will be executed against the database.  This is the SQL command that will insert the user input into the database
                OleDbCommand comAddBook = new OleDbCommand(myAddBookSQL, conn);

                //opens the connection to the database
                conn.Open();

                //checks to see if the connection was complete
                if (conn.State == ConnectionState.Open)
                {

                    parameterized queries are used to avoid SQL Injection
                    comAddBook.Parameters.Add("myAuthor", OleDbType.VarChar).Value = myAuthor;
                    comAddBook.Parameters.Add("myTitle", OleDbType.VarChar).Value = myTitle;
                    comAddBook.Parameters.Add("mySeries", OleDbType.VarChar).Value = mySeries;
                    comAddBook.Parameters.Add("myGenre", OleDbType.VarChar).Value = myGenre;

                    //only adds these parameters if book has been read                  
                    if (myComplete == "true")
                    {
                        comAddBook.Parameters.Add("myDate", OleDbType.Date).Value = myDate;
                        comAddBook.Parameters.Add("myComplete", OleDbType.Boolean).Value = myComplete;
                    }
                       
                    try
                    {
                        //runs the previously defined command once the connection is open
                        comAddBook.ExecuteNonQuery();
                        //displays confirmation to the user
                        MessageBox.Show("Book Added");
                        //reloads the datagrid with new input data
                        this.book_ListTableAdapter.Fill(this.book_ListDataSet.Book_List);
                        //refreshes the datagrid to display the new input
                        dagdBook_List.Refresh();
                        //closes the connection to the database
                        conn.Close();
                        //clears the input fields on the GUI
                        tbAuthor.Text = "";
                        tbGenre.Text = "";
                        tbSeries.Text = "";
                        tbTitle.Text = "";
                        ckbxComplete.Checked = false;
                    }
                    catch (OleDbException ex)//error messgae catch
                    {
                        MessageBox.Show(ex.Source + "\n" + ex.Message);
                        conn.Close();
                        break;
                    }
                }
                else//drop here if DB connection fails
                {
                    MessageBox.Show("Connection Failed");
                    break;
                }
                break;
            }
        }

        //>>>>>>>>>>>>>>>>>>>> Reference 1 End<<<<<<<<<<<<<<<<<

        //>>>>>>>>>>>>>>>>>>>> Reference 2<<<<<<<<<<<<<<<<<

        //this button updates the DB with any changes made directly in the Datagrid
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            while (true)
            {
                //Displays a confirmation request to the user
                DialogResult myDR = MessageBox.Show("     Are you sure you want to save Changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (myDR == DialogResult.Yes)
                {
                    //creates a new instance of a Connection for our database
                    OleDbConnection conn = new OleDbConnection();
                    //sets that connection to point to the Book_List database.  This call should point to the current file location no matter whose machine
                    conn.ConnectionString = myConnString;
                    conn.Open();//opens database
                    if (conn.State == ConnectionState.Open)
                    {
                        try
                        {
                            this.book_ListTableAdapter.Update(this.book_ListDataSet.Book_List);//saves changes to database
                            dagdBook_List.Refresh();//refreshes the Datagrid
                            conn.Close();//closes database

                            MessageBox.Show("Record Updated");//displays a confirmation massage
                        }
                        catch (OleDbException ex)//error messgae catch
                        {
                            MessageBox.Show(ex.Source + "\n" + ex.Message);
                            conn.Close();
                            break;

                        }
                        break;
                    }
                    else//drop here if DB connection fails
                    {
                        MessageBox.Show("Connection Failed");
                        break;
                    }
                }
                break;
            }
        }

        //>>>>>>>>>>>>>>>>>>>> Reference 2 End<<<<<<<<<<<<<<<<<

        //>>>>>>>>>>>>>>>>>>>> Reference 3 <<<<<<<<<<<<<<<<<

        // this will handle any errors in the datagridview with a more user friendly message
        private void dagdBook_List_DataError(object sender,
            DataGridViewDataErrorEventArgs e)
        {
            //Builds a string that will display a user more user freindly error message than the CLR default 
            string myDGVError = $"Error with {dagdBook_List.Columns[e.ColumnIndex].HeaderText}\n\n{e.Exception.Message}";
            // This stops the error from throwing the excpetion so we can show our own, easier to read message.
            e.ThrowException = false;
            // Display the error message.
            MessageBox.Show(myDGVError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // setting this to false cancels the changes that caused the error
            e.Cancel = false;
        }

        //>>>>>>>>>>>>>>>>>>>> Reference 3 End <<<<<<<<<<<<<<<<<

        //this button displays a random unread book to the user
        private void btnLucky_Click(object sender, EventArgs e)
        {
            //this calls a query built into the database that will display a random unread book into the smaller datagrid
            this.book_List_QueryTableAdapter.Fill(this.random_Book.Book_List_Query);
        }

        //this button opens a new form to dispaly various stats to the user
        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStatistics fS = new frmStatistics();
            fS.ShowDialog();
        }

        //this was used during testing.
        private void button1_Click_1(object sender, EventArgs e)
        {
            lblDate.Text = dtpDateRead.Text.Trim();
        }

        //This button will delete a single selceted row from the datagridview and save the change
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            //checks to see if the user has selected a row
            if (dagdBook_List.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row to delete");
            }
            //checks to see if the user selected a single row
            else if (dagdBook_List.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row to delete");
            }
            else
            {
                while (true)
                {
                    //displays a window to confirm that the user wants to delete the selected record
                    DialogResult myDR = MessageBox.Show("Are you sure you want to delete the selected book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (myDR == DialogResult.Yes)//begins the process to delete the record
                    {
                        //creates a new instance of a Connection for our database
                        OleDbConnection conn = new OleDbConnection();
                        //sets that connection to point to the Book_List database.  This call should point to the current file location no matter whose machine
                        conn.ConnectionString = myConnString;
                        conn.Open();//opens database
                        if (conn.State == ConnectionState.Open)//checks if the connection was succesful
                        {
                            try
                            {
                                //this line looks to see which row the user has selected on the datagridview
                                int mySelectedIndex = dagdBook_List.CurrentCell.RowIndex;
                                //this line removes the record at the selected location
                                dagdBook_List.Rows.RemoveAt(mySelectedIndex);
                                this.book_ListTableAdapter.Update(this.book_ListDataSet.Book_List);//saves changes to database
                                dagdBook_List.Refresh();//refreshes the Datagrid
                                conn.Close();//closes database

                                MessageBox.Show("Record Deleted");//displays a confirmation massage
                                break;
                            }
                            catch (OleDbException ex)//error messgae catch
                            {
                                MessageBox.Show(ex.Source + "\n" + ex.Message);
                                conn.Close();
                                break;
                            }
                        }
                        else//drop here if DB connection fails
                        {
                            MessageBox.Show("Connection Failed");
                            break;
                        }
                    }
                }
            }

        }

        //this event handler makes the date picker available or not based on whether the user checks the book read box or not
        private void ckbxComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxComplete.Checked.ToString().ToLower() == "true")
            {
                dtpDateRead.Visible = true;
            }
            else
            {
                dtpDateRead.Visible = false;
            }
            
        }
    }

}
