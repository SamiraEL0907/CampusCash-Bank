using System.Text;

namespace CampusCashBank
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }



        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string result = db.TestConnection();
            MessageBox.Show(result);
        }

        private void adminSignUpButton_Click(object sender, EventArgs e)
        {
            var adminSignUpForm = new AdminSignUp();
            adminSignUpForm.Show();
            this.Hide();
        }


    }
}