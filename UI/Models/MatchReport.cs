namespace PredictorUI.Models
{
    public class MatchReport
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }
        public string VenueName { get; set; }
        public Innings TeamAInnings { get; set; }
        public Innings TeamBInnings { get; set; }
        public string Result
        {
            get
            {
                if (TeamAInnings.InningsTotal == TeamBInnings.InningsTotal) return "Match tied";

                string winner = TeamAInnings.InningsTotal > TeamBInnings.InningsTotal ? "Team A" : "Team B";
                string winMargin = winner == "Team A" ? $"{TeamAInnings.InningsTotal - TeamBInnings.InningsTotal} runs" : $"{10 - TeamBInnings.InningsWickets} wickets";

                return $"{winner} win by {winMargin}";
            }
        }
    }
}
