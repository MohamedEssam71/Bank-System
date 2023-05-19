﻿namespace BankSystemGUI
{
    partial class ShowAccountCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAccountCustomer));
            showAccountCustomerLabel = new Label();
            customerAccountFlowControl = new FlowLayoutPanel();
            backToCustomerPanel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // showAccountCustomerLabel
            // 
            showAccountCustomerLabel.AutoSize = true;
            showAccountCustomerLabel.Font = new Font("Bauhaus 93", 30F, FontStyle.Bold, GraphicsUnit.Point);
            showAccountCustomerLabel.ForeColor = SystemColors.Highlight;
            showAccountCustomerLabel.Location = new Point(43, 86);
            showAccountCustomerLabel.Name = "showAccountCustomerLabel";
            showAccountCustomerLabel.Size = new Size(236, 57);
            showAccountCustomerLabel.TabIndex = 0;
            showAccountCustomerLabel.Text = "Accounts";
            // 
            // customerAccountFlowControl
            // 
            customerAccountFlowControl.AutoScroll = true;
            customerAccountFlowControl.BackColor = SystemColors.Control;
            customerAccountFlowControl.Dock = DockStyle.Right;
            customerAccountFlowControl.Location = new Point(341, 0);
            customerAccountFlowControl.Name = "customerAccountFlowControl";
            customerAccountFlowControl.Size = new Size(592, 450);
            customerAccountFlowControl.TabIndex = 1;
            customerAccountFlowControl.Paint += customerLoanFlowControl_Paint;
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
            pictureBox1.Location = new Point(69, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ShowAccountCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(933, 450);
            Controls.Add(pictureBox1);
            Controls.Add(backToCustomerPanel);
            Controls.Add(customerAccountFlowControl);
            Controls.Add(showAccountCustomerLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowAccountCustomer";
            Text = "ShowLoansCustomer";
            Load += ShowAccountCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showAccountCustomerLabel;
        private FlowLayoutPanel customerAccountFlowControl;
        private Label backToCustomerPanel;
        private PictureBox pictureBox1;
    }
}