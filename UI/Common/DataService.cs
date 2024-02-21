using Microsoft.Data.Sqlite;
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
                    var existQuery = "SELECT COUNT(1) FROM USERACCOUNTS WHERE USERNAME=@USERNAME OR EMAIL = @EMAIL";
                    var selectCommand = new SqliteCommand(existQuery, conn);
                    selectCommand.Parameters.AddWithValue("@USERNAME", username);
                    selectCommand.Parameters.AddWithValue("@EMAIL", email);
                    var result = selectCommand.ExecuteScalar();

                    if (result == null || (long)result > 0)
                    {

                        conn.Close();
                        return RegistrationResponseTypes.DuplicateUser;
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
            catch (Exception ex)
            {
                return RegistrationResponseTypes.Failed;
            }
        }

    }
}
