
var go = "s";

do
{
    Console.Write("Número de escritorios: ");
    var numberOfDesksInput = int.Parse(Console.ReadLine()!);
    var value = 650000;
    var totalToPay = 0.0;
    var discount = 0;
    var subtotal = 0.0;

    if (numberOfDesksInput < 5)
    {
        totalToPay = value * numberOfDesksInput * (1 - 0.10);
        Console.WriteLine($"El valor a pagar es: {totalToPay.ToString("N")}");
    }
    else if (numberOfDesksInput >= 5 && numberOfDesksInput < 10)
    {
        totalToPay = value * numberOfDesksInput;
        discount = (int)(value * numberOfDesksInput * -0.40);

        Console.WriteLine($"El valor a pagar es: {totalToPay.ToString("N")}");
    }
    else if (numberOfDesksInput >= 10)
    {
        totalToPay = value * numberOfDesksInput * (1 - 0.40);
        discount = (int)(value * numberOfDesksInput * 0.40);
        Console.WriteLine($"El valor a pagar es: {totalToPay.ToString("N")}");
        Console.WriteLine($"El descuento aplicado es: 40%, valor descontado {discount.ToString("N")} ");
    }

    Console.Write("Desea continuar [S/N]? : ");
    go = Console.ReadLine()!.ToUpper();
    Console.Write("-----------------------------------------------------------------------\n");

} while (go == "S");