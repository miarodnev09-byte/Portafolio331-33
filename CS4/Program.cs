using System;
//Espacio de nombres 
namespace CS4
{
    //Clase principal
    class Program
    {
        //Función principal
        static void Main(string[] args)
        {
            //Sesión 7: Operadores aritméticos
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 5 != 5;
            Console.WriteLine($"Diferencia {m}");
            m = 5 > 4;
            Console.WriteLine($"Mayor que: {m}");
            m = 4 < 5;
            Console.WriteLine($"Menor que: {m}");
            //Menor o igual que
            //1. Escribir una expresión que dé como resultado true.
            //Mayor o igual que
            //2. Escribir una expresión que dé como resultado false.
            m = 6 >= 5;
            Console.WriteLine($"Mayor o igual que: {m}");
            m = 3 <= 9;
            Console.WriteLine($"Menor o igual que: {m}");
            // 3. Operadores lógicos
            // a. Y (AND): &&
            // b. O (OR): ||
            bool e = false; 
            bool f = true; 
            bool d = false; 
            d = e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O: {d}");
        

        }
    }
}