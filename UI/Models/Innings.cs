using System.Linq;

namespace PredictorUI.Models
{
    public class Innings
    {
        public List<Over> Overs { get; set; }

        public List<string> Team { get; set; }
        public int InningsTotal => Overs.SelectMany(o => o.Balls).Sum(o => o.RunsScored);
        public int InningsWickets => Overs.SelectMany(o => o.Balls).Where(b => b.IsWicket).Count();
        public decimal OversCount => CalculateOvers(Overs.SelectMany(o => o.Balls).Count());
        public IEnumerable<BattingStats> BattingCard
        {
            get
            {
                var batters = Overs.SelectMany(o => o.Balls).GroupBy(p => p.Striker).Select(p => new BattingStats(
                                                                        p.Key,
                                                                        p.Sum(b => b.RunsScored),
                                                                        p.Count(),
                                                                        p.Any(b => b.IsWicket),
                                                                        p.FirstOrDefault(b => b.IsWicket)?.Bowler)).ToList();

                var unPlayed = Team.Except(batters.Select(b => b.Player));

                batters.AddRange(unPlayed.Select(p => new BattingStats(p, 0, 0, false, null)));

                return batters;
            }
        }

        public IEnumerable<BowlingStats> BowlingCard => Overs.SelectMany(o => o.Balls).GroupBy(p => p.Bowler).Select(p => new BowlingStats(
                                                                        p.Key,
                                                                        CalculateOvers(p.Count()),
                                                                        p.Count(b => b.IsWicket),
                                                                        p.Sum(b => b.RunsScored),
                                                                        p.Count()));


        private static decimal CalculateOvers(int balls)
        {
            var overs = balls / 6;
            var b = (decimal)(balls - overs * 6) / 10;

            return overs + b;
        }

    }
}
