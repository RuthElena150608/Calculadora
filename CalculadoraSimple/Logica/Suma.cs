using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Logica
{
    public class Suma : IOperacion
    {

        public double Calcular(double NumeroUno, double NumeroDos)
        {
            return NumeroUno + NumeroDos;
        }
    }
}
