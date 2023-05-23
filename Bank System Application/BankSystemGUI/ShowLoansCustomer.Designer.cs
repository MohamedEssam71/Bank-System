namespace BankSystemGUI
{
    partial class ShowLoansCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLoansCustomer));
            showLoansCustomerLabel = new Label();
            customerLoanFlowControl = new FlowLayoutPanel();
            backToCustomerPanel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // showLoansCustomerLabel
            // 
            showLoansCustomerLabel.AutoSize = true;
            showLoansCustomerLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            showLoansCustomerLabel.ForeColor = SystemColors.Highlight;
            showLoansCustomerLabel.Location = new Point(23, 86);
            showLoansCustomerLabel.Name = "showLoansCustomerLabel";
            showLoansCustomerLabel.Size = new Size(282, 57);
            showLoansCustomerLabel.TabIndex = 0;
            showLoansCustomerLabel.Text = "Show Loans";
            // 
            // customerLoanFlowControl
            // 
            customerLoanFlowControl.AutoScroll = true;
            customerLoanFlowControl.BackColor = SystemColors.Control;
            customerLoanFlowControl.Dock = DockStyle.Right;
            customerLoanFlowControl.Location = new Point(341, 0);
            customerLoanFlowControl.Name = "customerLoanFlowControl";
            customerLoanFlowControl.Size = new Size(592, 450);
            customerLoanFlowControl.TabIndex = 1;
            customerLoanFlowControl.Paint += customerLoanFlowControl_Paint;
            // 
            // backToCustomerPanel
            // 
            backToCustomerPanel.AutoSize = true;
            backToCustomerPanel.Cursor = Cursors.Hand;
            backToCustomerPanel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            backToCustomerPanel.Location = new Point(10, 25);
            backToCustomerPanel.Name = "backToCustomerPanel";
            backToCustomerPanel.Size = new Size(168, 24);
            backToCustomerPanel.TabIndex = 2;
            backToCustomerPanel.Text = "Back to Customer Panel";
            backToCustomerPanel.Click += backToCustomerPanel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ShowLoansCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(933, 450);
            Controls.Add(pictureBox1);
            Controls.Add(backToCustomerPanel);
            Controls.Add(customerLoanFlowControl);
            Controls.Add(showLoansCustomerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowLoansCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowLoansCustomer";
            Load += ShowLoansCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLoansCustomerLabel;
        private FlowLayoutPanel customerLoanFlowControl;
        private Label backToCustomerPanel;
        private PictureBox pictureBox1;
    }
}