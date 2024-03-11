using PredictorUI.Models;

namespace PredictorUI.Common
{
    public class MatchInputs
    {
        public List<string> TeamABatsmen { get; set; }
        public List<string> TeamABowlers { get; set; }
        public List<string> TeamBBatsmen { get; set; }
        public List<string> TeamBBowlers { get; set; }
        public string Venue { get; set; }
    }
}
