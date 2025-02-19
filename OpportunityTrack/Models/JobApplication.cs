namespace OpportunityTrack.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string SkillsRequired { get; set; }
        public DateTime DateApplied { get; set; }
        public bool FollowedUp { get; set; }
    }
}

