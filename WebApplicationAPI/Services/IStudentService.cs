using WebApplicationAPI.Models;

namespace WebApplicationAPI.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> AddStudent(Student student);
        Task<bool> DeleteStudent(int id); 
        Task<Student> UpdateStudent(Student student);

    }
}
