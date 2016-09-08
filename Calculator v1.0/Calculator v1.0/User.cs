using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0
{
    class User
    {
        private string _login;
        private string _password;

        public string login { get { return _login; } }
        public string password { get { return _password; } }

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

    }
}
