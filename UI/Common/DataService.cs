using Microsoft.Data.Sqlite;
using PredictorUI.Models;
using static PredictorUI.Common.ResponseTypes;


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

                    if(!string.IsNullOrEmpty(playerName)) 
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


        //public Player MapPlayer(SqliteDataReader reader)
        //{
        //    return new Player
        //    {
        //        Id = reader.GetInt32(0),
        //        Name = reader.GetString(1),
        //        Country = reader.GetString(2),
        //        IsBatsman = reader.GetBoolean(3),
        //        IsBowler = reader.GetBoolean(4)
        //    };
        //}
    }
}
