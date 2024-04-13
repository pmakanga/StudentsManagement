using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;
using System.Net.Http.Json;

namespace StudentsManagement.Client.Services
{
    public class StudentServices : IStudentRepository
    {
        private readonly HttpClient _httpClient;

        public StudentServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Student> AddStudentAsync(Student student)
        {
            var _student = await _httpClient.PostAsJsonAsync("api/Student/AddStudent", student);
            var response = await _student.Content.ReadFromJsonAsync<Student>();
            return response!;
        }

        public async Task<Student> DeleteStudentAsync(Guid studentId)
        {
            var student = await _httpClient.DeleteAsync($"api/Student/DeleteStudent/{studentId}");
            var response = await student.Content.ReadFromJsonAsync<Student>();
            return response!;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await _httpClient.GetAsync("api/Student/AllStudents");
            var response = await students.Content.ReadFromJsonAsync<List<Student>>();
            return response!;
        }

        public async Task<Student> GetStudentByIdAsync(Guid studentId)
        {
            var student = await _httpClient.GetAsync($"api/Student/StudentById/{studentId}");
            var response = await student.Content.ReadFromJsonAsync<Student>();
            return response!;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            var _student = await _httpClient.PostAsJsonAsync("api/Student/UpdateStudent", student);
            var response = await _student.Content.ReadFromJsonAsync<Student>();
            return response!;
        }
    }
}
