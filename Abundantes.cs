using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

       static void determinarAbundante(int n) 
        {
            int a = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    a = a + i;
                }

            }

            if (a > n)
            {
                Console.WriteLine("El número "+n+ " es abundante ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Impares [Abundantes] del 0 al 5000 ");
            for (int i = 0; i < 5000; i++) 
            {
                if (i % 2 != 0)
                {
                    determinarAbundante(i);                
                }            
            }
           Console.ReadKey();
        }    
    }
}
