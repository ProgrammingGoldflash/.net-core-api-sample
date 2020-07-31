using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository<T> : IRepository<T> where T : class
    {
        bool CheckForEmailAsync(string email);
    }
}
