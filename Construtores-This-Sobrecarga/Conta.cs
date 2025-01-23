using System;
using System.Collections.Generic;

namespace Course
{
    internal class Conta
    {
        public int Id { get; private set; } 
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta (int id, string titular)
        {
            Id = id;
            Titular = titular;
        }

        public Conta (int id, string titular, double saldo) : this (id, titular)
        {
            Saldo = saldo;
        }

       public double depositoInicial(double depositoI)
        {
            return depositoI;
        }
        
        public void AddSaldo(double valor)
        {
            Saldo += valor;
        }

        public void RemoveSaldo(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Id + ", Titular: " + Titular + ", Saldo: R$" + Saldo;
        }

    }
}
