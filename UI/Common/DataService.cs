using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using PredictorUI.Models;
using static PredictorUI.Common.ResponseTypes;


namespace PredictorUI.Common
{
    internal class DataService
    {

        private readonly string connectionString = @"Data Source=C:\Users\Abhi\Documents\Schoolwork\Computer Science\ScorePredictor\PredictorUI\Database\CricketPredictorDB.db;";
        public User? AuthenticateUser(string username, string password)
        {
            User? user = null;
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    var query = "SELECT id, userName, email, password, isAdmin FROM USERACCOUNTS WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD";

                    var selectCommand = new SqliteCommand(query, conn);
                    selectCommand.Parameters.AddWithValue("@USERNAME", username);
                    selectCommand.Parameters.AddWithValue("@PASSWORD", password.Encrypt());


                    //read output from sql query as iterable
                    var reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        //adding property to user for every item in iterable
                        user = new User(reader);
                    }
                    conn.Close();

                    //returning user item
                    return user;
                }
            }
            catch
            {
                throw;
            }
        }

        public RegistrationResponseTypes RegisterNewUser(string username, string password, string email)
        {
            try
            {

                //Register new user and return success/which error has occurred.
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    // Defining queries
                    var userExistQuery = "SELECT COUNT(1) FROM USERACCOUNTS WHERE USERNAME=@USERNAME;";
                    var userSelectCommand = new SqliteCommand(userExistQuery, conn);
                    userSelectCommand.Parameters.AddWithValue("@USERNAME", username);
                    var userResult = userSelectCommand.ExecuteScalar();
                    //Executing queries

                    if (userResult == null || (long)userResult > 0)
                    {
                        //Checking if username already in database
                        conn.Close();
                        return RegistrationResponseTypes.DuplicateUsername;
                    }

                    var emailExistQuery = "SELECT COUNT(1) FROM USERACCOUNTS WHERE EMAIL = @EMAIL";
                    var emailSelectCommand = new SqliteCommand(emailExistQuery, conn);
                    emailSelectCommand.Parameters.AddWithValue("@EMAIL", email);
                    var emailResult = emailSelectCommand.ExecuteScalar();
                    if (emailResult == null || (long)emailResult > 0)
                    {
                        //Checking if email already in database
                        conn.Close();
                        return RegistrationResponseTypes.DuplicateEmail;
                    }


                    //insert new user account into database//
                    var insertQuery = "INSERT INTO USERACCOUNTS VALUES (NULL, @USERNAME, @PASSWORD, @EMAIL, 0)";
                    var insertCommand = new SqliteCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@USERNAME", username);
                    insertCommand.Parameters.AddWithValue("@PASSWORD", password.Encrypt());
                    insertCommand.Parameters.AddWithValue("@EMAIL", email);
                    //Adding params
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
            //Searches all players and retrieves player matching autocomplete criteria
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
            //Gets list of all venues from database, with country and ids
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

        public MatchDetails? GetMatchDetails(int matchId)
        {
            MatchDetails? matchDetails = null;
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    var selectQuery = "SELECT a.id,matchDate,userId,venueId,teamABatsmen,teamABowlers,teamBBatsmen,teamBBowlers, scoreCard,b.name, b.longName, b.country, c.userName " +
                                        "FROM MatchDetails a inner join Venues b on a.venueId = b.Id " +
                                        "inner join userAccounts c on c.Id = a.userId where a.Id = @matchId";

                    var searchCommand = new SqliteCommand();

                    searchCommand.Parameters.AddWithValue("@matchId", matchId);

                    searchCommand.Connection = conn;
                    searchCommand.CommandText = selectQuery;

                    var reader = searchCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        matchDetails = new MatchDetails(reader);
                    }

                    conn.Close();
                    return matchDetails;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting match Details for {matchId}", ex);
            }

        }

        public List<MatchDetails> SearchMatches(User user, int? venueId = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var matches = new List<MatchDetails>();
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    var selectQuery = "SELECT a.id,matchDate,userId,venueId,teamABatsmen,teamABowlers,teamBBatsmen,teamBBowlers, scoreCard,b.name, b.longName, b.country, c.userName " +
                                        "FROM MatchDetails a inner join Venues b on a.venueId = b.Id " +
                                        "inner join userAccounts c on c.Id = a.userId where 1 = 1";

                    var searchCommand = new SqliteCommand();


                    if (!user.IsAdmin)
                    {
                        selectQuery += " and userId = @userId";
                        searchCommand.Parameters.AddWithValue("@userId", user.Id);
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
