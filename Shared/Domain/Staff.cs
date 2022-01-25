using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid Phone Number.")]
        public int Contact { get; set; }
    }
}
