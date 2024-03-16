namespace PredictorUI.Models
{
    public class SharedData
    {
        public User User { get; set; }
        public int MatchId { get; set; }
        public WelcomeForm WelcomeForm { get; set; }
        public bool UserLoggedIn => User != null && User.Id > 0;
        public bool LastSimulationSuccess { get; set; }
    }
}
