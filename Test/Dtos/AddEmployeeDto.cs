using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Dtos
{
    public class AddEmployeeDto:IValidatableObject
    {

        
       [Required]
        public string EmpName { get; set; }
        [Required]
        public DateTime DOB { get; set; }

        [Required]

        public string Gender { get; set; }

        [Required]

        public int Salary { get; set; }

        [Required]

        public string EntryBy { get; set; }

        [Required]

        public List<AddEmployeeQualificationDto> EmployeeQualificationDtos { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(DOB>=DateTime.Now)
            {
              yield return new ValidationResult("Date of Birth cannot be greater than present Date");
            }

            
        }
    }

    
}
