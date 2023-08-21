using StudentApp.WinForm.Forms.AuthForms;

namespace StudentApp.WinForm
{
    public partial class LoginForm : Form
    {
        // IOC => INVERSION OF CONTROL

  
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
    }
}