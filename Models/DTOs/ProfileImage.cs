
namespace participate_registration.Models.DTOs
{
    public class ProfileImage
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageHash { get; set; }
    }
}
