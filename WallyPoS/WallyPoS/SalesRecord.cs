/*
 *  FILENAME: SalesRecord.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: This file holds the SalesRecord window,
 *               which displays a current order's sales record.
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
using WallyPoS.API_Classes;

namespace WallyPoS

{
    // Name: SalesRecord
    // Description: This Class represents a sales record for a currently placed order.
    //
    public partial class SalesRecord : Form
    {
        API derivedAPI;
        private Select select;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="api"></param>
        /// <param name="salesRecordContents"></param>
        public SalesRecord(API api, string salesRecordContents)
        {
            InitializeComponent();
            derivedAPI = api;
            select = new Select();
            string[] sales = salesRecordContents.Split('`');
            for (int i = 0; i < sales.Length; i++)
            {
                SalesRecordListbox.Items.Add(sales[i]);
            }
           // SalesRecordTextbox.Text = salesRecordContents;
        }
    }
}
