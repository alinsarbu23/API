using DataBase.Entities;
using DataBase.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class OwnerRepository : BaseRepository, IOwnerRepository
    {
        public OwnerRepository(ProjectDbContext context) : base(context)
        {
        }

        public void Add(Owner owner)
        {
            _db.Owners.Add(owner);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Owner>> GetAllOwnersAsync()
        {
            return await _db.Owners.ToListAsync();
        }

        public async Task<Owner> GetOwnerByIdAsync(int id)
        {
            return await _db.Owners.FindAsync(id);
        }

        public Task<IEnumerable<Owner>> GetOwnersWithDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
