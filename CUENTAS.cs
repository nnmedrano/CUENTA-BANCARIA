using System;

using System.Collections.Generic;

public class Cuenta
{
    public int numeroDeCuenta;
    public List<Titular> ListaDeTitulares = new List<Titular>();
    public int saldo;

     public void depositar(decimal monto)
        {
           saldo = saldo + monto;
        }

        public virtual void retirar(decimal monto)
        {
          saldo = saldo - monto;
}