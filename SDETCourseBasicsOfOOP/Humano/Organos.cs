using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDETCourseBasicsOfOOP.Humano
{
    public class Organos : Acciones
    {
        internal void Pulmon()
        {
            Respirar();
            Console.WriteLine("Usando Pulmon");
        }
    }
}
