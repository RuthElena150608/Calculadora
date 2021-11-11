using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CalcularPrestamo
    {
        public double Monto { get; set; }
        public int TipoPrestamo { get; set; }

        public int CantidadMeses { get; set; }
        private int Tasa;

        public int ObtenerTasaInteres()
        {
            ITipoPrestamo tipoPrestamo = GetTipoPrestamo();
            int tasa = tipoPrestamo.TasaInteres;
            Tasa = tasa;
            return tasa;
        }

        private ITipoPrestamo GetTipoPrestamo()
        {
            switch (TipoPrestamo)
            {
                case (int)EnumTipoPrestamo.Persona:
                    return new TipoPersona();
                case (int)EnumTipoPrestamo.Automovil:
                    return new TipoAutomovil();
                case (int)EnumTipoPrestamo.Hipotecario:
                    return new TipoHipotecario();
            }
            return new TipoNoExistente();
        }

        public double ObtenerCuotas()
        {

            return (Monto + (Monto * (Tasa / 100))) / CantidadMeses;

        }
    }
}
