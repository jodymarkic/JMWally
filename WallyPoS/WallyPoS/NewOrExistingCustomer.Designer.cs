namespace WallyPoS
{
    partial class NewOrExistingCustomer
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
            this.CustomerChoiceLabel = new System.Windows.Forms.Label();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.ExistingCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerChoiceLabel
            // 
            this.CustomerChoiceLabel.AutoSize = true;
            this.CustomerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerChoiceLabel.Location = new System.Drawing.Point(57, 58);
            this.CustomerChoiceLabel.Name = "CustomerChoiceLabel";
            this.CustomerChoiceLabel.Size = new System.Drawing.Size(442, 25);
            this.CustomerChoiceLabel.TabIndex = 0;
            this.CustomerChoiceLabel.Text = "Please Choose a New Or Existing Customer.";
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(71, 111);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(193, 99);
            this.NewCustomerButton.TabIndex = 1;
            this.NewCustomerButton.Text = "New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // ExistingCustomerButton
            // 
            this.ExistingCustomerButton.Location = new System.Drawing.Point(289, 111);
            this.ExistingCustomerButton.Name = "ExistingCustomerButton";
            this.ExistingCustomerButton.Size = new System.Drawing.Size(193, 99);
            this.ExistingCustomerButton.TabIndex = 2;
            this.ExistingCustomerButton.Text = "Existing Customer";
            this.ExistingCustomerButton.UseVisualStyleBackColor = true;
            this.ExistingCustomerButton.Click += new System.EventHandler(this.ExistingCustomerButton_Click);
            // 
            // NewOrExistingCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 264);
            this.Controls.Add(this.ExistingCustomerButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.CustomerChoiceLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrExistingCustomer";
            this.Text = "NewOrExistingCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerChoiceLabel;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button ExistingCustomerButton;
    }
}