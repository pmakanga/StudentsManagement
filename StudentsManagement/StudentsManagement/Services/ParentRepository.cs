using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Shared.Models;
using StudentsManagement.Shared.StudentsRepository;

namespace StudentsManagement.Services
{
    public class ParentRepository : IParentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ParentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Parent> AddParentAsync(Parent parent)
        {
            if (parent == null) throw new ArgumentNullException();
            var newParent = _dbContext.Parents.Add(parent).Entity;
            await _dbContext.SaveChangesAsync();
            return newParent;
        }

        public async Task<List<Parent>> GetAllParentsAsync()
        {
            var parents = await _dbContext.Parents
               .Include(s => s.Student)
               .ToListAsync();
            return parents;
        }

        public async Task<Parent> GetParentsByIdAsync(Guid parentId)
        {
            var parent = await _dbContext.Parents.Where(_ => _.Id == parentId).FirstOrDefaultAsync();
            if (parent == null) throw new ArgumentNullException();

            return parent;
        }

        public async Task<Parent> UpdateParentAsync(Parent parent)
        {
            if (parent == null) throw new ArgumentNullException();
            var _parent = _dbContext.Parents.Update(parent).Entity;
            await _dbContext.SaveChangesAsync();
            return _parent;
        }
    }
}
