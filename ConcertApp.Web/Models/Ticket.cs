using System.ComponentModel.DataAnnotations;
using System;

namespace ConcertApp.Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfPeople { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }

        public Guid ConcertId { get; set; }
        public Concert? Concert { get; set; }
    }
}
