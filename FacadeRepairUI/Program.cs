using FacadeRepairLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
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

            //Initialize the database connection
            FacadeRepairLibrary.GlobalConfig.InitializeConnection(DatabaseType.TextFile);
            Application.Run(new CreatePolygonForm());

            //Application.Run(new PolygonViewerForm());
        }
    }
}
