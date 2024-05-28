using DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IUserService
    {
        Task Register(User user, string password);
        Task<string> Login(string username, string password);
        Task<User> GetUserByIdAsync(int id);
    }
}
