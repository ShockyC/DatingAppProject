using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace DatingAppProject.Server.Models
{
    public class ClientApplicationUser
    {
        public ClientApplicationUser(ApplicationUser AppUser)
        {
            this.Id = AppUser.Id;
            this.FirstName = AppUser.FirstName;
            this.LastName = AppUser.LastName;
            this.PhoneNumber = AppUser.PhoneNumber;
            this.NormalizedEmail = AppUser.NormalizedEmail;
            this.Email = AppUser.Email;
            this.NormalizedUserName = AppUser.NormalizedUserName;
            this.UserName = AppUser.UserName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string NormalizedEmail { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; }
        public string UserName { get; set; }
        public string Id { get; set; }
    }
}

