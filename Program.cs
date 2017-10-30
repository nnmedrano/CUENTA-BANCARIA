using System;

namespace CUENTA_BANCARIA
{
    class Program
    {
        static bool Main(string[] args)
        {
            Console.WriteLine("Cuentas");
            Titular Julian = new Titular();
            Julian.Nombre = "Julian";
            Julian.DNI = 38465233;
            Julian.Mail = "nnmedrano@gmail.com";
            Julian.FechaDeNacimiento = new DateTime(1994,07,08);

            Cuenta cuenta1 = new Cuenta();
            cuenta1.Numero = 233156799090;
            cuenta1.Saldo = 0;
            cuenta1.Titular = Julian;

           if(cuenta1.Depositar(4000))
           {
               Console.WriteLine("Operacion Ok");
           }
           if(cuenta1.Retirar(200))
           {
               Console.WriteLine("Operacion Ok");
           }
            Console.WriteLine("La cuenta tiene un saldo:" + cuenta1);
            
        }
    }
}
