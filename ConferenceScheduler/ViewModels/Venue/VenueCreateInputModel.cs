namespace ConferenceScheduler.ViewModels.Venue
{
    using System.Collections.Generic;

    using ConferenceScheduler.Data.Models;

    public class VenueCreateInputModel
    {
        public VenueCreateInputModel()
        {
            this.Conferences = new HashSet<Conference>();
            this.Halls = new HashSet<Hall>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Conference> Conferences { get; set; }

        public ICollection<Hall> Halls { get; set; }
    }
}
