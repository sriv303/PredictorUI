using Microsoft.Data.Sqlite;

namespace PredictorUI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public bool IsBatsman { get; set; }
        public bool IsBowler { get; set; }
        public bool IsAllrounder => IsBatsman && IsBowler;
        public string PlayerType {
            get
            {
                var profile = "";

                if (IsAllrounder) profile += "Allrounder";
                else if (IsBatsman) profile += "Batsman";
                else profile += "Bowler";

                return profile;
            }
        }
        public string PlayerProfile => $"{Name} ({Country}) {PlayerType}";
        public Player()
        {
        }
        public Player(SqliteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
            Country = reader.GetString(2);
            IsBatsman = reader.GetBoolean(3);
            IsBowler = reader.GetBoolean(4);
        }
    }
}
