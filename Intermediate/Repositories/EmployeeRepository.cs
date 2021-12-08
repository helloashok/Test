using Data;
using Intermediate.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate.Repositories
{
  public  class EmployeeRepository:BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext context):base(context)
        {

        }
    }
}
