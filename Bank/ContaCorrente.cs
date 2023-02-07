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

        public void Deposit(double valor)
        {
            this.balance += valor;
        }

        public bool Withdraw(double valor)
        {
            if(this.balance>= valor)
            {
                this.balance -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
