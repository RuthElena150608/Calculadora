using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class TipoNoExistente : ITipoPrestamo
    {
        public int TasaInteres => 0;
    }
}
