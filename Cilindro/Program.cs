using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("Insere a altura do cilindro;");
            string str1 = Console.ReadLine();
            double a = double.Parse(str1);

            Console.WriteLine("Insere o raio do cilindro;");
            string str2 = Console.ReadLine();
            double r = double.Parse(str2);

            double v = Math.PI*Math.Pow( r,r)*a;

            double S =2 * Math.PI*r*(r+a);

            Console.WriteLine($"{v:f3}");
            Console.WriteLine($"{S:f3}");
            


        }
    }
}
