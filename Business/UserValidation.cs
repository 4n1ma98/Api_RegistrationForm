using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Contracts;
using DataAccess.Contracts;
using Models.Dtos;
using Models.Entities;

namespace Business
{
    public class UserValidation : IUserValidation
    {
        private readonly IUserCrud _userCrud;

        public UserValidation(IUserCrud userCrud)
        {
            _userCrud = userCrud;
        }

        public void Create_User(CreateUserRequest request)
        {
            User user = new()
            {
                DocumentNumber = request.DocumentNumber,
                FirstName = request.FirstName,
                LastName = request.LastName,
                DocumentTypeId = request.DocumentTypeId,
                BirthDate = request.BirthDate,
                MaritalStatus = request.MaritalStatus,
            };

            Salary salary = new()
            {
                Total = request.Total,
            };

            _userCrud.Create(user, salary);
        }

        public List<User> Get_Users()
        {
            return _userCrud.ReadUsers();
        }
    }
}
