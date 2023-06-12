namespace CampusCashBank
{
    partial class LoginForm
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
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            StartPage = new Button();
            btnForgotPassword = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(352, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(242, 161);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(230, 202);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(337, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(337, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 26);
            label3.Name = "label3";
            label3.Size = new Size(143, 29);
            label3.TabIndex = 5;
            label3.Text = "Login Page";
            // 
            // StartPage
            // 
            StartPage.Location = new Point(647, 26);
            StartPage.Name = "StartPage";
            StartPage.Size = new Size(94, 29);
            StartPage.TabIndex = 6;
            StartPage.Text = "StartPage";
            StartPage.UseVisualStyleBackColor = true;
            StartPage.Click += StartPage_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(318, 330);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(170, 29);
            btnForgotPassword.TabIndex = 7;
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForgotPassword);
            Controls.Add(StartPage);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Button StartPage;
        private Button btnForgotPassword;
    }
}