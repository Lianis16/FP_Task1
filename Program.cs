using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuatiaDeGradul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("introduceti valoarea a pentru ecuatia ax+b = 0");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti valoarea b");
            int b = Convert.ToInt32(Console.ReadLine());
            int x = -b / a;
            Console.WriteLine("x = " + x);
            Console.ReadLine();



        }
    }
}
