namespace PredictorUI.Models
{
    public class BowlingStats
    {
        public string Player { get; }
        public decimal Overs { get; }

        public decimal BallsBowled { get; set; }
        public int InningsWickets { get; }
        public decimal RunsConceded { get; }

        public decimal EconomyRate => Math.Round(RunsConceded / BallsBowled * 6, 2);

        public BowlingStats(string player, decimal overs, int inningsWickets, int runsConceded, int ballsBowled)
        {
            Player = player;
            Overs = overs;
            InningsWickets = inningsWickets;
            RunsConceded = runsConceded;
            BallsBowled = ballsBowled;
        }
    }
}
