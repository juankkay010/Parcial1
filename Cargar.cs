using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    abstract class Cargar
    {
        public List<string> informacion= new List<string>();
        public void cargar_archivo(string path)
        {
            try
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
            catch (System.IO.FileNotFoundException)
            {
                throw new ArchivoNoEncontrado();
            }
            
        }
    }
}
