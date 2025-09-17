using LearningArena.DomainBlock.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.PersistenceBlock.Interface
{
    public interface IUserRepository
    {

         bool AddUser(User user);
         bool RemoveUser(Guid id);

         bool UpdateUser(User user);

         IEnumerable<User> GetAllUsers();

        void SendMessage(string msg);

        string GetMessage();
    }
}
