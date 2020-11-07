using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    class Account

    {

        private double balance;

        public double Balance

        {

            get { return balance; }

       

        }        public void Deposit(double amount)

        {

            balance += amount;

        }
        public void Withdraw(double amount)

        {

            balance -= amount;

        }

        public void Transfer(Account destination, double amount)

        {
            destination.Deposit(amount);
            Withdraw(amount);

        }



   }

}
