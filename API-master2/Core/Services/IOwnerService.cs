using Core.Models;
using DataBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IOwnerService
    {
        Task<IEnumerable<OwnerModel>> GetAllOwnersAsync();
        Task<OwnerModel> GetOwnerByIdAsync(int id);
        Task<IEnumerable<OwnerModel>> GetOwnersWithDetailsAsync(); // Adăugarea metodei necesare
    }
}
