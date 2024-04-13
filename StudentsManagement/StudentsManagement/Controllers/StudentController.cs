using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("AllStudents")]
        public ActionResult<List<Student>> GetAllStudentsAsync()
        {
            var students = _studentRepository.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpGet("StudentById/{id}")]
        public ActionResult<Student> GetStudentById(Guid id)
        {
            var student = _studentRepository.GetStudentByIdAsync(id);
            return Ok(student);
        }

        [HttpPost("AddStudent")]
        public ActionResult<Student> AddStudentAsync(Student student)
        {
            var _student = _studentRepository.AddStudentAsync(student);
            return Ok(_student);
        }

        [HttpPost("UpdateStudent")]
        public ActionResult<Student> UpdateStudentAsync(Student student)
        {
            var _student = _studentRepository.UpdateStudentAsync(student);
            return Ok(_student);
        }


        [HttpDelete("DeleteStudent/{id}")]
        public async Task<ActionResult<Student>> DeleteStudentAsync(Guid id)
        {
            var student = await _studentRepository.DeleteStudentAsync(id);
            return Ok(student);
        }
    }
}
