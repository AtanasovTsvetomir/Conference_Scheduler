namespace ConferenceScheduler.ViewModels.Hall
{
    using ConferenceScheduler.Data.Models;

    public class HallViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int VenueId { get; set; }
        public Venue Venue { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}
