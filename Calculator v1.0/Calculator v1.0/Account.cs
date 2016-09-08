using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0
{
    class Account
    {
        public User user;
        public double money;
        public string status; //object status

        public Account(User user, double money)
        {
            this.user = user;
            this.money = money;
            status = "new_user";
        }
    }
}
