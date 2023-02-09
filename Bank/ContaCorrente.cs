using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ContaCorrente
    {
        public int numeroagencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo <valor)
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
