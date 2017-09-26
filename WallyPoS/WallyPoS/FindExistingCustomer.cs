/*
 *  FILENAME: FindExistingCustomer.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: this file holds the window FindExistingCustomer, which steps
 *               a user through the process of finding an already existing customer to
 *               the JMWally database.
 *
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
//using WallyPoS.DatabaseClasses;
using WallyPoS.API_Classes;


namespace WallyPoS
{
    // Name: FindExistingCustomer
    // Description: this Class represents a window for the user to interact with
    //              and find an existing customer in JMWally through the PoS system.
    //
    public partial class FindExistingCustomer : Form
    {
        private API derivedAPI;
        private Select select;
        public FindExistingCustomer(API api)
        {
            InitializeComponent();
            derivedAPI = api;
            PoS.CurrentCustomer = "";
            PoS.CurrentCustomerID = "";
        }

        /// <summary>
        /// Search Customer button event handle for the FindExistingCustomer Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            List<string> customer = new List<string>();
            bool nameProvided = ValidateLastname();
            bool numberProvided = ValidatePhoneNumber();
            bool allGreen = displayError(nameProvided, numberProvided);
            if(allGreen)
            {
                DialogResult dialogResult = MessageBox.Show("Confirm customer details", "Confirm Existing Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    select = new Select();
                    if (PhoneNumberTextBox.Text.Length > 0)
                    {
                        customer = select.findExistingCustomer(derivedAPI, PhoneNumberTextBox.Text);
                    }
                    else
                    {
                        customer = select.findExistingCustomer(derivedAPI, LastNameTextbox.Text, 0);
                    }
                    if (!customer.Contains("NULL"))
                    {
                        SelectACustomer selectCustomer = new SelectACustomer(customer);
                        selectCustomer.ShowDialog();

                        //PoS.CurrentCustomer = LastNameTextbox.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Customer could not be found.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    LastNameTextbox.Text = "";
                    PhoneNumberTextBox.Text = "";
                }
            }
        }

        /// <summary>
        /// Validate last name in the LastNameTextBox of the FindExistingCustomer window
        /// </summary>
        /// <returns></returns>
        private bool ValidateLastname()
        {
            bool nameProvided = true;
            if (LastNameTextbox.Text.Length < 1)
            {
                nameProvided = false;
            }
            else
            {
                if(LastNameTextbox.Text.Contains(" "))
                {
                    nameProvided = false;
                }
            }
            return nameProvided;
        }

        /// <summary>
        ///  Validate last name in the PhoneNumberTextBox of the FindExistingCustomer window
        /// </summary>
        /// <returns></returns>
        private bool ValidatePhoneNumber()
        {
            bool numberProvided = true;
            if (PhoneNumberTextBox.Text.Length != 10)
            {
                numberProvided = false;
            }
            return numberProvided;
        }

        /// <summary>
        /// Display Error
        /// </summary>
        /// <param name="nameProvided"></param>
        /// <param name="numberProvided"></param>
        /// <returns></returns>
        private bool displayError(bool nameProvided, bool numberProvided)
        {
            bool allGreen = true;
            if (PhoneNumberTextBox.Text.Length > 0 && PhoneNumberTextBox.Text.Length != 10)
            {
                allGreen = false;
                MessageBox.Show("Please provide a valid phonenumber.\n e.g(2265004735)");
            }
            else if (!nameProvided && !numberProvided)
            {
                allGreen = false;
                MessageBox.Show("Please provide a lastname or a phone-number to search by.");
            }
            else if (nameProvided && numberProvided)
            {
                allGreen = false;
                MessageBox.Show("Please provide a lastname or a phone-number to search by,\n but not both.");
            }
            return allGreen;
        }
    }
}
