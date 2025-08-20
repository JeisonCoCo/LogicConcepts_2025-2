using System;

var continuar = "s";

do
{
    Console.Write("Ingrese el primer número entero : ");
    int a = int.Parse(Console.ReadLine()!); // a es el divisor

    Console.Write("Ingrese el segundo número entero: ");
    int b = int.Parse(Console.ReadLine()!); //b es el dividendo

    if (b % a == 0)
    {
        Console.WriteLine($"El número {a} es múltiplo de {b}.");
    }
    else
    {
        Console.WriteLine($"El número {a} no es múltiplo de {b}.");
    }
    Console.WriteLine("\n¿Desea continuar? (s -> sí / n -> no): ");
    continuar = Console.ReadLine()!;

} while (continuar.Equals("s", StringComparison.OrdinalIgnoreCase));