using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public OracleConnection(string connectionString, TimeSpan timeOutSpan) : base(connectionString, timeOutSpan)
        {
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("\nClass 'OracleConnection' openning database connection.");
            return true;
        }

        public override bool CloseConnection()
        {
            Console.WriteLine("Class 'OracleConnection' closing database connection.");
            return true;
        }
    }
}
