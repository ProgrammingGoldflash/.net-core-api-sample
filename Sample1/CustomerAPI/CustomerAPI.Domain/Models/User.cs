using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
