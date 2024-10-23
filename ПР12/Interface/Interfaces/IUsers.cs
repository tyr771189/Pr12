using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IUsers
    {
        void All(out List<Models.Users> users);
    }
}
