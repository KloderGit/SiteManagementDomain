using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repositories
{
    public interface ICommonRepository<T> : IDisposable
            where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id); 
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
