namespace BankSystemGUI
{
    partial class AddAccountCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountCustomer));
            addAccountLabel = new Label();
            backToCustomerPanelLabel = new Label();
            amountAccountLabel = new Label();
            balanceAccountTextBox = new TextBox();
            amountAccountPanel = new Panel();
            typeAccountComboBox = new ComboBox();
            typeAccountLabel = new Label();
            requestConfirmButton = new Button();
            SuspendLayout();
            // 
            // addAccountLabel
            // 
            addAccountLabel.AutoSize = true;
            addAccountLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            addAccountLabel.ForeColor = SystemColors.Highlight;
            addAccountLabel.Location = new Point(47, 27);
            addAccountLabel.Name = "addAccountLabel";
            addAccountLabel.Size = new Size(322, 57);
            addAccountLabel.TabIndex = 0;
            addAccountLabel.Text = "Add Account";
            // 
            // backToCustomerPanelLabel
            // 
            backToCustomerPanelLabel.AutoSize = true;
            backToCustomerPanelLabel.Cursor = Cursors.Hand;
            backToCustomerPanelLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToCustomerPanelLabel.Location = new Point(112, 392);
            backToCustomerPanelLabel.Name = "backToCustomerPanelLabel";
            backToCustomerPanelLabel.Size = new Size(168, 24);
            backToCustomerPanelLabel.TabIndex = 1;
            backToCustomerPanelLabel.Text = "Back to Customer Panel";
            backToCustomerPanelLabel.Click += backToCustomerPanelLabel_Click;
            // 
            // amountAccountLabel
            // 
            amountAccountLabel.AutoSize = true;
            amountAccountLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountAccountLabel.ForeColor = Color.Peru;
            amountAccountLabel.Location = new Point(61, 245);
            amountAccountLabel.Name = "amountAccountLabel";
            amountAccountLabel.Size = new Size(88, 24);
            amountAccountLabel.TabIndex = 2;
            amountAccountLabel.Text = "Balance:";
            // 
            // balanceAccountTextBox
            // 
            balanceAccountTextBox.BorderStyle = BorderStyle.None;
            balanceAccountTextBox.Cursor = Cursors.IBeam;
            balanceAccountTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            balanceAccountTextBox.Location = new Point(152, 244);
            balanceAccountTextBox.Name = "balanceAccountTextBox";
            balanceAccountTextBox.Size = new Size(181, 25);
            balanceAccountTextBox.TabIndex = 3;
            // 
            // amountAccountPanel
            // 
            amountAccountPanel.BackColor = Color.Black;
            amountAccountPanel.Location = new Point(61, 272);
            amountAccountPanel.Name = "amountAccountPanel";
            amountAccountPanel.Size = new Size(272, 1);
            amountAccountPanel.TabIndex = 4;
            // 
            // typeAccountComboBox
            // 
            typeAccountComboBox.BackColor = SystemColors.Control;
            typeAccountComboBox.Cursor = Cursors.Hand;
            typeAccountComboBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            typeAccountComboBox.FormattingEnabled = true;
            typeAccountComboBox.Location = new Point(118, 156);
            typeAccountComboBox.Name = "typeAccountComboBox";
            typeAccountComboBox.Size = new Size(215, 30);
            typeAccountComboBox.TabIndex = 5;
            typeAccountComboBox.SelectedIndexChanged += typeLoanComboBox_SelectedIndexChanged;
            // 
            // typeAccountLabel
            // 
            typeAccountLabel.AutoSize = true;
            typeAccountLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeAccountLabel.ForeColor = Color.Peru;
            typeAccountLabel.Location = new Point(61, 156);
            typeAccountLabel.Name = "typeAccountLabel";
            typeAccountLabel.Size = new Size(51, 24);
            typeAccountLabel.TabIndex = 6;
            typeAccountLabel.Text = "Type";
            // 
            // requestConfirmButton
            // 
            requestConfirmButton.Cursor = Cursors.Hand;
            requestConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            requestConfirmButton.Location = new Point(100, 334);
            requestConfirmButton.Name = "requestConfirmButton";
            requestConfirmButton.Size = new Size(193, 43);
            requestConfirmButton.TabIndex = 7;
            requestConfirmButton.Text = "Add Account";
            requestConfirmButton.UseVisualStyleBackColor = true;
            requestConfirmButton.Click += requestConfirmButton_Click;
            // 
            // AddAccountCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(412, 450);
            Controls.Add(requestConfirmButton);
            Controls.Add(typeAccountLabel);
            Controls.Add(typeAccountComboBox);
            Controls.Add(amountAccountPanel);
            Controls.Add(balanceAccountTextBox);
            Controls.Add(amountAccountLabel);
            Controls.Add(backToCustomerPanelLabel);
            Controls.Add(addAccountLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAccountCustomer";
            Text = "Add Account";
            Load += AddAccountCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addAccountLabel;
        private Label backToCustomerPanelLabel;
        private Label amountAccountLabel;
        private TextBox balanceAccountTextBox;
        private Panel amountAccountPanel;
        private ComboBox typeAccountComboBox;
        private Label typeAccountLabel;
        private Button requestConfirmButton;
    }
}