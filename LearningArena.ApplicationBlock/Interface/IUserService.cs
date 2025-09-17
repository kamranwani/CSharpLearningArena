using LearningArena.DomainBlock.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.ApplicationBlock.Interface
{
    public interface IUserService
    {
         bool RegisterUser(User user);
         User GetUser(Guid id );

         bool UpdateUser(Guid id, User updatedUser);

        bool DeleteUser(Guid id);

         IEnumerable<User> GetAllUsers();

        void SendMessage(string msg);
        string GetMessage();
    }
}
