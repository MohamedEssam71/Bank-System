namespace BankSystemGUI
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            label1 = new Label();
            CustomerListFlowControlPanel = new FlowLayoutPanel();
            addCustomer = new Button();
            customerNameLabel = new Label();
            customerNameTextBox = new TextBox();
            customerNamePanel = new Panel();
            customerSsnPanel = new Panel();
            customerSsnTextBox = new TextBox();
            customerSsnLabel = new Label();
            customerPhonePanel = new Panel();
            customerPhoneTextBox = new TextBox();
            customerPhoneLabel = new Label();
            customerAddressPanel = new Panel();
            customerAdderssTextBox = new TextBox();
            customerAddressLabel = new Label();
            backToAdminLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 57);
            label1.TabIndex = 0;
            label1.Text = "Customer List";
            // 
            // CustomerListFlowControlPanel
            // 
            CustomerListFlowControlPanel.AutoScroll = true;
            CustomerListFlowControlPanel.BackColor = SystemColors.Control;
            CustomerListFlowControlPanel.Location = new Point(370, 0);
            CustomerListFlowControlPanel.Name = "CustomerListFlowControlPanel";
            CustomerListFlowControlPanel.Size = new Size(725, 488);
            CustomerListFlowControlPanel.TabIndex = 1;
            // 
            // addCustomer
            // 
            addCustomer.Cursor = Cursors.Hand;
            addCustomer.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addCustomer.Location = new Point(83, 393);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(193, 43);
            addCustomer.TabIndex = 2;
            addCustomer.Text = "Add Customer";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerNameLabel.ForeColor = Color.Peru;
            customerNameLabel.Location = new Point(36, 116);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(68, 24);
            customerNameLabel.TabIndex = 3;
            customerNameLabel.Text = "Name:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.BorderStyle = BorderStyle.None;
            customerNameTextBox.Cursor = Cursors.IBeam;
            customerNameTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTextBox.Location = new Point(108, 117);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(227, 25);
            customerNameTextBox.TabIndex = 4;
            // 
            // customerNamePanel
            // 
            customerNamePanel.BackColor = Color.Black;
            customerNamePanel.ForeColor = Color.Black;
            customerNamePanel.Location = new Point(36, 143);
            customerNamePanel.Name = "customerNamePanel";
            customerNamePanel.Size = new Size(302, 1);
            customerNamePanel.TabIndex = 5;
            // 
            // customerSsnPanel
            // 
            customerSsnPanel.BackColor = Color.Black;
            customerSsnPanel.ForeColor = Color.Black;
            customerSsnPanel.Location = new Point(36, 208);
            customerSsnPanel.Name = "customerSsnPanel";
            customerSsnPanel.Size = new Size(302, 1);
            customerSsnPanel.TabIndex = 8;
            // 
            // customerSsnTextBox
            // 
            customerSsnTextBox.BorderStyle = BorderStyle.None;
            customerSsnTextBox.Cursor = Cursors.IBeam;
            customerSsnTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerSsnTextBox.Location = new Point(108, 182);
            customerSsnTextBox.Name = "customerSsnTextBox";
            customerSsnTextBox.Size = new Size(227, 25);
            customerSsnTextBox.TabIndex = 7;
            // 
            // customerSsnLabel
            // 
            customerSsnLabel.AutoSize = true;
            customerSsnLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerSsnLabel.ForeColor = Color.Peru;
            customerSsnLabel.Location = new Point(36, 181);
            customerSsnLabel.Name = "customerSsnLabel";
            customerSsnLabel.Size = new Size(53, 24);
            customerSsnLabel.TabIndex = 6;
            customerSsnLabel.Text = "SSN:";
            // 
            // customerPhonePanel
            // 
            customerPhonePanel.BackColor = Color.Black;
            customerPhonePanel.ForeColor = Color.Black;
            customerPhonePanel.Location = new Point(36, 272);
            customerPhonePanel.Name = "customerPhonePanel";
            customerPhonePanel.Size = new Size(302, 1);
            customerPhonePanel.TabIndex = 11;
            // 
            // customerPhoneTextBox
            // 
            customerPhoneTextBox.BorderStyle = BorderStyle.None;
            customerPhoneTextBox.Cursor = Cursors.IBeam;
            customerPhoneTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerPhoneTextBox.Location = new Point(108, 246);
            customerPhoneTextBox.Name = "customerPhoneTextBox";
            customerPhoneTextBox.Size = new Size(227, 25);
            customerPhoneTextBox.TabIndex = 10;
            // 
            // customerPhoneLabel
            // 
            customerPhoneLabel.AutoSize = true;
            customerPhoneLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerPhoneLabel.ForeColor = Color.Peru;
            customerPhoneLabel.Location = new Point(36, 245);
            customerPhoneLabel.Name = "customerPhoneLabel";
            customerPhoneLabel.Size = new Size(71, 24);
            customerPhoneLabel.TabIndex = 9;
            customerPhoneLabel.Text = "Phone:";
            // 
            // customerAddressPanel
            // 
            customerAddressPanel.BackColor = Color.Black;
            customerAddressPanel.ForeColor = Color.Black;
            customerAddressPanel.Location = new Point(36, 337);
            customerAddressPanel.Name = "customerAddressPanel";
            customerAddressPanel.Size = new Size(302, 1);
            customerAddressPanel.TabIndex = 14;
            // 
            // customerAdderssTextBox
            // 
            customerAdderssTextBox.BorderStyle = BorderStyle.None;
            customerAdderssTextBox.Cursor = Cursors.IBeam;
            customerAdderssTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerAdderssTextBox.Location = new Point(132, 311);
            customerAdderssTextBox.Name = "customerAdderssTextBox";
            customerAdderssTextBox.Size = new Size(203, 25);
            customerAdderssTextBox.TabIndex = 13;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerAddressLabel.ForeColor = Color.Peru;
            customerAddressLabel.Location = new Point(36, 310);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(90, 24);
            customerAddressLabel.TabIndex = 12;
            customerAddressLabel.Text = "Address:";
            // 
            // backToAdminLabel
            // 
            backToAdminLabel.AutoSize = true;
            backToAdminLabel.Cursor = Cursors.Hand;
            backToAdminLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backToAdminLabel.Location = new Point(107, 451);
            backToAdminLabel.Name = "backToAdminLabel";
            backToAdminLabel.Size = new Size(147, 24);
            backToAdminLabel.TabIndex = 15;
            backToAdminLabel.Text = "Back to Admin Panel";
            backToAdminLabel.Click += backToAdminLabel_Click;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1095, 488);
            Controls.Add(backToAdminLabel);
            Controls.Add(customerAddressPanel);
            Controls.Add(customerAdderssTextBox);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerPhonePanel);
            Controls.Add(customerPhoneTextBox);
            Controls.Add(customerPhoneLabel);
            Controls.Add(customerSsnPanel);
            Controls.Add(customerSsnTextBox);
            Controls.Add(customerSsnLabel);
            Controls.Add(customerNamePanel);
            Controls.Add(customerNameTextBox);
            Controls.Add(customerNameLabel);
            Controls.Add(addCustomer);
            Controls.Add(CustomerListFlowControlPanel);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerList";
            Load += CustomerList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel CustomerListFlowControlPanel;
        private Button addCustomer;
        private Label customerNameLabel;
        private TextBox customerNameTextBox;
        private Panel customerNamePanel;
        private Panel customerSsnPanel;
        private TextBox customerSsnTextBox;
        private Label customerSsnLabel;
        private Panel customerPhonePanel;
        private TextBox customerPhoneTextBox;
        private Label customerPhoneLabel;
        private Panel customerAddressPanel;
        private TextBox customerAdderssTextBox;
        private Label customerAddressLabel;
        private Label backToAdminLabel;
    }
}