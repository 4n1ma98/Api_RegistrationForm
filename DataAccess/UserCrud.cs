using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess.Contracts;
using Microsoft.Extensions.Configuration;
using Models.Entities;

namespace DataAccess
{
    public class UserCrud : IUserCrud
    {
        private readonly DBContext _dBContext;
        private readonly IConfiguration _config;
        public UserCrud(DBContext dBContext, IConfiguration config)
        {
            _dBContext = dBContext;
            _config = config;
        }

        public void Create(User user, Salary salary)
        {
            try
            {
                var parameters = new
                {
                    Option = 2,
                    user.DocumentNumber,
                    user.FirstName,
                    user.LastName,
                    user.DocumentTypeId,
                    user.BirthDate,
                    user.MaritalStatus,
                    salary.Total,
                };

                using (IDbConnection _context = _dBContext.Conn(_config.GetConnectionString("DefaultConnection")!))
                {
                    _context.Execute("SP_Crud", parameters, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<User> ReadUsers()
        {
            try
            {
                var parameters = new
                {
                    Option = 1,
                };

                using (IDbConnection _context = _dBContext.Conn(_config.GetConnectionString("DefaultConnection")!))
                {
                    return _context.Query<User>("SP_Crud", parameters, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
