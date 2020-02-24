using System;
using System.Collections.Generic;

namespace Usuario
{
    class CorreoE
    {
        private string correo;
        public CorreoE(string c)
        {
            correo=c;
        }
        public string getCorreo()
        {
            return correo;
        }
    }

    class Usuario
    {
        private string nombre;
        private List <CorreoE> correos;
        public Usuario (string nombre)
        {
            this.nombre=nombre;
            correos = new List <CorreoE>();
        }

        public string getNombre()
        {
            return nombre;
        }
        public void AgregaCorreo(CorreoE c)
        {
            correos.Add(c);
        }
        public void Print()
        {
            Console.WriteLine(nombre);
            foreach (CorreoE c in correos)
            {
                Console.WriteLine(c.getCorreo ());
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario u1 = new Usuario("Juan");
            Console.WriteLine (u1.getNombre());
            u1.AgregaCorreo(new CorreoE ("juan@a.com"));
            u1.AgregaCorreo(new CorreoE ("juan@gmail.com"));
            u1.Print();
        }
    }
}
