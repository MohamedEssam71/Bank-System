﻿namespace BankSystemGUI
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
            reportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).BeginInit();
            SuspendLayout();
            // 
            // BankSystemTitle
            // 
            BankSystemTitle.AutoSize = true;
            BankSystemTitle.BackColor = SystemColors.ButtonHighlight;
            BankSystemTitle.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            BankSystemTitle.ForeColor = SystemColors.Highlight;
            BankSystemTitle.Location = new Point(47, 33);
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
            registerButton.Location = new Point(89, 192);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(211, 56);
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
            loginButton.Location = new Point(89, 115);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(211, 56);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // welcomePictureBox
            // 
            welcomePictureBox.BackColor = SystemColors.Window;
            welcomePictureBox.Dock = DockStyle.Right;
            welcomePictureBox.Image = (Image)resources.GetObject("welcomePictureBox.Image");
            welcomePictureBox.Location = new Point(393, 0);
            welcomePictureBox.Name = "welcomePictureBox";
            welcomePictureBox.Size = new Size(360, 438);
            welcomePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
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
            exitButton.Location = new Point(89, 353);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(211, 56);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // reportButton
            // 
            reportButton.BackColor = SystemColors.Menu;
            reportButton.Cursor = Cursors.Hand;
            reportButton.FlatAppearance.BorderColor = SystemColors.Highlight;
            reportButton.FlatAppearance.BorderSize = 2;
            reportButton.FlatAppearance.MouseOverBackColor = SystemColors.Info;
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportButton.Location = new Point(89, 274);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(211, 56);
            reportButton.TabIndex = 5;
            reportButton.Text = "Generate Report";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(753, 438);
            Controls.Add(reportButton);
            Controls.Add(exitButton);
            Controls.Add(welcomePictureBox);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(BankSystemTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button reportButton;
    }
}