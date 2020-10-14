using System.Collections.Generic;

namespace api.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<EmployeeForDetailedDto> Employee { get; set; }
    }
}