using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Models
{
    public class AnimalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
    }
}

