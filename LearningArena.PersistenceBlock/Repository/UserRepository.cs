using LearningArena.DomainBlock.Entities;
using LearningArena.PersistenceBlock.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.PersistenceBlock.Repositary;


public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new List<User>();

    private readonly string _path = @"C:\Users\Kamran Wani\Documents\data.txt";

    public void SendMessage(string msg)
    {
        using StreamWriter sw=new StreamWriter(_path,true);
              sw.WriteLine(msg);
    }

    


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

    public string GetMessage()
    {
        using StreamReader sr=new StreamReader(_path);
        string msg = sr.ReadToEnd();
        return msg;
    }
}
