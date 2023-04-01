using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DataBaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1: Design a database connectionTo access a database, we need to open a 
             * connection to it first and close it once our job is done. Connecting to a database 
             * depends on the type of the target database and the database management system (DBMS). 
             * For example, connecting to a SQL Server database is different from connecting to an 
             * Oracle database. But both these connections have a few things in common: 
             * 
             * •They have a connection string 
             * •They can be opened
             * •They can be closed
             * •They may have a timeout attribute (so if the connection could not be opened within the timeout, 
             * an exception will be thrown).
             * 
             * Your job is to represent these commonalities in a base class called DbConnection. 
             * This class should have two properties: ConnectionString : stringTimeout : TimeSpanA 
             * 
             * DbConnection will not be in a valid state if it doesn’t have a connection string. 
             * So you need to pass a connection string in the constructor of this class. 
             * Also, take into account the scenarios where null or an empty string is sent as the connection string. 
             * Make sure to throw an exception to guarantee that your class will always be in a valid state.
             * Our DbConnection should also have two methods for opening and closing a connection. 
             * We don’t know how to open or close a connection in a DbConnection and this should be left to the classes that derive from DbConnection. 
             * These classes (eg SqlConnection or OracleConnection) will provide the actual implementation. 
             * So you need to declare these methods as abstract.
             * Derive two classes SqlConnection and OracleConnection from DbConnection and provide a simple implementation of opening and closing connections using Console.WriteLine(). 
             * In the real-world, SQL Server provides an API for opening or closing a connection to a database. 
             * But for this exercise, we don’t need to worry about it.
             */
             /* test null string and empty string */
             try
            {
                DbConnection db1 = new SqlConnection(null, TimeSpan.FromSeconds(30));
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            try
            {
                DbConnection db2 = new SqlConnection("", TimeSpan.FromSeconds(30));
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            /* test Oracle Connection */
            try
            {
                DbConnection db3 = new OracleConnection("123.34.23.12", TimeSpan.FromSeconds(30));
                db3.OpenConnection();
                db3.CloseConnection();
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            /* test Oracle Connection */
            try
            {
                /* Exercise 2: Design a database commandNow that we have the concept of a DbConnection, 
                 * let’s work out how to represent a DbCommand.Design a class called DbCommand for executing 
                 * an instruction against the database.A DbCommand cannot be in a valid state without having 
                 * a connection.So in the constructor of this class, pass a DbConnection. Don’t forget to cater 
                 * for the null.Each DbCommand should also have the instruction to be sent to the database.
                 * In case of SQL Server, this instruction is expressed in T-SQL language.
                 * Use a string to represent this instruction.Again, a command cannot be in a valid state without 
                 * this instruction.So make sure to receive it in the constructor and cater for the null reference 
                 * or an empty string. Each command should be executable.So we need to create a method called Execute(). 
                 * 
                 * In this method, we need a simple implementation as follows: 
                 * Open the connectionRun the instruction Close the connectionNote that here, inside the DbCommand, 
                 * we have a reference to DbConnection. Depending on the type of DbConnection sent at runtime, opening 
                 * and closing a connection will be different. For example, if we initialize this DbCommand with a SqlConnection, 
                 * we will open and close a connection to a Sql Server database. This is polymorphism.Interestingly, 
                 * DbCommand doesn’t care about how a connection is opened or closed.It’s not the responsibility of the DbCommand.
                 * All it cares about is to send an instruction to a database.For running the instruction, simply output it to the Console. 
                 * In the real-world, SQL Server (or any other DBMS) provides an API for running an instruction against the database.
                 * We don’t need to worry about it for this exercise.
                 * In the main method, initialize a DbCommand with some string as the instruction and a SqlConnection.
                 * Execute the command and see the result on the console.
                 * Then, swap the SqlConnection with an OracleConnection and see polymorphism in action. */
                DbConnection db4 = new SqlConnection("113.14.13.02", TimeSpan.FromSeconds(30));
                db4.OpenConnection();
                db4.CloseConnection();
                Console.WriteLine("Time out span of database is {0}s.", db4.TimeoutSpan.TotalSeconds);
            }
            catch (Exception ex4)
            {
                Console.WriteLine(ex4.Message);
            }

            /* Ex2: test Sql Connection */
            try
            {
                /* Exercise 2: Design a database commandNow that we have the concept of a DbConnection, 
                 * let’s work out how to represent a DbCommand.Design a class called DbCommand for executing 
                 * an instruction against the database.A DbCommand cannot be in a valid state without having 
                 * a connection.So in the constructor of this class, pass a DbConnection. Don’t forget to cater 
                 * for the null.Each DbCommand should also have the instruction to be sent to the database.
                 * In case of SQL Server, this instruction is expressed in T-SQL language.
                 * Use a string to represent this instruction.Again, a command cannot be in a valid state without 
                 * this instruction.So make sure to receive it in the constructor and cater for the null reference 
                 * or an empty string. Each command should be executable.So we need to create a method called Execute(). 
                 * 
                 * In this method, we need a simple implementation as follows: 
                 * Open the connectionRun the instruction Close the connectionNote that here, inside the DbCommand, 
                 * we have a reference to DbConnection. Depending on the type of DbConnection sent at runtime, opening 
                 * and closing a connection will be different. For example, if we initialize this DbCommand with a SqlConnection, 
                 * we will open and close a connection to a Sql Server database. This is polymorphism.Interestingly, 
                 * DbCommand doesn’t care about how a connection is opened or closed.It’s not the responsibility of the DbCommand.
                 * All it cares about is to send an instruction to a database.For running the instruction, simply output it to the Console. 
                 * In the real-world, SQL Server (or any other DBMS) provides an API for running an instruction against the database.
                 * We don’t need to worry about it for this exercise.
                 * In the main method, initialize a DbCommand with some string as the instruction and a SqlConnection.
                 * Execute the command and see the result on the console.
                 * Then, swap the SqlConnection with an OracleConnection and see polymorphism in action. */
                DbConnection db4 = new SqlConnection("113.14.13.02", TimeSpan.FromSeconds(30));
                DbCommand cmd = new DbCommand(db4, "CREATE TABLE CUSTOMERS(\r\n   ID   INT              " +
                                                   "NOT NULL,\r\n   NAME VARCHAR (20)     NOT NULL,\r\n   AGE  INT" +
                                                   "              NOT NULL,\r\n   ADDRESS  CHAR (25) ,\r\n   SALARY   " +
                                                   "DECIMAL (18, 2),       \r\n   PRIMARY KEY (ID)\r\n);");
                cmd.Execute();
            }
            catch (Exception ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            /* Ex2: test Oracle Connection */
            try
            {
                DbConnection db5 = new OracleConnection("103.04.03.22", TimeSpan.FromSeconds(30));
                DbCommand cmd = new DbCommand(db5, "CREATE TABLE CUSTOMERS(\r\n   ID   INT              " +
                                                   "NOT NULL,\r\n   NAME VARCHAR (20)     NOT NULL,\r\n   AGE  INT" +
                                                   "              NOT NULL,\r\n   ADDRESS  CHAR (25) ,\r\n   SALARY   " +
                                                   "DECIMAL (18, 2),       \r\n   PRIMARY KEY (ID)\r\n);");
                cmd.Execute();
            }
            catch (Exception ex5)
            {
                Console.WriteLine(ex5.Message);
            }

            /* freeze the console */
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
