namespace ConferenceScheduler.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Venue
    {
        public Venue()
        {
            this.Conferences = new HashSet<Conference>();
            this.Halls = new HashSet<Hall>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public ICollection<Conference> Conferences { get; set; }

        public ICollection<Hall> Halls { get; set; }
    }
}
