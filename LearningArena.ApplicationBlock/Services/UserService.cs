using LearningArena.ApplicationBlock.Interface;
using LearningArena.DomainBlock.Entities;
using LearningArena.PersistenceBlock.Interface;
using LearningArena.PersistenceBlock.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.ApplicationBlock.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void SendMessage(string msg)
        {
            _userRepository.SendMessage(msg);
        }

        public string GetMessage()
        {
            return _userRepository.GetMessage();
        }

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
