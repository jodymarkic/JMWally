/*
 *  FILENAME: API.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: this file holds some generic methods to connect to mysql
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WallyPoS
{
    // Name: API
    // Description: this class is used to initally connect to open and close connections
    //              with the JMWally database
    //
    public class API
    {
        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        /// <summary>
        ///  Constructor
        /// </summary>
        public API()
        {
            InitializeDBConnection();
        }

        /// <summary>
        /// Initialize connection with JMWally Database
        /// </summary>
        public void InitializeDBConnection()
        {
            string server = "localhost";
            string database = "jmWally";
            string uid = "root";
            string password = "Conestoga1";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            Connection = new MySqlConnection(connectionString);
        }

       /// <summary>
       ///  Attempt to Open a connection to JMWally
       /// </summary>
       /// <returns>bool</returns>
        public bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                       // MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        /// <summary>
        /// Attempt to close a connection with JMWally
        /// </summary>
        /// <returns>bool</returns>
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException)
            {
              //  MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
