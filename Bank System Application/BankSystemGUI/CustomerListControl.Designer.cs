namespace BankSystemGUI
{
    partial class CustomerListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListControl));
            pictureBox1 = new PictureBox();
            customerNameLabel = new Label();
            customerDescriptionLabel = new Label();
            picPanel = new Panel();
            separationPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            picPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point);
            customerNameLabel.Location = new Point(152, 22);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(0, 30);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Click += customerNameLabel_Click;
            // 
            // customerDescriptionLabel
            // 
            customerDescriptionLabel.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            customerDescriptionLabel.Location = new Point(152, 52);
            customerDescriptionLabel.Name = "customerDescriptionLabel";
            customerDescriptionLabel.Size = new Size(566, 87);
            customerDescriptionLabel.TabIndex = 2;
            // 
            // picPanel
            // 
            picPanel.BackColor = Color.BlanchedAlmond;
            picPanel.Controls.Add(pictureBox1);
            picPanel.Dock = DockStyle.Left;
            picPanel.Location = new Point(0, 0);
            picPanel.Name = "picPanel";
            picPanel.Size = new Size(149, 141);
            picPanel.TabIndex = 3;
            // 
            // separationPanel
            // 
            separationPanel.BackColor = Color.Peru;
            separationPanel.Location = new Point(3, 136);
            separationPanel.Name = "separationPanel";
            separationPanel.Size = new Size(718, 5);
            separationPanel.TabIndex = 4;
            // 
            // CustomerListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(separationPanel);
            Controls.Add(picPanel);
            Controls.Add(customerDescriptionLabel);
            Controls.Add(customerNameLabel);
            Name = "CustomerListControl";
            Size = new Size(721, 141);
            Load += CustomerListControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            picPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label customerNameLabel;
        private Label customerDescriptionLabel;
        private Panel picPanel;
        private Panel separationPanel;
    }
}
