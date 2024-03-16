using PredictorUI.Models;
using static PredictorUI.Common.ResponseTypes;

namespace PredictorUI.Common
{
    public interface IDataServiceX
    {
        bool AuthenticateUser(string username, string password);
        int CreateNewMatch(MatchDetails details);
        Player GetPlayer(int id);
        List<Venue> GetVenues();
        RegistrationResponseTypes RegisterNewUser(string username, string password, string email);
        List<MatchDetails> SearchMatches(int? userId = null, int? venueId = null, DateTime? fromDate = null, DateTime? toDate = null);
        List<Player> SearchPlayers(string playerName, bool isBowler = false);
    }
}
