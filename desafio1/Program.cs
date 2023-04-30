
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("1100", "Nokia");
            Telefono t2 = new Telefono();
            t1.NumeroTelefonico = "2235384018";
            t1.CodigoOperador = 2;

            Console.WriteLine("El telefono es un: " + t1.Marca + " " + t1.Modelo);
            Console.WriteLine("El numero de telefono es: " + t1.NumeroTelefonico);
            Console.WriteLine("El codigo de operador es: " + t1.CodigoOperador);
            Console.WriteLine(t1.llamar());
            Console.WriteLine(t1.llamar("Juancho"));
            Console.ReadKey();
        }
                
    }
}
