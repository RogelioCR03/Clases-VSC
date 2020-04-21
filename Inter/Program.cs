using System;

namespace Inter
{
    interface IActor
    {
        void actua();
        void ensayar();
        int getPremios();
    }

    interface INacionalidad
    {
        string Pais();
        
    }
    abstract class Musico 
    {
        protected string _nombre;

        public Musico(string n)
        {
            _nombre = n;
        }


        public string Nombre 
        { 
        get => _nombre; 
        set => _nombre = value; 
        }

        public abstract void afina();
    }

    class Bajista : Musico, IActor 
    {
        public Bajista(string n):base(n)
        {

        }

        public void actua()
        {
            throw new NotImplementedException();
        }

        public override void afina()
        {
            Console.WriteLine("{0} afinando su bajo", Nombre);
        }

        public void ensayar()
        {
            throw new NotImplementedException();
        }

        public int getPremios()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
