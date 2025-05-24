// Responder las siguientes preguntas en el archivo readme.md
// ¿String es una tipo por valor o un tipo por referencia?
// ¿Qué secuencias de escape tiene el tipo string?
// ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Console.WriteLine("Ingrese la cadena: ");
string? cadena1 = Console.ReadLine();

if (!string.IsNullOrEmpty(cadena1))
{
    Console.WriteLine($"La longitud de la cadena es de: {cadena1.Length} ");
    Console.WriteLine("Ingrese otra cadena: ");
    string? cadena2 = Console.ReadLine();
    if (!string.IsNullOrEmpty(cadena2))
    {
        string concatenar = $"{cadena1}{cadena2}";
        Console.WriteLine($"Cadenas concatenadas: {concatenar} ");

        string subcadena = concatenar.Substring(concatenar.Length - 3, 2);
        Console.WriteLine($"Subcadena de la concatenada: {subcadena} ");


        Console.WriteLine($"Mostrando la cadena '{cadena1}' caracter a caracter:");
        foreach (char caracter in cadena1)
        {
            Console.WriteLine(caracter);
        }

        Console.WriteLine("Buscar la ocurrencia de una palabra, ingrese la palabra: ");
        string? ocurrencia = Console.ReadLine();

        int posicion = cadena1.IndexOf(ocurrencia);

        if (posicion != -1)
        {
            Console.WriteLine($"La palabra '{cadena1}' se encontró en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"La palabra '{cadena1}' no se encontró en la frase.");
        }

        Console.WriteLine($"Cadena '{cadena1.ToUpper()}' en mayusculas.");

        Console.WriteLine($"Cadena '{cadena1.ToLower()}' en minusculas.");

        Console.WriteLine("Ingrese una frase con separacion ';':");
        string? partes = Console.ReadLine();
        string[] separacion = partes.Split(';');

        Console.WriteLine("Frase en partes separadas:");

        foreach (string parte in separacion)
        {
            Console.WriteLine(parte);
        }
    }
    else
    {
        Console.WriteLine("Se ingreso una cadena vacia o nula.");
    }
}
else
{
    Console.WriteLine("Se ingreso una cadena vacia o nula.");
}