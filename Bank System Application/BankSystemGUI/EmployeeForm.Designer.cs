namespace BankSystemGUI
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            employeeFormLabel = new Label();
            backToMainLabel = new Label();
            employeePanelPictureBox = new PictureBox();
            showLoansEmployeeButton = new Button();
            showCustomerListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)employeePanelPictureBox).BeginInit();
            SuspendLayout();
            // 
            // employeeFormLabel
            // 
            employeeFormLabel.AutoSize = true;
            employeeFormLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            employeeFormLabel.ForeColor = SystemColors.Highlight;
            employeeFormLabel.Location = new Point(16, 75);
            employeeFormLabel.Name = "employeeFormLabel";
            employeeFormLabel.Size = new Size(395, 57);
            employeeFormLabel.TabIndex = 0;
            employeeFormLabel.Text = "Employee Panel";
            // 
            // backToMainLabel
            // 
            backToMainLabel.AutoSize = true;
            backToMainLabel.Cursor = Cursors.Hand;
            backToMainLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToMainLabel.ForeColor = SystemColors.ControlText;
            backToMainLabel.Location = new Point(23, 24);
            backToMainLabel.Name = "backToMainLabel";
            backToMainLabel.Size = new Size(78, 24);
            backToMainLabel.TabIndex = 1;
            backToMainLabel.Text = "Main Page";
            backToMainLabel.Click += backToMainLabel_Click;
            // 
            // employeePanelPictureBox
            // 
            employeePanelPictureBox.Dock = DockStyle.Right;
            employeePanelPictureBox.Image = (Image)resources.GetObject("employeePanelPictureBox.Image");
            employeePanelPictureBox.Location = new Point(417, 0);
            employeePanelPictureBox.Name = "employeePanelPictureBox";
            employeePanelPictureBox.Size = new Size(383, 421);
            employeePanelPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            employeePanelPictureBox.TabIndex = 2;
            employeePanelPictureBox.TabStop = false;
            // 
            // showLoansEmployeeButton
            // 
            showLoansEmployeeButton.BackColor = SystemColors.Control;
            showLoansEmployeeButton.FlatAppearance.BorderColor = Color.Black;
            showLoansEmployeeButton.FlatAppearance.BorderSize = 2;
            showLoansEmployeeButton.FlatStyle = FlatStyle.Flat;
            showLoansEmployeeButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showLoansEmployeeButton.Location = new Point(33, 198);
            showLoansEmployeeButton.Name = "showLoansEmployeeButton";
            showLoansEmployeeButton.Size = new Size(132, 117);
            showLoansEmployeeButton.TabIndex = 3;
            showLoansEmployeeButton.Text = "Show Loans";
            showLoansEmployeeButton.UseVisualStyleBackColor = false;
            showLoansEmployeeButton.Click += showLoansEmployeeButton_Click;
            // 
            // showCustomerListButton
            // 
            showCustomerListButton.BackColor = SystemColors.Control;
            showCustomerListButton.FlatAppearance.BorderColor = Color.Black;
            showCustomerListButton.FlatAppearance.BorderSize = 2;
            showCustomerListButton.FlatStyle = FlatStyle.Flat;
            showCustomerListButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            showCustomerListButton.Location = new Point(236, 198);
            showCustomerListButton.Name = "showCustomerListButton";
            showCustomerListButton.Size = new Size(132, 117);
            showCustomerListButton.TabIndex = 4;
            showCustomerListButton.Text = "Customer List";
            showCustomerListButton.UseVisualStyleBackColor = false;
            showCustomerListButton.Click += showCustomerListButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 421);
            Controls.Add(showCustomerListButton);
            Controls.Add(showLoansEmployeeButton);
            Controls.Add(employeePanelPictureBox);
            Controls.Add(backToMainLabel);
            Controls.Add(employeeFormLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeForm";
            Text = "Employee Form";
            ((System.ComponentModel.ISupportInitialize)employeePanelPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeFormLabel;
        private Label backToMainLabel;
        private PictureBox employeePanelPictureBox;
        private Button showLoansEmployeeButton;
        private Button showCustomerListButton;
    }
}