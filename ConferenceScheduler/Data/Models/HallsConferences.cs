namespace ConferenceScheduler.Data.Models
{
    public class HallsConferences
    {
        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }
    }
}
