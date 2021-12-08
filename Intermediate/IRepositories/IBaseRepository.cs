using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate.IRepositories
{
   public interface IBaseRepository<T> where T:class
    {

        void Add(T entity);

        void AddRange(List<T> entities);

        List<T> GetAll();
    }
}
