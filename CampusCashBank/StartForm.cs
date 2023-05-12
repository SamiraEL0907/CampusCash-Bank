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

        private void adminButton_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string result = db.TestConnection();
            MessageBox.Show(result);
        }
    }
}