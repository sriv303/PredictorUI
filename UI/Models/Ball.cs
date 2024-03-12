using Newtonsoft.Json;

namespace PredictorUI.Models
{
    public class Ball
    {

        [JsonProperty("over_number")]
        public int OverNumber { get; set; }
        [JsonProperty("ball_number")]
        public int BallNumber { get; set; }
        [JsonProperty("striker")]
        public string Striker { get; set;}
        [JsonProperty("bowler")]
        public string Bowler { get; set; }
        [JsonProperty("runs_scored")]
        public int RunsScored { get; set; }
        [JsonProperty("is_wicket")]
        public bool IsWicket { get; set; }
        [JsonProperty("innings")]
        public int Innings { get; set; }
    }
}
