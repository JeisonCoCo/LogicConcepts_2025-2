
using System;

var continuar = "s ->> para salir";

do
{
    Console.Write("Ingrese el primer número entero: ");
    int a = int.Parse(Console.ReadLine()!);

    Console.Write("Ingrese el segundo número entero: ");
    int b = int.Parse(Console.ReadLine()!);

    Console.Write("Ingrese el tercer número entero: ");
    int c = int.Parse(Console.ReadLine()!);

    if (a > b && a > c)
    {
        Console.WriteLine($"El número mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El número mayor es: {b}");
    }
    else
    {
        Console.WriteLine($"El número mayor es: {c}");
    }

    if (a < b && a > c)
    {
        Console.WriteLine($"El número del medio: {a}");
    }
    else if (b < a && b > c)
    {
        Console.WriteLine($"El número del medio es: {b}");
    }
    else
    {
        Console.WriteLine($"El número del medio es: {c}");
    }

    if (a < b && a < c)
    {
        Console.WriteLine($"El número menor es: {a}");
    }
    else if (b < a && b < c)
    {
        Console.WriteLine($"El número menor es: {b}");
    }
    else
    {
        Console.WriteLine($"El número menor es: {c}");
    }
    Console.WriteLine("\n¿Desea continuar? (s -> sí / n -> no): ");
    continuar = Console.ReadLine()!;

    Console.WriteLine("Hasta la vista, Baby 👋");
} while (continuar.Equals("s", StringComparison.OrdinalIgnoreCase));
