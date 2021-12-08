using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Dtos
{
    
    public class GetEmployeeDto 
    {
        public string EmpName { get; set; }

        public Guid EmployeeId { get; set; }

        //public DateTime DOB { get; set; }

        //public string Gender { get; set; }

        //public int Salary { get; set; }

        //public DateTime EntryDate { get; set; }

        //public string EntryBy { get; set; }
    }
}
