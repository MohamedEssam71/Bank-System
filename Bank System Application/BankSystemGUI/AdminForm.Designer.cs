namespace BankSystemGUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            adminPanelLabel = new Label();
            addBankButton = new Button();
            addBranchButton = new Button();
            mainPageLabel = new Label();
            showCustomerListButton = new Button();
            showLoansListButton = new Button();
            adminPictureBox = new PictureBox();
            profileInfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).BeginInit();
            SuspendLayout();
            // 
            // adminPanelLabel
            // 
            adminPanelLabel.AutoSize = true;
            adminPanelLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            adminPanelLabel.ForeColor = SystemColors.Highlight;
            adminPanelLabel.Location = new Point(40, 70);
            adminPanelLabel.Name = "adminPanelLabel";
            adminPanelLabel.Size = new Size(315, 57);
            adminPanelLabel.TabIndex = 0;
            adminPanelLabel.Text = "Admin Panel";
            // 
            // addBankButton
            // 
            addBankButton.BackColor = SystemColors.Control;
            addBankButton.Cursor = Cursors.Hand;
            addBankButton.FlatAppearance.BorderColor = Color.Black;
            addBankButton.FlatAppearance.BorderSize = 2;
            addBankButton.FlatStyle = FlatStyle.Flat;
            addBankButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addBankButton.Location = new Point(40, 151);
            addBankButton.Name = "addBankButton";
            addBankButton.Size = new Size(132, 117);
            addBankButton.TabIndex = 1;
            addBankButton.Text = "Add Bank";
            addBankButton.UseVisualStyleBackColor = false;
            addBankButton.Click += addBankButton_Click;
            // 
            // addBranchButton
            // 
            addBranchButton.BackColor = SystemColors.Control;
            addBranchButton.Cursor = Cursors.Hand;
            addBranchButton.FlatAppearance.BorderColor = Color.Black;
            addBranchButton.FlatAppearance.BorderSize = 2;
            addBranchButton.FlatStyle = FlatStyle.Flat;
            addBranchButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addBranchButton.Location = new Point(236, 151);
            addBranchButton.Name = "addBranchButton";
            addBranchButton.Size = new Size(132, 117);
            addBranchButton.TabIndex = 2;
            addBranchButton.Text = "Add Bank Branch";
            addBranchButton.UseVisualStyleBackColor = false;
            addBranchButton.Click += addBranchButton_Click;
            // 
            // mainPageLabel
            // 
            mainPageLabel.AutoSize = true;
            mainPageLabel.Cursor = Cursors.Hand;
            mainPageLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mainPageLabel.Location = new Point(23, 24);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(78, 24);
            mainPageLabel.TabIndex = 3;
            mainPageLabel.Text = "Main Page";
            mainPageLabel.Click += mainPageLabel_Click;
            // 
            // showCustomerListButton
            // 
            showCustomerListButton.BackColor = SystemColors.Control;
            showCustomerListButton.Cursor = Cursors.Hand;
            showCustomerListButton.FlatAppearance.BorderColor = Color.Black;
            showCustomerListButton.FlatAppearance.BorderSize = 2;
            showCustomerListButton.FlatStyle = FlatStyle.Flat;
            showCustomerListButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showCustomerListButton.Location = new Point(40, 292);
            showCustomerListButton.Name = "showCustomerListButton";
            showCustomerListButton.Size = new Size(132, 117);
            showCustomerListButton.TabIndex = 4;
            showCustomerListButton.Text = "Customer List";
            showCustomerListButton.UseVisualStyleBackColor = false;
            showCustomerListButton.Click += showCustomerListButton_Click;
            // 
            // showLoansListButton
            // 
            showLoansListButton.BackColor = SystemColors.Control;
            showLoansListButton.Cursor = Cursors.Hand;
            showLoansListButton.FlatAppearance.BorderColor = Color.Black;
            showLoansListButton.FlatAppearance.BorderSize = 2;
            showLoansListButton.FlatStyle = FlatStyle.Flat;
            showLoansListButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showLoansListButton.Location = new Point(236, 292);
            showLoansListButton.Name = "showLoansListButton";
            showLoansListButton.Size = new Size(132, 117);
            showLoansListButton.TabIndex = 5;
            showLoansListButton.Text = "Loans List";
            showLoansListButton.UseVisualStyleBackColor = false;
            showLoansListButton.Click += showLoansListButton_Click;
            // 
            // adminPictureBox
            // 
            adminPictureBox.Dock = DockStyle.Right;
            adminPictureBox.Image = (Image)resources.GetObject("adminPictureBox.Image");
            adminPictureBox.Location = new Point(417, 0);
            adminPictureBox.Name = "adminPictureBox";
            adminPictureBox.Size = new Size(383, 431);
            adminPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            adminPictureBox.TabIndex = 6;
            adminPictureBox.TabStop = false;
            // 
            // profileInfoLabel
            // 
            profileInfoLabel.AutoSize = true;
            profileInfoLabel.Cursor = Cursors.Hand;
            profileInfoLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profileInfoLabel.Location = new Point(107, 24);
            profileInfoLabel.Name = "profileInfoLabel";
            profileInfoLabel.Size = new Size(84, 24);
            profileInfoLabel.TabIndex = 7;
            profileInfoLabel.Text = "Profile Info";
            profileInfoLabel.Click += profileInfoLabel_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 431);
            Controls.Add(profileInfoLabel);
            Controls.Add(adminPictureBox);
            Controls.Add(showLoansListButton);
            Controls.Add(showCustomerListButton);
            Controls.Add(mainPageLabel);
            Controls.Add(addBranchButton);
            Controls.Add(addBankButton);
            Controls.Add(adminPanelLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminPanelLabel;
        private Button addBankButton;
        private Button addBranchButton;
        private Label mainPageLabel;
        private Button showCustomerListButton;
        private Button showLoansListButton;
        private PictureBox adminPictureBox;
        private Label profileInfoLabel;
    }
}