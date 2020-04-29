using System;
using System.Collections.Generic;

namespace figura
{
    interface IFigura 
    {
        string color {get; set;}
        void dibujar();
    }

    class Circulo : IFigura
    {
        string Color;
        public Circulo(string color)
        {
            Color = color;
        }
        public string color { get => color; set => color = value; }
        public void dibujar()
        {
            Console.WriteLine("Se dibuja un circulo de color {0}", Color);
        }
    }

    class Rect : IFigura
    {
        string Color;
        public Rect(string color)
        {
            Color = color;
        }
        public string color { get => color; set => color = value; }
        public void dibujar()
        {
            Console.WriteLine("Se dibuja un rectangulo de color {0}", Color);
        }
    }
    class Program{
        static void Main(string[] args){
            List <IFigura> figuras = new List<IFigura>();
            figuras.Add(new Circulo("Azul"));
            figuras.Add(new Circulo("Verde"));
            figuras.Add(new Circulo("Negro"));
            figuras.Add(new Rect("Rojo"));
            figuras.Add(new Rect("Morado"));
            figuras.Add(new Rect("Rosa"));

            
            foreach(var u in figuras)
            u.dibujar();

            

            }
        }
}