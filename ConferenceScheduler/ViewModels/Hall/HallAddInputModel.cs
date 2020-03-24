namespace ConferenceScheduler.ViewModels.Hall
{
    using ConferenceScheduler.Data.Models;

    public class HallAddInputModel
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int VenueId { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}
