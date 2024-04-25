using System;

namespace elevadorAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Bienvenido a el elevador al cubo, por favor inserte el numero a ser calculado:");
            n1 = int.Parse(Console.ReadLine());
            n2 = n1 * n1 * n1;
            Console.WriteLine("El resultado de elevar al cubo " + n1 + " es " + n2);
            Console.WriteLine("Gracias por usar el elevador al cubo");
        }
    }
}
