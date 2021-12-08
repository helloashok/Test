using Intermediate.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {
        private readonly EmployeeContext _employeeContext;

        public BaseRepository(EmployeeContext context)
        {
            _employeeContext = context;
        }
        public void Add(T entity)
        {
            _employeeContext.Set<T>().Add(entity);
        }

        public void AddRange(List<T> entities)
        {
            _employeeContext.Set<T>().AddRange(entities);
        }

        public List<T> GetAll()
        {
          return  _employeeContext.Set<T>().ToList();
        }
    }
}
