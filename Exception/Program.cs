using System;

namespace CapturaEdad
{
    class EdadOverflowExcepcion : Exception
    {
        public EdadOverflowExcepcion():base("Edad no valida")
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura tu edad");
            //string edad_capturada = Console.ReadLine();
            int edad = -1;
            bool conexion = true;

            try
            {
                edad = Int32.Parse(Console.ReadLine());
                if (edad > 130)
                {
                    edad = -1;
                    throw new EdadOverflowExcepcion();
                }
                conexion = false;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("No se permite ingresar letras, simbolos o espacios");
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ingresa una edad valida");
            }
            catch (EdadOverflowExcepcion e)
            {
                Console.WriteLine("Ingresa una edad menor a 130");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error al ingresar tu edad {0}", e.GetType());
            }
            finally 
            {
                conexion = false;
            }

            if (edad != -1)
            {
                if(edad > 40)
                {
                    Console.WriteLine("Estas en riesgo");
                }
                else 
                {
                    Console.WriteLine("Riesgo bajo");
                }
                    Console.WriteLine(conexion);
            }
        }
    }
}
