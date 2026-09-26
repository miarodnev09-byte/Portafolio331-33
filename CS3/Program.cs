using System;

namespace CS3
{
    class Program
    {
        //Función pricipal
        static void Main(string[] args)
        {
            // Sesiíon 6: Operadores 
            // Declaración e inicialización
            double a = 1;
            double b = 2;
            double resultado = 0;
            // 1. Operadores aritméticos
            // a. Suma: +
            resultado = a + b;
            Console.WriteLine($"Resultado: {resultado}");
            // b. Resta: -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            // c. Multiplicación: *
            resultado = a * b;
            Console.WriteLine($"Resultado: {resultado}");
            // d. División: /
            resultado = a / b;
            Console.WriteLine($"Resultado: {resultado}");
            // e. Resto (módulo): %
            resultado = a % b;
            Console.WriteLine($"Resultado: {resultado}");
             // Incrementos y decrementos
             // resultado = resultado + 9;
             resultado += 9;
             resultado -= 5;
             Console.WriteLine($"Resultado: {resultado}");
            /*
            2. Operadores comparativos
            a. Igualdad: ==
            b. Diferencia: !=
            c. Menor que: <
            d. Mayor que: >
            e. Menor o igual que: <=
            f. Mayor o igual que: >=
            */
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
        }// Término de la función principal
    } // Término de la clase principal
} // Término del espacio de nombres
