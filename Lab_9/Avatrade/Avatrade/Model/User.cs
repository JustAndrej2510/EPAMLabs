using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Model
{
    public class User
    {
        private string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public User() { }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(typeof(User).IsInstanceOfType(obj))) return false;
            User user = (User)obj;

            return Equals(Email, user.Email) &&
                Equals(Password, user.Password);
        }

        public override string ToString()
        {
            return $"User\nEmail: {Email}; Password: {Password};";
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode() + Password.GetHashCode();
        }
    }
}
