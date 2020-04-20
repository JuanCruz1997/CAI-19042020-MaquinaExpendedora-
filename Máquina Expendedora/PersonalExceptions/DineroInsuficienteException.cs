using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExceptions
{
    public class DineroInsuficienteException : Exception
    {
        public DineroInsuficienteException() : base("El dinero ingresado no es suficiente para comprar la lata.")
        {

        }
    }
}
