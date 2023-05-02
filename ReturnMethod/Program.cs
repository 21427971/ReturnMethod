using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace ReturnMethod
{
    //Method that return a value with method declaration
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));
        }

        static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }
    }
}
