namespace CampusCashBank
{
    partial class SignupForm
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
            FirstName = new Label();
            LastName = new Label();
            Email = new Label();
            Password = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            goToLoginPageButton = new Button();
            label1 = new Label();
            StartPage = new Button();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(160, 118);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(76, 20);
            FirstName.TabIndex = 0;
            FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(161, 155);
            LastName.Name = "LastName";
            LastName.Size = new Size(75, 20);
            LastName.TabIndex = 1;
            LastName.Text = "LastName";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(161, 194);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(161, 230);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(252, 118);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(252, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(252, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(252, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(265, 304);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 29);
            btnSignup.TabIndex = 8;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // goToLoginPageButton
            // 
            goToLoginPageButton.Location = new Point(468, 22);
            goToLoginPageButton.Name = "goToLoginPageButton";
            goToLoginPageButton.Size = new Size(141, 29);
            goToLoginPageButton.TabIndex = 9;
            goToLoginPageButton.Text = "Login Page";
            goToLoginPageButton.UseVisualStyleBackColor = true;
            goToLoginPageButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 29);
            label1.TabIndex = 10;
            label1.Text = "Sign up";
            // 
            // StartPage
            // 
            StartPage.Location = new Point(625, 22);
            StartPage.Name = "StartPage";
            StartPage.Size = new Size(109, 29);
            StartPage.TabIndex = 11;
            StartPage.Text = "StartPage";
            StartPage.UseVisualStyleBackColor = true;
            StartPage.Click += StartPage_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(StartPage);
            Controls.Add(label1);
            Controls.Add(goToLoginPageButton);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "SignupForm";
            Text = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private Label LastName;
        private Label Email;
        private Label Password;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignup;
        private Button goToLoginPageButton;
        private Label label1;
        private Button StartPage;
    }
}