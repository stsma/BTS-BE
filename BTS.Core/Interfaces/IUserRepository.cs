using BTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUser(int Id);
        Task<IEnumerable<User>> GetUsers();
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User userChanges);
        Task<bool> DeleteUser(int Id);
    }
}
