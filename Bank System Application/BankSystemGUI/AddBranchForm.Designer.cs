namespace BankSystemGUI
{
    partial class AddBranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranchForm));
            AddBranchFormLabel = new Label();
            codeBranchLabel = new Label();
            branchNameLabel = new Label();
            addressBranchLabel = new Label();
            nameBranchPanel = new Panel();
            codeBranchPanel = new Panel();
            addressBranchPanel = new Panel();
            nameBranchTextBox = new TextBox();
            codeBranchTextBox = new TextBox();
            addressBranchTextBox = new TextBox();
            addBranchConfirmButton = new Button();
            backToAdminLabel = new Label();
            SuspendLayout();
            // 
            // AddBranchFormLabel
            // 
            AddBranchFormLabel.AutoSize = true;
            AddBranchFormLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            AddBranchFormLabel.ForeColor = SystemColors.Highlight;
            AddBranchFormLabel.Location = new Point(116, 22);
            AddBranchFormLabel.Name = "AddBranchFormLabel";
            AddBranchFormLabel.Size = new Size(292, 57);
            AddBranchFormLabel.TabIndex = 0;
            AddBranchFormLabel.Text = "Add Branch";
            // 
            // codeBranchLabel
            // 
            codeBranchLabel.AutoSize = true;
            codeBranchLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            codeBranchLabel.ForeColor = Color.Peru;
            codeBranchLabel.Location = new Point(96, 219);
            codeBranchLabel.Name = "codeBranchLabel";
            codeBranchLabel.Size = new Size(60, 24);
            codeBranchLabel.TabIndex = 1;
            codeBranchLabel.Text = "Code:";
            // 
            // branchNameLabel
            // 
            branchNameLabel.AutoSize = true;
            branchNameLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            branchNameLabel.ForeColor = Color.Peru;
            branchNameLabel.Location = new Point(96, 126);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new Size(68, 24);
            branchNameLabel.TabIndex = 2;
            branchNameLabel.Text = "Name:";
            // 
            // addressBranchLabel
            // 
            addressBranchLabel.AutoSize = true;
            addressBranchLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBranchLabel.ForeColor = Color.Peru;
            addressBranchLabel.Location = new Point(96, 304);
            addressBranchLabel.Name = "addressBranchLabel";
            addressBranchLabel.Size = new Size(90, 24);
            addressBranchLabel.TabIndex = 3;
            addressBranchLabel.Text = "Address:";
            // 
            // nameBranchPanel
            // 
            nameBranchPanel.BackColor = Color.Black;
            nameBranchPanel.Location = new Point(105, 153);
            nameBranchPanel.Name = "nameBranchPanel";
            nameBranchPanel.Size = new Size(326, 1);
            nameBranchPanel.TabIndex = 4;
            // 
            // codeBranchPanel
            // 
            codeBranchPanel.BackColor = Color.Black;
            codeBranchPanel.Location = new Point(105, 246);
            codeBranchPanel.Name = "codeBranchPanel";
            codeBranchPanel.Size = new Size(326, 1);
            codeBranchPanel.TabIndex = 5;
            // 
            // addressBranchPanel
            // 
            addressBranchPanel.BackColor = Color.Black;
            addressBranchPanel.Location = new Point(105, 331);
            addressBranchPanel.Name = "addressBranchPanel";
            addressBranchPanel.Size = new Size(326, 1);
            addressBranchPanel.TabIndex = 5;
            // 
            // nameBranchTextBox
            // 
            nameBranchTextBox.BackColor = SystemColors.Window;
            nameBranchTextBox.BorderStyle = BorderStyle.None;
            nameBranchTextBox.Cursor = Cursors.IBeam;
            nameBranchTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameBranchTextBox.Location = new Point(162, 126);
            nameBranchTextBox.Name = "nameBranchTextBox";
            nameBranchTextBox.Size = new Size(269, 25);
            nameBranchTextBox.TabIndex = 0;
            // 
            // codeBranchTextBox
            // 
            codeBranchTextBox.BackColor = SystemColors.Window;
            codeBranchTextBox.BorderStyle = BorderStyle.None;
            codeBranchTextBox.Cursor = Cursors.IBeam;
            codeBranchTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            codeBranchTextBox.Location = new Point(162, 218);
            codeBranchTextBox.Name = "codeBranchTextBox";
            codeBranchTextBox.Size = new Size(269, 25);
            codeBranchTextBox.TabIndex = 6;
            codeBranchTextBox.TextChanged += codeBankTextBox_TextChanged;
            // 
            // addressBranchTextBox
            // 
            addressBranchTextBox.BackColor = SystemColors.Window;
            addressBranchTextBox.BorderStyle = BorderStyle.None;
            addressBranchTextBox.Cursor = Cursors.IBeam;
            addressBranchTextBox.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addressBranchTextBox.Location = new Point(192, 303);
            addressBranchTextBox.Name = "addressBranchTextBox";
            addressBranchTextBox.Size = new Size(239, 25);
            addressBranchTextBox.TabIndex = 7;
            // 
            // addBranchConfirmButton
            // 
            addBranchConfirmButton.Cursor = Cursors.Hand;
            addBranchConfirmButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBranchConfirmButton.ForeColor = SystemColors.WindowText;
            addBranchConfirmButton.Location = new Point(162, 365);
            addBranchConfirmButton.Name = "addBranchConfirmButton";
            addBranchConfirmButton.Size = new Size(193, 43);
            addBranchConfirmButton.TabIndex = 8;
            addBranchConfirmButton.Text = "Add Branch";
            addBranchConfirmButton.UseVisualStyleBackColor = true;
            addBranchConfirmButton.Click += addBankConfirmButton_Click;
            // 
            // backToAdminLabel
            // 
            backToAdminLabel.AutoSize = true;
            backToAdminLabel.Cursor = Cursors.Hand;
            backToAdminLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backToAdminLabel.Location = new Point(182, 421);
            backToAdminLabel.Name = "backToAdminLabel";
            backToAdminLabel.Size = new Size(147, 24);
            backToAdminLabel.TabIndex = 9;
            backToAdminLabel.Text = "Back to Admin Panel";
            backToAdminLabel.Click += backToAdminLabel_Click;
            // 
            // AddBranchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(523, 467);
            Controls.Add(backToAdminLabel);
            Controls.Add(addBranchConfirmButton);
            Controls.Add(addressBranchTextBox);
            Controls.Add(codeBranchTextBox);
            Controls.Add(nameBranchTextBox);
            Controls.Add(addressBranchPanel);
            Controls.Add(codeBranchPanel);
            Controls.Add(nameBranchPanel);
            Controls.Add(addressBranchLabel);
            Controls.Add(branchNameLabel);
            Controls.Add(codeBranchLabel);
            Controls.Add(AddBranchFormLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBranchForm";
            Text = "AddBranchForm";
            Load += AddBankForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddBranchFormLabel;
        private Label codeBranchLabel;
        private Label branchNameLabel;
        private Label addressBranchLabel;
        private Panel nameBranchPanel;
        private Panel codeBranchPanel;
        private Panel addressBranchPanel;
        private TextBox nameBranchTextBox;
        private TextBox codeBranchTextBox;
        private TextBox addressBranchTextBox;
        private Button addBranchConfirmButton;
        private Label backToAdminLabel;
    }
}