using System;

namespace LeerTeclado
{
    /// <summary>
    /// Leer datos del teclado
    /// </sumary>
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Suma de dos números");
            Console.Write("Ingrese el número 1: ");
            // Los datos se leen como cadena
            string dato = Console.ReadLine();
            //convertir a número con int.Parse
            int n1 = int.Parse(dato);

            Console.Write("Ingrese el número 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es de: {0}", suma);
            
        }
    }
}