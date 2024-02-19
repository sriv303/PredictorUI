using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PredictorUI.Common.ResponseTypes;

namespace PredictorUI.Common
{
    public interface IDataService
    {
        bool AuthenticateUser(string username, string password);
        RegistrationResponseTypes RegisterNewUser(string username, string password, string email);
    }
}
