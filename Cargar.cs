using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Cargar
    {
        public List<string> informacion= new List<string>();
        public Cargar(string path)
        {
            StreamReader sr = new StreamReader(path);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string line = sr.ReadLine();
            while (line != null)
            {    
                informacion.Add(line);
                line = sr.ReadLine();

            }
            sr.Close();
        }
    }
}
