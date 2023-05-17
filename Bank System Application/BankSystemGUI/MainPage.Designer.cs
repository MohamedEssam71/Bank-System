namespace BankSystemGUI
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            BankSystemTitle = new Label();
            registerButton = new Button();
            loginButton = new Button();
            welcomePictureBox = new PictureBox();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).BeginInit();
            SuspendLayout();
            // 
            // BankSystemTitle
            // 
            BankSystemTitle.AutoSize = true;
            BankSystemTitle.BackColor = SystemColors.ButtonHighlight;
            BankSystemTitle.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            BankSystemTitle.ForeColor = SystemColors.Highlight;
            BankSystemTitle.Location = new Point(253, 30);
            BankSystemTitle.Name = "BankSystemTitle";
            BankSystemTitle.Size = new Size(311, 57);
            BankSystemTitle.TabIndex = 0;
            BankSystemTitle.Text = "Bank System";
            BankSystemTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.Menu;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            registerButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.Location = new Point(167, 218);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(141, 56);
            registerButton.TabIndex = 1;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.Menu;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            loginButton.FlatAppearance.BorderSize = 2;
            loginButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(167, 130);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(141, 56);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // welcomePictureBox
            // 
            welcomePictureBox.BackColor = SystemColors.HighlightText;
            welcomePictureBox.BackgroundImage = (Image)resources.GetObject("welcomePictureBox.BackgroundImage");
            welcomePictureBox.Image = (Image)resources.GetObject("welcomePictureBox.Image");
            welcomePictureBox.Location = new Point(418, 115);
            welcomePictureBox.Name = "welcomePictureBox";
            welcomePictureBox.Size = new Size(305, 286);
            welcomePictureBox.TabIndex = 3;
            welcomePictureBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.Menu;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            exitButton.FlatAppearance.BorderSize = 2;
            exitButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(167, 302);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(141, 56);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(welcomePictureBox);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(BankSystemTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = "BankSystem";
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label BankSystemTitle;
        private Button registerButton;
        private Button loginButton;
        private PictureBox welcomePictureBox;
        private Button exitButton;
    }
}