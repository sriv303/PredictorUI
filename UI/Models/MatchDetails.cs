using Microsoft.Data.Sqlite;

namespace PredictorUI.Models
{
    public class MatchDetails
    {

        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int VenueId { get; set; }
        public string[] TeamABatsmen { get; set; }
        public string[] TeamABowlers { get; set; }
        public string[] TeamBBatsmen { get; set; }
        public string[] TeamBBowlers { get; set; }
        public string ScoreCard { get; set; }
        public string StrTeamABatsmen { get; set; }
        public string StrTeamABowlers { get; set; }
        public string StrTeamBBatsmen { get; set; }
        public string StrTeamBBowlers { get; set; }
        public Venue Venue { get; set; }
        public string VenueName => Venue.Name;
        public MatchDetails()
        {
        }
        public MatchDetails(SqliteDataReader reader)
        {
            Id = reader.GetInt32(0);
            MatchDate = DateTime.Parse(reader.GetString(1));
            UserId = reader.GetInt32(2);
            VenueId = reader.GetInt32(3);
            StrTeamABatsmen = reader.GetString(4);
            StrTeamABowlers = reader.GetString(5);
            StrTeamBBatsmen = reader.GetString(6);
            StrTeamBBowlers = reader.GetString(7);
            ScoreCard = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
            Venue = new Venue
            {
                Id = reader.GetInt32(3),
                Name = reader.GetString(9),
                LongName = reader.GetString(10),
                Country = reader.GetString(11)
            };
            UserName = reader.GetString(12);
        }
    }
}
