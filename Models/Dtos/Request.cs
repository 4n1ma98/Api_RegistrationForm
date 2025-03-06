using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos
{
    public class CreateUserRequest
    {
        public int DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte DocumentTypeId { get; set; }
        public DateTime BirthDate { get; set; }
        public bool MaritalStatus { get; set; }
        public int Total { get; set; }
    }
}
