using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        //Esta funcion se llamara periodicamente para determinar si el numero
        // "n" es abundante.
    
       static void determinarAbundante(int n) 
        {
            int a = 0;
            /*Este blucle calculara cuales son los numeros "divisores" 
             *del numero "n", luego los sumara todos para verificar
             *si sumatoria de divisores>n.
            */
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) //Verificar si "i" es divisor de "n".
                {
                    a = a + i; //Si "i" es divisor de "n", sumarlo.
                }
            }
            if (a > n) //si la sumatoria de "a"(divisores de n) es mayor a "n"
            {
                //Imprimir en la consola que el numero es abundante.
                Console.WriteLine("El número "+n+ " es abundante ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Impares [Abundantes] del 0 al 5000 ");
           //Este bucle manda todos los numeros impares como parametro
           //A la funcion determinarAbundante();
            for (int i = 0; i < 5000; i++) 
            {
                //Verificar si el numero es impar.
                if (i % 2 != 0)
                {
                    //Llamar a la funcion para calcular los numeros abundantes
                    //mandando como parametro "i".
                    determinarAbundante(i);                
                }            
            }
            //Esperar la pulsacion de una tecla para finalizar.
            //el programa y cerrar la consola.
           Console.ReadKey();
        }    
    }
}
