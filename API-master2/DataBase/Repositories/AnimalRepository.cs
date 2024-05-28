using DataBase.Context;
using DataBase.Entities;
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

        public async Task<IEnumerable<Animal>> GetAllAnimalsAsync()
        {
            return await _db.Animals.ToListAsync();
        }

        public async Task<Animal> GetAnimalByIdAsync(int id)
        {
            return await _db.Animals.FindAsync(id);
        }

        public Task<IEnumerable<Animal>> GetAnimalsWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Animal>> GetAnimalsWithOwnersAsync()
        {
            return await _db.Animals.Include(animal => animal.Owner).ToListAsync();
        }
    }
}
