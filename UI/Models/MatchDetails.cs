using Microsoft.Data.Sqlite;

namespace PredictorUI.Models
{
    public class MatchDetails
    {

        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public int UserId { get; set; }
        public int VenueId { get; set; }
        public string[] TeamABatsmen { get; set; }
        public string[] TeamABowlers { get; set; }
        public string[] TeamBBatsmen { get; set; }
        public string[] TeamBBowlers { get; set; }

        public MatchDetails() { 
        }
        public MatchDetails(SqliteDataReader reader)
        {
            Id = reader.GetInt32(0);
            MatchDate = reader.GetDateTime(1);
            UserId = reader.GetInt32(2);
            VenueId = reader.GetInt32(3);
            //TeamABatsmen = "";
            //TeamABowlers = "";
            //TeamBBatsmen = "";
            //TeamBBowlers = "";

        }
    }
}
