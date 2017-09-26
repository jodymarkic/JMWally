/*
 *  FILENAME: SelectACustomer.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: this file holds the SelectACustomerWindow,
 *               this window is spawned each time the user wants to
 *               find an existing customer, it just confirms that the
 *               customer they've search for is the right customer
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

namespace WallyPoS
{
    // Name: Select a customer
    // Description: This Class allows the user to confirm the existing
    //              customer they've searched for, expecially if multiple
    //              customers are returned from query.
    //
    public partial class SelectACustomer : Form
    {
        List<string> customers;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customer"></param>
        public SelectACustomer(List<string> customer)
        {
            InitializeComponent();
            customers = customer;
            SeedCustomerChoiceListbox();
            PoS.CurrentCustomer = "";
        }

        /// <summary>
        /// Add to the Customer choice listbox
        /// </summary>
        public void SeedCustomerChoiceListbox()
        {
            string customer = "";
            for (int i = 0; i < customers.Count; i++)
            {
                if (string.Compare(customers[i], "BREAK") != 0)
                {
                    customer = customer + " " + customers[i];
                }
                else
                {
                    CustomerChoiceListbox.Items.Add(customer);
                    customer = "";
                }
            }
        }

        /// <summary>
        /// Confirm Customer button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmCustomerButton_Click(object sender, EventArgs e)
        {
            string[] _currentCustomer;

            if (CustomerChoiceListbox.SelectedIndex != -1)
            {
                _currentCustomer = CustomerChoiceListbox.SelectedItem.ToString().Split(' ');

                PoS.CurrentCustomer = _currentCustomer[2] + " " + _currentCustomer[3];
                PoS.CurrentCustomerID = _currentCustomer[1];
                this.Close();
            }
            else
            {
                MessageBox.Show("Select a customer or press cancel button to exit current window.");
            }
        }

        /// <summary>
        /// Cancel button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCustomerButton_Click(object sender, EventArgs e)
        {
            PoS.CurrentCustomer = "";
            this.Close();
        }
    }
}
