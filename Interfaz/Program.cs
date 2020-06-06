using System;
using System.Collections.Generic;

namespace Interfaz
{
    class Usuario : IComparable
    {
        public string nombre {get; set;}
        private string _correo;
        public Usuario (string n, string c)
        {
            nombre = n;
            correo = c;
        }

        public string correo {
            get => _correo;
            set => _correo = value;
            }
        public int CompareTo(object obj)
        {
            return correo.CompareTo(((Usuario)obj).correo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int instruccion;
            Console.WriteLine("Ingrese Instruccion");
            instruccion = Int32.Parse(Console.ReadLine());

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("pam","pam@gmail.com"));
            usuarios.Add(new Usuario("tom","tom@gmail.com"));
            usuarios.Add(new Usuario("jim","jim@gmail.com"));
            usuarios.Add(new Usuario("ana","mna@gmail.com"));

            usuarios.Sort();
            
            foreach(Usuario u in usuarios)
            Console.WriteLine(u.correo);
        
        }
    }
}
