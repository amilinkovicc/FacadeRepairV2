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
            if (db == DatabaseType.Sql) 
            {
                // TODO - Set up the SQL connection properly
                SqlConnector sql = new SqlConnector ();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile) 
            {
                // TODO - Create the TextFile connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
    }
}
