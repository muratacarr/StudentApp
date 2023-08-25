using StudentApp.Business;
using StudentApp.Business.Interfaces;
using StudentApp.DTOs;

namespace StudentApp.WinForm.Forms.AuthForms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenderService genderService;
        private readonly IInstructorService instructorService;
        private readonly IAppUserService appUserService;
        private GenderListDto selectedGender;
        private InstructorSelectListDto selectedInstructor;
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            instructorService = dependencyContainer.GetInstructorServiceInstance();
            appUserService = dependencyContainer.GetAppUserServiceInstance();
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
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtStudentNumber.Text) && !string.IsNullOrEmpty(txtUsername.Text) && selectedGender != null && selectedInstructor != null)
            {

                string result = appUserService.CreateUser(new DTOs.StudentCreateDto
                {
                    GenderId = selectedGender.Id,
                    InstructorId = selectedInstructor.Id,
                    Name = txtName.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    StudentNumber = int.Parse(txtStudentNumber.Text),
                    Username = txtUsername.Text,
                    Surname = txtLastName.Text,
                });

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız veya bir seçim yapınız");
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem != null)
            {
                selectedGender = cmbGender.SelectedItem as GenderListDto;
            }

        }

        private void cmbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInstructor.SelectedItem != null)
            {
                selectedInstructor = cmbInstructor.SelectedItem as InstructorSelectListDto;
            }
        }
    }
}