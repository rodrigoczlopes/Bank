using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CurrentAccount
    {
        public int agnumber;
        public string cont;
        public string holder;
        public double balance = 100;

        public void Deposit(double value)
        {
            this.balance += value;
        }

        public bool Withdraw(double value)
        {
            if(this.balance>= value)
            {
                this.balance -= value;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transfer(double value, CurrentAccount destiny)
        {
            if(this.balance<value)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
