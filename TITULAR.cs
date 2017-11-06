using System;

namespace CUENTA_BANCARIA
{
    public class Titular
    {
        public string Nombre { get; set; }
        public long DNI { get; set; }
        public string Mail { get; set; }
        private int Telefono { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
    }
}