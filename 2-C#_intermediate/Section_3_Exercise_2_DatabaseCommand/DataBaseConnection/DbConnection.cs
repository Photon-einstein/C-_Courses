using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    internal abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeoutSpan { get; set; }

        public TimeSpan TimeoutSpan
        {
            get { return _timeoutSpan; }
        }

        public DbConnection(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("\nConnection string cannot be null.\n");
            } else if (connectionString.Length == 0)
            {
                throw new ArgumentException("\nConnection string cannot be empty.\n");
            }
            _connectionString = connectionString;
        }

        public DbConnection(string connectionString, TimeSpan timeOutSpan)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("Connection string cannot be null.");
            }
            else if (connectionString.Length == 0)
            {
                throw new ArgumentException("Connection string cannot be empty.");
            }
            _connectionString = connectionString;
            _timeoutSpan = timeOutSpan;
        }

        public abstract bool OpenConnection();
        public abstract bool CloseConnection();





    }
}
