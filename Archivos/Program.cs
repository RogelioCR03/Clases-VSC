using System;
using System.Collections.Generic;
using System.IO;

namespace Archivos
{
        class Product
        {   
            public Product(string c, string d, double p)
            {
                Code = c;
                Description = d;
                Price = p;
            }
            public Product()
            {

            }
            public string Code {get; set;}
            public string Description {get; set;}
            public double Price{get; set;}
            public override string ToString()
            {
                return String.Format("{0}|{1}|{2}", Code, Description, Price);
            }

        }
        
        class ProductDB
        {
            public static void WriteToTXT(string path, List<Product> products)
            {
                StreamWriter txtOut = 
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

                foreach(Product p in products)
                {
                    txtOut.WriteLine("{0}|{1}|{2}", p.Code, p.Description, p.Price);
                }

                txtOut.Close();
            }
            public static void WriteToBIN(string path, List<Product> products)
            {
                BinaryWriter binOut = 
                new BinaryWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

                foreach(Product p in products)
                {
                    binOut.Write(p.Code);
                    binOut.Write(p.Description);
                    binOut.Write(p.Price);
                }

                binOut.Close();
            }
            /*public static List<Product> ReadFromTXT(string path)
            {
                List<Product> products = new List<Product>();
                StreamReader txtIn = new StreamReader(
                    new FileStream(path, FileMode.Open, FileAccess.Read)
                );
                while(txtIn.Peek() != -1)
                {
                    string line = txtIn.ReadLine();
                    //["SDF", "HTC", "1234.5"]
                    string[] columns = line.Split('|');
                    Product p = new Product(columns[0], columns[1], Double.Parse(columns[2]));
                    products.Add(p);
                }
                return products;
                
            }*/
            public static List<Product> ReadFromBIN(string path)
            {
                List<Product> products = new List<Product>();
                BinaryReader binIn = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                while(binIn.PeekChar() != -1)
                {
                    Product p = new Product();
                    p.Code = binIn.ReadString();
                    p.Description = binIn.ReadString();
                    p.Price = binIn.ReadDouble();
                    products.Add(p);
                }
                return products;
        }
        class Program
        {
        static void Main(string[] args)
        {   
            
            List<Product> products = new List<Product>();
            /*
            products.Add(new Product("SDF", "HTC", 1234.5));
            products.Add(new Product("SDA", "Samsung", 1237.5));
            products.Add(new Product("SDB", "Huawei", 1278.5));
            products.Add(new Product("SDC", "Alcatel", 1531.5));
            products.Add(new Product("SDD", "IPhone", 1145.5));

            ProductDB.WriteToBIN("productos.dat", products);

            */
            products = ProductDB.ReadFromBIN(@".\productos.dat");
            foreach(Product p in products)
            Console.WriteLine(p.Description);
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
           
            /*
            //Si el directorio existe o no, mostrara true o false
            bool existe = File.Exists(@"C:\Users\ROGELIO\hola\Nuevo.txt");
            Console.WriteLine(existe);

            // Si el directorio no existe, lo va a crear
            /*
            if (!Directory.Exists(@"C:\Users\ROGELIO\hola\helou"))
            {
                Directory.CreateDirectory(@"C:\Users\ROGELIO\hola\helou");
            }
            
        
            //File.Copy(@"C:\Users\ROGELIO\hola\Nuevo.txt", @"C:\Users\ROGELIO\hola\helou");

            //Directory.Delete(@"C:\Users\ROGELIO\hola\helou", true);

            foreach (string ruta in Directory.GetFiles(@"C:\Users\ROGELIO\hola"))
            {
                Console.WriteLine(ruta);
                Console.WriteLine(Path.GetFileName(ruta));
            }
            */
        }
        }
    }
    
}
