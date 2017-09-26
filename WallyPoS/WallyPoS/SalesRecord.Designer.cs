namespace WallyPoS
{
    partial class SalesRecord
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
            this.SalesRecordListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SalesRecordListbox
            // 
            this.SalesRecordListbox.Enabled = false;
            this.SalesRecordListbox.FormattingEnabled = true;
            this.SalesRecordListbox.ItemHeight = 16;
            this.SalesRecordListbox.Location = new System.Drawing.Point(12, 14);
            this.SalesRecordListbox.Name = "SalesRecordListbox";
            this.SalesRecordListbox.Size = new System.Drawing.Size(470, 468);
            this.SalesRecordListbox.TabIndex = 0;
            // 
            // SalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 498);
            this.Controls.Add(this.SalesRecordListbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesRecord";
            this.Text = "SalesRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SalesRecordListbox;
    }
}