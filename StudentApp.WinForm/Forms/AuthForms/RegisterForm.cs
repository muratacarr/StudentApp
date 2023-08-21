using StudentApp.Business;
using StudentApp.Business.Interfaces;
namespace StudentApp.WinForm.Forms.AuthForms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenderService genderService;
        //private readonly IInstructorRepository instructorRepository;
        public RegisterForm()
        {
            InitializeComponent();
            var dependencyContainer = new BusinessServiceRegistration();
            genderService = dependencyContainer.GetGenderServiceInstance();
            //instructorRepository = dependencyContainer.GetInstructorRepositoryInstance();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadGender();
            //LoadInstructor();
        }

        //private void LoadInstructor()
        //{
        //    var instructorList = instructorRepository.GetInstructors();

        //    var list = ConvertToInstrocturDtoList(instructorList);

        //    cmbInstructor.DataSource = null;
        //    cmbInstructor.DataSource = list;
        //    cmbInstructor.DisplayMember = "FullName";
        //    cmbInstructor.ValueMember = "Id";

        //}

        private void LoadGender()
        {
            var genderList = genderService.GetGenders();
            cmbGender.DataSource = null;
            cmbGender.DataSource = genderList;
            cmbGender.DisplayMember = "Definition";
            cmbGender.ValueMember = "Id";
        }

        /// DONT REPEAT YOURSELF
        /// REPOSITORY DESIGN PATTERN



        // BUSINESS 
        // FULLNAME
        //private List<InstructorListDto> ConvertToInstrocturDtoList(List<Instructor> instructors)
        //{
        //    var list = new List<InstructorListDto>();
        //    foreach (var instructor in instructors)
        //    {
        //        var dto = new InstructorListDto();

        //        dto.Id = instructor.Id;
        //        dto.UserId = instructor.UserId;
        //        dto.PhoneNumber = instructor.PhoneNumber;
        //        dto.FullName = instructor.Name + " " + instructor.Surname;
        //        dto.Salary = instructor.Salary;
        //        dto.GenderId = instructor.GenderId;
        //        dto.Password = instructor.Password;
        //        dto.Username = instructor.Username;

        //        list.Add(dto);
        //    }

        //    return list;

        //}

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}


// BUSINESS || DATA yı birbirinden ayırmak.