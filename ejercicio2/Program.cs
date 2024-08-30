using System;
class program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Introduce un operador (+, -, *, /): ");
        char operador = char.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+':
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Resultado: {num1 / num2}");
                else
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
            default:
                Console.WriteLine("Operador no válido.");
                break;
        }
    }
}
