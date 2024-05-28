using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class Animal : BaseEntity
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
