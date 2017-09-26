namespace WallyPoS
{
    partial class AddNewCustomer
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddCustomerDataButton = new System.Windows.Forms.Button();
            this.EnterFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterLastNameTextbox = new System.Windows.Forms.TextBox();
            this.EnterPhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(51, 30);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(175, 20);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Enter a First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(52, 70);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(173, 20);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Enter a Last Name:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(16, 113);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(205, 20);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Enter a Phone Number:";
            // 
            // AddCustomerDataButton
            // 
            this.AddCustomerDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerDataButton.Location = new System.Drawing.Point(192, 169);
            this.AddCustomerDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCustomerDataButton.Name = "AddCustomerDataButton";
            this.AddCustomerDataButton.Size = new System.Drawing.Size(241, 142);
            this.AddCustomerDataButton.TabIndex = 3;
            this.AddCustomerDataButton.Text = "Submit Customer Data";
            this.AddCustomerDataButton.UseVisualStyleBackColor = true;
            this.AddCustomerDataButton.Click += new System.EventHandler(this.AddCustomerDataButton_Click);
            // 
            // EnterFirstNameTextBox
            // 
            this.EnterFirstNameTextBox.Location = new System.Drawing.Point(245, 28);
            this.EnterFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterFirstNameTextBox.MaxLength = 50;
            this.EnterFirstNameTextBox.Name = "EnterFirstNameTextBox";
            this.EnterFirstNameTextBox.Size = new System.Drawing.Size(371, 22);
            this.EnterFirstNameTextBox.TabIndex = 4;
            // 
            // EnterLastNameTextbox
            // 
            this.EnterLastNameTextbox.Location = new System.Drawing.Point(245, 65);
            this.EnterLastNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterLastNameTextbox.MaxLength = 50;
            this.EnterLastNameTextbox.Name = "EnterLastNameTextbox";
            this.EnterLastNameTextbox.Size = new System.Drawing.Size(371, 22);
            this.EnterLastNameTextbox.TabIndex = 5;

            // 
            // EnterPhoneNumberTextbox
            // 
            this.EnterPhoneNumberTextbox.Location = new System.Drawing.Point(245, 112);
            this.EnterPhoneNumberTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterPhoneNumberTextbox.MaxLength = 10;
            this.EnterPhoneNumberTextbox.Name = "EnterPhoneNumberTextbox";
            this.EnterPhoneNumberTextbox.Size = new System.Drawing.Size(371, 22);
            this.EnterPhoneNumberTextbox.TabIndex = 6;
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 350);
            this.Controls.Add(this.EnterPhoneNumberTextbox);
            this.Controls.Add(this.EnterLastNameTextbox);
            this.Controls.Add(this.EnterFirstNameTextBox);
            this.Controls.Add(this.AddCustomerDataButton);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCustomer";
            this.Text = "AddNewCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button AddCustomerDataButton;
        private System.Windows.Forms.TextBox EnterFirstNameTextBox;
        private System.Windows.Forms.TextBox EnterLastNameTextbox;
        private System.Windows.Forms.TextBox EnterPhoneNumberTextbox;
    }
}