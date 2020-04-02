using System;
using System.Collections.Generic;

namespace Herencia
{
    class Musico
    {
        protected string nombre;

        public Musico (string n)
        {
            nombre = n;
        }

        public virtual void saluda()
        {
            Console.WriteLine("Hola soy {0}", nombre);
        }
    }

    class Baterista : Musico
    {
        protected string bateria;

        public Baterista(string nombre, string bateria):base(nombre)
        {
            this.bateria = bateria;
        }
        public override void saluda()
        {
            Console.WriteLine("Hola soy el baterista {0}, mi pila es una {1}", nombre,bateria);
        }        
    }
        class Bajista : Musico
    {
        protected string bajo;

        public Bajista(string nombre, string bajo):base(nombre)
        {
            this.bajo = bajo;
        }
        public override void saluda()
        {
            Console.WriteLine("Hola soy el bajista {0}, mi pila es una {1}", nombre,bajo);
        }
    }

        class Pianista : Musico
    {
        protected string piano;

        public Pianista (string nombre, string piano):base(nombre)
        {
            this.piano = piano;
        }
        public override void saluda()
        {
            Console.WriteLine("Hola soy el pianista {0}, mi pila es una {1}", nombre,piano);
        }        
    }

        class Violinista : Musico
    {
        protected string violin;

        public Violinista (string nombre, string violin):base(nombre)
        {
            this.violin = violin;
        }
        public override void saluda()
        {
            Console.WriteLine("Hola soy el violinista {0}, mi pila es una {1}", nombre,violin);
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Rogelio = new Musico("Rogelio");
            Rogelio.saluda();

            Baterista Richard = new Baterista("Richard", "Tama");
            Bajista Abraham = new Bajista ("Abraham", "Gibson");
            Pianista Pepe = new Pianista("Pepe","Yamaha");
            Violinista Bryan = new Violinista("Bryan","Stentor");
            
            Richard.saluda();
            Abraham.saluda();
            Pepe.saluda();
            Bryan.saluda();

            //List<Musico> musicos = new List<Musico>(); 
            //musicos.Add(Juan);
            //musicos.Add(Tom); 
            //musicos.Add(new Baterista ("Joe","Apex"));

            //foreach (Musico a in musicos)
            //a.saluda();        
        
        }
    }
}
