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
            dgvTransactionHistory = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            OtherPartyID = new DataGridViewTextBoxColumn();
            Sent = new DataGridViewTextBoxColumn();
            Received = new DataGridViewTextBoxColumn();
            Timestamp = new DataGridViewTextBoxColumn();
            btnSend = new Button();
            txtAmount = new TextBox();
            txtReceiverAccountId = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            dgvTransactionHistory.Size = new Size(775, 582);
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
            Timestamp.Width = 125;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(963, 388);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(157, 36);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(976, 338);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 2;
            txtAmount.Text = "Amount";
            // 
            // txtReceiverAccountId
            // 
            txtReceiverAccountId.Location = new Point(976, 284);
            txtReceiverAccountId.Name = "txtReceiverAccountId";
            txtReceiverAccountId.Size = new Size(125, 27);
            txtReceiverAccountId.TabIndex = 3;
            txtReceiverAccountId.Text = "AccountID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 64);
            label2.Name = "label2";
            label2.Size = new Size(330, 35);
            label2.TabIndex = 5;
            label2.Text = "Transaction History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(920, 211);
            label1.Name = "label1";
            label1.Size = new Size(234, 29);
            label1.TabIndex = 6;
            label1.Text = "Add new transfer";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1283, 709);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtReceiverAccountId);
            Controls.Add(txtAmount);
            Controls.Add(btnSend);
            Controls.Add(dgvTransactionHistory);
            Name = "TransferForm";
            Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransactionHistory;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn OtherPartyID;
        private DataGridViewTextBoxColumn Sent;
        private DataGridViewTextBoxColumn Received;
        private DataGridViewTextBoxColumn Timestamp;
        private Button btnSend;
        private TextBox txtAmount;
        private TextBox txtReceiverAccountId;
        private Label label2;
        private Label label1;
    }
}