using System;

using System.Collections.Generic;

namespace CUENTA_BANCARIA
{
    public class Account

    {
        public long Numero { get; set; }
        public List<Titular> ListaDeTitulares = new List<Titular>();
        public decimal Saldo { get; set; }

        public List<Operacion> ListaDeOperaciones {get; set; }

         public Account()
        {
            this.Saldo = 0;
            this.ListaDeTitulares = new List<Titular>();
            this.ListaDeOperaciones = new List<Operacion>();
        }

        public Account(long numero)
        {
            this.Numero = numero;
            this.Saldo = 0;
            this.ListaDeTitulares = new List<Titular>();
            this.ListaDeOperaciones = new List<Operacion>();
        }

        public virtual bool Retirar(decimal cantidad)
        {
            if (Saldo >= cantidad)
            {
                this.Saldo -= cantidad; //this.Saldo = this.Saldo - cantidad; 
                return true;
            }
            return false;
        }
        public virtual bool Depositar(decimal cantidad)
        {
            if (Saldo <= cantidad)
            {
                this.Saldo += cantidad;
                return true;
            }
            return false;
        }
    }
}