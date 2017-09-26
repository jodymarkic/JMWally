/*
 *  FILENAME: AddNewCustomer.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: this file holds the window AddNewCustomer, which steps
 *               a user through the process of creating a new customer to
 *               the JMWally database
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WallyPoS.API_Classes;

namespace WallyPoS
{
    // Name: AddNewCustomer
    // Description: this Class represents a window for the user to interact with
    //              and create a new customer for JMWally through the PoS system.
    //
    public partial class AddNewCustomer : Form
    {
        private API derivedAPI;
        private Insert insert;
        private Select select;
        // private int errorFlag;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="api"></param>
        public AddNewCustomer(API api)
        {
            InitializeComponent();
            derivedAPI = api;
            insert = new Insert();
            select = new Select();
            PoS.CurrentCustomer = "";
            PoS.CurrentCustomerID = "";

        }

        /// <summary>
        /// Event handle for the Add customer button of the AddNewCustomerWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerDataButton_Click(object sender, EventArgs e)
        {
            List<string> existingCustomer = new List<string>();
            bool addCustomer;
            addCustomer = ValidateCustomerFields();
            if (addCustomer)
            {
                DialogResult dialogResult = MessageBox.Show("Are these the correct customer details?", "Add New Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FirstName = EnterFirstNameTextBox.Text;
                    LastName = EnterLastNameTextbox.Text;
                    PhoneNumber = EnterPhoneNumberTextbox.Text;
                    if (!select.checkDatabaseNewCustomer(derivedAPI, FirstName, LastName, PhoneNumber))
                    {
                        PoS.CurrentCustomer = FirstName + " " + LastName;
                        insert.AddNewCustomer(derivedAPI, FirstName, LastName, PhoneNumber);
                        this.Close();
                    }
                    else
                    {
                        PoS.CurrentCustomer = "";
                        MessageBox.Show("Customer already exists in database.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    EnterFirstNameTextBox.Text = "";
                    EnterLastNameTextbox.Text = "";
                    EnterPhoneNumberTextbox.Text = "";
                }
            }
        }


        /// <summary>
        /// Validate the first Name enter in the EnterFirstNameTextbox of the AddNewCustomer window
        /// </summary>
        /// <returns>bool</returns>
        private bool ValidateFirstName()
        {
            bool flag = true;
            string firstName = EnterFirstNameTextBox.Text;
            if (Regex.IsMatch(EnterFirstNameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                FirstName = firstName;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Validate the last Name enter in the EnterFirstNameTextbox of the AddNewCustomer window
        /// </summary>
        /// <returns>bool</returns>
        private bool ValidateLastName()
        {
            bool flag = true;
            string lastName = EnterLastNameTextbox.Text;
            if (Regex.IsMatch(EnterLastNameTextbox.Text, @"^[a-zA-Z]+$"))
            {
                LastName = lastName;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// Validate the phonenumber enter in the EnterFirstNameTextbox of the AddNewCustomer window
        /// </summary>
        /// <returns>bool</returns>
        private bool ValidatePhoneNumber()
        {
            bool flag = true;
            Int64 phoneNumber;

            if (Int64.TryParse(EnterPhoneNumberTextbox.Text, out phoneNumber))
            {
                if (phoneNumber.ToString().Length != 10)
                {
                    flag = false;
                }
                else
                {
                    PhoneNumber = phoneNumber.ToString();
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

       /// <summary>
       /// Check returns of the the validate customer info methods in the AddNewCustomer window
       /// </summary>
       /// <returns></returns>
        private bool ValidateCustomerFields()
        {
            bool dataOkay;
            bool[] allGreen = new bool[3];
            dataOkay = ValidateFirstName();
            allGreen[0] = dataOkay;
            dataOkay = ValidateLastName();
            allGreen[1] = dataOkay;
            dataOkay = ValidatePhoneNumber();
            allGreen[2] = dataOkay;
            dataOkay = BuildErrorMessage(allGreen);

            return dataOkay;
        }

        /// <summary>
        /// Builds an error message depending on the user input in the AddNewCustomer Window
        /// </summary>
        /// <param name="flags"></param>
        /// <returns></returns>
        private bool BuildErrorMessage(bool[] flags)
        {
            bool allGreen = false;
            string errorMessage = "";
            if (flags[0] && flags[1] && flags[2])
            {
                allGreen = true;
            }
            else
            {
                if (!(flags[0]))
                {
                    errorMessage = "Please provide a valid Firstname.\n";
                }
                if (!(flags[1]))
                {
                    errorMessage = errorMessage + "Please provide a valid LastName.\n";
                }
                if (!(flags[2]))
                {
                    errorMessage = errorMessage + "Please Provide a valid Phone-Number.\n";
                }
                DisplayErrorMessage(errorMessage);
            }
            return allGreen;
        }
        /// <summary>
        /// Display that built error message
        /// </summary>
        /// <param name="error"></param>
        private void DisplayErrorMessage(string error)
        {
            MessageBox.Show(error);
        }

        // END OF VALIDATING DATA FOR NEW CUSTOMER
    }
}
