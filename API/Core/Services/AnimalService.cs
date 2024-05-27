using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using DataBase.Repositories;
using DataBase.Entities;

namespace Core.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<IEnumerable<AnimalModel>> GetAllAnimalsAsync()
        {
            var animals = await _animalRepository.GetAllAnimalsAsync();
            return animals.Select(animal => MapAnimalToModel(animal));
        }

        public async Task<AnimalModel> GetAnimalByIdAsync(int id)
        {
            var animal = await _animalRepository.GetAnimalByIdAsync(id);
            return MapAnimalToModel(animal);
        }

        public async Task<IEnumerable<AnimalModel>> GetAnimalsWithOwnersAsync()
        {
            var animals = await _animalRepository.GetAnimalsWithOwnersAsync();
            return animals.Select(animal => MapAnimalToModel(animal));
        }

        public async Task AddAnimalAsync(AnimalModel animalModel)
        {
            var animal = new Animal
            {
                Name = animalModel.Name,
                Species = animalModel.Species
            };

            await _animalRepository.AddAsync(animal);
        }




        // Add other service methods as needed

        private AnimalModel MapAnimalToModel(Animal animal)
        {
            if (animal == null)
                return null;

            return new AnimalModel { Id = animal.Id, Name = animal.Name, Species = animal.Species };
        }
    }
}
