namespace BankSystemGUI
{
    partial class CustomerAccountListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccountListControl));
            accountPanel = new Panel();
            accountPicBox = new PictureBox();
            accountTypeLabel = new Label();
            accountDetailLabel = new Label();
            accountSeparationPanel = new Panel();
            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountPicBox).BeginInit();
            SuspendLayout();
            // 
            // accountPanel
            // 
            accountPanel.BackColor = SystemColors.ActiveCaption;
            accountPanel.Controls.Add(accountPicBox);
            accountPanel.Location = new Point(0, 0);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(149, 141);
            accountPanel.TabIndex = 0;
            // 
            // accountPicBox
            // 
            accountPicBox.BackColor = SystemColors.Window;
            accountPicBox.Image = (Image)resources.GetObject("accountPicBox.Image");
            accountPicBox.Location = new Point(18, 14);
            accountPicBox.Name = "accountPicBox";
            accountPicBox.Size = new Size(110, 113);
            accountPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            accountPicBox.TabIndex = 0;
            accountPicBox.TabStop = false;
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Font = new Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point);
            accountTypeLabel.Location = new Point(152, 22);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new Size(0, 30);
            accountTypeLabel.TabIndex = 1;
            // 
            // accountDetailLabel
            // 
            accountDetailLabel.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            accountDetailLabel.Location = new Point(152, 56);
            accountDetailLabel.Name = "accountDetailLabel";
            accountDetailLabel.Size = new Size(401, 76);
            accountDetailLabel.TabIndex = 2;
            // 
            // accountSeparationPanel
            // 
            accountSeparationPanel.BackColor = Color.Gold;
            accountSeparationPanel.Location = new Point(3, 140);
            accountSeparationPanel.Name = "accountSeparationPanel";
            accountSeparationPanel.Size = new Size(557, 5);
            accountSeparationPanel.TabIndex = 3;
            // 
            // CustomerAccountListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            Controls.Add(accountSeparationPanel);
            Controls.Add(accountDetailLabel);
            Controls.Add(accountTypeLabel);
            Controls.Add(accountPanel);
            Name = "CustomerAccountListControl";
            Size = new Size(556, 148);
            accountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accountPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel accountPanel;
        private PictureBox accountPicBox;
        private Label accountTypeLabel;
        private Label accountDetailLabel;
        private Panel accountSeparationPanel;
    }
}
