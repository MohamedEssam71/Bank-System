namespace BankSystemGUI
{
    partial class ShowLoansAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLoansAdmin));
            showLoansLabel = new Label();
            backToAdminLabel = new Label();
            adminLoansFlowControl = new FlowLayoutPanel();
            adminLoansPictureBox = new PictureBox();
            numberLoanLabel = new Label();
            adminNumberLoanPanel = new Panel();
            adminNumberLoanTextBox = new TextBox();
            stateLoanComboBox = new ComboBox();
            employeeStateLoanPanel = new Panel();
            stateLoanLabel = new Label();
            confirmStateLoanButton = new Button();
            reloadLabel = new Label();
            ssnTextBox = new TextBox();
            ssnPanel = new Panel();
            ssnLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)adminLoansPictureBox).BeginInit();
            SuspendLayout();
            // 
            // showLoansLabel
            // 
            showLoansLabel.AutoSize = true;
            showLoansLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            showLoansLabel.ForeColor = SystemColors.Highlight;
            showLoansLabel.Location = new Point(30, 64);
            showLoansLabel.Name = "showLoansLabel";
            showLoansLabel.Size = new Size(282, 57);
            showLoansLabel.TabIndex = 0;
            showLoansLabel.Text = "Show Loans";
            // 
            // backToAdminLabel
            // 
            backToAdminLabel.AutoSize = true;
            backToAdminLabel.Cursor = Cursors.Hand;
            backToAdminLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToAdminLabel.Location = new Point(12, 27);
            backToAdminLabel.Name = "backToAdminLabel";
            backToAdminLabel.Size = new Size(147, 24);
            backToAdminLabel.TabIndex = 1;
            backToAdminLabel.Text = "Back to Admin Panel";
            backToAdminLabel.Click += backToEmployeeLabel_Click;
            // 
            // adminLoansFlowControl
            // 
            adminLoansFlowControl.AutoScroll = true;
            adminLoansFlowControl.BackColor = SystemColors.Control;
            adminLoansFlowControl.Dock = DockStyle.Right;
            adminLoansFlowControl.Location = new Point(341, 0);
            adminLoansFlowControl.Name = "adminLoansFlowControl";
            adminLoansFlowControl.Size = new Size(592, 450);
            adminLoansFlowControl.TabIndex = 2;
            adminLoansFlowControl.Paint += employeeLoansFlowControl_Paint;
            // 
            // adminLoansPictureBox
            // 
            adminLoansPictureBox.Image = (Image)resources.GetObject("adminLoansPictureBox.Image");
            adminLoansPictureBox.Location = new Point(109, 124);
            adminLoansPictureBox.Name = "adminLoansPictureBox";
            adminLoansPictureBox.Size = new Size(125, 62);
            adminLoansPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            adminLoansPictureBox.TabIndex = 3;
            adminLoansPictureBox.TabStop = false;
            // 
            // numberLoanLabel
            // 
            numberLoanLabel.AutoSize = true;
            numberLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numberLoanLabel.ForeColor = Color.Peru;
            numberLoanLabel.Location = new Point(30, 204);
            numberLoanLabel.Name = "numberLoanLabel";
            numberLoanLabel.Size = new Size(87, 24);
            numberLoanLabel.TabIndex = 4;
            numberLoanLabel.Text = "Number:";
            // 
            // adminNumberLoanPanel
            // 
            adminNumberLoanPanel.BackColor = Color.Black;
            adminNumberLoanPanel.Location = new Point(32, 231);
            adminNumberLoanPanel.Name = "adminNumberLoanPanel";
            adminNumberLoanPanel.Size = new Size(280, 1);
            adminNumberLoanPanel.TabIndex = 5;
            // 
            // adminNumberLoanTextBox
            // 
            adminNumberLoanTextBox.BorderStyle = BorderStyle.None;
            adminNumberLoanTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminNumberLoanTextBox.Location = new Point(123, 204);
            adminNumberLoanTextBox.Name = "adminNumberLoanTextBox";
            adminNumberLoanTextBox.Size = new Size(189, 25);
            adminNumberLoanTextBox.TabIndex = 6;
            // 
            // stateLoanComboBox
            // 
            stateLoanComboBox.BackColor = SystemColors.Control;
            stateLoanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateLoanComboBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stateLoanComboBox.FormattingEnabled = true;
            stateLoanComboBox.Items.AddRange(new object[] { "Accept", "Reject", "Delete" });
            stateLoanComboBox.Location = new Point(109, 296);
            stateLoanComboBox.Name = "stateLoanComboBox";
            stateLoanComboBox.Size = new Size(203, 32);
            stateLoanComboBox.TabIndex = 7;
            stateLoanComboBox.SelectedIndexChanged += employeeStateLoanComboBox_SelectedIndexChanged;
            // 
            // employeeStateLoanPanel
            // 
            employeeStateLoanPanel.BackColor = Color.Black;
            employeeStateLoanPanel.Location = new Point(32, 327);
            employeeStateLoanPanel.Name = "employeeStateLoanPanel";
            employeeStateLoanPanel.Size = new Size(280, 1);
            employeeStateLoanPanel.TabIndex = 9;
            // 
            // stateLoanLabel
            // 
            stateLoanLabel.AutoSize = true;
            stateLoanLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stateLoanLabel.ForeColor = Color.Peru;
            stateLoanLabel.Location = new Point(30, 300);
            stateLoanLabel.Name = "stateLoanLabel";
            stateLoanLabel.Size = new Size(73, 24);
            stateLoanLabel.TabIndex = 8;
            stateLoanLabel.Text = "Status:";
            // 
            // confirmStateLoanButton
            // 
            confirmStateLoanButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmStateLoanButton.Location = new Point(70, 372);
            confirmStateLoanButton.Name = "confirmStateLoanButton";
            confirmStateLoanButton.Size = new Size(193, 43);
            confirmStateLoanButton.TabIndex = 10;
            confirmStateLoanButton.Text = "Confirm Operation";
            confirmStateLoanButton.UseVisualStyleBackColor = true;
            confirmStateLoanButton.Click += confirmStateLoanButton_Click;
            // 
            // reloadLabel
            // 
            reloadLabel.AutoSize = true;
            reloadLabel.Cursor = Cursors.Hand;
            reloadLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadLabel.Location = new Point(214, 27);
            reloadLabel.Name = "reloadLabel";
            reloadLabel.Size = new Size(98, 24);
            reloadLabel.TabIndex = 11;
            reloadLabel.Text = "Reload Loans";
            reloadLabel.Click += reloadLabel_Click;
            // 
            // ssnTextBox
            // 
            ssnTextBox.BorderStyle = BorderStyle.None;
            ssnTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ssnTextBox.Location = new Point(123, 254);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(189, 25);
            ssnTextBox.TabIndex = 14;
            // 
            // ssnPanel
            // 
            ssnPanel.BackColor = Color.Black;
            ssnPanel.Location = new Point(32, 281);
            ssnPanel.Name = "ssnPanel";
            ssnPanel.Size = new Size(280, 1);
            ssnPanel.TabIndex = 13;
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ssnLabel.ForeColor = Color.Peru;
            ssnLabel.Location = new Point(30, 254);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(53, 24);
            ssnLabel.TabIndex = 12;
            ssnLabel.Text = "SSN:";
            // 
            // ShowLoansAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(933, 450);
            Controls.Add(ssnTextBox);
            Controls.Add(ssnPanel);
            Controls.Add(ssnLabel);
            Controls.Add(reloadLabel);
            Controls.Add(confirmStateLoanButton);
            Controls.Add(employeeStateLoanPanel);
            Controls.Add(stateLoanLabel);
            Controls.Add(stateLoanComboBox);
            Controls.Add(adminNumberLoanTextBox);
            Controls.Add(adminNumberLoanPanel);
            Controls.Add(numberLoanLabel);
            Controls.Add(adminLoansPictureBox);
            Controls.Add(adminLoansFlowControl);
            Controls.Add(backToAdminLabel);
            Controls.Add(showLoansLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowLoansAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Loans Admin";
            Load += ShowLoansAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)adminLoansPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLoansLabel;
        private Label backToAdminLabel;
        private FlowLayoutPanel adminLoansFlowControl;
        private PictureBox adminLoansPictureBox;
        private Label numberLoanLabel;
        private Panel adminNumberLoanPanel;
        private TextBox adminNumberLoanTextBox;
        private ComboBox stateLoanComboBox;
        private Panel employeeStateLoanPanel;
        private Label stateLoanLabel;
        private Button confirmStateLoanButton;
        private Label reloadLabel;
        private TextBox ssnTextBox;
        private Panel ssnPanel;
        private Label ssnLabel;
    }
}