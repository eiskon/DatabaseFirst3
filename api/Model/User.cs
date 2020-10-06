using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace api.Model
{
    public class User : IdentityUser<int>
    {
        public int? EmployeeId { get; set; }
        
        // public string CustomerId { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}