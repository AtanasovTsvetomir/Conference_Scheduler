namespace ConferenceScheduler.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Speaker
    {
        public Speaker()
        {
            this.Sessions = new HashSet<Session>();
            this.SpeakersConferences = new HashSet<SpeakersConferences>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public string ImageName { get; set; }

        public ICollection<SpeakersConferences> SpeakersConferences { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
