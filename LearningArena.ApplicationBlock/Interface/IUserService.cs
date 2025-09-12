using LearningArena.DomainBlock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.ApplicationBlock.Interface
{
    public interface IUserService
    {
        public bool RegisterUser();
        public User GetUser(Guid id);

        public bool UpdateUser(Guid id);

        public bool DeleteUser(Guid id);

        public List<User> GetAllUsers();
    }
}
