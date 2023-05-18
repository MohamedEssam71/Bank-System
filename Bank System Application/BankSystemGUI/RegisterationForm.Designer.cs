namespace BankSystemGUI
{
    partial class RegisterationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterationForm));
            registerLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            typeLabel = new Label();
            typeDropDownList = new ComboBox();
            registrationPictureBox = new PictureBox();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            ssnTextBox = new TextBox();
            ssnLabel = new Label();
            signConfirmButton = new Button();
            goBackToMainButton = new Button();
            ((System.ComponentModel.ISupportInitialize)registrationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = SystemColors.Highlight;
            registerLabel.Location = new Point(217, 23);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(353, 45);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "Registration Page";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(95, 98);
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
            usernameTextBox.Location = new Point(207, 99);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(167, 29);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.OldLace;
            passwordTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(207, 202);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(164, 29);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(92, 202);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 24);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeLabel.Location = new Point(92, 367);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(51, 24);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Type";
            // 
            // typeDropDownList
            // 
            typeDropDownList.BackColor = Color.OldLace;
            typeDropDownList.Cursor = Cursors.Hand;
            typeDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            typeDropDownList.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            typeDropDownList.FormattingEnabled = true;
            typeDropDownList.Items.AddRange(new object[] { "Customer", "Employee", "Admin" });
            typeDropDownList.Location = new Point(207, 371);
            typeDropDownList.Name = "typeDropDownList";
            typeDropDownList.Size = new Size(164, 30);
            typeDropDownList.TabIndex = 6;
            // 
            // registrationPictureBox
            // 
            registrationPictureBox.BackColor = Color.White;
            registrationPictureBox.BackgroundImage = (Image)resources.GetObject("registrationPictureBox.BackgroundImage");
            registrationPictureBox.Image = (Image)resources.GetObject("registrationPictureBox.Image");
            registrationPictureBox.Location = new Point(420, 98);
            registrationPictureBox.Name = "registrationPictureBox";
            registrationPictureBox.Size = new Size(304, 289);
            registrationPictureBox.TabIndex = 7;
            registrationPictureBox.TabStop = false;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.OldLace;
            phoneTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(207, 259);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(164, 29);
            phoneTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.Location = new Point(92, 258);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(66, 24);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone";
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = Color.OldLace;
            addressTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(207, 316);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(164, 29);
            addressTextBox.TabIndex = 11;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(92, 312);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(85, 24);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address";
            // 
            // ssnTextBox
            // 
            ssnTextBox.BackColor = Color.OldLace;
            ssnTextBox.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ssnTextBox.Location = new Point(207, 151);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(164, 29);
            ssnTextBox.TabIndex = 13;
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ssnLabel.Location = new Point(95, 152);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(48, 24);
            ssnLabel.TabIndex = 12;
            ssnLabel.Text = "SSN";
            // 
            // signConfirmButton
            // 
            signConfirmButton.Cursor = Cursors.Hand;
            signConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signConfirmButton.Location = new Point(457, 411);
            signConfirmButton.Name = "signConfirmButton";
            signConfirmButton.Size = new Size(113, 40);
            signConfirmButton.TabIndex = 14;
            signConfirmButton.Text = "Sign in";
            signConfirmButton.UseVisualStyleBackColor = true;
            signConfirmButton.Click += signConfirmButton_Click;
            // 
            // goBackToMainButton
            // 
            goBackToMainButton.Cursor = Cursors.Hand;
            goBackToMainButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            goBackToMainButton.Location = new Point(601, 411);
            goBackToMainButton.Name = "goBackToMainButton";
            goBackToMainButton.Size = new Size(113, 40);
            goBackToMainButton.TabIndex = 15;
            goBackToMainButton.Text = "Go Back";
            goBackToMainButton.UseVisualStyleBackColor = true;
            goBackToMainButton.Click += goBackToMainButton_Click;
            // 
            // RegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(766, 474);
            Controls.Add(goBackToMainButton);
            Controls.Add(signConfirmButton);
            Controls.Add(ssnTextBox);
            Controls.Add(ssnLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(registrationPictureBox);
            Controls.Add(typeDropDownList);
            Controls.Add(typeLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(registerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterationForm";
            Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)registrationPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label registerLabel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label typeLabel;
        private ComboBox typeDropDownList;
        private PictureBox registrationPictureBox;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox ssnTextBox;
        private Label ssnLabel;
        private Button signConfirmButton;
        private Button goBackToMainButton;
    }
}