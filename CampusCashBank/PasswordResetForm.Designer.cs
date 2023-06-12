namespace CampusCashBank
{
    partial class PasswordResetForm
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
            txtEmail = new TextBox();
            txtUserID = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            BtnResetPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(214, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(214, 166);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(181, 27);
            txtUserID.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(214, 229);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(181, 27);
            txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(214, 294);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(181, 27);
            txtConfirmNewPassword.TabIndex = 3;
            // 
            // BtnResetPassword
            // 
            BtnResetPassword.Location = new Point(256, 357);
            BtnResetPassword.Name = "BtnResetPassword";
            BtnResetPassword.Size = new Size(94, 29);
            BtnResetPassword.TabIndex = 4;
            BtnResetPassword.Text = "Submit";
            BtnResetPassword.UseVisualStyleBackColor = true;
            BtnResetPassword.Click += BtnResetPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 108);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 166);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 6;
            label2.Text = "UserID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 238);
            label3.Name = "label3";
            label3.Size = new Size(129, 18);
            label3.TabIndex = 7;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 298);
            label4.Name = "label4";
            label4.Size = new Size(160, 18);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 19);
            label5.Name = "label5";
            label5.Size = new Size(208, 26);
            label5.TabIndex = 9;
            label5.Text = "Forgot password";
            // 
            // PasswordResetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnResetPassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtUserID);
            Controls.Add(txtEmail);
            Name = "PasswordResetForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtUserID;
        private TextBox txtNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button BtnResetPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}