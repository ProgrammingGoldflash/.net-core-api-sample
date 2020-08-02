using CustomerAPI.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
