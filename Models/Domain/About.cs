using BWITCODE.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BWITCODE.Models.Domain
{
    public class About : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public string TelegramUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}