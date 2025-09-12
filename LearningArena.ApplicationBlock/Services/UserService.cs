using LearningArena.ApplicationBlock.Interface;
using LearningArena.DomainBlock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.ApplicationBlock.Services
{
    public class UserService : IUserService
    {
        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(Guid id, User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
