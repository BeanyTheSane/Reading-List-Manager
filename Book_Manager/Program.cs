//Project Name:     Personal Project: Better Book Manager
//Description:      This Application provides a GUI to manage a Book reading list.  It can also show reading suggestions and reading statistics based
//                  on data in the DB.
//Written For:      CISS 222
//Written By:       Adam Knitter
//Date Began:       02/21/2019
//Date Complete:    03/31/2019
//Dates Edited:     04/07/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        //common variables in a central, easy to manage location
        public class ComPubVar
        {
            public const string myConnString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= Book_List.accdb";
        }
    }
}
