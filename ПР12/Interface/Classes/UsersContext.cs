using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Models;
using Interface.Interfaces;

namespace Interface.Classes
{
    public class UsersContext : Users, IUsers
    {
        public List<Users> AllUsers;

        public UsersContext() => this.All(out AllUsers);

        public void All(out List<Users> users)
        {
            users = new List<Users>();

            AllUsers.Add(new Users(1, "Аликина Ольга"));
            AllUsers.Add(new Users(2, "Бояркин Данил"));
        }
    }
}
