using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest.mySql
{
    class SqlCommand
    {
        public string selectCmd(string tblName)
        {
            return "SELECT * FROM `" + tblName + "`";
        }
    }
}
