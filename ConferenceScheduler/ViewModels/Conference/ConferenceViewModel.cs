namespace ConferenceScheduler.ViewModels.Conference
{
    using System;
    using ConferenceScheduler.Data.Models;

    public class ConferenceViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Venue Venue { get; set; }
    }
}
