using participate_registration.Models.DTOs;

namespace participate_registration.Models
{
    public class User : InsertUser
    {
        public ProfileImage ProfileImage { get; set; }
    }
}
