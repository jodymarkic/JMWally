/*
 *  FILENAME: Update.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: This file hold methods to query the JMWally database for with UPDATE scripts
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
    // Name: Update
    // Description: This Class is used to make UPDATE queries to the JMWally database
    //
    public class Update
    {
       /// <summary>
       /// update the product inventory of specific product with the product_id,`
       /// and the newInventory to be written
       /// </summary>
       /// <param name="api"></param>
       /// <param name="product_id"></param>
       /// <param name="newInventory"></param>
        public void updateProductInventory(API api, string product_id, string newInventory)
        {
            string query = "UPDATE product SET Quantity = '" + newInventory + "' WHERE Product_ID = '" + product_id + "'";

            //Open connection
            if (api.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);
                //Assign the query using CommandText
                cmd.ExecuteNonQuery();
                //close connection
                api.CloseConnection();
            }
        }

        /// <summary>
        /// Cancel a specific pending order with order_id and the new status to
        /// be updated with
        /// </summary>
        /// <param name="api"></param>
        /// <param name="order_id"></param>
        /// <param name="status"></param>
        public void CancelPendingOrder(API api, string order_id, string status)
        {
            string query = "UPDATE orders SET Status_ID = 'CNCL' WHERE Order_ID = '" + order_id + "';";

            //Open connection
            if (api.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);
                //Assign the query using CommandText
                cmd.ExecuteNonQuery();
                //close connection
                api.CloseConnection();
            }
        }

       /// <summary>
       /// Update a specific pending order to paid with the order_id
       /// </summary>
       /// <param name="api"></param>
       /// <param name="order_id"></param>
        public void PayPendingOrder(API api, string order_id)
        {
            string query = "UPDATE orders SET Status_ID = 'PAID' WHERE Order_ID = '" + order_id +"';";

            //Open connection
            if (api.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);
                //Assign the query using CommandText
                cmd.ExecuteNonQuery();
                //close connection
                api.CloseConnection();
            }
        }

        /// <summary>
        /// Update a specifc Paid order to RNFD with the order_id and the status
        /// to update with
        /// </summary>
        /// <param name="api"></param>
        /// <param name="order_id"></param>
        /// <param name="status"></param>
        public void RefundPaidOrder(API api, string order_id, string status)
        {
            string query = "UPDATE orders SET Status_ID = 'RFND' WHERE Order_ID = '" + order_id + "';";

            //Open connection
            if (api.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, api.Connection);
                //Assign the query using CommandText
                cmd.ExecuteNonQuery();
                //close connection
                api.CloseConnection();
            }
        }
    }
}
