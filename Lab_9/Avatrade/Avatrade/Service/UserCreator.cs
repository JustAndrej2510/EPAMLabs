using Avatrade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Service
{
    class UserCreator
    {
        private static string _email = DataReader.GetTestSettings().user.Email;
        private static string _password = DataReader.GetTestSettings().user.Password;

        public static User WithCredentialsFromProperty()
        {
            return new User(_email, _password);
        }

        public static User WithEmptyEmail()
        {
            return new User("", _password);
        }

        public static User WithEmptyPassword()
        {
            return new User(_email, "");
        }
    }
}
