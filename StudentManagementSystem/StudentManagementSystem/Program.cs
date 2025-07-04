using StudentManagementSystem.UI;
using StudentManagementSystem.UI.Grades;
using StudentManagementSystem.UI.GradeSubject;
using StudentManagementSystem.UI.Students;
using StudentManagementSystem.UI.Subjects;
using StudentManagementSystem.UI.Teachers;
using StudentManagementSystem.UI.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
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
            Application.Run(new GradesForm());
        }
    }
}
