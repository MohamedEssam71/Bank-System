namespace BankSystemGUI
{
    partial class RequestLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestLoan));
            requestLoanLabel = new Label();
            backToCustomerPanelLabel = new Label();
            amountLoanLabel = new Label();
            amountLoanTextBox = new TextBox();
            amountLoanPanel = new Panel();
            typeLoanComboBox = new ComboBox();
            typeLoanLabel = new Label();
            requestConfirmButton = new Button();
            SuspendLayout();
            // 
            // requestLoanLabel
            // 
            requestLoanLabel.AutoSize = true;
            requestLoanLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            requestLoanLabel.ForeColor = SystemColors.Highlight;
            requestLoanLabel.Location = new Point(47, 27);
            requestLoanLabel.Name = "requestLoanLabel";
            requestLoanLabel.Size = new Size(328, 57);
            requestLoanLabel.TabIndex = 0;
            requestLoanLabel.Text = "Request Loan";
            // 
            // backToCustomerPanelLabel
            // 
            backToCustomerPanelLabel.AutoSize = true;
            backToCustomerPanelLabel.Cursor = Cursors.Hand;
            backToCustomerPanelLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToCustomerPanelLabel.Location = new Point(119, 393);
            backToCustomerPanelLabel.Name = "backToCustomerPanelLabel";
            backToCustomerPanelLabel.Size = new Size(168, 24);
            backToCustomerPanelLabel.TabIndex = 1;
            backToCustomerPanelLabel.Text = "Back to Customer Panel";
            backToCustomerPanelLabel.Click += backToCustomerPanelLabel_Click;
            // 
            // amountLoanLabel
            // 
            amountLoanLabel.AutoSize = true;
            amountLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountLoanLabel.ForeColor = Color.Peru;
            amountLoanLabel.Location = new Point(62, 262);
            amountLoanLabel.Name = "amountLoanLabel";
            amountLoanLabel.Size = new Size(85, 24);
            amountLoanLabel.TabIndex = 2;
            amountLoanLabel.Text = "Amount:";
            // 
            // amountLoanTextBox
            // 
            amountLoanTextBox.BorderStyle = BorderStyle.None;
            amountLoanTextBox.Cursor = Cursors.IBeam;
            amountLoanTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amountLoanTextBox.Location = new Point(153, 261);
            amountLoanTextBox.Name = "amountLoanTextBox";
            amountLoanTextBox.Size = new Size(181, 25);
            amountLoanTextBox.TabIndex = 3;
            // 
            // amountLoanPanel
            // 
            amountLoanPanel.BackColor = Color.Black;
            amountLoanPanel.Location = new Point(62, 289);
            amountLoanPanel.Name = "amountLoanPanel";
            amountLoanPanel.Size = new Size(272, 1);
            amountLoanPanel.TabIndex = 4;
            // 
            // typeLoanComboBox
            // 
            typeLoanComboBox.BackColor = SystemColors.Control;
            typeLoanComboBox.Cursor = Cursors.Hand;
            typeLoanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeLoanComboBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            typeLoanComboBox.FormattingEnabled = true;
            typeLoanComboBox.Location = new Point(119, 173);
            typeLoanComboBox.Name = "typeLoanComboBox";
            typeLoanComboBox.Size = new Size(215, 30);
            typeLoanComboBox.TabIndex = 5;
            typeLoanComboBox.SelectedIndexChanged += typeLoanComboBox_SelectedIndexChanged;
            // 
            // typeLoanLabel
            // 
            typeLoanLabel.AutoSize = true;
            typeLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeLoanLabel.ForeColor = Color.Peru;
            typeLoanLabel.Location = new Point(62, 173);
            typeLoanLabel.Name = "typeLoanLabel";
            typeLoanLabel.Size = new Size(51, 24);
            typeLoanLabel.TabIndex = 6;
            typeLoanLabel.Text = "Type";
            // 
            // requestConfirmButton
            // 
            requestConfirmButton.Cursor = Cursors.Hand;
            requestConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            requestConfirmButton.Location = new Point(107, 335);
            requestConfirmButton.Name = "requestConfirmButton";
            requestConfirmButton.Size = new Size(193, 43);
            requestConfirmButton.TabIndex = 7;
            requestConfirmButton.Text = "Send Request";
            requestConfirmButton.UseVisualStyleBackColor = true;
            requestConfirmButton.Click += requestConfirmButton_Click;
            // 
            // RequestLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(412, 450);
            Controls.Add(requestConfirmButton);
            Controls.Add(typeLoanLabel);
            Controls.Add(typeLoanComboBox);
            Controls.Add(amountLoanPanel);
            Controls.Add(amountLoanTextBox);
            Controls.Add(amountLoanLabel);
            Controls.Add(backToCustomerPanelLabel);
            Controls.Add(requestLoanLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RequestLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RequestLoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label requestLoanLabel;
        private Label backToCustomerPanelLabel;
        private Label amountLoanLabel;
        private TextBox amountLoanTextBox;
        private Panel amountLoanPanel;
        private ComboBox typeLoanComboBox;
        private Label typeLoanLabel;
        private Button requestConfirmButton;
    }
}