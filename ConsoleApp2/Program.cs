using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resultado = 0;
            resultado   = sumar(a, b);
            Console.WriteLine("El resultado es: "+ resultado);
        }
        
        static int sumar(int a, int b) 
        {
            return a + b; 
        }
    }
}
