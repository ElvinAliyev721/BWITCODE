using BWITCODE.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace BWITCODE.Models.Domain
{
    public class Work : BaseEntity
    {
        public string WorkTitle { get; set; }
        public string WorkList { get; set; }
        public byte[] WorkIcon { get; set; }
        public bool WorkStatus { get; set; }
    }
}
