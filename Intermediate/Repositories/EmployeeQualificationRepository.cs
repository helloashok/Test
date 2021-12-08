using Data;
using Intermediate.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate.Repositories
{
   public class EmployeeQualificationRepository:BaseRepository<EmployeeQualification>, IEmployeeQualificationRepository
    {

        
        public EmployeeQualificationRepository(EmployeeContext context):base(context)
        {

        }
    }
}
