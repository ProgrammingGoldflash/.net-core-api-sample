using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
