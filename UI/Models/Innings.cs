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

        //adding batting statistics, defining battingstats as enum
        public IEnumerable<BattingStats> BattingCard
        {
            get
            {
                //instantiating batter statistcs while looking through all balls filtering on striker
                var batters = Overs.SelectMany(o => o.Balls).GroupBy(p => p.Striker).Select(p => new BattingStats(
                                                                        p.Key,
                                                                        p.Sum(b => b.RunsScored),//sum runs scored
                                                                        p.Count(),//balls faced
                                                                        p.Any(b => b.IsWicket),//boolean if wicket
                                                                        p.FirstOrDefault(b => b.IsWicket)?.Bowler)).ToList();//convert bowler and iswicket to combined string
                                                                                                                             //bowler null when no wicket has fallen

                var unPlayed = Team.Except(batters.Select(b => b.Player));//getting players who didnt bat

                batters.AddRange(unPlayed.Select(p => new BattingStats(p, 0, 0, false, null)));//adding 0/null values for players who didnt bat inside data grid view

                return batters;
            }
        }

        //adding bowler statistics, defining bowling stats as enum
        public IEnumerable<BowlingStats> BowlingCard => Overs.SelectMany(o => o.Balls).GroupBy(p => p.Bowler).Select(p => new BowlingStats(
                                                                        p.Key,
                                                                        CalculateOvers(p.Count()),//overs bowled
                                                                        p.Count(b => b.IsWicket),//number of wickets
                                                                        p.Sum(b => b.RunsScored),//runs conceded
                                                                        p.Count()));//balls bowled


        private static decimal CalculateOvers(int balls)
            //calculates no. overs from total number of balls
        {
            var overs = balls / 6;
            var b = (decimal)(balls - overs * 6) / 10;

            return overs + b;
        }

    }
}
