/*
var response = string.Empty; //Variable para almacenar la respuesta del usuario

do
{
    Console.Write("Ingrese un número entero : ");

    var numberString = Console.ReadLine(); //Lee dato ingresado por el usuario -> String "45"
    var numberInt = int.Parse(numberString!);// convierte el string a int 45

    if (numberInt % 2 == 0) //Si el numero ingresado es divisible por 2 es par
    {
        Console.WriteLine($"El Número {numberInt}, es par. "); //$ interpolación de cadenas
    }
    else
    {
        Console.WriteLine($"El Número {numberInt}, es Impar. ");
        response = Console.ReadLine()!.ToUpper(); //.ToUpper() : convierte la cadena a mayúsculas para comparar con "S" o "N"
    } Console.ReadLine("¿Desea continuar? (S -> sí / N -> no): ");//Pregunta si desea continuar
} while (response == "S" ); //Bucle infinito, para que el programa no se cierre y pueda ingresar otro número
*/

using Shared;

var response = string.Empty;
do
{
    try  // --> Intentar
    {
        var number = ConsoleExtensions.GetInt("Ingrese número entero: ");
        if (number % 2 == 0)
        {
            Console.WriteLine($"El número: {number} es par.");
        }
        else
        {
            Console.WriteLine($"El número: {number} es impar.");
        }
    }
    catch (Exception ex)  //--> Capturar ó atrapar
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Desea continuar [S/N]? ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

