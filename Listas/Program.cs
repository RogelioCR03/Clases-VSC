using System;
using System.Collections.Generic;

namespace Listas
{
    class Alumno
    {
        public string nombre;
        public void imprime()
        {
            Console.WriteLine(nombre);
        }
        public Alumno(string n)
        {
            nombre=n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno ana = new Alumno("Ana");
            ana.nombre="Ana";
            ana.imprime();

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Ana"));
            alumnos[0].imprime();
            alumnos.Add(new Alumno("Rogelio"));
            alumnos[1].imprime();
            alumnos.Add(new Alumno("Ricardo"));
            alumnos[2].imprime();
            alumnos.Add(new Alumno("Abraham"));
            alumnos[3].imprime();
            alumnos.Add(new Alumno("Ana"));
            alumnos[4].imprime();
            alumnos.Add(new Alumno("Miguel"));
            alumnos[5].imprime();
            alumnos.Add(new Alumno("Daniel"));
            alumnos[6].imprime();
            alumnos.Add(new Alumno("Mario"));
            alumnos[7].imprime();
            alumnos.Add(new Alumno("Jesus"));
            alumnos[8].imprime();
            alumnos.Add(new Alumno("Axel"));
            alumnos[9].imprime();

            for(int i=0;i<alumnos.Count;i++)
            alumnos[i].imprime();

            foreach (Alumno a in alumnos)
                a.imprime();

        }
    }
}
    