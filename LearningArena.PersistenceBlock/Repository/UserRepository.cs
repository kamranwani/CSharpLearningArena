using LearningArena.DomainBlock.Entities;
using LearningArena.PersistenceBlock.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.PersistenceBlock.Repositary;


internal class UserRepository : IUserRepository
{
    private readonly List<User> _users = new List<User>();

    public bool AddUser(User user)
    {
        throw new NotImplementedException();
    }

    

    public IEnumerable<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public bool RemoveUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
