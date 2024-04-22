using StudentsManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Shared.StudentsRepository
{
    public interface ISystemCodeDetailRepository
    {
        Task<SystemCodeDetail> AddSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail);
        Task<SystemCodeDetail> UpdateSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail);
        Task<List<SystemCodeDetail>> GetAllSystemCodeDetailsAsync();
        Task<SystemCodeDetail> GetSystemCodeDetailByIdAsync(int systemCodeDetailId);
    }
}
