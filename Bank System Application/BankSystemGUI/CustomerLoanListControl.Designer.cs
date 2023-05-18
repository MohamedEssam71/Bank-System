namespace BankSystemGUI
{
    partial class CustomerLoanListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoanListControl));
            loanPicPanel = new Panel();
            loanPictureBox = new PictureBox();
            loanTypeLabel = new Label();
            loanDescriptionLabel = new Label();
            seperationPanel = new Panel();
            loanPicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loanPictureBox).BeginInit();
            SuspendLayout();
            // 
            // loanPicPanel
            // 
            loanPicPanel.BackColor = SystemColors.ActiveCaption;
            loanPicPanel.Controls.Add(loanPictureBox);
            loanPicPanel.Location = new Point(0, 0);
            loanPicPanel.Name = "loanPicPanel";
            loanPicPanel.Size = new Size(149, 141);
            loanPicPanel.TabIndex = 0;
            // 
            // loanPictureBox
            // 
            loanPictureBox.BackColor = SystemColors.Window;
            loanPictureBox.Image = (Image)resources.GetObject("loanPictureBox.Image");
            loanPictureBox.Location = new Point(19, 22);
            loanPictureBox.Name = "loanPictureBox";
            loanPictureBox.Size = new Size(104, 100);
            loanPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loanPictureBox.TabIndex = 0;
            loanPictureBox.TabStop = false;
            // 
            // loanTypeLabel
            // 
            loanTypeLabel.AutoSize = true;
            loanTypeLabel.Font = new Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point);
            loanTypeLabel.Location = new Point(152, 22);
            loanTypeLabel.Name = "loanTypeLabel";
            loanTypeLabel.Size = new Size(0, 30);
            loanTypeLabel.TabIndex = 1;
            // 
            // loanDescriptionLabel
            // 
            loanDescriptionLabel.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loanDescriptionLabel.Location = new Point(152, 56);
            loanDescriptionLabel.Name = "loanDescriptionLabel";
            loanDescriptionLabel.Size = new Size(401, 76);
            loanDescriptionLabel.TabIndex = 2;
            // 
            // seperationPanel
            // 
            seperationPanel.BackColor = Color.Gold;
            seperationPanel.Location = new Point(3, 140);
            seperationPanel.Name = "seperationPanel";
            seperationPanel.Size = new Size(557, 5);
            seperationPanel.TabIndex = 1;
            // 
            // CustomerLoanListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            Controls.Add(seperationPanel);
            Controls.Add(loanDescriptionLabel);
            Controls.Add(loanTypeLabel);
            Controls.Add(loanPicPanel);
            Name = "CustomerLoanListControl";
            Size = new Size(556, 148);
            loanPicPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loanPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loanPicPanel;
        private PictureBox loanPictureBox;
        private Label loanTypeLabel;
        private Label loanDescriptionLabel;
        private Panel seperationPanel;
    }
}
