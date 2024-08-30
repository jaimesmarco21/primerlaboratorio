using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");     
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Elige una opción: ");
        int opcion = int.Parse(Console.ReadLine());
        Console.Write("Introduce el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado de la suma: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Resultado de la resta: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"Resultado de la multiplicación: {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine($"Resultado de la división: {num1 / num2}");
                else
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
