using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Verificador_txt:Cargar
    {
        public List<string[]> invitados= new List<string[]>();
        public Verificador_txt(string path): base(path)
        {
            foreach (string invitado in informacion)
            {
                string[] lista_invitados = invitado.Split();
                invitados.Add(lista_invitados);
            }
             
        }

        public bool Si_esta_en_invitados(string id)
        {
            bool estaEnLista = invitados.Exists(x => x[1].Equals(id));
            if (estaEnLista)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool Es_mayor_de_18(string id)
        {
            foreach (string[] invitado in invitados)
            {
                if (this.Si_esta_en_invitados(id))
                {
                    if (invitado.Contains(id))
                    {
                        int edad;
                        if (int.TryParse(invitado[3], out edad) && edad >= 18)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

    }
    
}
