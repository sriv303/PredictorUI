using Microsoft.Data.Sqlite;
using PredictorUI.Common;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace PredictorUI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }

        public User(SqliteDataReader reader)
        {
            Id = reader.GetInt32(0);
            UserName = reader.GetString(1);
            Email = reader.GetString(2);
            Password = reader.GetString(3);
            IsAdmin=reader.GetBoolean(4);
        }
    }
}
