﻿namespace ConferenceScheduler.ViewModels.Hall
{
    using ConferenceScheduler.Data.Models;

    public class HallAddInputModel
    {
        public int VenueId { get; set; }
        public Venue Venue { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}
