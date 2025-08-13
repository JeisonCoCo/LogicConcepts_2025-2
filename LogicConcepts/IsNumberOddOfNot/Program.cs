do
{
   
    Console.WriteLine("\t");
    Console.Write("Ingrese un número entero o presione Ctrl+C para salir : ");

    var numberString = Console.ReadLine(); //Lee dato ingresado por el usuario -> String "45"
    var numberInt = int.Parse(numberString!);// convierte el string a int 45

    if (numberInt % 2 == 0) //Si el numero ingresado es divisible por 2 es par
    {
        Console.WriteLine($"El Número {numberInt}, es par. "); //$ interpolación de cadenas
    }
    else
    {
        Console.WriteLine($"El Número {numberInt}, es Impar. ");
    }
}while (true); //Bucle infinito, para que el programa no se cierre y pueda ingresar otro número

