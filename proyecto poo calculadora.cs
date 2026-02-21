using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string NOMBRE_PROGRAMA = "CALCULADORA";
            int numero1;
            int numero2;
            int resultado;
            double division;

            Console.WriteLine("=====================================");
            Console.WriteLine(NOMBRE_PROGRAMA);
            Console.WriteLine("=====================================");
            Console.WriteLine();

            Console.Write("Ingrese el primer número: ");
            string input1 = Console.ReadLine();

            Console.Write("Ingrese el segundo número: ");
            string input2 = Console.ReadLine();

            numero1 = Convert.ToInt32(input1);
            numero2 = Convert.ToInt32(input2);

            resultado = numero1 + numero2;
            Console.WriteLine("Suma: " + numero1 + " + " + numero2 + " = " + resultado);

            resultado = numero1 - numero2;
            Console.WriteLine("Resta: " + numero1 + " - " + numero2 + " = " + resultado);

            resultado = numero1 * numero2;
            Console.WriteLine("Multiplicación: " + numero1 + " * " + numero2 + " = " + resultado);

            division = (double)numero1 / numero2;
            Console.WriteLine("División: " + numero1 + " / " + numero2 + " = " + division);

            resultado = numero1 % numero2;
            Console.WriteLine("Residuo: " + numero1 + " % " + numero2 + " = " + resultado);

            Console.WriteLine();
            Console.WriteLine("Gracias por usar el programa.");
            Console.ReadLine();
        }
    }
}