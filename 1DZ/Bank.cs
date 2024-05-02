using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    public class Bank
    {
        private List<User> users;

        public Bank()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public  void MakeATransaction(Transaction transaction)
        {
            transaction.MakeATransaction();
        }
    }
}
