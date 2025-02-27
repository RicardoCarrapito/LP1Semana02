using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte b1 =byte.MaxValue;
            byte b2=byte.MinValue;

            sbyte sb1=sbyte.MaxValue;
            sbyte sb2=sbyte.MinValue;

            short sh1= short.MaxValue;
            short sh2=short.MinValue;

            ushort ush1= ushort.MaxValue;
            ushort ush2= ushort.MinValue;

            int i1= int.MaxValue;
            int i2= int.MinValue;

            uint ui1=uint.MaxValue;
            uint ui2=uint.MinValue;

            long l1=long.MaxValue;
            long l2=long.MinValue;

            ulong ul1=ulong.MaxValue;
            ulong ul2=ulong.MinValue;

            char ch1=char.MaxValue;
            char ch2=char.MinValue;

            float fl1=float.MaxValue;
            float fl2=float.MinValue;

            double db1=double.MaxValue;
            double db2=double.MinValue;

            decimal de1=decimal.MaxValue;
            decimal de2=decimal.MinValue;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sh1);
            Console.WriteLine(sh2);
            Console.WriteLine(ush1);
            Console.WriteLine(ush2);
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(ui1);
            Console.WriteLine(ui2);
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(ul1);
            Console.WriteLine(ul2);
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(fl1);
            Console.WriteLine(fl2);
            Console.WriteLine(db1);
            Console.WriteLine(db2);
            Console.WriteLine(de1);
            Console.WriteLine(de2);

            float fli1= float.PositiveInfinity;
            float fli2= float.NegativeInfinity;
            float fln1= float.NaN;

            double dbi1= double.PositiveInfinity;
            double dbi2= double.NegativeInfinity;
            double dbn=double.NaN;

            Console.WriteLine(fli1);
            Console.WriteLine(fli2);
            Console.WriteLine(fln1);
            Console.WriteLine(dbi1);
            Console.WriteLine(dbi2);
            Console.WriteLine(dbn);

            // segunda parte do exercicio 

            Console.WriteLine(ui1+1);

            float over =2*float.MaxValue;
            float over2=float.MaxValue+1;

            Console.WriteLine(over);
            Console.WriteLine(over2);
            



        }
    }
}
