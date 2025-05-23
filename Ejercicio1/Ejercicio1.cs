Console.WriteLine("Ingrese un numero entero: ");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    if (numero > 0)
    {
        double inverso = 1.0 / numero;
        Console.WriteLine($"El numero invertido de {numero} es: {inverso}");
    }
    else
    {
        Console.WriteLine("No se puede dividir en 0.");
    }
}
else
{
    Console.WriteLine("NO se ingreso un numero entero.");
}

