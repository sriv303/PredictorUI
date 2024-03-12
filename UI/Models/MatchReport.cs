namespace PredictorUI.Models
{
    public class MatchReport
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }
        public string VenueName { get; set; }
        public Innings TeamAInnings { get; set; }
        public Innings TeamBInnings { get; set; }
    }
}
