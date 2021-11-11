using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class TipoAutomovil : ITipoPrestamo
    {
       public int TasaInteres { get; } = 12;
    }
}
