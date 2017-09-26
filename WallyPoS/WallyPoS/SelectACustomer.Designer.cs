namespace WallyPoS
{
    partial class SelectACustomer
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
            this.CustomerChoiceListbox = new System.Windows.Forms.ListBox();
            this.ConfirmCustomerButton = new System.Windows.Forms.Button();
            this.CancelCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerChoiceListbox
            // 
            this.CustomerChoiceListbox.FormattingEnabled = true;
            this.CustomerChoiceListbox.ItemHeight = 16;
            this.CustomerChoiceListbox.Location = new System.Drawing.Point(14, 28);
            this.CustomerChoiceListbox.Name = "CustomerChoiceListbox";
            this.CustomerChoiceListbox.Size = new System.Drawing.Size(450, 308);
            this.CustomerChoiceListbox.TabIndex = 0;
            // 
            // ConfirmCustomerButton
            // 
            this.ConfirmCustomerButton.Location = new System.Drawing.Point(12, 358);
            this.ConfirmCustomerButton.Name = "ConfirmCustomerButton";
            this.ConfirmCustomerButton.Size = new System.Drawing.Size(211, 108);
            this.ConfirmCustomerButton.TabIndex = 1;
            this.ConfirmCustomerButton.Text = "Confirm";
            this.ConfirmCustomerButton.UseVisualStyleBackColor = true;
            this.ConfirmCustomerButton.Click += new System.EventHandler(this.ConfirmCustomerButton_Click);
            // 
            // CancelCustomerButton
            // 
            this.CancelCustomerButton.Location = new System.Drawing.Point(253, 358);
            this.CancelCustomerButton.Name = "CancelCustomerButton";
            this.CancelCustomerButton.Size = new System.Drawing.Size(211, 108);
            this.CancelCustomerButton.TabIndex = 2;
            this.CancelCustomerButton.Text = "Cancel";
            this.CancelCustomerButton.UseVisualStyleBackColor = true;
            this.CancelCustomerButton.Click += new System.EventHandler(this.CancelCustomerButton_Click);
            // 
            // SelectACustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 482);
            this.Controls.Add(this.CancelCustomerButton);
            this.Controls.Add(this.ConfirmCustomerButton);
            this.Controls.Add(this.CustomerChoiceListbox);
            this.Name = "SelectACustomer";
            this.Text = "SelectACustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerChoiceListbox;
        private System.Windows.Forms.Button ConfirmCustomerButton;
        private System.Windows.Forms.Button CancelCustomerButton;
    }
}