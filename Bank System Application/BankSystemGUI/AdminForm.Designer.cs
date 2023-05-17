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
            SuspendLayout();
            // 
            // adminPanelLabel
            // 
            adminPanelLabel.AutoSize = true;
            adminPanelLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            adminPanelLabel.ForeColor = SystemColors.Highlight;
            adminPanelLabel.Location = new Point(141, 25);
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
            addBankButton.Location = new Point(98, 197);
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
            addBranchButton.Location = new Point(364, 197);
            addBranchButton.Name = "addBranchButton";
            addBranchButton.Size = new Size(132, 117);
            addBranchButton.TabIndex = 2;
            addBranchButton.Text = "Add Bank Branch";
            addBranchButton.UseVisualStyleBackColor = false;
            // 
            // mainPageLabel
            // 
            mainPageLabel.AutoSize = true;
            mainPageLabel.Cursor = Cursors.Hand;
            mainPageLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mainPageLabel.Location = new Point(22, 25);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(78, 24);
            mainPageLabel.TabIndex = 3;
            mainPageLabel.Text = "Main Page";
            mainPageLabel.Click += mainPageLabel_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(593, 450);
            Controls.Add(mainPageLabel);
            Controls.Add(addBranchButton);
            Controls.Add(addBankButton);
            Controls.Add(adminPanelLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Admin Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminPanelLabel;
        private Button addBankButton;
        private Button addBranchButton;
        private Label mainPageLabel;
    }
}