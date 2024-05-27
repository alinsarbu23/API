using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IOwnerService
    {
        Task<IEnumerable<OwnerModel>> GetAllOwnersAsync();
        Task<OwnerModel> GetOwnerByIdAsync(int id);
    }
}
