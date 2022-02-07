using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppProject.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Address does not meet length requirements")]
        public string Address { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Education Level does not meet length requirements")]
        public string EducationLevel { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Position does not meet length requirements")]
        public string Position { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Contact { get; set; }
    }
}
