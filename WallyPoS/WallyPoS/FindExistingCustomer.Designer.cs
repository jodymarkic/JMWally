namespace WallyPoS
{
    partial class FindExistingCustomer
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(13, 36);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(251, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Enter a Customer Lastname:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(53, 77);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(205, 20);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "Enter a Phone Number:";
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerButton.Location = new System.Drawing.Point(195, 155);
            this.SearchCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(241, 142);
            this.SearchCustomerButton.TabIndex = 4;
            this.SearchCustomerButton.Text = "Search for Customer";
            this.SearchCustomerButton.UseVisualStyleBackColor = true;
            this.SearchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(276, 36);
            this.LastNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(299, 22);
            this.LastNameTextbox.TabIndex = 5;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(276, 75);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberTextBox.MaxLength = 10;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(299, 22);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // FindExistingCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 350);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.SearchCustomerButton);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindExistingCustomer";
            this.Text = "FindExistingCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
    }
}