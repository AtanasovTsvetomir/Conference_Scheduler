namespace ConferenceScheduler.Data.Models
{
    public class SpeakersConferences
    {
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}
