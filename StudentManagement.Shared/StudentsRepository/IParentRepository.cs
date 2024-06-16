using StudentsManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Shared.StudentsRepository
{
    public interface IParentRepository
    {
        Task<Parent> AddParentAsync(Parent parent);
        Task<Parent> UpdateParentAsync(Parent parent);
        Task<List<Parent>> GetAllParentsAsync();
        Task<Parent> GetParentsByIdAsync(Guid parentId);
    }
}
