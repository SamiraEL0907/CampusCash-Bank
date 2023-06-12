namespace CampusCashBank
{
    partial class UserAccountsForm
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
            listViewAccounts = new ListView();
            AccountID = new ColumnHeader();
            AccountName = new ColumnHeader();
            AccountBalance = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewAccounts
            // 
            listViewAccounts.Columns.AddRange(new ColumnHeader[] { AccountID, AccountName, AccountBalance });
            listViewAccounts.FullRowSelect = true;
            listViewAccounts.Location = new Point(12, 110);
            listViewAccounts.Name = "listViewAccounts";
            listViewAccounts.Size = new Size(700, 364);
            listViewAccounts.TabIndex = 0;
            listViewAccounts.UseCompatibleStateImageBehavior = false;
            listViewAccounts.View = View.Details;
            // 
            // AccountID
            // 
            AccountID.Text = "AccountID";
            AccountID.Width = 150;
            // 
            // AccountName
            // 
            AccountName.Text = "AccountName";
            AccountName.Width = 150;
            // 
            // AccountBalance
            // 
            AccountBalance.Text = "AccountBalance";
            AccountBalance.Width = 150;
            // 
            // UserAccountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 486);
            Controls.Add(listViewAccounts);
            Name = "UserAccountsForm";
            Text = "Form1";
          
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAccounts;
        private ColumnHeader AccountID;
        private ColumnHeader AccountName;
        private ColumnHeader AccountBalance;
    }
}