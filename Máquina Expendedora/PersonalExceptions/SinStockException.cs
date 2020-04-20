using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExceptions
{
    public class SinStockException : Exception
    {
        public SinStockException() : base("No hay stock de la bebida seleccionada.")
        {

        }
    }
}
