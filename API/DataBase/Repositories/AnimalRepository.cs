using DataBase.Entities;
using DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class AnimalRepository : BaseRepository, IAnimalRepository
    {
        public AnimalRepository(ProjectDbContext context) : base(context)
        {
        }

        public void Add(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        public async Task AddAsync(Animal animal)
        {
            _db.Animals.Add(animal);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync()
        {
            return await _db.Animals.ToListAsync();
        }

        public async Task<Animal> GetAnimalByIdAsync(int id)
        {
            return await _db.Animals.FindAsync(id);
        }

        // Implementarea metodei care arunca o excepție
        public async Task<IEnumerable<Animal>> GetAnimalsWithOwnersAsync()
        {
            throw new NotImplementedException("This method is not implemented in AnimalRepository.");
        }
    }
}
