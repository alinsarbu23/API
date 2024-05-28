using System;
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

        public Task GetAllAuthorsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AnimalModel> GetAnimalByIdAsync(int id)
        {
            var animal = await _animalRepository.GetAnimalByIdAsync(id);
            return MapAnimalToModel(animal);
        }

        public Task<IEnumerable<AnimalModel>> GetAnimalsByOwnerIdAsync(int ownerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AnimalModel>> GetAnimalsWithDetailsAsync()
        {
            var animals = await _animalRepository.GetAnimalsWithDetailsAsync();
            return animals.Select(animal => MapAnimalToModel(animal));
        }

        private AnimalModel MapAnimalToModel(Animal animal)
        {
            if (animal == null)
                return null;

            return new AnimalModel { Id = animal.Id, Name = animal.Name, Species = animal.Species };
        }
    }
}
