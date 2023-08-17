using StudentApp.WinForm.Entities;

namespace StudentApp.WinForm.Interfaces
{
    public interface IInstructorRepository
    {
        List<Instructor> GetInstructors();
    }
}
