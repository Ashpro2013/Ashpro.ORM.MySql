using System;
using System.Collections.Generic;
using System.Text;

namespace Ashpro.ORM.MySql
{
    public class DBConnection
    {
        public static string Connection { get; set; }
        public static void SetConnection(string connection)
        {
            Connection = connection;
        }
        public static string GetConnection()
        {
            return Connection;
        }
    }
}
