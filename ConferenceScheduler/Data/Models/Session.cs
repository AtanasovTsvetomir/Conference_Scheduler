namespace ConferenceScheduler.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Session
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public DateTime SessionStart { get; set; }

        [Required]
        public DateTime SessionEnd { get; set; }

        public int HallId { get; set; }
        public Hall Hall { get; set; }

        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}
