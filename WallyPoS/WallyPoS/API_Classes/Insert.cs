/*
 *  FILENAME: Insert.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: This file hold methods to query the JMWally database for with INSERT INTO scripts
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WallyPoS.API_Classes
{
    // Name: Insert
    // Description: This Class is used to make INSERT INTO queries to the JMWally database
    //
    class Insert
    {
       /// <summary>
       /// Add's a New customer to the database
       /// </summary>
       /// <param name="api"></param>
       /// <param name="firstName"></param>
       /// <param name="lastName"></param>
       /// <param name="phoneNumber"></param>
        public void AddNewCustomer(API api, string firstName, string lastName, string phoneNumber)
        {
            string query = @"INSERT INTO customer (First_Name, Last_Name, Telephone) VALUES('"
                           + firstName +"','" + lastName + "','" + phoneNumber +"');";

            //open connection
            if (api.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                api.CloseConnection();
            }
        }

        /// <summary>
        /// Add's a new order to the Database
        /// </summary>
        /// <param name="api"></param>
        /// <param name="customer_id"></param>
        /// <param name="branch_id"></param>
        /// <param name="status"></param>
        public void AddNewOrder(API api, string customer_id, string branch_id, string status)
        {
            string query = @"INSERT INTO orders (Customer_ID, Branch_ID, Status_ID) VALUES('"
                          + customer_id + "','" + branch_id + "','" + status + "');";

            //INSERT INTO orders(Customer_ID, Branch_ID, Status_ID)
           // VALUES(1, 2, 'PAID');

            //open connection
            if (api.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                api.CloseConnection();
            }

        }

        /// <summary>
        /// Add's a new orderline to the database
        /// </summary>
        /// <param name="api"></param>
        /// <param name="order_id"></param>
        /// <param name="product_id"></param>
        /// <param name="quantity"></param>
        public void AddNewOrderLine(API api, string order_id, string product_id, string quantity)
        {
            string query = @"INSERT INTO orderline (Order_ID, Product_ID, Order_Quantity) VALUES('"
                         + order_id + "','" + product_id + "','" + quantity + "');";

            //INSERT INTO orders(Customer_ID, Branch_ID, Status_ID)
            // VALUES(1, 2, 'PAID');

            //open connection
            if (api.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                api.CloseConnection();
            }
        }
    }
}
