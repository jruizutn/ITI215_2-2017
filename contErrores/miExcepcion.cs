using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conErrores
{
    class miExcepcion : Exception {
        // constructor por defecto de Exception
        public miExcepcion() : base() { }

        // constructor por defecto de Exception
        public miExcepcion(String cadena):base(cadena){ }

    }
}
