using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExceptions
{
    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException():base("El código ingresado no es válido.")
        {

        }
    }
}
