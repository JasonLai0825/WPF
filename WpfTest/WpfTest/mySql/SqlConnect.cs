using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest.mySql
{
    class SqlConnect
    {
        public string getConnectString()
        {
            string dbHost = "127.0.0.1";
            string dbUser = "root";
            string dbPass = "zone3210";
            string dbName = "sa";

            string strMySqlServer = String.Format("server=" + dbHost + ";user id=" + dbUser + "; password=" + dbPass + "; database=" + dbName + ";");
            return strMySqlServer;
        }
    }
}
