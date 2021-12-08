using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Test.Dtos
{
    public class AddEmployeeQualificationDto
    {
        [JsonIgnore]
        public   Guid EmployeeId { get; set; }
        [Required]

        public int QualificationId { get; set; }
        [Required]

        public int Marks { get; set; }
    }
}
