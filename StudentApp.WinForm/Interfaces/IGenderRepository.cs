using StudentApp.WinForm.Entities;

namespace StudentApp.WinForm.Interfaces
{
    public interface IGenderRepository
    {
        List<Gender> GetGenders();
    }
}
