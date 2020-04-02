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
    class Program
    {
        static void Main(string[] args)
        {
            Musico Juan = new Musico("Juan");
            //Juan.saluda();

            Baterista Paco = new Baterista("Paco", "Tama");
            Bajista Tom = new Bajista ("Tom", "Gibson");
            //Paco.saluda();
            //Tom.saluda();

            List<Musico> musicos = new List<Musico>(); 
            musicos.Add(Juan);
            musicos.Add(Tom); 
            musicos.Add(new Baterista ("Joe","Apex"));

            foreach (Musico a in musicos)
            a.saluda();        
        
        }
    }
}
