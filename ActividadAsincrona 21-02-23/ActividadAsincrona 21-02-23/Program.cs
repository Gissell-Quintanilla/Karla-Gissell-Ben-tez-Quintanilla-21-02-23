// See https://aka.ms/new-console-template for more information
using System;
 
namespace For1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor1;
            int Valor2;
            int ValoresPares = 0;

            Console.Write("Ingrese un valor inicial: ");
            Valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un valor final: ");
            Valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Los valores pares entre " + Valor1 + " y " + Valor2 + " son:");

            for (int i = Valor1; i <= Valor2; i++)
            {
                if (i % 2 == 0)
                {
                  
                    Console.WriteLine(i.ToString());
                    ValoresPares++;

                }
            }
            if (ValoresPares == 0)
            {
                Console.WriteLine("El valor ingresado es inválido"); 
            }
            else
            {
                Console.WriteLine("Gracias!");
            }
        }
    }
}