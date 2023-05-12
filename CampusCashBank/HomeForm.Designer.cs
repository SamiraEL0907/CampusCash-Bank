namespace CampusCashBank
{
    partial class HomeForm
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
            TransferButton = new Button();
            AccountButton = new Button();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(119, 38);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // TransferButton
            // 
            TransferButton.Location = new Point(282, 38);
            TransferButton.Name = "TransferButton";
            TransferButton.Size = new Size(94, 29);
            TransferButton.TabIndex = 1;
            TransferButton.Text = "Transfers";
            TransferButton.UseVisualStyleBackColor = true;
            TransferButton.Click += TransferButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(464, 38);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(94, 29);
            AccountButton.TabIndex = 2;
            AccountButton.Text = "Accounts";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AccountButton);
            Controls.Add(TransferButton);
            Controls.Add(HomeButton);
            Name = "HomeForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button TransferButton;
        private Button AccountButton;
    }
}