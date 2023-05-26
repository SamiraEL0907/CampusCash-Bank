namespace CampusCashBank
{
    partial class AccountsForm
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
            btnAdd = new Button();
            txtAccountName = new TextBox();
            txtBalance = new TextBox();
            txtNegativeLimit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lvUserAccounts = new ListView();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(998, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(981, 123);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(182, 27);
            txtAccountName.TabIndex = 1;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(981, 165);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(182, 27);
            txtBalance.TabIndex = 2;
            // 
            // txtNegativeLimit
            // 
            txtNegativeLimit.Location = new Point(981, 218);
            txtNegativeLimit.Name = "txtNegativeLimit";
            txtNegativeLimit.Size = new Size(182, 27);
            txtNegativeLimit.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(813, 127);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 5;
            label1.Text = "Account Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(879, 169);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 6;
            label2.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(821, 219);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 7;
            label3.Text = "Negative Limit";
            // 
            // lvUserAccounts
            // 
            lvUserAccounts.BackColor = Color.Silver;
            lvUserAccounts.Location = new Point(12, 83);
            lvUserAccounts.Name = "lvUserAccounts";
            lvUserAccounts.Size = new Size(730, 403);
            lvUserAccounts.TabIndex = 8;
            lvUserAccounts.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 32);
            label4.Name = "label4";
            label4.Size = new Size(312, 35);
            label4.TabIndex = 9;
            label4.Text = "Accounts Overview";
            // 
            // AccountsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1209, 509);
            Controls.Add(label4);
            Controls.Add(lvUserAccounts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNegativeLimit);
            Controls.Add(txtBalance);
            Controls.Add(txtAccountName);
            Controls.Add(btnAdd);
            Name = "AccountsForm";
            Text = "Form1";
            Load += AccountsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtAccountName;
        private TextBox txtBalance;
        private TextBox txtNegativeLimit;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lvAccounts;
        private ListView lvUserAccounts;
        private Label label4;
    }
}