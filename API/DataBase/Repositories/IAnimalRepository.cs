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
        Task AddAsync(Animal animal); // Adăugăm o metodă AddAsync care primește un obiect Animal
    }
}
