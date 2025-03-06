using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Dtos;
using Models.Entities;

namespace Business.Contracts
{
    public interface IUserValidation
    {
        void Create_User(CreateUserRequest request);
        List<User> Get_Users();
    }
}
