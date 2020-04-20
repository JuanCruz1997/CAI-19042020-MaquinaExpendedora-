using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExceptions
{
    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException() : base("La máquina está llena. No pueden agregarse nuevas latas.")
        {

        }
    }
}
