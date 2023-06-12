namespace CampusCashBank
{
    partial class AdminForm
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
            label1 = new Label();
            listViewUsers = new ListView();
            UserID = new ColumnHeader();
            Email = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            btnDeleteUser = new Button();
            BtnAddUser = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 104);
            label1.Name = "label1";
            label1.Size = new Size(98, 35);
            label1.TabIndex = 1;
            label1.Text = "Users";
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { UserID, Email, FirstName, LastName });
            listViewUsers.FullRowSelect = true;
            listViewUsers.Location = new Point(17, 150);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(758, 316);
            listViewUsers.TabIndex = 2;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            listViewUsers.Click += listViewUsers_DoubleClick;
            // 
            // UserID
            // 
            UserID.Text = "UserID";
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 350;
            // 
            // FirstName
            // 
            FirstName.Text = "FirstName";
            FirstName.Width = 150;
            // 
            // LastName
            // 
            LastName.Text = "LastName";
            LastName.Width = 150;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteUser.Location = new Point(914, 167);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(117, 41);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // BtnAddUser
            // 
            BtnAddUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddUser.Location = new Point(914, 237);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(117, 45);
            BtnAddUser.TabIndex = 4;
            BtnAddUser.Text = "Add User";
            BtnAddUser.UseVisualStyleBackColor = true;
            BtnAddUser.Click += BtnAddUser_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1030, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 5;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 478);
            Controls.Add(Exit);
            Controls.Add(BtnAddUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(listViewUsers);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListView listViewUsers;
        private ColumnHeader UserID;
        private ColumnHeader Email;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private Button btnDeleteUser;
        private Button BtnAddUser;
        private Button Exit;
    }
}