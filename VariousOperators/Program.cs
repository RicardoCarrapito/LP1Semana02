using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número-não negativo:");
            string str= Console.ReadLine();
            sbyte n= sbyte.Parse(str);

            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^6);
            Console.WriteLine(n>10);
            

        }
    }
}
