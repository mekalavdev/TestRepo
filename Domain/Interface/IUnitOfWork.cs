using System;

namespace Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        bool SaveChanges();
    }
}
