namespace CampusCashBank
{
    partial class TransferForm
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
            HomeButton = new Button();
            transferButton = new Button();
            AccountButton = new Button();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(146, 54);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // transferButton
            // 
            transferButton.Location = new Point(305, 54);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(94, 29);
            transferButton.TabIndex = 1;
            transferButton.Text = "Transfers";
            transferButton.UseVisualStyleBackColor = true;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(471, 54);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(94, 29);
            AccountButton.TabIndex = 2;
            AccountButton.Text = "Accounts";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AccountButton);
            Controls.Add(transferButton);
            Controls.Add(HomeButton);
            Name = "TransferForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button transferButton;
        private Button AccountButton;
    }
}