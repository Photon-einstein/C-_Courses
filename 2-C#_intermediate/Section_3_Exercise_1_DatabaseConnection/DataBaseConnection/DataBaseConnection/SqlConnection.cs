using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) 
        {
        }

        public SqlConnection(string connectionString, TimeSpan timeOutSpan) : base(connectionString, timeOutSpan)    
        {
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("Class 'SqlConnection' openning database connection.");
            return true;
        }

        public override bool CloseConnection()
        {
            Console.WriteLine("Class 'SqlConnection' closing database connection.");
            return true;
        }
    }
}
