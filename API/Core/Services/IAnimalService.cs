using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IAnimalService
    {
        Task<IEnumerable<AnimalModel>> GetAllAnimalsAsync();
        Task<AnimalModel> GetAnimalByIdAsync(int id);
        Task<IEnumerable<AnimalModel>> GetAnimalsWithOwnersAsync();
    }
}
