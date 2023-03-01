using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Reto1
{
    internal class Program
    {
        public static void Main(string[] args)
        {  
            Verificador_csv verificador = new Verificador_csv();
            while(true)
            {
                Console.WriteLine("Ingrese el ID que desea buscar (o 0 para salir): ");
                string id = Console.ReadLine();
                int edad = verificador.Es_mayor_de_18(id);
                string email = verificador.validar_correo(id);
                if (id == "0")
                {
                    break;
                }
                if (verificador.Si_esta_en_invitados(id))
                {
                    if (verificador.Es_mayor_de_18(id) >= 18)
                    {
                        if (verificador.validar_correo(id) != null)
                        { 
                            Console.WriteLine("La persona con el ID {0} se encuentra en la lista, tiene una edad de {1}, y su correo {2} es válido, por lo que podrá ingresar", id, edad, email);
                        }
                        else
                        {
                            Console.WriteLine("La persona con el ID {0} se encuentra en la lista y tiene una edad de {1} pero su correo {2} no es válido, por lo que no podra ingresar", id, edad, email);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La persona con el ID {0} se encuentra en la lista de invitados pero tiene una edad de {1}, por lo que no podrá ingresar", id, edad);
                    }
                    
                }    
                else
                {
                    Console.WriteLine("La persona con el ID {0} no se encuentra en la lista de invitados", id);
                }
            }
            
             
            
        }
    }
}
