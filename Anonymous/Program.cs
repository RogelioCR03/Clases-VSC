using System;

namespace Anonymous
{
    class Persona 
    {
        public string nombre, apellido;
        public Persona(string n, string a)
        {
            nombre = n ; apellido = a;
        }

    class Anonimo
    {
        static public void anonimiza(Persona p)
        {
            p.nombre="XXXXX";
            p.apellido="XXXXX";
        }
    }   

    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona espia = new Persona("Fulano", "Detal");
            Console.WriteLine(espia.nombre);
            Anonimo.anonimiza(espia);
            Console.WriteLine(espia.nombre);
        }
    }
}
