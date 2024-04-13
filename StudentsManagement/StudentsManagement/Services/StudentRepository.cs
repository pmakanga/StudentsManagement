using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> AddStudentAsync(Student student)
        {
            if (student == null) throw new ArgumentNullException();

            var newStudent = _dbContext.Students.Add(student).Entity;
            await _dbContext.SaveChangesAsync();
            return newStudent;
        }

        public async Task<Student> DeleteStudentAsync(Guid studentId)
        {
            var student = await _dbContext.Students.Where(_ => _.Id == studentId).FirstOrDefaultAsync();
            if (student == null) throw new ArgumentNullException();

            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await _dbContext.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentByIdAsync(Guid studentId)
        {
            var student = await _dbContext.Students.Where(_ => _.Id == studentId).FirstOrDefaultAsync();
            if (student == null) throw new ArgumentNullException();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            if (student == null) throw new ArgumentNullException();

            var _student = _dbContext.Students.Update(student).Entity;
            await _dbContext.SaveChangesAsync();
            return _student;
        }
    }
}
