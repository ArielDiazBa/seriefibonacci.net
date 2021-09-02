using System;

namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer el teclado
            Console.WriteLine("Ingrese el tamaño de la serie Fibonacci: ");

            //variable para guardar el numero digitado por teclado
            long Number = long.Parse(Console.ReadLine());

            //Dejar un espacio entre la cantidad digitada para la serie y el comienzo de la serie
            Console.WriteLine(" ");

            //Muestra el resultado y/o la serie
            for (int i = 0; i < Number; i++)
            {

                if (PrimeNumber(FibonacciSerie(i)))
                {
                    Console.WriteLine(FibonacciSerie(i) + " - " + " El Número Primo");
                }
                else
                {
                    Console.WriteLine(FibonacciSerie(i) + " - El numero no es Primo");
                }
            }
        }

        //Metodo que calcula la secuencia hasta llegar a N numeros
        public static long FibonacciSerie(long NumberEntry)
        {

            if (NumberEntry > 1)
            {
                //Funcion Recursiva
                return FibonacciSerie(NumberEntry - 1) + FibonacciSerie(NumberEntry - 2);
            }
            else if (NumberEntry == 1)
            {
                //Caso base
                return 1;
            }
            else if (NumberEntry == 0)
            {
                //Caso base
                return 0;
            }
            else
            {
                //Error
                Console.WriteLine("Ingrese un tamaño igual o mayor a 1");
                return -1;
            }
        }

        //Metodo que define si el numero de la serie es primo o no
        public static Boolean PrimeNumber(long NumberValidation)
        {
            //Variable para guardar si el número a valir es primo o no
            Boolean ValidationPrime = false;
            //Variable contadora de cantidad de divisibles que tiene el número ingresado
            int Divisibles = 0;

            //for para saber cuantos numeros divisibles tiene el valor ingresado
            for (int i = 1; i <= NumberValidation; i++)
            {
                if (NumberValidation % i == 0)
                {
                    Divisibles++;
                }
            }

            //saber si el valor solo tiene 2 numeros divisibles/ primo
            if (Divisibles == 2)
            {
                ValidationPrime = true;
            }
            return ValidationPrime;
        }
    }
}
