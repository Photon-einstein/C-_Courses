using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    internal class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private string _command;
        public DbCommand(DbConnection dbConnection, string command)
        {
            // test dbConnection
            if (dbConnection == null)
            {
                throw new ArgumentNullException("\ndbConnection cannot be null.\n");
            }
            // test command
            if (command == null)
            {
                throw new ArgumentNullException("\nCommand cannot be null.\n");
            }
            else if (command.Length == 0)
            {
                throw new ArgumentException("\nCommand cannot be empty.\n");
            }
            _dbConnection = dbConnection;
            _command= command;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Command executed: {0}", _command);
            _dbConnection.CloseConnection();
        }
    }
}
