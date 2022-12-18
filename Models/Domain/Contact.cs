using System.ComponentModel.DataAnnotations;

namespace BWITCODE.Models.Domain
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public string InstagramUrl { get; set; }
        public string TelegramUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
