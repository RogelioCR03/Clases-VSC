using System;

namespace Sobrecarga
{
    class Racional 
    {
        public int numerador;
        public int denominador;

        public Racional (int num, int den)
        {
            numerador = num;
            denominador = den;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", numerador, denominador);
        }

        public static Racional operator + (Racional x, Racional y)
        {
            int numerador = (x.numerador * y.denominador) + (y.numerador * x.denominador);
            int denominador = x.denominador * y.denominador;
            return new Racional(numerador, denominador);
        }

        public static Racional operator ++ (Racional x)
        {
            return new Racional(x.numerador+1, x.denominador+1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Racional a = new Racional (1,2);
            Racional b = new Racional (2,4);

            Racional c = a + b;

            Racional x = c++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x);
        }
    }
}
