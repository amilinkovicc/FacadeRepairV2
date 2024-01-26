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
            if (db == DatabaseType.Sql) 
            {
                // TODO DELETE (Set up the SQL connection properly)
                //SqlConnector sql = new SqlConnector ();
                //Connection = sql;
            }
            else if (db == DatabaseType.TextFile) 
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
    }
}
