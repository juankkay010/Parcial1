using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reto1
{
    abstract class Verificador:Cargar
    {
        public List<string[]> invitados = new List<string[]>();
        public Verificador()
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
        public int Es_mayor_de_18(string id)
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
                            return edad;
                        }
                        else
                        {
                            return edad;
                        }
                    }
                }
            }
            return -1;
        }

        public string validar_correo(string id)
        {
            if (!this.Si_esta_en_invitados(id))
            {
                return null;
            }

            foreach (string[] invitado in invitados)
            {
                if (invitado.Contains(id))
                {
                    char first_letter = invitado[2][0];
                    if (char.IsLetter(first_letter))
                    {
                        int posicion_conector = invitado[2].IndexOf("@");
                        if (posicion_conector >= 0)
                        {
                            string slice = invitado[2].Substring(posicion_conector + 1);
                            if (slice.Contains("gmail") || slice.Contains("hotmail") || slice.Contains("live"))
                            {
                                if (invitado[2].EndsWith(".com") || invitado[2].EndsWith(".co") || invitado[2].EndsWith(".edu.co") || invitado[2].EndsWith(".org"))
                                {
                                    return invitado[2];
                                }
                            }
                        }
                    }
                }
            }
            return null; 
        }
    }
}


