using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Services
{
    public class SystemCodeDetailRepository : ISystemCodeDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SystemCodeDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<SystemCodeDetail> AddSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
        {
            if (systemCodeDetail == null) throw new ArgumentNullException();
            var newSystemCodeDetail = _dbContext.SystemCodeDetails.Add(systemCodeDetail).Entity;
            await _dbContext.SaveChangesAsync();
            return newSystemCodeDetail;
        }

        public async Task<List<SystemCodeDetail>> GetAllSystemCodeDetailsAsync()
        {
            var systemcodeDetails = await _dbContext.SystemCodeDetails
                .Include(x => x.SystemCode)
                .ToListAsync();
            return systemcodeDetails;
        }

        public async Task<List<SystemCodeDetail>> GetSystemCodeDetailByCodeAsync(string code)
        {
            var data = await _dbContext.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Where(x => x.SystemCode!.Code == code)
                .ToListAsync();
            if (data == null) throw new ArgumentException();

            return data;
        }

        public async Task<SystemCodeDetail> GetSystemCodeDetailByIdAsync(int systemCodeDetailId)
        {
            var systemcodeDetails = await _dbContext.SystemCodeDetails.Where(_ => _.Id == systemCodeDetailId).FirstOrDefaultAsync();
            if (systemcodeDetails == null) throw new ArgumentNullException();

            return systemcodeDetails;
        }

        public async Task<SystemCodeDetail> UpdateSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
        {
            if (systemCodeDetail == null) throw new ArgumentNullException();
            var _systemCodeDetail = _dbContext.SystemCodeDetails.Update(systemCodeDetail).Entity;
            await _dbContext.SaveChangesAsync();
            return _systemCodeDetail;
        }
    }
}
