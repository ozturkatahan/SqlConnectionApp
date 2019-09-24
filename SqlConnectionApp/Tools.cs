using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionApp
{
    public class Tools
    {
        public static string ConnectionString()
        {
            return "Server =.; Database = Northwind; UID = sa; PWD = 123";
        }
    }
}
