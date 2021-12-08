using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public  class Employee:BaseClass
    {
        public enum Genders
        {
           MALE,
           FEMALE,
           THIRD
        }
        public string EmpName { get; set; }

      
        public DateTime DOB { get; set; }

        public Genders Gender { get; set; }

        public int Salary { get; set; }

        public DateTime EntryDate { get; set; }

        public string EntryBy { get; set; }

        public ICollection<EmployeeQualification> EmployeeQualifications { get; set; }

    }

  
}
