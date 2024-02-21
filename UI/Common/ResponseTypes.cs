using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictorUI.Common
{
    public class ResponseTypes
    {
        public enum RegistrationResponseTypes
        {
            DuplicateUsername = 0,
            DuplicateEmail = 1,
            Failed = 2,
            Success = 3
        }
    }
}
