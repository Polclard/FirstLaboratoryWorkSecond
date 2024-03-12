using System.ComponentModel.DataAnnotations;

namespace ConcertApp.Web.Models
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }
        public string? ConcertName { get; set; }
        [Required]
        public DateTime? ConcertDate { get; set; }
        [Required]
        public float? ConcertPrice { get; set; }
        [Required]
        public string? ConcertPlace { get; set; }
        public string? ConcertImage { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
