using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace DataAccess.Contracts
{
    public interface IUserCrud
    {
        void Create(User user, Salary salary);
        List<User> ReadUsers();
    }
}
