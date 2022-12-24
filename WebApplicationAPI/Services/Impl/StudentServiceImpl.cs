using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Services.Impl
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly StudentDbContext _dbContext;

        public StudentServiceImpl(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            try
            {
                List<Student> students = new List<Student>();
                students = await _dbContext.Students.ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
