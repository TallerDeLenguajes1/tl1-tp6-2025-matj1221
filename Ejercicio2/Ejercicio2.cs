//Calculadora V1
using System;

int opc = 0;

string? entrada, entrada1, entrada2;
int numero1, numero2;
while (opc != 5)
{
    Console.WriteLine("\n1. Sumar \n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir \nIngrese la operacion a realizar:");
    entrada = Console.ReadLine();
    if (int.TryParse(entrada, out opc))
    {
        switch (opc)
        {
            case 1:
                Console.WriteLine("Ingrese el primer numero: ");
                entrada1 = Console.ReadLine();
                if (int.TryParse(entrada1, out numero1))
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    entrada2 = Console.ReadLine();
                    if (int.TryParse(entrada2, out numero2))
                    {
                        Console.WriteLine($"Resultado: {Sumar(numero1, numero2)}");
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un numero entero. ");
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero entero. ");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese el primer numero: ");
                entrada1 = Console.ReadLine();
                if (int.TryParse(entrada1, out numero1))
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    entrada2 = Console.ReadLine();
                    if (int.TryParse(entrada2, out numero2))
                    {
                        Console.WriteLine($"Resultado: {Restar(numero1, numero2)}");
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un numero entero. ");
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero entero. ");
                }
                break;
            case 3:
                Console.WriteLine("Ingrese el primer numero: ");
                entrada1 = Console.ReadLine();
                if (int.TryParse(entrada1, out numero1))
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    entrada2 = Console.ReadLine();
                    if (int.TryParse(entrada2, out numero2))
                    {
                        Console.WriteLine($"Resultado: {Multiplicar(numero1, numero2)}");
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un numero entero. ");
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero entero. ");
                }
                break;
            case 4:
                Console.WriteLine("Ingrese el primer numero: ");
                entrada1 = Console.ReadLine();
                if (int.TryParse(entrada1, out numero1))
                {
                    Console.WriteLine("Ingrese el segundo numero: ");
                    entrada2 = Console.ReadLine();
                    if (int.TryParse(entrada2, out numero2))
                    {
                        Console.WriteLine($"Resultado: {Dividir(numero1, numero2)}");
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un numero entero. ");
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un numero entero. ");
                }
                break;
            case 5:
                break;

        }
    }
    else
    {
        Console.WriteLine("\nNo ingresaste un numero entero.\n");
        opc = 0;
    }

}
//FUNCIONES
static int Sumar(int a, int b)
{
    return a + b;
}

int Restar(int a, int b)
{
    return a - b;
}

int Multiplicar(int a, int b)
{
    return a * b;
}

int Dividir(int a, int b)
{
    return a / b;
}