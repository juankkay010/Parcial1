using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class ArchivoNoEncontrado: Exception
    {
        public ArchivoNoEncontrado(): base("No se ha encontrado el archivo")
        {
        }
    }
}
