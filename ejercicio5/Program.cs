using System;
class program
{
    static void Main()
    {
        Console.Write("Introduce un número del 1 al 4: ");
        int estacion = int.Parse(Console.ReadLine());
        
        switch (estacion)
        {
            case 1:
                Console.WriteLine("Primavera");
                break;
            case 2:
                Console.WriteLine("Verano");
                break;
            case 3:
                Console.WriteLine("Otoño");
                break;
            case 4:
                Console.WriteLine("Invierno");
                break;
            default:
                Console.WriteLine("Número no válido. Debe ser entre 1 y 4.");
                break;
        }
    }
}