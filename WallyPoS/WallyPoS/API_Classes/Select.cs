/*
 *  FILENAME: Select.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: This file hold methods to query the JMWally database for with SELECT scripts
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//using WallyPoS.DatabaseClasses;

namespace WallyPoS.API_Classes
{
    // Name: Select
    // Description: This Class is used to make SELECT queries to the JMWally database
    //
    public class Select
    {
        /// <summary>
        /// searches database for new customer to avoid duplication
        /// </summary>
        /// <param name="api"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="telephone"></param>
        /// <returns>bool</returns>
        public bool checkDatabaseNewCustomer(API api, string firstName, string lastName, string telephone)
        {
            bool employeeExist = false;
            List<string> customerToSearch = new List<string>();

            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT First_Name, Last_Name, Telephone FROM customer " +
                   "WHERE First_Name='" + firstName + "' AND Last_Name='" + lastName + "' AND Telephone='" +
                   telephone + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    customerToSearch.Add(dataReader["First_Name"].ToString());
                    customerToSearch.Add(dataReader["Last_Name"].ToString());
                    customerToSearch.Add(dataReader["Telephone"].ToString());
                    //customerToSearch.Add()
                }

                if (customerToSearch.Count == 3)
                {
                    employeeExist = true;
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                employeeExist = true;
            }
            return employeeExist;
        }

       /// <summary>
       /// Seeds the branch combobox on startup of the program
       /// </summary>
       /// <param name="api"></param>
       /// <returns></returns>
        public List<string> SeedBranchComboBox(API api)
        {
            List<string> branches = new List<string>();

            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT Branch_Name FROM branch", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    branches.Add(dataReader["Branch_Name"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                branches.Add("Could not open connection.");
            }
            return branches;
        }

        /// <summary>
        /// Find an existing customer within the database with a lastName
        /// </summary>
        /// <param name="api"></param>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        /// <returns>List of strings</returns>
        public List<string> findExistingCustomer(API api, string name, int tag)
        {
            int flag = 0;
            List<string> customer = new List<string>();
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM customer WHERE Last_Name = '" + name + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                while (dataReader.Read())
                {
                    customer.Add(dataReader["Customer_ID"].ToString());
                    customer.Add(dataReader["First_Name"].ToString());
                    customer.Add(dataReader["Last_Name"].ToString());
                    customer.Add(dataReader["Telephone"].ToString());
                    customer.Add("BREAK");
                    flag = 1;
                }
                if (flag == 0)
                {
                    customer.Add("NULL");
                }
                //close Data Reader


                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                customer.Add("NULL");
            }
            return customer;
        }

        /// <summary>
        /// find existing customer withing the database with a telephone number
        /// </summary>
        /// <param name="api"></param>
        /// <param name="telephone"></param>
        /// <returns> List of strings</returns>
        public List<string> findExistingCustomer(API api, string telephone)
        {
            int flag = 0;
            List<string> customer = new List<string>();
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM customer WHERE Telephone = '" + telephone + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list

                while (dataReader.Read())
                {
                    customer.Add(dataReader["Customer_ID"].ToString());
                    customer.Add(dataReader["First_Name"].ToString());
                    customer.Add(dataReader["Last_Name"].ToString());
                    customer.Add(dataReader["Telephone"].ToString());
                    customer.Add("BREAK");
                    flag = 1;
                }
                if (flag == 0)
                {
                    customer.Add("NULL");
                }
                //close Data Reader


                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                customer.Add("NULL");
            }
            return customer;
        }

        /// <summary>
        ///  Seed the products Combobox on load of the PoS
        /// </summary>
        /// <param name="api"></param>
        /// <returns>List of strings</returns>
        public List<string> SeedProductsComboBox(API api)
        {
            List<string> productNames = new List<string>();
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand("SELECT Product_Name FROM product", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    productNames.Add(dataReader["Product_Name"].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                productNames.Add("NULL");
            }
            return productNames;
        }

        /// <summary>
        /// Retrieve an Item price in the Products table
        /// </summary>
        /// <param name="api"></param>
        /// <param name="productName"></param>
        /// <returns>string </returns>
        public string retrieveItemPrice(API api, string productName)
        {
            string price = "0";
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Price FROM product WHERE Product_Name = '" + productName + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    price = dataReader["Price"].ToString();
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
            else
            {
                price ="NULL";
            }


            return price;
        }

        /// <summary>
        /// Checks the Product inventory and compares it to the quantity a customer
        ///  is requesting to purchase
        /// </summary>
        /// <param name="api"></param>
        /// <param name="product_Name"></param>
        /// <param name="quantity"></param>
        /// <returns>bool</returns>
        public bool CheckProductInventory(API api, string product_Name, string quantity)
        {
            bool allGood = false;
            int _quantity = int.Parse(quantity);
            int inventory = 0;
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Quantity FROM product WHERE Product_Name = '" + product_Name + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    inventory = (int)dataReader["Quantity"];
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                if (_quantity <= inventory)
                {
                    allGood = true;
                }

                //return list to be displayed
            }
            else
            {
                allGood = false;
            }
            return allGood;
        }

        /// <summary>
        /// Gets the Customer ID from the customer table
        /// </summary>
        /// <param name="api"></param>
        /// <param name="customer_name"></param>
        public void GetCustomerID(API api, string customer_name)
        {
            string[] split = customer_name.Split(' ');
            

            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Customer_ID FROM customer WHERE First_Name = '" 
                                                    + split[0] + "' AND Last_Name = '" + split[1] + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    PoS.CustomerID = dataReader["Customer_ID"].ToString();
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                //return list to be displayed
            }
        }

        /// <summary>
        /// Get the Branch id from the branch table
        /// </summary>
        /// <param name="api"></param>
        /// <param name="branch_name"></param>
        public void GetBranchID(API api, string branch_name)
        {
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Branch_ID FROM branch WHERE Branch_Name = '"
                                                    + branch_name + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    PoS.BranchID = dataReader["Branch_ID"].ToString();
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();
                //return list to be displayed
            }

        }

        /// <summary>
        /// get the orderID from the currently placed order
        /// </summary>
        /// <param name="api"></param>
        public void GetCurrentOrder(API api)
        {
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT COUNT(*) FROM orders;", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    PoS.OrderID = dataReader.GetInt32(0).ToString();
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();
                //return list to be displayed
            }
        }

        /// <summary>
        ///  Get the product ID from products with a product Name
        /// </summary>
        /// <param name="api"></param>
        /// <param name="product_Name"></param>
        /// <returns>string</returns>
        public string GetProductID(API api, string product_Name)
        {
            string _productID = "";
            string _inventory = "";
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Product_ID, Quantity FROM product WHERE Product_Name = '" + product_Name + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _productID = dataReader["Product_ID"].ToString();
                    _inventory = dataReader["Quantity"].ToString();
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();
            }
            return _productID + " " + _inventory;
        }

        /// <summary>
        /// Get product name price and quantity from the product table
        /// </summary>
        /// <param name="api"></param>
        /// <returns>list of strings</returns>
        public List<string> GetProducts(API api)
        {
            List<string> productData = new List<string>();


            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Product_Name, Price, Quantity FROM product;", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    productData.Add(dataReader["Product_Name"].ToString());
                    productData.Add(dataReader["Price"].ToString());
                    productData.Add(dataReader["Quantity"].ToString());
                    //productData.Add("BREAK");
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();
            }
            return productData;

        }

        /// <summary>
        /// Get All orders associated with a customer
        /// </summary>
        /// <param name="api"></param>
        /// <param name="customerID"></param>
        /// <returns>list of strings</returns>
        public List<string> GetOrders(API api, string customerID)
        {
            List<string> orderData = new List<string>();

            if (api.OpenConnection() == true)
            {
                //Create Comman
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM orders WHERE Customer_ID = '" + customerID + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    orderData.Add(dataReader["Order_ID"].ToString());
                    orderData.Add(dataReader["Customer_ID"].ToString());
                    orderData.Add(dataReader["Branch_ID"].ToString());
                    orderData.Add(dataReader["Order_Date"].ToString());
                    orderData.Add(dataReader["Status_ID"].ToString());

                }
                dataReader.Close();
                //close Connection
                api.CloseConnection();
                //close 
            }
            else
            {
                orderData.Add("NULL");
            }

            return orderData;
        }

        /// <summary>
        /// Get all orderlines associated with an order
        /// </summary>
        /// <param name="api"></param>
        /// <param name="orderID"></param>
        /// <returns> list of strings</returns>
        public List<string> GetOrderLines(API api, string orderID)
        {
            List<string> orderlistData = new List<string>();

            if (api.OpenConnection() == true)
            {
                //Create Comman
                MySqlCommand cmd = new MySqlCommand(@"SELECT Product_ID, Order_Quantity FROM Orderline WHERE Order_ID = '" + orderID + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    orderlistData.Add(dataReader["Product_ID"].ToString());
                    orderlistData.Add(dataReader["Order_Quantity"].ToString());
                }
                dataReader.Close();
                //close Connection
                api.CloseConnection();
                //close 
            }
            else
            {
                orderlistData.Add("NULL");
            }

            return orderlistData;
        }


       /// <summary>
       ///  Check the product inventory of a specific product with product ID,
       ///  and the quantity to compare to
       /// </summary>
       /// <param name="api"></param>
       /// <param name="product_id"></param>
       /// <param name="quantity"></param>
       /// <returns>bool</returns>
        public bool CheckProductInventory(API api, int product_id, string quantity)
        {
            bool allGood = false;
            int _quantity = int.Parse(quantity);
            int inventory = 0;
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Quantity FROM product WHERE Product_ID = '" + product_id.ToString() + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    inventory = (int)dataReader["Quantity"];
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();

                if (_quantity <= inventory)
                {
                    allGood = true;
                }

                //return list to be displayed
            }
            else
            {
                allGood = false;
            }
            return allGood;
        }

        /// <summary>
        /// Get the product inventory of a paticular product from the products
        /// table with the product_id
        /// </summary>
        /// <param name="api"></param>
        /// <param name="product_id"></param>
        /// <returns>int</returns>
        public int GetProductInventory(API api, int product_id)
        {
            int inventory = 0;
            if (api.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(@"SELECT Quantity FROM product WHERE Product_ID = '" + product_id.ToString() + "';", api.Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    inventory = int.Parse(dataReader["Quantity"].ToString());
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                api.CloseConnection();
                //return list to be displayed
            }
            else
            {
                inventory = -1;
            }
            return inventory;
        }
    }
}
