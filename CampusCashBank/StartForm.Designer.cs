namespace CampusCashBank
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            signupButton = new Button();
            adminSignUpButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ButtonHighlight;
            loginButton.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(440, 125);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(159, 52);
            loginButton.TabIndex = 0;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.BackColor = SystemColors.ButtonHighlight;
            signupButton.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signupButton.Location = new Point(440, 216);
            signupButton.Margin = new Padding(4, 5, 4, 5);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(159, 56);
            signupButton.TabIndex = 1;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // adminSignUpButton
            // 
            adminSignUpButton.BackColor = SystemColors.ButtonHighlight;
            adminSignUpButton.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            adminSignUpButton.Location = new Point(440, 303);
            adminSignUpButton.Margin = new Padding(4, 5, 4, 5);
            adminSignUpButton.Name = "adminSignUpButton";
            adminSignUpButton.Size = new Size(159, 52);
            adminSignUpButton.TabIndex = 2;
            adminSignUpButton.Text = "Admin";
            adminSignUpButton.UseVisualStyleBackColor = false;
            adminSignUpButton.Click += adminSignUpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(335, 26);
            label1.Name = "label1";
            label1.Size = new Size(393, 45);
            label1.TabIndex = 3;
            label1.Text = "Welcome to CampusCash-Bank";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1067, 692);
            Controls.Add(label1);
            Controls.Add(adminSignUpButton);
            Controls.Add(signupButton);
            Controls.Add(loginButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button adminSignUpButton;
        private Label label1;
    }
}