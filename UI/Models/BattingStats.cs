namespace PredictorUI.Models
{
    public class BattingStats
    {
        public string Player { get; set; }
        public decimal Runs { get; }
        public decimal BallsFaced { get; set; }
        public bool IsOut { get; }
        public string? Bowler { get; }//which bowler got them out

        public decimal StrikeRate => BallsFaced == 0 ? 0 : Math.Round(Runs * 100 / BallsFaced, 2);

        public BattingStats()
        {

        }
        public BattingStats(string player, int runs, int ballsFaced, bool isOut, string? bowler)
        {
            Player = player;
            Runs = runs;
            BallsFaced = ballsFaced;
            IsOut = isOut;
            Bowler = bowler;
        }


    }
}
