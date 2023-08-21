using StudentApp.Business;
using StudentApp.Business.Interfaces;
namespace StudentApp.WinForm.Forms.AuthForms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenderService genderService;
        private readonly IInstructorService instructorService;
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            instructorService = dependencyContainer.GetInstructorServiceInstance(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadInstructor();
        }

        private void LoadInstructor()
        {
            var instructorList = instructorService.GetInstructors();
            cmbInstructor.DataSource = null;
            cmbInstructor.DataSource = instructorList;
            cmbInstructor.DisplayMember = "FullName";
            cmbInstructor.ValueMember = "Id";

        }

        private void LoadGender()
        {
            var genderList = genderService.GetGenders();
            cmbGender.DataSource = null;
            cmbGender.DataSource = genderList;
            cmbGender.DisplayMember = "Definition";
            cmbGender.ValueMember = "Id";
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtStudentNumber.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {

            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız ");
            }
        }
    }
}