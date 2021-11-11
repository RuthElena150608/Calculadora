using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    public class Operaciones
    {
        public double NumeroUno { get; set; }
        public double NumeroDos { get; set; }
        public string Operacion { get; set; }

        public (double, bool) Calcular()
        {

            switch (Operacion)
            {
                case "+":
                    Suma suma = new Suma();
                    return (suma.Calcular(NumeroUno, NumeroDos), false);

                case "-":
                    Resta resta = new Resta();
                    return (resta.Calcular(NumeroUno, NumeroDos), false);

                case "*":
                    Multiplicar mult = new Multiplicar();
                    return (mult.Calcular(NumeroUno, NumeroDos), false);

                case "/":
                    Dividir div = new Dividir();
                    double result = div.Calcular(NumeroUno, NumeroDos);
                    if (Double.IsInfinity(result))
                    {

                        return (0, true);
                    }
                    else
                        return (result, false);
                default:
                    return (0, false);
            }

        }

        public Operaciones()
        {

        }
        public Operaciones(double numeroUno, double numeroDos, string operacion)
        {
            NumeroUno = numeroUno;
            NumeroDos = numeroDos;
            Operacion = operacion;
        }
    }
}
