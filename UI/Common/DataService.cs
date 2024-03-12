using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using PredictorUI.Models;
using System.Drawing;
using static PredictorUI.Common.ResponseTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PredictorUI.Common
{
    internal class DataService : IDataService
    {

        private readonly string connectionString = @"Data Source=C:\Users\Abhi\Documents\Schoolwork\Computer Science\ScorePredictor\PredictorUI\Database\CricketPredictorDB.db;";
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var query = "SELECT COUNT(1) FROM USERACCOUNTS WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD";

                    var selectCommand = new SqliteCommand(query, conn);
                    selectCommand.Parameters.AddWithValue("@USERNAME", username);
                    selectCommand.Parameters.AddWithValue("@PASSWORD", password.Encrypt());

                    var result = selectCommand.ExecuteScalar();

                    conn.Close();

                    return result != null && (long)result == 1;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public RegistrationResponseTypes RegisterNewUser(string username, string password, string email)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    // You can execute SQL commands here using SQLiteCommand
                    var userExistQuery = "SELECT COUNT(1) FROM USERACCOUNTS WHERE USERNAME=@USERNAME;";
                    var userSelectCommand = new SqliteCommand(userExistQuery, conn);
                    userSelectCommand.Parameters.AddWithValue("@USERNAME", username);
                    var userResult = userSelectCommand.ExecuteScalar();

                    if (userResult == null || (long)userResult > 0)
                    {

                        conn.Close();
                        return RegistrationResponseTypes.DuplicateUsername;
                    }

                    var emailExistQuery = "SELECT COUNT(1) FROM USERACCONTS WHERE EMAIL = @EMAIL";
                    var emailSelectCommand = new SqliteCommand(emailExistQuery, conn);
                    emailSelectCommand.Parameters.AddWithValue("@EMAIL", email);
                    var emailResult = emailSelectCommand.ExecuteScalar();
                    if (emailResult == null || (long)emailResult > 0)
                    {
                        conn.Close();
                        return RegistrationResponseTypes.DuplicateEmail;
                    }


                    //insert new user account into database//
                    var insertQuery = "INSERT INTO USERACCOUNTS VALUES (NULL, @USERNAME, @PASSWORD, @EMAIL)";
                    var insertCommand = new SqliteCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@USERNAME", username);
                    insertCommand.Parameters.AddWithValue("@PASSWORD", password.Encrypt());
                    insertCommand.Parameters.AddWithValue("@EMAIL", email);
                    insertCommand.ExecuteNonQuery();
                    conn.Close();
                    return RegistrationResponseTypes.Success;
                }
            }
            catch (Exception)
            {
                return RegistrationResponseTypes.Failed;
            }
        }

        public List<Player> SearchPlayers(string playerName, bool isBowler = false)
        {
            var players = new List<Player>();

            if (!string.IsNullOrEmpty(playerName) && playerName.Length < 2) return players;

            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var query = $"SELECT id,name,country,isBatsman,isBowler FROM PLAYERS WHERE 1 = 1 ";

                    if (!string.IsNullOrEmpty(playerName))
                    {
                        query += $" AND NAME LIKE '%{playerName}%'";
                    }
                    if (isBowler)
                    {
                        query += " AND ISBOWLER = 1";
                    }

                    var selectCommand = new SqliteCommand(query, conn);

                    var reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        players.Add(new Player(reader));
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in player search", ex);
            }

            return players;
        }

        public Player GetPlayer(int id)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var query = $"SELECT id,name,country,isBatsman,isBowler FROM PLAYERS WHERE Id = @playerId";

                    var selectCommand = new SqliteCommand(query, conn);

                    selectCommand.Parameters.AddWithValue("@playerId", id);


                    var reader = selectCommand.ExecuteReader();

                    if (!reader.Read()) throw new InvalidOperationException("No records were returned.");

                    var player = new Player(reader);

                    conn.Close();

                    return player;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in retrieving player", ex);
            }
        }

        public List<Venue> GetVenues()
        {
            var venues = new List<Venue>();
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var query = $"SELECT id, name, longName, country FROM venues";


                    var selectCommand = new SqliteCommand(query, conn);

                    var reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        venues.Add(new Venue(reader));
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in venue search", ex);
            }

            return venues;
        }

        public int CreateNewMatch(MatchDetails details)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    //insert new user account into database//
                    var insertQuery = "INSERT INTO MatchDetails (id,matchDate,userId,venueId,teamABatsmen,teamABowlers,teamBBatsmen,teamBBowlers) " +
                "VALUES (NULL, @matchDate, @userId, @venueId, @teamABatsmen, @teamABowlers ,@teamBBatsmen, @teamBBowlers)";

                    var insertCommand = new SqliteCommand(insertQuery, conn);

                    insertCommand.Parameters.AddWithValue("@matchDate", DateTime.Now.ToString("G"));
                    insertCommand.Parameters.AddWithValue("@userId", details.UserId);
                    insertCommand.Parameters.AddWithValue("@venueId", details.VenueId);
                    insertCommand.Parameters.AddWithValue("@teamABatsmen", SerialisePlayers(details.TeamABatsmen));
                    insertCommand.Parameters.AddWithValue("@teamABowlers", SerialisePlayers(details.TeamABowlers));
                    insertCommand.Parameters.AddWithValue("@teamBBatsmen", SerialisePlayers(details.TeamBBatsmen));
                    insertCommand.Parameters.AddWithValue("@teamBBowlers", SerialisePlayers(details.TeamBBowlers));

                    insertCommand.ExecuteNonQuery();

                    var idCommand = conn.CreateCommand();
                    idCommand.CommandText = "SELECT last_insert_rowid()";
                    int lastId = Convert.ToInt32(idCommand.ExecuteScalar());
                    conn.Close();
                    return lastId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in creating new matchDetails record", ex);
            }

        }

        public List<MatchDetails> SearchMatches(int? userId, int? venueId, DateTime? fromDate, DateTime? toDate)
        {
            var matches = new List<MatchDetails>();
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    var selectQuery = "SELECT a.id,matchDate,userId,venueId,teamABatsmen,teamABowlers,teamBBatsmen,teamBBowlers, scoreCard,b.name, b.longName, b.country " +
                                        "FROM MatchDetails a inner join Venues b on a.venueId = b.Id where 1=1";

                    var searchCommand = new SqliteCommand();


                    if (userId.HasValue)
                    {
                        selectQuery += " and userId = @userId";
                        searchCommand.Parameters.AddWithValue("@userId", userId);
                    }
                    if (venueId.HasValue)
                    {
                        selectQuery += " and venueId = @venueId";
                        searchCommand.Parameters.AddWithValue("@venueId", venueId);
                    }

                    if (fromDate.HasValue)
                    {
                        selectQuery += " and date(matchDate) >= @fromDate";
                        searchCommand.Parameters.AddWithValue("@fromDate", fromDate.Value.ToShortDateString());
                    }

                    if (toDate.HasValue)
                    {
                        selectQuery += " and date(matchDate) <= @toDate";
                        searchCommand.Parameters.AddWithValue("@toDate", toDate.Value.ToShortDateString());
                    }

                    searchCommand.Connection = conn;
                    searchCommand.CommandText = selectQuery;

                    var reader = searchCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        matches.Add(new MatchDetails(reader));
                    }

                    conn.Close();
                    return matches;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in searching matchDetails records", ex);
            }

        }

        public string SerialisePlayers(string[] players)
        {
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;

            return JsonConvert.SerializeObject(players);
        }
    }
}
