using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaaPOOex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior a; 
                a = new Maior();

            Console.WriteLine("x");
            a.setx(double.Parse(Console.ReadLine()));
            Console.WriteLine("y");
            a.sety(double.Parse(Console.ReadLine())) ;

            a.calcular();


        }
    }
}
