using DataBase.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAllAnimalsAsync();
        Task<Animal> GetAnimalByIdAsync(int id);
        Task<IEnumerable<Animal>> GetAnimalsWithOwnersAsync();
        Task<IEnumerable<Animal>> GetAnimalsWithDetailsAsync(); // Adăugarea metodei necesare
    }
}
