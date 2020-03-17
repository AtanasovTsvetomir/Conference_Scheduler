namespace ConferenceScheduler.ViewModels.Hall
{
    public class HallCreateInputModel
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public VenueEnum Venue { get; set; }
    }
}
