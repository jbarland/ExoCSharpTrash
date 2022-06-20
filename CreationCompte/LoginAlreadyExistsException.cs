using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationCompte
{
    public class LoginAlreadyExistsException: Exception
    {
        public LoginAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
