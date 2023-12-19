using System;
using System.Globalization;

namespace Exercicio
{
    internal class ContaBancaria
    {
        private double _desconto = 5.00;
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }
        public ContaBancaria (int numConta, string nome, double depositoInicial) : this(numConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= valor + _desconto;
        }

        public override string ToString()
        {
            return $"Conta {NumConta}," +
                $"Titular: {Nome}, " +
                $"Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
            
        }
    }
}
