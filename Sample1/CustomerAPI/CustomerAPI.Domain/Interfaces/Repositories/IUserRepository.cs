using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.Domain.Interfaces.Repositories
{
    public interface IUserRepository<T> : IRepository<T> where T : class
    {
        T RegisterUser(T entity);
    }
}
