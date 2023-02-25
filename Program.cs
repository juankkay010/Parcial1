﻿using System;
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
            string path = @"C:\Users\juana\source\repos\Reto1\Reto1\Taller_herencia.txt";
            Cargar archivo = new Cargar(path);    



            Verificador_txt verificador = new Verificador_txt(path);
            while(true)
            {
                Console.WriteLine("Ingrese el ID que desea buscar (o 0 para salir): ");
                string id = Console.ReadLine();
                if (id == "0")
                {
                    break;
                }
                if (verificador.Si_esta_en_invitados(id))
                {
                    if (verificador.Es_mayor_de_18(id))
                    {
                        Console.WriteLine("La persona con el ID {0} se encuentra en la lista y tiene una edad de {1}, por lo que podrá ingresar", id, verificador.invitados);
                    }
                    Console.WriteLine("La persona con el ID {0} se encuentra en la lista de invitados", id);
                }    
                else
                {
                    Console.WriteLine("La persona con el ID {0} no se encuentra en la lista de invitados", id);
                }
            }
            
             
            
        }
    }
}