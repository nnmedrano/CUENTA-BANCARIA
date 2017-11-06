using System;

namespace CUENTA_BANCARIA
{
    public class CUENTACORRIENTE : Account
    {
        public CUENTACORRIENTE() : base()
        {
        }
        public CUENTACORRIENTE(long numero) : base(numero)
        {
        }

    public override bool Retirar(decimal cantidad)
    {
        this.Saldo -= cantidad;
        this.ListaDeOperaciones.Add(new Operacion { Saldo = -1 * cantidad, Fecha = DateTime.Now, Tipo = "Extracción" });
        return true;
    }

}
}