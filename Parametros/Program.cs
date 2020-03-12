using System;

namespace Parametros
{
    class Prueba 
    {
        public static void sumaUno(ref int x)
        {
            x=x+1;
            Console.WriteLine(x);
        }

        public static void suma(in int a, in int b, out int c)
        {
            c=a+b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12; int b=10; int c;
            Prueba.sumaUno(ref a);
            Console.WriteLine(a);
            Prueba.suma(in a, in b, out c);
            Console.WriteLine(c);
        }
    }
}
