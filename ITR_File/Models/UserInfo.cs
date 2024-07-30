using System.ComponentModel.DataAnnotations;

namespace ITR_File.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Username {  get; set; }
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
