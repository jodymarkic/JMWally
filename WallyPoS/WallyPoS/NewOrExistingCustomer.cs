/*
 *  FILENAME: NewOrExistingCustomer.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: this file holds the window for NewOrExistingCustomer,
 *               if a user places an order without a customer selected this
 *               window spawn which allows the user to spawn either AddNewCustomer
 *               or FindExisting Customer
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
    // Name: NewOrExistingCustomer
    // Description: this Class represents a window for the user to choose from
    //              creating or finding an existing customer for the current sales record
    //              to complete it for JMWally through the PoS system.
    //
    public partial class NewOrExistingCustomer : Form
    {
        private API derivedAPI;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="api"></param>
        public NewOrExistingCustomer(API api)
        {
            InitializeComponent();
            derivedAPI = api;
        }

        /// <summary>
        /// NewCustomer button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomer newCustomer = new AddNewCustomer(derivedAPI);
            newCustomer.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// existing customer event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExistingCustomerButton_Click(object sender, EventArgs e)
        {
            FindExistingCustomer existingCustomer = new FindExistingCustomer(derivedAPI);
            existingCustomer.ShowDialog();
            this.Close();
        }
    }
}
