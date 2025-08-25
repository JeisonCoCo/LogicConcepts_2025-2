//using Shared;


var go = "s";

do
{
    Console.Write("Ingrese nombre: ");
    var nombreInput = Console.ReadLine();

    Console.Write("Ingrese número de horas trabajadas: ");
    var horasInput = int.Parse(Console.ReadLine()!);

    Console.Write("Ingrese valor hora: ");
    var valorHoraImput = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese valor salario mínimo mensual: ");
    var salarioMinimoImput = double.Parse(Console.ReadLine()!);

    var salarioMensual = horasInput * valorHoraImput;    


    if (salarioMensual > salarioMinimoImput)
    {
        Console.WriteLine($"Nombre : {nombreInput}");
        Console.WriteLine($"Salario mensual: {salarioMensual.ToString("N")} ");
        //Console.WriteLine($"Salario mensual: {salarioMensual.ToString("N2", new CultureInfo("es-ES "))} ");
    }
    else
    {
        Console.WriteLine($"Nombre : {nombreInput}");
    }

    Console.Write("Desea continuar [S/N]? : ");
    go = Console.ReadLine()!.ToUpper();
    Console.Write("-----------------------------------------------------------------------\n");

} while (go.Equals("S", StringComparison.OrdinalIgnoreCase));
