using System;
//Espacio de nombres 
namespace SE1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proyecto en C#
            //Sintaxis
            //Tipo de dato identificador variable;
            bool a;
            int número;
            //3. Interpolación
            //Combinación de datos dentro de una cadena
            a = true;
            número = 10;
            Console.WriteLine($"Booleano: {a}");
            Console.WriteLine($"Número: {número}");
            //4. Incrementos y decrementos
            int m = 0;
            int n = -1;
            m += 1;
            n -= 3;
            m -= 5;
            n += 9;
            //5. Operador resto (módulo)
            int residuo = 40 % 16;
            Console.WriteLine($"Residuo: {residuo}");
            //6. Operadores aritméticos
            double operación = 0;
            operación = ((30 + 8 - 2) / 2) * -1;
            Console.WriteLine($"Operación: {operación}");
            //Sesión 11: Solución de exámen (...continuación)
            //7. Interruptores
            bool interruptor_1 = false;
            bool interruptor_2 = true;
            bool bombilla = false;
            if (interruptor_1 && interruptor_2)
            {
                bombilla = true;
            }
            else
            {
                bombilla = false;
            }
            Console.WriteLine($"Bombilla: {bombilla}");
            //8. Asueto
            int dia = 16;
            string mes = "septiembre";
            if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine($"Asueto");
            }
            else
            {
                Console.WriteLine($"Sin definir");
            }
            //9. Almacenar una expresión que de como resultado true
            bool resultado = 7<11 && 9!=0;
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
   
}

