//using Shared;

var continueV = "s";

do
{
    Console.Write("Ingrese año: ");
    var yearInput = int.Parse(Console.ReadLine()!);

    if ((yearInput % 4 == 0 && yearInput % 100 != 0) || yearInput % 400 == 0)
    {
        Console.WriteLine($"El año {yearInput}, si es bisiesto");
    }
    else
    {
        Console.WriteLine($"El año {yearInput}, no es bisiesto");
    }

    Console.Write("Desea continuar [S/N]? : ");
    continueV = Console.ReadLine()!.ToUpper();

} while (continueV.Equals("S", StringComparison.OrdinalIgnoreCase));
