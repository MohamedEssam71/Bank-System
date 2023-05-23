namespace BankSystemGUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            customerPanelLabel = new Label();
            backToMainLabel = new Label();
            requestLoanButton = new Button();
            showLoanButton = new Button();
            pictureBox1 = new PictureBox();
            profilePicCustomerLabel = new Label();
            addAccountButton = new Button();
            showAccountButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customerPanelLabel
            // 
            customerPanelLabel.AutoSize = true;
            customerPanelLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            customerPanelLabel.ForeColor = SystemColors.Highlight;
            customerPanelLabel.Location = new Point(12, 68);
            customerPanelLabel.Name = "customerPanelLabel";
            customerPanelLabel.Size = new Size(389, 57);
            customerPanelLabel.TabIndex = 0;
            customerPanelLabel.Text = "Customer Panel";
            // 
            // backToMainLabel
            // 
            backToMainLabel.AutoSize = true;
            backToMainLabel.Cursor = Cursors.Hand;
            backToMainLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToMainLabel.Location = new Point(23, 24);
            backToMainLabel.Name = "backToMainLabel";
            backToMainLabel.Size = new Size(78, 24);
            backToMainLabel.TabIndex = 1;
            backToMainLabel.Text = "Main Page";
            backToMainLabel.Click += backToMainLabel_Click;
            // 
            // requestLoanButton
            // 
            requestLoanButton.BackColor = SystemColors.Control;
            requestLoanButton.Cursor = Cursors.Hand;
            requestLoanButton.FlatAppearance.BorderColor = Color.Black;
            requestLoanButton.FlatAppearance.BorderSize = 2;
            requestLoanButton.FlatStyle = FlatStyle.Flat;
            requestLoanButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            requestLoanButton.Location = new Point(40, 151);
            requestLoanButton.Name = "requestLoanButton";
            requestLoanButton.Size = new Size(132, 117);
            requestLoanButton.TabIndex = 2;
            requestLoanButton.Text = "Request Loan";
            requestLoanButton.UseVisualStyleBackColor = false;
            requestLoanButton.Click += requestLoanButton_Click;
            // 
            // showLoanButton
            // 
            showLoanButton.BackColor = SystemColors.Control;
            showLoanButton.Cursor = Cursors.Hand;
            showLoanButton.FlatAppearance.BorderColor = Color.Black;
            showLoanButton.FlatAppearance.BorderSize = 2;
            showLoanButton.FlatStyle = FlatStyle.Flat;
            showLoanButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showLoanButton.Location = new Point(236, 151);
            showLoanButton.Name = "showLoanButton";
            showLoanButton.Size = new Size(132, 117);
            showLoanButton.TabIndex = 3;
            showLoanButton.Text = "Show Loan";
            showLoanButton.UseVisualStyleBackColor = false;
            showLoanButton.Click += showLoanButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // profilePicCustomerLabel
            // 
            profilePicCustomerLabel.AutoSize = true;
            profilePicCustomerLabel.Cursor = Cursors.Hand;
            profilePicCustomerLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profilePicCustomerLabel.Location = new Point(107, 24);
            profilePicCustomerLabel.Name = "profilePicCustomerLabel";
            profilePicCustomerLabel.Size = new Size(84, 24);
            profilePicCustomerLabel.TabIndex = 5;
            profilePicCustomerLabel.Text = "Profile Info";
            profilePicCustomerLabel.Click += profilePicCustomerLabel_Click;
            // 
            // addAccountButton
            // 
            addAccountButton.BackColor = SystemColors.Control;
            addAccountButton.Cursor = Cursors.Hand;
            addAccountButton.FlatAppearance.BorderColor = Color.Black;
            addAccountButton.FlatAppearance.BorderSize = 2;
            addAccountButton.FlatStyle = FlatStyle.Flat;
            addAccountButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addAccountButton.Location = new Point(40, 292);
            addAccountButton.Name = "addAccountButton";
            addAccountButton.Size = new Size(132, 117);
            addAccountButton.TabIndex = 6;
            addAccountButton.Text = "Add Account";
            addAccountButton.UseVisualStyleBackColor = false;
            addAccountButton.Click += addAccountButton_Click;
            // 
            // showAccountButton
            // 
            showAccountButton.BackColor = SystemColors.Control;
            showAccountButton.Cursor = Cursors.Hand;
            showAccountButton.FlatAppearance.BorderColor = Color.Black;
            showAccountButton.FlatAppearance.BorderSize = 2;
            showAccountButton.FlatStyle = FlatStyle.Flat;
            showAccountButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showAccountButton.Location = new Point(236, 292);
            showAccountButton.Name = "showAccountButton";
            showAccountButton.Size = new Size(132, 117);
            showAccountButton.TabIndex = 7;
            showAccountButton.Text = "Show Accounts";
            showAccountButton.UseVisualStyleBackColor = false;
            showAccountButton.Click += showAccountButton_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 431);
            Controls.Add(showAccountButton);
            Controls.Add(addAccountButton);
            Controls.Add(profilePicCustomerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(showLoanButton);
            Controls.Add(requestLoanButton);
            Controls.Add(backToMainLabel);
            Controls.Add(customerPanelLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerPanelLabel;
        private Label backToMainLabel;
        private Button requestLoanButton;
        private Button showLoanButton;
        private PictureBox pictureBox1;
        private Label profilePicCustomerLabel;
        private Button addAccountButton;
        private Button showAccountButton;
    }
}