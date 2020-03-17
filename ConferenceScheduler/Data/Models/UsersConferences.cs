namespace ConferenceScheduler.Data.Models
{
    public class UsersConferences 
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
}
