using PredictorUI.Models;
using static PredictorUI.Common.ResponseTypes;

namespace PredictorUI.Common
{
    public interface IDataService
    {
        bool AuthenticateUser(string username, string password);
        Player GetPlayer(int id);
        List<Venue> GetVenues();
        RegistrationResponseTypes RegisterNewUser(string username, string password, string email);
        List<Player> SearchPlayers(string playerName, bool isBowler = false);
    }
}
