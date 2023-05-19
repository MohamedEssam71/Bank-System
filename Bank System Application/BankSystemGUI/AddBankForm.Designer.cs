namespace BankSystemGUI
{
    partial class AddBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBankForm));
            AddBankFormLabel = new Label();
            bankNameLabel = new Label();
            addressBankLabel = new Label();
            nameBankPanel = new Panel();
            addressBankPanel = new Panel();
            nameBankTextBox = new TextBox();
            addressBankTextBox = new TextBox();
            addBankConfirmButton = new Button();
            backToAdminLabel = new Label();
            SuspendLayout();
            // 
            // AddBankFormLabel
            // 
            AddBankFormLabel.AutoSize = true;
            AddBankFormLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            AddBankFormLabel.ForeColor = SystemColors.Highlight;
            AddBankFormLabel.Location = new Point(109, 44);
            AddBankFormLabel.Name = "AddBankFormLabel";
            AddBankFormLabel.Size = new Size(246, 57);
            AddBankFormLabel.TabIndex = 0;
            AddBankFormLabel.Text = "Add Bank";
            // 
            // bankNameLabel
            // 
            bankNameLabel.AutoSize = true;
            bankNameLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bankNameLabel.ForeColor = Color.Peru;
            bankNameLabel.Location = new Point(53, 142);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new Size(68, 24);
            bankNameLabel.TabIndex = 2;
            bankNameLabel.Text = "Name:";
            // 
            // addressBankLabel
            // 
            addressBankLabel.AutoSize = true;
            addressBankLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBankLabel.ForeColor = Color.Peru;
            addressBankLabel.Location = new Point(53, 221);
            addressBankLabel.Name = "addressBankLabel";
            addressBankLabel.Size = new Size(90, 24);
            addressBankLabel.TabIndex = 3;
            addressBankLabel.Text = "Address:";
            // 
            // nameBankPanel
            // 
            nameBankPanel.BackColor = Color.Black;
            nameBankPanel.Location = new Point(62, 169);
            nameBankPanel.Name = "nameBankPanel";
            nameBankPanel.Size = new Size(326, 1);
            nameBankPanel.TabIndex = 4;
            // 
            // addressBankPanel
            // 
            addressBankPanel.BackColor = Color.Black;
            addressBankPanel.Location = new Point(62, 248);
            addressBankPanel.Name = "addressBankPanel";
            addressBankPanel.Size = new Size(326, 1);
            addressBankPanel.TabIndex = 5;
            // 
            // nameBankTextBox
            // 
            nameBankTextBox.BackColor = SystemColors.Window;
            nameBankTextBox.BorderStyle = BorderStyle.None;
            nameBankTextBox.Cursor = Cursors.IBeam;
            nameBankTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameBankTextBox.Location = new Point(127, 142);
            nameBankTextBox.Name = "nameBankTextBox";
            nameBankTextBox.Size = new Size(261, 25);
            nameBankTextBox.TabIndex = 0;
            // 
            // addressBankTextBox
            // 
            addressBankTextBox.BackColor = SystemColors.Window;
            addressBankTextBox.BorderStyle = BorderStyle.None;
            addressBankTextBox.Cursor = Cursors.IBeam;
            addressBankTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBankTextBox.Location = new Point(149, 220);
            addressBankTextBox.Name = "addressBankTextBox";
            addressBankTextBox.Size = new Size(239, 25);
            addressBankTextBox.TabIndex = 7;
            // 
            // addBankConfirmButton
            // 
            addBankConfirmButton.Cursor = Cursors.Hand;
            addBankConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBankConfirmButton.ForeColor = SystemColors.WindowText;
            addBankConfirmButton.Location = new Point(109, 327);
            addBankConfirmButton.Name = "addBankConfirmButton";
            addBankConfirmButton.Size = new Size(193, 43);
            addBankConfirmButton.TabIndex = 8;
            addBankConfirmButton.Text = "Add Bank";
            addBankConfirmButton.UseVisualStyleBackColor = true;
            addBankConfirmButton.Click += addBankConfirmButton_Click;
            // 
            // backToAdminLabel
            // 
            backToAdminLabel.AutoSize = true;
            backToAdminLabel.Cursor = Cursors.Hand;
            backToAdminLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backToAdminLabel.Location = new Point(129, 383);
            backToAdminLabel.Name = "backToAdminLabel";
            backToAdminLabel.Size = new Size(147, 24);
            backToAdminLabel.TabIndex = 9;
            backToAdminLabel.Text = "Back to Admin Panel";
            backToAdminLabel.Click += backToAdminLabel_Click;
            // 
            // AddBankForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(433, 457);
            Controls.Add(backToAdminLabel);
            Controls.Add(addBankConfirmButton);
            Controls.Add(addressBankTextBox);
            Controls.Add(nameBankTextBox);
            Controls.Add(addressBankPanel);
            Controls.Add(nameBankPanel);
            Controls.Add(addressBankLabel);
            Controls.Add(bankNameLabel);
            Controls.Add(AddBankFormLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBankForm";
            Text = "AddBankForm";
            Load += AddBankForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddBankFormLabel;
        private Label bankNameLabel;
        private Label addressBankLabel;
        private Panel nameBankPanel;
        private Panel addressBankPanel;
        private TextBox nameBankTextBox;
        private TextBox addressBankTextBox;
        private Button addBankConfirmButton;
        private Label backToAdminLabel;
    }
}