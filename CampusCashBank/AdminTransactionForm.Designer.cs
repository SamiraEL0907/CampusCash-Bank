namespace CampusCashBank
{
    partial class AdminTransactionForm
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
            dgvTransactionHistory = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            OtherPartyID = new DataGridViewTextBoxColumn();
            Sent = new DataGridViewTextBoxColumn();
            Received = new DataGridViewTextBoxColumn();
            Timestamp = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvTransactionHistory
            // 
            dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionHistory.Columns.AddRange(new DataGridViewColumn[] { TransactionID, OtherPartyID, Sent, Received, Timestamp });
            dgvTransactionHistory.Location = new Point(12, 116);
            dgvTransactionHistory.Name = "dgvTransactionHistory";
            dgvTransactionHistory.RowHeadersWidth = 51;
            dgvTransactionHistory.RowTemplate.Height = 29;
            dgvTransactionHistory.Size = new Size(766, 313);
            dgvTransactionHistory.TabIndex = 0;
            
            // 
            // TransactionID
            // 
            TransactionID.HeaderText = "TransactionID";
            TransactionID.MinimumWidth = 6;
            TransactionID.Name = "TransactionID";
            TransactionID.Width = 125;
            // 
            // OtherPartyID
            // 
            OtherPartyID.HeaderText = "OtherPartyID";
            OtherPartyID.MinimumWidth = 6;
            OtherPartyID.Name = "OtherPartyID";
            OtherPartyID.Width = 125;
            // 
            // Sent
            // 
            Sent.HeaderText = "Sent";
            Sent.MinimumWidth = 6;
            Sent.Name = "Sent";
            Sent.Width = 125;
            // 
            // Received
            // 
            Received.HeaderText = "Received";
            Received.MinimumWidth = 6;
            Received.Name = "Received";
            Received.Width = 125;
            // 
            // Timestamp
            // 
            Timestamp.HeaderText = "Timestamp";
            Timestamp.MinimumWidth = 6;
            Timestamp.Name = "Timestamp";
            Timestamp.Width = 200;
            // 
            // AdminTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTransactionHistory);
            Name = "AdminTransactionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransactionHistory;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn OtherPartyID;
        private DataGridViewTextBoxColumn Sent;
        private DataGridViewTextBoxColumn Received;
        private DataGridViewTextBoxColumn Timestamp;
    }
}