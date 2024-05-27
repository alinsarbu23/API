using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using DataBase.Repositories;
using DataBase.Entities;

namespace Core.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task<IEnumerable<OwnerModel>> GetAllOwnersAsync()
        {
            var owners = await _ownerRepository.GetAllOwnersAsync();
            return owners.Select(owner => MapOwnerToModel(owner));
        }

        public async Task<OwnerModel> GetOwnerByIdAsync(int id)
        {
            var owner = await _ownerRepository.GetOwnerByIdAsync(id);
            return MapOwnerToModel(owner);
        }

        // Add other service methods as needed

        private OwnerModel MapOwnerToModel(Owner owner)
        {
            if (owner == null)
                return null;

            return new OwnerModel
            {
                Id = owner.Id,
                Name = owner.Name,
                Address = owner.Address
            };
        }
    }
}
