using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.DataAccess;

namespace FacadeRepairLibrary
{
    public static class GlobalConfig
    {
        // TODO summary
        /// <summary>
        /// 
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFile"></param>
        public static void InitializeConnection (DatabaseType db)
        {
            // TODO - Set up connections properly
            if (db == DatabaseType.SXML) 
            {
                // TODO (Set up the SXML connection properly)
                //SXMLConnector smxl = new SMXLConnector ();
                //Connection = smxl;
            }
            else if (db == DatabaseType.CSV) 
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
            else if (db == DatabaseType.XLSX)
            {
                //XLSXConnector xlsx = new XLSXConnector();
                //Connection = xlsx;
            }
        }
    }
}
