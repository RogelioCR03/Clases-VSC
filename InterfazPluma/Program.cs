using System;
using System.Collections.Generic;

namespace InterfazPluma
{
    interface IPluma
    {
        string Color{get; set;}
        bool Open();
        bool Close();
        void Escribir(string text);
    }
    class Gis
    {
        string Color {get; set;}

        public Gis (string color)
        {
            Color = color;
        }

        public void Escribir(string text)
        {
            Console.WriteLine(text);
        }

    }
    class Bic : IPluma
    {
        public string Color { get => _color; set => _color = value; }

        private bool tieneTapon = true;
        public bool Close()
        {
            tieneTapon = true;
            return tieneTapon;
        }
        public bool Open()
        {
            tieneTapon = false;
            return tieneTapon;
        }
        public void Escribir(string text)
        {
            if(tieneTapon)
            {
                Console.WriteLine("Escribe el texto: {0} en color {1}", text, Color);
            }
            else
            {
                Console.WriteLine("No escribe nada");
            }
        
        }
         public Bic (string color)
        {
            Color = color;
        }
        private string _color;
    }
    class Cello : IPluma
    {
        public string Color {get; set;}
        private bool puedeEscribir = false;

        public bool Open()
        {
            puedeEscribir = true;
            return puedeEscribir;
        }

        public bool Close()
        {
            puedeEscribir = false;
            return puedeEscribir;
        }

        public void Escribir(string text)
        {
            if(puedeEscribir)
            {
                Console.WriteLine("Escribe el texto: {0} en color {1}", text, Color);
            }
            else
            {
                Console.WriteLine("No escribe nada");
            }
        }
        public Cello (string color)
        {
            Color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cello pluma_cello = new Cello("Azul");
            Bic pluma_bic = new Bic("Rojo");
            Gis gis1 = new Gis("Blanco");
            
            /*
            pluma_cello.Open();
            pluma_cello.Escribir("Hola");
            pluma_bic.Open();
            pluma_bic.Escribir("Hola");
            gis1.Escribir("Hola");
            */

            List<Object> plumas = new List<Object>();
            plumas.Add(pluma_cello);
            plumas.Add(pluma_bic);
            plumas.Add(gis1);

            foreach(var objeto in plumas)
            {
                if (objeto is IPluma)
                {
                    Console.WriteLine("El objeto implementa IPluma");
                    (objeto as IPluma).Open();
                    (objeto as IPluma).Escribir("Hola");
                }
                else
                {
                    var gis = objeto as Gis;
                    if ( gis != null)
                    gis.Escribir("Hola");
                }
                
            }
                
        }
    }
}
