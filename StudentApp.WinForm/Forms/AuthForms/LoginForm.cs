using StudentApp.WinForm.Container;
using StudentApp.WinForm.Forms.AuthForms;
using StudentApp.WinForm.Interfaces;

namespace StudentApp.WinForm
{
    public partial class LoginForm : Form
    {
        // IOC => INVERSION OF CONTROL

        private readonly IGenderRepository genderRepository;
        public LoginForm()
        {
            InitializeComponent();
            genderRepository = new DependencyContainer().GetGenderRepositoryInstance();
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