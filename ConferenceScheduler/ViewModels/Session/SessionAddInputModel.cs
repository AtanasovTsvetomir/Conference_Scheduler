namespace ConferenceScheduler.ViewModels.Session
{
    using System;

    using ConferenceScheduler.Data.Models;

    public class SessionAddInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }
    }
}
