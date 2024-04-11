using BTS.Core.Entities;
using BTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Core.Services
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public Task<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User userChanges)
        {
            throw new NotImplementedException();
        }
    }
}
