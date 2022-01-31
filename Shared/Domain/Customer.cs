using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Religion { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Contact { get; set; }
    }
}
