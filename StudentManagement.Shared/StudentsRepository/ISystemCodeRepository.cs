using StudentsManagement.Shared.Models;


namespace StudentsManagement.Shared.StudentsRepository
{
    public interface ISystemCodeRepository
    {
        Task<SystemCode> AddSystemCodeAsync(SystemCode systemCode);
        Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode);
        Task<List<SystemCode>> GetAllSystemCodesAsync();
        Task<SystemCode> GetSystemCodeByIdAsync(int systemCodeId);
    }
}
