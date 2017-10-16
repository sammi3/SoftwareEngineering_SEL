using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Receptionist user;

        internal static Receptionist User
        {
            get
            {
                return user;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            user = new Receptionist();

            Application.Run(new LoginPage());
        }
    }
    class Staff
    {
        private string staffID;
        private string firstName;
        private string lastName;
        private string address;

        public string StaffID
        {
            get
            {
                return staffID;
            }

            set
            {
                staffID = value;
            }
        }
    }
    class Receptionist : Staff
    {
        private string password;

    }
}
