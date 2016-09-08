using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1._0
{
    class Billing
    {
        //Objects

        //1.User

        public Billing(User user)
        {

        }

        //user_new (string login, string password)

            //login - user login
            //password - user password
            //return new user 
            //(or null if user not created)
        public User user_new(string login, string password)
        {
            User new_user = new User(login, password);
            Account new_account = new Account(new_user, 0);
            accounts.Add(new_account);
            return new_user;
        }

        //user_delete (User user)

            //delete user account
            //return true
            //(or false if account not deleted)
        public bool user_delete(User user)
        {
            foreach(Account current_account in accounts)
            {
                if (current_account.user.login == user.login && current_account.user.password == user.password)
                {
                    accounts.Remove(current_account);
                    return true;
                }
            }
            return false;
        }

        //user_handlers

        //user_Pay

            //User - user information for search account
            //money - money to account
            //ratourn in money
            //(or zero if account not find)
        public double user_pay(User user, double money)
        {
            Account current_account = search_user_account(user);
            if (current_account == null)
                return 0;

            current_account.money += money;
            return money;
        }

        //user_calculating

        //User - user information for search account
        //operation - operation id
        //return operation price
        //(or zero if account not find)
        //(chenge user status to blocked)
        double user_calculating(User user, int operation)
        {
            Account current_account = search_user_account(user);
            if (current_account == null)
                return 0;

            double value = money_operation[operation];

            if (value > current_account.money)
            {
                return 0;
                current_account.status = "blocked"; // !!!
            }

            current_account.money -= value;
            return value;
        }

        //user_blocked
        bool user_blocked(User user)
        {
            Account current_account = search_user_account(user);
            if (current_account == null)
                return false;
            if (current_account.status == "blocked")
                return true;
            return false;
        }

        //----------------------------------------------------------------------------------------------------

        //object_state_structures (OSS)

        //user, money, count_operation, status

        //interface_state_structure (ISS)

        //External data

        //int get_user_history(User user)

        //relation_state_structures (RSS)

        //rules of relation
        //($ <-> operation, $ <-> status, operation <-> status, $ <-> user, ...)
        //dictionary

        private Dictionary<bool, string> accaunt_status = new Dictionary<bool, string>
        {
            { true, "you have money" },
            { false, "zero" }
        };

        private Dictionary<double, int> money_operation = new Dictionary<double, int>
        {
            { 1, 1 },
            { 1, 2 },
            { 2, 3 },
            { 2, 4 },
            { 3, 5 },
            { 3, 6 }
        };

        private List<Account> accounts = new List<Account>();

            //search user account
            //user - user for search
            //return user account
            //(or null if account not find)
        private Account search_user_account(User user)
        {
            foreach(Account current_account in accounts)
            {
                if (current_account.user.login == user.login || current_account.user.password == user.pass)
                {
                    return current_account;
                }
            }
            return null;
        }
        
        //list of Account + users and money



    }
}
