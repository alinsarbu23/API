using DataBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public interface IOwnerRepository
    {
        Task<IEnumerable<Owner>> GetAllOwnersAsync();
        Task<Owner> GetOwnerByIdAsync(int id);
    }
}
