namespace ConferenceScheduler.ViewModels.Conference
{
    using System;

    public class ConferenceCreateInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int VenueId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

    }
}
