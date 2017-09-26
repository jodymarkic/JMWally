namespace WallyPoS
{
    partial class PoS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PoSTabControl = new System.Windows.Forms.TabControl();
            this.SalesRecordTab = new System.Windows.Forms.TabPage();
            this.CollectivePriceLabel = new System.Windows.Forms.Label();
            this.CollectivePriceListbox = new System.Windows.Forms.ListBox();
            this.PricePerUnitLabel = new System.Windows.Forms.Label();
            this.ProductQuantityLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.PricePerUnitListbox = new System.Windows.Forms.ListBox();
            this.QuantityListbox = new System.Windows.Forms.ListBox();
            this.ConfirmQuantityButton = new System.Windows.Forms.Button();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SaleTotalValueLabel = new System.Windows.Forms.Label();
            this.HSTValueLabel = new System.Windows.Forms.Label();
            this.SubtotalValueLabel = new System.Windows.Forms.Label();
            this.SalesTotalLabel = new System.Windows.Forms.Label();
            this.HSTLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextbox = new System.Windows.Forms.TextBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.CurrentCustomerLabel = new System.Windows.Forms.Label();
            this.ProductCombobox = new System.Windows.Forms.ComboBox();
            this.ProductNameListbox = new System.Windows.Forms.ListBox();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.ExistingCustomer = new System.Windows.Forms.Button();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.SearchRecordTab = new System.Windows.Forms.TabPage();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TimeStampLabel = new System.Windows.Forms.Label();
            this.BranchIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.StatusListbox = new System.Windows.Forms.ListBox();
            this.TimestampListbox = new System.Windows.Forms.ListBox();
            this.BranchIDListbox = new System.Windows.Forms.ListBox();
            this.CustomerIDListbox = new System.Windows.Forms.ListBox();
            this.CancelStatusButton = new System.Windows.Forms.Button();
            this.OrderIDListbox = new System.Windows.Forms.ListBox();
            this.RefundStatusButton = new System.Windows.Forms.Button();
            this.PaidStatusButton = new System.Windows.Forms.Button();
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.s = new System.Windows.Forms.Label();
            this.InventoryPriceLabel = new System.Windows.Forms.Label();
            this.InventoryNameLabel = new System.Windows.Forms.Label();
            this.InventoryCountListbox = new System.Windows.Forms.ListBox();
            this.InventoryPriceListBox = new System.Windows.Forms.ListBox();
            this.InventoryNameListbox = new System.Windows.Forms.ListBox();
            this.UpdateInventoryButton = new System.Windows.Forms.Button();
            this.PoSTabControl.SuspendLayout();
            this.SalesRecordTab.SuspendLayout();
            this.SearchRecordTab.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PoSTabControl
            // 
            this.PoSTabControl.Controls.Add(this.SalesRecordTab);
            this.PoSTabControl.Controls.Add(this.SearchRecordTab);
            this.PoSTabControl.Controls.Add(this.InventoryTab);
            this.PoSTabControl.Location = new System.Drawing.Point(16, 15);
            this.PoSTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.PoSTabControl.Name = "PoSTabControl";
            this.PoSTabControl.SelectedIndex = 0;
            this.PoSTabControl.Size = new System.Drawing.Size(1349, 631);
            this.PoSTabControl.TabIndex = 0;
            this.PoSTabControl.Tag = "";
            // 
            // SalesRecordTab
            // 
            this.SalesRecordTab.Controls.Add(this.CollectivePriceLabel);
            this.SalesRecordTab.Controls.Add(this.CollectivePriceListbox);
            this.SalesRecordTab.Controls.Add(this.PricePerUnitLabel);
            this.SalesRecordTab.Controls.Add(this.ProductQuantityLabel);
            this.SalesRecordTab.Controls.Add(this.ProductNameLabel);
            this.SalesRecordTab.Controls.Add(this.PricePerUnitListbox);
            this.SalesRecordTab.Controls.Add(this.QuantityListbox);
            this.SalesRecordTab.Controls.Add(this.ConfirmQuantityButton);
            this.SalesRecordTab.Controls.Add(this.QuantityTextbox);
            this.SalesRecordTab.Controls.Add(this.QuantityLabel);
            this.SalesRecordTab.Controls.Add(this.SaleTotalValueLabel);
            this.SalesRecordTab.Controls.Add(this.HSTValueLabel);
            this.SalesRecordTab.Controls.Add(this.SubtotalValueLabel);
            this.SalesRecordTab.Controls.Add(this.SalesTotalLabel);
            this.SalesRecordTab.Controls.Add(this.HSTLabel);
            this.SalesRecordTab.Controls.Add(this.SubtotalLabel);
            this.SalesRecordTab.Controls.Add(this.BranchComboBox);
            this.SalesRecordTab.Controls.Add(this.label1);
            this.SalesRecordTab.Controls.Add(this.CustomerNameTextbox);
            this.SalesRecordTab.Controls.Add(this.ProductLabel);
            this.SalesRecordTab.Controls.Add(this.CurrentCustomerLabel);
            this.SalesRecordTab.Controls.Add(this.ProductCombobox);
            this.SalesRecordTab.Controls.Add(this.ProductNameListbox);
            this.SalesRecordTab.Controls.Add(this.RemoveItemButton);
            this.SalesRecordTab.Controls.Add(this.ConfirmOrderButton);
            this.SalesRecordTab.Controls.Add(this.ExistingCustomer);
            this.SalesRecordTab.Controls.Add(this.CreateCustomer);
            this.SalesRecordTab.Location = new System.Drawing.Point(4, 25);
            this.SalesRecordTab.Margin = new System.Windows.Forms.Padding(4);
            this.SalesRecordTab.Name = "SalesRecordTab";
            this.SalesRecordTab.Padding = new System.Windows.Forms.Padding(4);
            this.SalesRecordTab.Size = new System.Drawing.Size(1341, 602);
            this.SalesRecordTab.TabIndex = 0;
            this.SalesRecordTab.Text = "SalesRecord";
            this.SalesRecordTab.UseVisualStyleBackColor = true;
            // 
            // CollectivePriceLabel
            // 
            this.CollectivePriceLabel.AutoSize = true;
            this.CollectivePriceLabel.Location = new System.Drawing.Point(1140, 30);
            this.CollectivePriceLabel.Name = "CollectivePriceLabel";
            this.CollectivePriceLabel.Size = new System.Drawing.Size(108, 17);
            this.CollectivePriceLabel.TabIndex = 26;
            this.CollectivePriceLabel.Text = "Collective Price:";
            // 
            // CollectivePriceListbox
            // 
            this.CollectivePriceListbox.Enabled = false;
            this.CollectivePriceListbox.FormattingEnabled = true;
            this.CollectivePriceListbox.ItemHeight = 16;
            this.CollectivePriceListbox.Location = new System.Drawing.Point(1143, 55);
            this.CollectivePriceListbox.Name = "CollectivePriceListbox";
            this.CollectivePriceListbox.Size = new System.Drawing.Size(160, 436);
            this.CollectivePriceListbox.TabIndex = 25;
            // 
            // PricePerUnitLabel
            // 
            this.PricePerUnitLabel.AutoSize = true;
            this.PricePerUnitLabel.Location = new System.Drawing.Point(980, 30);
            this.PricePerUnitLabel.Name = "PricePerUnitLabel";
            this.PricePerUnitLabel.Size = new System.Drawing.Size(99, 17);
            this.PricePerUnitLabel.TabIndex = 24;
            this.PricePerUnitLabel.Text = "Price Per Unit:";
            // 
            // ProductQuantityLabel
            // 
            this.ProductQuantityLabel.AutoSize = true;
            this.ProductQuantityLabel.Location = new System.Drawing.Point(820, 30);
            this.ProductQuantityLabel.Name = "ProductQuantityLabel";
            this.ProductQuantityLabel.Size = new System.Drawing.Size(65, 17);
            this.ProductQuantityLabel.TabIndex = 23;
            this.ProductQuantityLabel.Text = "Quantity:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(450, 30);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(102, 17);
            this.ProductNameLabel.TabIndex = 22;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // PricePerUnitListbox
            // 
            this.PricePerUnitListbox.Enabled = false;
            this.PricePerUnitListbox.FormattingEnabled = true;
            this.PricePerUnitListbox.ItemHeight = 16;
            this.PricePerUnitListbox.Location = new System.Drawing.Point(983, 55);
            this.PricePerUnitListbox.Name = "PricePerUnitListbox";
            this.PricePerUnitListbox.Size = new System.Drawing.Size(160, 436);
            this.PricePerUnitListbox.TabIndex = 21;
            // 
            // QuantityListbox
            // 
            this.QuantityListbox.Enabled = false;
            this.QuantityListbox.FormattingEnabled = true;
            this.QuantityListbox.ItemHeight = 16;
            this.QuantityListbox.Location = new System.Drawing.Point(823, 55);
            this.QuantityListbox.Name = "QuantityListbox";
            this.QuantityListbox.Size = new System.Drawing.Size(160, 436);
            this.QuantityListbox.TabIndex = 20;
            // 
            // ConfirmQuantityButton
            // 
            this.ConfirmQuantityButton.Enabled = false;
            this.ConfirmQuantityButton.Location = new System.Drawing.Point(192, 372);
            this.ConfirmQuantityButton.Name = "ConfirmQuantityButton";
            this.ConfirmQuantityButton.Size = new System.Drawing.Size(75, 25);
            this.ConfirmQuantityButton.TabIndex = 19;
            this.ConfirmQuantityButton.Text = "Confirm";
            this.ConfirmQuantityButton.UseVisualStyleBackColor = true;
            this.ConfirmQuantityButton.Click += new System.EventHandler(this.ConfirmQuantityButton_Click);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Enabled = false;
            this.QuantityTextbox.Location = new System.Drawing.Point(23, 373);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(163, 22);
            this.QuantityTextbox.TabIndex = 18;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(22, 345);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(93, 25);
            this.QuantityLabel.TabIndex = 17;
            this.QuantityLabel.Text = "Quantity";
            // 
            // SaleTotalValueLabel
            // 
            this.SaleTotalValueLabel.AutoSize = true;
            this.SaleTotalValueLabel.Location = new System.Drawing.Point(578, 563);
            this.SaleTotalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaleTotalValueLabel.Name = "SaleTotalValueLabel";
            this.SaleTotalValueLabel.Size = new System.Drawing.Size(0, 17);
            this.SaleTotalValueLabel.TabIndex = 16;
            // 
            // HSTValueLabel
            // 
            this.HSTValueLabel.AutoSize = true;
            this.HSTValueLabel.Location = new System.Drawing.Point(578, 532);
            this.HSTValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HSTValueLabel.Name = "HSTValueLabel";
            this.HSTValueLabel.Size = new System.Drawing.Size(0, 17);
            this.HSTValueLabel.TabIndex = 15;
            // 
            // SubtotalValueLabel
            // 
            this.SubtotalValueLabel.AutoSize = true;
            this.SubtotalValueLabel.Location = new System.Drawing.Point(578, 502);
            this.SubtotalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtotalValueLabel.Name = "SubtotalValueLabel";
            this.SubtotalValueLabel.Size = new System.Drawing.Size(0, 17);
            this.SubtotalValueLabel.TabIndex = 14;
            // 
            // SalesTotalLabel
            // 
            this.SalesTotalLabel.AutoSize = true;
            this.SalesTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTotalLabel.Location = new System.Drawing.Point(449, 561);
            this.SalesTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTotalLabel.Name = "SalesTotalLabel";
            this.SalesTotalLabel.Size = new System.Drawing.Size(121, 20);
            this.SalesTotalLabel.TabIndex = 13;
            this.SalesTotalLabel.Text = "Sales Total =";
            // 
            // HSTLabel
            // 
            this.HSTLabel.AutoSize = true;
            this.HSTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSTLabel.Location = new System.Drawing.Point(457, 530);
            this.HSTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HSTLabel.Name = "HSTLabel";
            this.HSTLabel.Size = new System.Drawing.Size(113, 20);
            this.HSTLabel.TabIndex = 12;
            this.HSTLabel.Text = "HST(13%) =";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.Location = new System.Drawing.Point(475, 500);
            this.SubtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(95, 20);
            this.SubtotalLabel.TabIndex = 11;
            this.SubtotalLabel.Text = "Subtotal =";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(23, 52);
            this.BranchComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(381, 24);
            this.BranchComboBox.TabIndex = 10;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select A Branch";
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.Enabled = false;
            this.CustomerNameTextbox.Location = new System.Drawing.Point(23, 236);
            this.CustomerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(381, 22);
            this.CustomerNameTextbox.TabIndex = 8;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(21, 276);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(174, 25);
            this.ProductLabel.TabIndex = 7;
            this.ProductLabel.Text = "Select A Product";
            // 
            // CurrentCustomerLabel
            // 
            this.CurrentCustomerLabel.AutoSize = true;
            this.CurrentCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCustomerLabel.Location = new System.Drawing.Point(21, 208);
            this.CurrentCustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentCustomerLabel.Name = "CurrentCustomerLabel";
            this.CurrentCustomerLabel.Size = new System.Drawing.Size(183, 25);
            this.CurrentCustomerLabel.TabIndex = 6;
            this.CurrentCustomerLabel.Text = "Current Customer";
            // 
            // ProductCombobox
            // 
            this.ProductCombobox.Enabled = false;
            this.ProductCombobox.FormattingEnabled = true;
            this.ProductCombobox.Location = new System.Drawing.Point(23, 304);
            this.ProductCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductCombobox.Name = "ProductCombobox";
            this.ProductCombobox.Size = new System.Drawing.Size(381, 24);
            this.ProductCombobox.TabIndex = 5;
            this.ProductCombobox.SelectedIndexChanged += new System.EventHandler(this.ProductCombobox_SelectedIndexChanged);
            // 
            // ProductNameListbox
            // 
            this.ProductNameListbox.FormattingEnabled = true;
            this.ProductNameListbox.ItemHeight = 16;
            this.ProductNameListbox.Location = new System.Drawing.Point(453, 55);
            this.ProductNameListbox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductNameListbox.Name = "ProductNameListbox";
            this.ProductNameListbox.Size = new System.Drawing.Size(370, 436);
            this.ProductNameListbox.TabIndex = 4;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Enabled = false;
            this.RemoveItemButton.Location = new System.Drawing.Point(23, 500);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(189, 79);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove Items";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Enabled = false;
            this.ConfirmOrderButton.Location = new System.Drawing.Point(220, 500);
            this.ConfirmOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(189, 79);
            this.ConfirmOrderButton.TabIndex = 2;
            this.ConfirmOrderButton.Text = "Confirm Order\r\n";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // ExistingCustomer
            // 
            this.ExistingCustomer.Enabled = false;
            this.ExistingCustomer.Location = new System.Drawing.Point(220, 103);
            this.ExistingCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.ExistingCustomer.Name = "ExistingCustomer";
            this.ExistingCustomer.Size = new System.Drawing.Size(189, 79);
            this.ExistingCustomer.TabIndex = 1;
            this.ExistingCustomer.Text = "Find Existing Customer";
            this.ExistingCustomer.UseVisualStyleBackColor = true;
            this.ExistingCustomer.Click += new System.EventHandler(this.ExistingCustomer_Click);
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Enabled = false;
            this.CreateCustomer.Location = new System.Drawing.Point(23, 103);
            this.CreateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(189, 79);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "Add Customer";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // SearchRecordTab
            // 
            this.SearchRecordTab.Controls.Add(this.StatusLabel);
            this.SearchRecordTab.Controls.Add(this.TimeStampLabel);
            this.SearchRecordTab.Controls.Add(this.BranchIDLabel);
            this.SearchRecordTab.Controls.Add(this.CustomerIDLabel);
            this.SearchRecordTab.Controls.Add(this.OrderIDLabel);
            this.SearchRecordTab.Controls.Add(this.StatusListbox);
            this.SearchRecordTab.Controls.Add(this.TimestampListbox);
            this.SearchRecordTab.Controls.Add(this.BranchIDListbox);
            this.SearchRecordTab.Controls.Add(this.CustomerIDListbox);
            this.SearchRecordTab.Controls.Add(this.CancelStatusButton);
            this.SearchRecordTab.Controls.Add(this.OrderIDListbox);
            this.SearchRecordTab.Controls.Add(this.RefundStatusButton);
            this.SearchRecordTab.Controls.Add(this.PaidStatusButton);
            this.SearchRecordTab.Controls.Add(this.SearchCustomerButton);
            this.SearchRecordTab.Location = new System.Drawing.Point(4, 25);
            this.SearchRecordTab.Margin = new System.Windows.Forms.Padding(4);
            this.SearchRecordTab.Name = "SearchRecordTab";
            this.SearchRecordTab.Padding = new System.Windows.Forms.Padding(4);
            this.SearchRecordTab.Size = new System.Drawing.Size(1341, 602);
            this.SearchRecordTab.TabIndex = 1;
            this.SearchRecordTab.Text = "SearchRecord";
            this.SearchRecordTab.UseVisualStyleBackColor = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(1095, 38);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(69, 20);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status:";
            // 
            // TimeStampLabel
            // 
            this.TimeStampLabel.AutoSize = true;
            this.TimeStampLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStampLabel.Location = new System.Drawing.Point(902, 39);
            this.TimeStampLabel.Name = "TimeStampLabel";
            this.TimeStampLabel.Size = new System.Drawing.Size(109, 20);
            this.TimeStampLabel.TabIndex = 13;
            this.TimeStampLabel.Text = "TimeStamp:";
            // 
            // BranchIDLabel
            // 
            this.BranchIDLabel.AutoSize = true;
            this.BranchIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchIDLabel.Location = new System.Drawing.Point(709, 38);
            this.BranchIDLabel.Name = "BranchIDLabel";
            this.BranchIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BranchIDLabel.Size = new System.Drawing.Size(94, 20);
            this.BranchIDLabel.TabIndex = 12;
            this.BranchIDLabel.Text = "BranchID:";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(516, 38);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(115, 20);
            this.CustomerIDLabel.TabIndex = 11;
            this.CustomerIDLabel.Text = "CustomerID:";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDLabel.Location = new System.Drawing.Point(323, 38);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(82, 20);
            this.OrderIDLabel.TabIndex = 10;
            this.OrderIDLabel.Text = "OrderID:";
            // 
            // StatusListbox
            // 
            this.StatusListbox.Enabled = false;
            this.StatusListbox.FormattingEnabled = true;
            this.StatusListbox.ItemHeight = 16;
            this.StatusListbox.Location = new System.Drawing.Point(1099, 62);
            this.StatusListbox.Name = "StatusListbox";
            this.StatusListbox.Size = new System.Drawing.Size(193, 516);
            this.StatusListbox.TabIndex = 9;
            // 
            // TimestampListbox
            // 
            this.TimestampListbox.Enabled = false;
            this.TimestampListbox.FormattingEnabled = true;
            this.TimestampListbox.ItemHeight = 16;
            this.TimestampListbox.Location = new System.Drawing.Point(906, 62);
            this.TimestampListbox.Name = "TimestampListbox";
            this.TimestampListbox.Size = new System.Drawing.Size(193, 516);
            this.TimestampListbox.TabIndex = 8;
            // 
            // BranchIDListbox
            // 
            this.BranchIDListbox.Enabled = false;
            this.BranchIDListbox.FormattingEnabled = true;
            this.BranchIDListbox.ItemHeight = 16;
            this.BranchIDListbox.Location = new System.Drawing.Point(713, 62);
            this.BranchIDListbox.Name = "BranchIDListbox";
            this.BranchIDListbox.Size = new System.Drawing.Size(193, 516);
            this.BranchIDListbox.TabIndex = 7;
            // 
            // CustomerIDListbox
            // 
            this.CustomerIDListbox.Enabled = false;
            this.CustomerIDListbox.FormattingEnabled = true;
            this.CustomerIDListbox.ItemHeight = 16;
            this.CustomerIDListbox.Location = new System.Drawing.Point(520, 62);
            this.CustomerIDListbox.Name = "CustomerIDListbox";
            this.CustomerIDListbox.Size = new System.Drawing.Size(193, 516);
            this.CustomerIDListbox.TabIndex = 6;
            // 
            // CancelStatusButton
            // 
            this.CancelStatusButton.Enabled = false;
            this.CancelStatusButton.Location = new System.Drawing.Point(27, 422);
            this.CancelStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelStatusButton.Name = "CancelStatusButton";
            this.CancelStatusButton.Size = new System.Drawing.Size(252, 50);
            this.CancelStatusButton.TabIndex = 5;
            this.CancelStatusButton.Text = "CANCEL";
            this.CancelStatusButton.UseVisualStyleBackColor = true;
            this.CancelStatusButton.Click += new System.EventHandler(this.CancelStatusButton_Click);
            // 
            // OrderIDListbox
            // 
            this.OrderIDListbox.FormattingEnabled = true;
            this.OrderIDListbox.ItemHeight = 16;
            this.OrderIDListbox.Location = new System.Drawing.Point(327, 62);
            this.OrderIDListbox.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIDListbox.Name = "OrderIDListbox";
            this.OrderIDListbox.Size = new System.Drawing.Size(193, 516);
            this.OrderIDListbox.TabIndex = 4;
            this.OrderIDListbox.SelectedIndexChanged += new System.EventHandler(this.OrderIDListbox_SelectedIndexChanged);
            // 
            // RefundStatusButton
            // 
            this.RefundStatusButton.Enabled = false;
            this.RefundStatusButton.Location = new System.Drawing.Point(27, 496);
            this.RefundStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefundStatusButton.Name = "RefundStatusButton";
            this.RefundStatusButton.Size = new System.Drawing.Size(252, 52);
            this.RefundStatusButton.TabIndex = 3;
            this.RefundStatusButton.Text = "REFUND";
            this.RefundStatusButton.UseVisualStyleBackColor = true;
            this.RefundStatusButton.Click += new System.EventHandler(this.RefundStatusButton_Click);
            // 
            // PaidStatusButton
            // 
            this.PaidStatusButton.Enabled = false;
            this.PaidStatusButton.Location = new System.Drawing.Point(27, 351);
            this.PaidStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.PaidStatusButton.Name = "PaidStatusButton";
            this.PaidStatusButton.Size = new System.Drawing.Size(252, 50);
            this.PaidStatusButton.TabIndex = 1;
            this.PaidStatusButton.Text = "PAID";
            this.PaidStatusButton.UseVisualStyleBackColor = true;
            this.PaidStatusButton.Click += new System.EventHandler(this.PaidStatusButton_Click);
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.Location = new System.Drawing.Point(27, 30);
            this.SearchCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(252, 178);
            this.SearchCustomerButton.TabIndex = 0;
            this.SearchCustomerButton.Text = "Search For Customer";
            this.SearchCustomerButton.UseVisualStyleBackColor = true;
            this.SearchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.s);
            this.InventoryTab.Controls.Add(this.InventoryPriceLabel);
            this.InventoryTab.Controls.Add(this.InventoryNameLabel);
            this.InventoryTab.Controls.Add(this.InventoryCountListbox);
            this.InventoryTab.Controls.Add(this.InventoryPriceListBox);
            this.InventoryTab.Controls.Add(this.InventoryNameListbox);
            this.InventoryTab.Controls.Add(this.UpdateInventoryButton);
            this.InventoryTab.Location = new System.Drawing.Point(4, 25);
            this.InventoryTab.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Size = new System.Drawing.Size(1341, 602);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(978, 29);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(62, 20);
            this.s.TabIndex = 7;
            this.s.Text = "Stock:";
            // 
            // InventoryPriceLabel
            // 
            this.InventoryPriceLabel.AutoSize = true;
            this.InventoryPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryPriceLabel.Location = new System.Drawing.Point(658, 29);
            this.InventoryPriceLabel.Name = "InventoryPriceLabel";
            this.InventoryPriceLabel.Size = new System.Drawing.Size(140, 20);
            this.InventoryPriceLabel.TabIndex = 6;
            this.InventoryPriceLabel.Text = " Per Unit Price:";
            // 
            // InventoryNameLabel
            // 
            this.InventoryNameLabel.AutoSize = true;
            this.InventoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryNameLabel.Location = new System.Drawing.Point(339, 30);
            this.InventoryNameLabel.Name = "InventoryNameLabel";
            this.InventoryNameLabel.Size = new System.Drawing.Size(134, 20);
            this.InventoryNameLabel.TabIndex = 5;
            this.InventoryNameLabel.Text = "Product Name:";
            // 
            // InventoryCountListbox
            // 
            this.InventoryCountListbox.Enabled = false;
            this.InventoryCountListbox.FormattingEnabled = true;
            this.InventoryCountListbox.ItemHeight = 16;
            this.InventoryCountListbox.Location = new System.Drawing.Point(977, 62);
            this.InventoryCountListbox.Name = "InventoryCountListbox";
            this.InventoryCountListbox.Size = new System.Drawing.Size(315, 516);
            this.InventoryCountListbox.TabIndex = 4;
            // 
            // InventoryPriceListBox
            // 
            this.InventoryPriceListBox.Enabled = false;
            this.InventoryPriceListBox.FormattingEnabled = true;
            this.InventoryPriceListBox.ItemHeight = 16;
            this.InventoryPriceListBox.Location = new System.Drawing.Point(663, 62);
            this.InventoryPriceListBox.Name = "InventoryPriceListBox";
            this.InventoryPriceListBox.Size = new System.Drawing.Size(314, 516);
            this.InventoryPriceListBox.TabIndex = 3;
            // 
            // InventoryNameListbox
            // 
            this.InventoryNameListbox.Enabled = false;
            this.InventoryNameListbox.FormattingEnabled = true;
            this.InventoryNameListbox.ItemHeight = 16;
            this.InventoryNameListbox.Location = new System.Drawing.Point(337, 62);
            this.InventoryNameListbox.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryNameListbox.Name = "InventoryNameListbox";
            this.InventoryNameListbox.Size = new System.Drawing.Size(326, 516);
            this.InventoryNameListbox.TabIndex = 2;
            // 
            // UpdateInventoryButton
            // 
            this.UpdateInventoryButton.Location = new System.Drawing.Point(27, 30);
            this.UpdateInventoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateInventoryButton.Name = "UpdateInventoryButton";
            this.UpdateInventoryButton.Size = new System.Drawing.Size(252, 178);
            this.UpdateInventoryButton.TabIndex = 1;
            this.UpdateInventoryButton.Text = "Update Inventory Stock";
            this.UpdateInventoryButton.UseVisualStyleBackColor = true;
            this.UpdateInventoryButton.Click += new System.EventHandler(this.UpdateInventoryButton_Click);
            // 
            // PoS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 661);
            this.Controls.Add(this.PoSTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoS";
            this.Text = "jmWally PoS";
            this.PoSTabControl.ResumeLayout(false);
            this.SalesRecordTab.ResumeLayout(false);
            this.SalesRecordTab.PerformLayout();
            this.SearchRecordTab.ResumeLayout(false);
            this.SearchRecordTab.PerformLayout();
            this.InventoryTab.ResumeLayout(false);
            this.InventoryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PoSTabControl;
        private System.Windows.Forms.TabPage SalesRecordTab;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label CurrentCustomerLabel;
        private System.Windows.Forms.ComboBox ProductCombobox;
        private System.Windows.Forms.ListBox ProductNameListbox;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Button ExistingCustomer;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.TabPage SearchRecordTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TextBox CustomerNameTextbox;
        private System.Windows.Forms.ListBox OrderIDListbox;
        private System.Windows.Forms.Button RefundStatusButton;
        private System.Windows.Forms.Button PaidStatusButton;
        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.ListBox InventoryNameListbox;
        private System.Windows.Forms.Button UpdateInventoryButton;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SaleTotalValueLabel;
        private System.Windows.Forms.Label HSTValueLabel;
        private System.Windows.Forms.Label SubtotalValueLabel;
        private System.Windows.Forms.Label SalesTotalLabel;
        private System.Windows.Forms.Label HSTLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Button ConfirmQuantityButton;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.ListBox CollectivePriceListbox;
        private System.Windows.Forms.Label PricePerUnitLabel;
        private System.Windows.Forms.Label ProductQuantityLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.ListBox PricePerUnitListbox;
        private System.Windows.Forms.ListBox QuantityListbox;
        private System.Windows.Forms.Label CollectivePriceLabel;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label InventoryPriceLabel;
        private System.Windows.Forms.Label InventoryNameLabel;
        private System.Windows.Forms.ListBox InventoryCountListbox;
        private System.Windows.Forms.ListBox InventoryPriceListBox;
        private System.Windows.Forms.Button CancelStatusButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TimeStampLabel;
        private System.Windows.Forms.Label BranchIDLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.ListBox StatusListbox;
        private System.Windows.Forms.ListBox TimestampListbox;
        private System.Windows.Forms.ListBox BranchIDListbox;
        private System.Windows.Forms.ListBox CustomerIDListbox;
    }
}

