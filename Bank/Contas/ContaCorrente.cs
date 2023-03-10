using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Titular;

namespace Bank.Contas
{
    public class ContaCorrente
    {
        public int numeroagencia;
        public string conta;
        private double saldo = 100;

        public Cliente titular;


        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void DefinirSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
    }
}
