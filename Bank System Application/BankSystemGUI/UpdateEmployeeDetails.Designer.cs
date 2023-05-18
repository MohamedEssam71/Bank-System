namespace BankSystemGUI
{
    partial class UpdateEmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeDetails));
            profileLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            updateEmployeeDetailsBox = new PictureBox();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            ssnTextBox = new TextBox();
            ssnLabel = new Label();
            updateConfirmButton = new Button();
            goBackToEmployeeButton = new Button();
            bankNumLabel = new Label();
            bankNumComboBox = new ComboBox();
            branchNumComboBox = new ComboBox();
            branchNumLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)updateEmployeeDetailsBox).BeginInit();
            SuspendLayout();
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            profileLabel.ForeColor = SystemColors.Highlight;
            profileLabel.Location = new Point(12, 25);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(346, 45);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "Employee Profile ";
            profileLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(32, 94);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(103, 24);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.OldLace;
            usernameTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(144, 95);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(167, 29);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.OldLace;
            passwordTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(144, 198);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(164, 29);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(29, 198);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 24);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // updateEmployeeDetailsBox
            // 
            updateEmployeeDetailsBox.BackColor = Color.White;
            updateEmployeeDetailsBox.Dock = DockStyle.Right;
            updateEmployeeDetailsBox.Image = (Image)resources.GetObject("updateEmployeeDetailsBox.Image");
            updateEmployeeDetailsBox.Location = new Point(386, 0);
            updateEmployeeDetailsBox.Name = "updateEmployeeDetailsBox";
            updateEmployeeDetailsBox.Size = new Size(370, 538);
            updateEmployeeDetailsBox.SizeMode = PictureBoxSizeMode.Zoom;
            updateEmployeeDetailsBox.TabIndex = 7;
            updateEmployeeDetailsBox.TabStop = false;
            updateEmployeeDetailsBox.Click += registrationPictureBox_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.OldLace;
            phoneTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(144, 255);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(164, 29);
            phoneTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(29, 254);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(66, 24);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone";
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.OldLace;
            addressTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(144, 312);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(164, 29);
            addressTextBox.TabIndex = 11;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(29, 308);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(85, 24);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address";
            // 
            // ssnTextBox
            // 
            ssnTextBox.BackColor = Color.OldLace;
            ssnTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ssnTextBox.Location = new Point(144, 147);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(164, 29);
            ssnTextBox.TabIndex = 13;
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ssnLabel.Location = new Point(32, 148);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(48, 24);
            ssnLabel.TabIndex = 12;
            ssnLabel.Text = "SSN";
            // 
            // updateConfirmButton
            // 
            updateConfirmButton.Cursor = Cursors.Hand;
            updateConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateConfirmButton.Location = new Point(32, 486);
            updateConfirmButton.Name = "updateConfirmButton";
            updateConfirmButton.Size = new Size(113, 40);
            updateConfirmButton.TabIndex = 14;
            updateConfirmButton.Text = "Save Info";
            updateConfirmButton.UseVisualStyleBackColor = true;
            updateConfirmButton.Click += updateConfirmButton_Click;
            // 
            // goBackToEmployeeButton
            // 
            goBackToEmployeeButton.Cursor = Cursors.Hand;
            goBackToEmployeeButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            goBackToEmployeeButton.Location = new Point(198, 486);
            goBackToEmployeeButton.Name = "goBackToEmployeeButton";
            goBackToEmployeeButton.Size = new Size(113, 40);
            goBackToEmployeeButton.TabIndex = 15;
            goBackToEmployeeButton.Text = "Go Back";
            goBackToEmployeeButton.UseVisualStyleBackColor = true;
            goBackToEmployeeButton.Click += goBackToMainButton_Click;
            // 
            // bankNumLabel
            // 
            bankNumLabel.AutoSize = true;
            bankNumLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bankNumLabel.Location = new Point(29, 367);
            bankNumLabel.Name = "bankNumLabel";
            bankNumLabel.Size = new Size(98, 24);
            bankNumLabel.TabIndex = 16;
            bankNumLabel.Text = "BankNum";
            // 
            // bankNumComboBox
            // 
            bankNumComboBox.BackColor = Color.OldLace;
            bankNumComboBox.Cursor = Cursors.Hand;
            bankNumComboBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bankNumComboBox.FormattingEnabled = true;
            bankNumComboBox.Location = new Point(144, 363);
            bankNumComboBox.Name = "bankNumComboBox";
            bankNumComboBox.Size = new Size(164, 30);
            bankNumComboBox.TabIndex = 17;
            bankNumComboBox.SelectedIndexChanged += bankNumComboBox_SelectedIndexChanged;
            // 
            // branchNumComboBox
            // 
            branchNumComboBox.BackColor = Color.OldLace;
            branchNumComboBox.Cursor = Cursors.Hand;
            branchNumComboBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            branchNumComboBox.FormattingEnabled = true;
            branchNumComboBox.Location = new Point(145, 419);
            branchNumComboBox.Name = "branchNumComboBox";
            branchNumComboBox.Size = new Size(164, 30);
            branchNumComboBox.TabIndex = 19;
            // 
            // branchNumLabel
            // 
            branchNumLabel.AutoSize = true;
            branchNumLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            branchNumLabel.Location = new Point(30, 423);
            branchNumLabel.Name = "branchNumLabel";
            branchNumLabel.Size = new Size(117, 24);
            branchNumLabel.TabIndex = 18;
            branchNumLabel.Text = "BranchNum";
            // 
            // UpdateEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(756, 538);
            Controls.Add(branchNumComboBox);
            Controls.Add(branchNumLabel);
            Controls.Add(bankNumComboBox);
            Controls.Add(bankNumLabel);
            Controls.Add(goBackToEmployeeButton);
            Controls.Add(updateConfirmButton);
            Controls.Add(ssnTextBox);
            Controls.Add(ssnLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(updateEmployeeDetailsBox);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(profileLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateEmployeeDetails";
            Text = "Profile Page";
            Load += UpdateCustomerDetails_Load;
            ((System.ComponentModel.ISupportInitialize)updateEmployeeDetailsBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label profileLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private PictureBox updateEmployeeDetailsBox;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox ssnTextBox;
        private Label ssnLabel;
        private Button updateConfirmButton;
        private Button goBackToEmployeeButton;
        private Label bankNumLabel;
        private ComboBox bankNumComboBox;
        private ComboBox branchNumComboBox;
        private Label branchNumLabel;
    }
}