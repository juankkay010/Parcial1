using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Verificador_txt:Verificador
    {
        public Verificador_txt()
        {
            string file = @"C:\Users\juana\source\repos\RETO2\Taller_herencia.txt";
            this.cargar_archivo(file);
            foreach (string invitado in informacion)
            {
                string[] lista_invitados = invitado.Split();
                invitados.Add(lista_invitados);
            }
        }
    }
}
