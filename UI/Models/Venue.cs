using Microsoft.Data.Sqlite;

namespace PredictorUI.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public string Country { get; set; }

        public string Profile => $"{Name} - {Country}";

        public Venue() { }
        public Venue(SqliteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
            LongName = reader.GetString(2);
            Country = reader.GetString(3);
        }
    }
}
