namespace ConferenceScheduler.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Hall
    {
        public Hall()
        {
            this.Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Capacity { get; set; }

        public int? ConferenceId { get; set; }
        public Conference Conference { get; set; }

        public int? VenueId { get; set; }
        public Venue Venue { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
