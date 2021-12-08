using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
  public  class EmployeeQualification
    {
        

        public Employee Employee { get; set; }

        public Guid EmployeeId { get; set; }

        public int QualificationListId { get; set; }

        public QualificationList QualificationList { get; set; }


        public int Marks { get; set; }

    
    }
}
