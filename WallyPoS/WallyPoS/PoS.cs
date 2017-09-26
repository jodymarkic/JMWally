/*
 *  FILENAME: PoS.CS
 *  PROJECT: JMWally
 *  PROGRAMMER: Jody Markic
 *  FIRST VERSION: 2016-12-07
 *  DESCRIPTION: This file holds the PoS Window, it is the
 *               main window in the JmWally Point of Sale System
 *               from here users can create or search for existing customers
 *               add new orders, create a sales record, update existing orders,
 *               and check inventory levels.
 *
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WallyPoS.API_Classes;

namespace WallyPoS
{
    // Name: PoS
    // Description: this class is the main window in the JmWally Point of Sale System
    //              from here users can create or search for existing customers, add new
    //              orders, create a sales record, update existing orders, and check inventory
    //              levels.
    //
    public partial class PoS : Form
    {
        //private Database database;
        private API api;
        private Select select;
        private Insert insert;
        private Update update;
        public static string CurrentCustomer { get; set; }
        public static string CurrentCustomerID { get; set; }

        public static int WhichTab { get; set; }

        public static string CustomerID { get; set; }
        public static string BranchID { get; set; }
        public static string OrderID { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public PoS()
        {
            InitializeComponent();
            List<string> buffer = new List<string>();
            //database = new Database();
            api = new API();
            select = new Select();
            insert = new Insert();
            update = new Update();
            AddToBranchComboBox(select.SeedBranchComboBox(api));
            AddToProductComboBox(select.SeedProductsComboBox(api));
            AddToInventoryListbox();
            CurrentCustomer = "";
            CurrentCustomerID = "";
        }

        /// <summary>
        /// Add to inventory listbox
        /// </summary>
        private void AddToInventoryListbox()
        {
            //int i = 0;
            List<string> products = new List<string>();

            products = select.GetProducts(api);
            for (int i = 0; i < products.Count; i++)
            {
                InventoryNameListbox.Items.Add(products[i]);
                i++;
                InventoryPriceListBox.Items.Add(products[i]);
                i++;
                InventoryCountListbox.Items.Add(products[i]);
            }

        }

        /// <summary>
        /// Adds to the Branches combo box
        /// </summary>
        /// <param name="branches"></param>
        private void AddToBranchComboBox(List<string> branches)
        {
            int length = branches.Count;

            for (int i = 0; i < length; i++)
            {
                BranchComboBox.Items.Add(branches[i]);
            }
        }

        /// <summary>
        /// Adds tot the Products combobox
        /// </summary>
        /// <param name="products"></param>
        private void AddToProductComboBox(List<string> products)
        {
            int length = products.Count;
            for (int i = 0; i < length; i++)
            {
                ProductCombobox.Items.Add(products[i]);
            }
        }

        /// <summary>
        /// Adds to the SalesRecordListbox
        /// </summary>
        /// <param name="price"></param>
        private void AddToSalesRecordListbox(string price)
        {
            string quantity = QuantityTextbox.Text.TrimStart('0');
            ProductNameListbox.Items.Add(ProductCombobox.SelectedItem.ToString());
            QuantityListbox.Items.Add(quantity);
            PricePerUnitListbox.Items.Add(price);
            CollectivePriceListbox.Items.Add(calculateCollectivePrice(QuantityTextbox.Text, price));
        }

        /// <summary>
        /// Calculates the collective price for an item in cart.
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="unitPrice"></param>
        /// <returns></returns>
        private string calculateCollectivePrice(string quantity, string unitPrice)
        {
            double _quantity = double.Parse(quantity);
            double _unitPrice = double.Parse(unitPrice);
            double collectivePrice = Math.Round(_quantity * _unitPrice, 2);

            return collectivePrice.ToString(".00");
        }

        /// <summary>
        /// toggles button after a branch has been selected to enable creating orders
        /// </summary>
        private void ToggleCustomerButtons()
        {
            CreateCustomer.Enabled = true;
            ExistingCustomer.Enabled = true;
            ProductCombobox.Enabled = true;
        }

        /// <summary>
        /// disable ability to move through branches once selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BranchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BranchComboBox.Enabled = false;
            ToggleCustomerButtons();

        }
        
        /// <summary>
        /// Create customer button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCustomer_Click(object sender, EventArgs e)
        {

            AddNewCustomer newCustomer = new AddNewCustomer(api);
            newCustomer.ShowDialog();
            CustomerNameTextbox.Text = CurrentCustomer;
        }
        /// <summary>
        /// existing customer button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExistingCustomer_Click(object sender, EventArgs e)
        {
            FindExistingCustomer existingCustomer = new FindExistingCustomer(api);
            existingCustomer.ShowDialog();
            if (CurrentCustomer.Length > 1)
            {
                parseCustomerInformation();
            }
            CustomerNameTextbox.Text = CurrentCustomer;
        }
        /// <summary>
        /// search Customer button event handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            OrderIDListbox.Items.Clear();
            CustomerIDListbox.Items.Clear();
            BranchIDListbox.Items.Clear();
            TimestampListbox.Items.Clear();
            StatusListbox.Items.Clear();
            FindExistingCustomer existingCustomer = new FindExistingCustomer(api);
            existingCustomer.ShowDialog();
            getOrders();
            //here is where I can make the order status UPDATE.

            //CustomerID
            // End of Event Handles.
        }
        /// <summary>
        /// event handle for product combo box selection changing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantityTextbox.Enabled = true;
            ConfirmQuantityButton.Enabled = true;
        }
        /// <summary>
        ///  Confirm button handle for a quantity places in the QuantityTextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmQuantityButton_Click(object sender, EventArgs e)
        {
            int validInteger = 0;
            RemoveItemButton.Enabled = true;
            ConfirmOrderButton.Enabled = true;
            if (int.TryParse(QuantityTextbox.Text, out validInteger))
            {
                if (validInteger > 0)
                {
                    AddToSalesRecordListbox(select.retrieveItemPrice(api, ProductCombobox.SelectedItem.ToString()));
                    CalculateSalesTotal();
                }
                else
                {
                    MessageBox.Show("Please provide a postive valued integer.");
                }
            }
            else
            {
                MessageBox.Show("Please provide a valid integer.");
            }
        }
        /// <summary>
        /// Calculate the total sales for an order
        /// </summary>
        private void CalculateSalesTotal()
        {
            int i = 0;
            double _SubtotalPrice = 0.0;
            SubtotalValueLabel.Text = "";
            HSTValueLabel.Text = "";
            SaleTotalValueLabel.Text = "";

            while (i < CollectivePriceListbox.Items.Count)
            {
                double _CollectivePrice = double.Parse(CollectivePriceListbox.Items[i].ToString());
                _SubtotalPrice = _SubtotalPrice + _CollectivePrice;
                i++;
            }
            _SubtotalPrice = Math.Round(_SubtotalPrice + 0.00, 2);
            double HST = Math.Round(_SubtotalPrice * (0.13), 2);
            double TotalPrice = Math.Round(_SubtotalPrice + HST, 2);
            SubtotalValueLabel.Text = _SubtotalPrice.ToString(".00");
            HSTValueLabel.Text = HST.ToString(".00");
            SaleTotalValueLabel.Text = TotalPrice.ToString(".00");
        }
        /// <summary>
        /// Remove either all or a current item in the Product listboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (ProductNameListbox.SelectedIndex != -1)
            {
                index = ProductNameListbox.SelectedIndex;
                ProductNameListbox.Items.RemoveAt(index);
                QuantityListbox.Items.RemoveAt(index);
                PricePerUnitListbox.Items.RemoveAt(index);
                CollectivePriceListbox.Items.RemoveAt(index);
                CalculateSalesTotal();
            }
            else
            {
                ProductNameListbox.Items.Clear();
                QuantityListbox.Items.Clear();
                PricePerUnitListbox.Items.Clear();
                CollectivePriceListbox.Items.Clear();
                SubtotalValueLabel.Text = "";
                HSTValueLabel.Text = "";
                SaleTotalValueLabel.Text = "";
            }
        }
        /// <summary>
        /// Confirm order button handles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please confirm placing this order", "Confirm purchase", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (CustomerNameTextbox.Text.Length <= 0)
                {
                    NewOrExistingCustomer newCustomer = new NewOrExistingCustomer(api);
                    newCustomer.ShowDialog();
                    CustomerNameTextbox.Text = CurrentCustomer;
                    SetupOrderQuery();
                    //this is where you would proceed as paid and eventually update
                    // Product Quantity levels for items purchased
                    if (CheckProductInventories())
                    {
                        insert.AddNewOrder(api, CustomerID, BranchID, "PAID");
                        select.GetCurrentOrder(api);
                        seedOrderLines_UpdateInventory();
                        //show receipt
                        SalesRecord salesRecord = new SalesRecord(api, prepareSalesRecordData());
                        salesRecord.ShowDialog();
                    }
                    // this is where you would proceed as pending and not update
                    // Product Quantity level for items purchased
                    else
                    {
                        insert.AddNewOrder(api, CustomerID, BranchID, "PEND");
                        select.GetCurrentOrder(api);
                        seedOrderLines();
                        //show receipt
                        SalesRecord salesRecord = new SalesRecord(api, prepareSalesRecordData());
                        salesRecord.ShowDialog();

                    }
                }
                else
                {
                    if (ProductNameListbox.Items.Count < 1)
                    {
                        MessageBox.Show("Please make and item selection and quantity before confirming\n purchase of a new order.");
                    }
                    else
                    {
                        SetupOrderQuery();
                        //this is where you would proceed as paid and eventually update
                        // Product Quantity levels for items purchased
                        if (CheckProductInventories())
                        {
                            insert.AddNewOrder(api, CustomerID, BranchID, "PAID");
                            select.GetCurrentOrder(api);
                            seedOrderLines_UpdateInventory();
                            //show receipt
                            SalesRecord salesRecord = new SalesRecord(api, prepareSalesRecordData());
                            salesRecord.ShowDialog();
                        }
                        // this is where you would proceed as pending and not update
                        // Product Quantity level for items purchased
                        else
                        {
                            insert.AddNewOrder(api, CustomerID, BranchID, "PEND");
                            select.GetCurrentOrder(api);
                            seedOrderLines();
                            //show receipt
                            SalesRecord salesRecord = new SalesRecord(api, prepareSalesRecordData());
                            salesRecord.ShowDialog();
                            
                        }
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }
        /// <summary>
        /// parses information to gather both the CustomerID and Name exclusively.
        /// </summary>
        public void parseCustomerInformation()
        {
            string[] split = CurrentCustomer.Split(' ');
            if(CurrentCustomer.IndexOf(' ') == 0)
            {
                CurrentCustomerID = split[1].ToString();
                CurrentCustomer = split[2].ToString() + " " + split[3].ToString();
            }
            else
            {
                CurrentCustomer = split[0].ToString() + " " + split[1].ToString();
            }
        }
        /// <summary>
        /// Check product inventories
        /// </summary>
        /// <returns></returns>
        public bool CheckProductInventories()
        {
            bool paid = true;
            bool[] allGood = new bool[ProductNameListbox.Items.Count];

            for (int i = 0; i < ProductNameListbox.Items.Count; i++)
            {
               allGood[i] = select.CheckProductInventory(api, ProductNameListbox.Items[i].ToString(), QuantityListbox.Items[i].ToString());
            }
            for (int j = 0; j < allGood.Length; j++)
            {
                if (allGood[j] == false)
                {
                    paid = false;
                    break;
                }
            }
            return paid;
        }
        /// <summary>
        /// Setup an Order Query
        /// </summary>
        public void SetupOrderQuery()
        { 
            select.GetCustomerID(api, CustomerNameTextbox.Text);
            select.GetBranchID(api, BranchComboBox.Text);
        }
        /// <summary>
        /// Insert Into the orderline table and Update the Inventories in the products tables
        /// </summary>
        public void seedOrderLines_UpdateInventory()
        {
            string[] parse;
            string _productID_inventory = "";
            string newInventory = "";
            for (int i = 0; i < ProductNameListbox.Items.Count; i++)
            {
                _productID_inventory = select.GetProductID(api, ProductNameListbox.Items[i].ToString());
                parse = _productID_inventory.Split(' ');
                insert.AddNewOrderLine(api, PoS.OrderID, parse[0], QuantityListbox.Items[i].ToString());
                newInventory = calculateNewInventory(parse[1], QuantityListbox.Items[i].ToString());
                update.updateProductInventory(api, parse[0], newInventory);
            }
        }
        /// <summary>
        /// Calculate the New inventory with current inventory and quantity requested
        /// for purchase
        /// </summary>
        /// <param name="inventory"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public string calculateNewInventory(string inventory, string quantity)
        {
            int _inventory = int.Parse(inventory);
            int _quantity = int.Parse(quantity);
            int newInventory = _inventory - _quantity;

            return newInventory.ToString();
        }
        /// <summary>
        /// Seed the orderlines
        /// </summary>
        public void seedOrderLines()
        {
            string[] parse;
            string _productID_inventory = "";
            for (int i = 0; i < ProductNameListbox.Items.Count; i++)
            {
                _productID_inventory = select.GetProductID(api, ProductNameListbox.Items[i].ToString());
                parse = _productID_inventory.Split(' ');
                insert.AddNewOrderLine(api, PoS.OrderID, parse[0], QuantityListbox.Items[i].ToString());
            }
        }
        /// <summary>
        /// Perpare a sales Record for a current order
        /// </summary>
        /// <returns></returns>
        public string prepareSalesRecordData()
        {
            string branch = BranchComboBox.Text;
            string currentTime = DateTime.Now.ToString("yyy-MM-dd");
            string customerName = CustomerNameTextbox.Text;

            string salesRecord = "**********************************`" +
                                 "Thank you for shopping at`" +
                                 "Wally's World " + branch + "`" +
                                 "On " + currentTime + ", " + customerName + "!`";

            for (int i = 0; i < ProductNameListbox.Items.Count; i++)
            {
                salesRecord = salesRecord + ProductNameListbox.Items[i].ToString() + " " +
                              QuantityListbox.Items[i].ToString() + " x  $" +
                              PricePerUnitListbox.Items[i].ToString() + "=" +
                              CollectivePriceListbox.Items[i].ToString() + "`";
            }
            string subtotal = SubtotalValueLabel.Text;
            string hst = HSTValueLabel.Text;
            string salesTotal = SaleTotalValueLabel.Text;

            salesRecord = salesRecord + "Subtotal=$ " + subtotal + "`" +
                         "HST (13%)=$ " + hst + "`" + "Sale Total=$ " +
                         salesTotal;

            return salesRecord;
        }
        /// <summary>
        /// Update Inventory button event handle, refreshes list boxes that show
        /// current inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            InventoryNameListbox.Items.Clear();

            InventoryPriceListBox.Items.Clear();

            InventoryCountListbox.Items.Clear();
            AddToInventoryListbox();
        }
        /// <summary>
        /// get Orders()
        /// </summary>
        private void getOrders()
        {
            List<string> orders = new List<string>();
            orders = select.GetOrders(api, CurrentCustomerID);

            for (int i = 0; i < orders.Count; i++)
            {
                OrderIDListbox.Items.Add(orders[i].ToString());
                i++;
                CustomerIDListbox.Items.Add(orders[i].ToString());
                i++;
                BranchIDListbox.Items.Add(orders[i].ToString());
                i++;
                TimestampListbox.Items.Add(orders[i].ToString());
                i++;
                StatusListbox.Items.Add(orders[i].ToString());
            }
        }
        /// <summary>
        /// OrderIDListbox_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderIDListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrderIDListbox.SelectedIndex;
            string status;

            if (index != -1)
            {
                status = StatusListbox.Items[index].ToString();

                switch (status)
                {
                    case "PAID":
                        PaidStatusButton.Enabled = false;
                        CancelStatusButton.Enabled = false;
                        RefundStatusButton.Enabled = true;
                        break;
                    case "PEND":
                        PaidStatusButton.Enabled = true;
                        CancelStatusButton.Enabled = true;
                        RefundStatusButton.Enabled = false;
                        break;
                    case "CNCL":
                        PaidStatusButton.Enabled = false;
                        CancelStatusButton.Enabled = false;
                        RefundStatusButton.Enabled = false;
                        break;
                    case "RFND":
                        PaidStatusButton.Enabled = false;
                        CancelStatusButton.Enabled = false;
                        RefundStatusButton.Enabled = false;
                        break;
                }

            } 
        }
        /// <summary>
        /// PaidStatusButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaidStatusButton_Click(object sender, EventArgs e)
        {
            int index = OrderIDListbox.SelectedIndex;
            string order_ID = OrderIDListbox.SelectedItem.ToString();
            string status = StatusListbox.Items[index].ToString();

            if (updateProductInventory(select.GetOrderLines(api, order_ID)))
            {
                update.PayPendingOrder(api, order_ID);
                StatusListbox.Items[index] = "PAID";
            }
        }
        /// <summary>
        /// CancelStatusButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelStatusButton_Click(object sender, EventArgs e)
        {
            int index = OrderIDListbox.SelectedIndex;
            string order_ID = OrderIDListbox.SelectedItem.ToString();
            string status = StatusListbox.Items[index].ToString();
            update.CancelPendingOrder(api, order_ID, status);
            StatusListbox.Items[index] = "CNCL";
        }
        /// <summary>
        /// RefundStatusButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefundStatusButton_Click(object sender, EventArgs e)
        {
            int index = OrderIDListbox.SelectedIndex;
            string order_ID = OrderIDListbox.SelectedItem.ToString();
            string status = StatusListbox.Items[index].ToString();

            ZeroProductInventory(select.GetOrderLines(api, order_ID));
            update.RefundPaidOrder(api, order_ID, status);
            StatusListbox.Items[index] = "RFND";
        }
        /// <summary>
        /// updateProductInventory
        /// </summary>
        /// <param name="orderline"></param>
        /// <returns></returns>
        private bool updateProductInventory(List<string> orderline)
        {
            bool updateSuccesful = false;
            List<bool> allGood = new List<bool>();
            int newInventory = 0;

            for (int i = 0; i < orderline.Count; i++)
            {
                int product_id = int.Parse(orderline[i]);
                i++;
                string quantity = orderline[i];

               allGood.Add(select.CheckProductInventory(api, product_id, quantity));
            }

            if (allGood.Contains(false))
            {
                
                MessageBox.Show("Sorry but item inventory still hasn't adjusted to finalize this order.");
            }
            else
            {
                for (int i = 0; i < orderline.Count; i++)
                {
                    int product_id = int.Parse(orderline[i]);
                    i++;
                    int quantity = int.Parse(orderline[i]);
                    newInventory = select.GetProductInventory(api, product_id);
                    newInventory = newInventory - quantity;
                    update.updateProductInventory(api, product_id.ToString(), newInventory.ToString());
                    //lets update this bitch
                }

                updateSuccesful = true;
            }
            return updateSuccesful;
        }
        /// <summary>
        /// orderline"></param
        /// </summary>
        /// <param name="orderline"></param>
        private void ZeroProductInventory(List<string> orderline)
        {
            int newInventory = 0;

            for (int i = 0; i < orderline.Count; i++)
            {
                int product_id = int.Parse(orderline[i]);
                i++;
                int quantity = int.Parse(orderline[i]);
                newInventory = select.GetProductInventory(api, product_id);
                newInventory = newInventory + quantity;
                update.updateProductInventory(api, product_id.ToString(), newInventory.ToString());
            }
        }
    }
}
