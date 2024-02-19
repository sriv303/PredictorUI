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
            DuplicateUser = 0,
            Failed = 1,
            Success = 2
        }
    }
}
