using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Services
{
    public class SystemCodeRepository : ISystemCodeRepository
    {

        private readonly ApplicationDbContext _dbContext;
        public SystemCodeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SystemCode> AddSystemCodeAsync(SystemCode systemCode)
        {
            if (systemCode == null) throw new ArgumentNullException();
            var newSystemCode = _dbContext.SystemCodes.Add(systemCode).Entity;
            await _dbContext.SaveChangesAsync();
            return newSystemCode;
        }

        public async Task<List<SystemCode>> GetAllSystemCodesAsync()
        {
            var systemcodes = await _dbContext.SystemCodes.ToListAsync();
            return systemcodes;
        }

        public async Task<SystemCode> GetSystemCodeByIdAsync(int systemCodeId)
        {
            var systemcode= await _dbContext.SystemCodes.Where(_ => _.Id == systemCodeId).FirstOrDefaultAsync();
            if (systemcode == null) throw new ArgumentNullException();

            return systemcode;
        }

        public async Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode)
        {
            if (systemCode == null) throw new ArgumentNullException();
            var _systemCode = _dbContext.SystemCodes.Update(systemCode).Entity;
            await _dbContext.SaveChangesAsync();
            return _systemCode;
        }
    }
}
