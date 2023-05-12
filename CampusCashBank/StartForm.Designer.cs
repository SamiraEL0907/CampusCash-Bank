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
            adminButton = new Button();
            btnTestConnection = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(417, 135);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 35);
            loginButton.TabIndex = 0;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(417, 207);
            signupButton.Margin = new Padding(4, 5, 4, 5);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(100, 35);
            signupButton.TabIndex = 1;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(417, 283);
            adminButton.Margin = new Padding(4, 5, 4, 5);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(100, 35);
            adminButton.TabIndex = 2;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(12, 12);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(232, 29);
            btnTestConnection.TabIndex = 4;
            btnTestConnection.Text = "Database connection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(btnTestConnection);
            Controls.Add(adminButton);
            Controls.Add(signupButton);
            Controls.Add(loginButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button adminButton;
        private Button btnTestConnection;
    }
}