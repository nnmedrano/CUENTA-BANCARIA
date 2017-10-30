using System;

using System.Collections.Generic;

namespace CUENTA_BANCARIA
{
public class Account

{
    public long Numero {get; set;}
    //public List<Titular> ListaDeTitulares = new List<Titular>();//
    public Titular titular1 {get; set;}
    public decimal Saldo {get; set;}

    public virtual bool Retirar(decimal cantidad)
        {
            if(Saldo >=cantidad)
            {
               this.Saldo -=cantidad; //this.Saldo = this.Saldo - cantidad; 
               return true; 
            }
            return false;
        } 
    public virtual bool Depositar(decimal cantidad)
        {
           if(Saldo <= cantidad)
           {
               this.Saldo += cantidad;
               return true;
           }
           return false;
        }
}
}