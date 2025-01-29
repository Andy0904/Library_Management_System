using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new view_books());
            Application.Run(new login());
            //Application.Run(new mdi_user());
            //Application.Run(new add_books());
            //Application.Run(new addStudents());
            //Application.Run(new issue_books());
            //Application.Run(new test());
        }
    }
}
