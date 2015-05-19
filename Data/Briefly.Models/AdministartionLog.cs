namespace Briefly.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AdministartionLog
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public string IpAddress { get; set; }

        public string RequestType { get; set; }

        public string Url { get; set; }

        public virtual User User { get; set; }

    }
}
