using LearningArena.DomainBlock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.PersistenceBlock.Interface
{
    internal interface IUserRepository
    {

        public bool AddUser(User user);
        public bool RemoveUser(Guid id);

        public bool UpdateUser(User user);

        public IEnumerable<User> GetAllUsers();
    }
}
