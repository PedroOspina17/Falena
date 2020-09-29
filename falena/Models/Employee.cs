using falena.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [DisplayName("Employee type")]
        public EmployeeEnums.EmployeeType EmployeeType { get; set; }
        [DisplayName("Is active")]
        public bool IsActive { get; set; }

    }
}
