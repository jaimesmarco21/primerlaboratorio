using System;
class program
{
    static void Main()
    {
        Console.Write("Introduce una calificación del 1 al 10: ");
        int calificacion = int.Parse(Console.ReadLine());
        
        switch (calificacion)
        {
            case 10:
            case 9:
                Console.WriteLine("Excelente");
                break;
            case 8:
            case 7:
                Console.WriteLine("Muy Bien");
                break;
            case 6:
                Console.WriteLine("Bien");
                break;
            case 5:
                Console.WriteLine("Suficiente");
                break;
            case 4:
            case 3:
            case 2:
            case 1:
                Console.WriteLine("Insuficiente");
                break;
            default:
                Console.WriteLine("Calificación no válida.");
                break;
        }
    }
}