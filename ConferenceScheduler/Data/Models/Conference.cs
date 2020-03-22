namespace ConferenceScheduler.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Conference
    {
        public Conference()
        {
            this.UsersConferences = new HashSet<UsersConferences>();
            this.Halls = new HashSet<Hall>();
            this.SpeakersConferences = new HashSet<SpeakersConferences>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int VenueId { get; set; }
        public Venue Venue { get; set; }

        public ICollection<SpeakersConferences> SpeakersConferences { get; set; }

        public ICollection<Hall> Halls { get; set; }

        public ICollection<UsersConferences> UsersConferences { get; set; }
    }
}
