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

//Calculadora V2
Console.WriteLine("Ingrese un numero real: ");
string? entrada3 = Console.ReadLine();
double numero3;
if (double.TryParse(entrada3, out numero3))
{
    if (numero3 >= 0)
    {
        Console.WriteLine($"Valor absoluto de {numero3}: {numero3}");
    }
    else
    {
        Console.WriteLine($"Valor absoluto de {numero3}: {-numero3}");
    }

    Console.WriteLine($"El cuadrado de {numero3}: {numero3 * numero3}");
    Console.WriteLine($"La raiz cuadrada de {numero3}: {Math.Sqrt(numero3)}");
    Console.WriteLine($"El seno de {numero3}: {Math.Sin(numero3 * Math.PI / 180)}");
    Console.WriteLine($"El coseno de {numero3}: {Math.Cos(numero3 * Math.PI / 180)}");
    Console.WriteLine($"La parte entera de {numero3}: {Math.Truncate(numero3)}");
}


string? entrada4, entrada5;
double numero4, numero5;

Console.WriteLine("Ingrese un numero real: ");
entrada4 = Console.ReadLine();
if (double.TryParse(entrada4, out numero4))
{
    Console.WriteLine("Ingrese otro numero real: ");
    entrada5 = Console.ReadLine();
    if (double.TryParse(entrada5, out numero5))
    {
        if (numero4 > numero5)
        {
            Console.WriteLine($"El mayor es: {numero4}");
            Console.WriteLine($"El menor es: {numero5}");
        }
        else
        {
            Console.WriteLine($"El mayor es: {numero5}");
            Console.WriteLine($"El menor es: {numero4}");
        }
    }
    else
    {
        Console.WriteLine("No ingresaste un numero real. ");

    }
}
else
{
    Console.WriteLine("No ingresaste un numero real. ");
}

Console.WriteLine("\n--- Ejercicio de formato de texto ---");
Console.WriteLine("Ingrese dos numeros para sumar y mostrar el resultado en texto:");

Console.Write("Numero 1: ");
if (int.TryParse(Console.ReadLine(), out int num1))
{
    Console.Write("Numero 2: ");
    if (int.TryParse(Console.ReadLine(), out int num2))
    {
        int resultado = Sumar(num1, num2);
        Console.WriteLine("La suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());
    }
}


Console.WriteLine("Ingrese una ecuacion simple como cadena de caracteres");
string? ecuacion = Console.ReadLine();

if (!string.IsNullOrEmpty(ecuacion))
{
    char operador = ' ';
    int posicion = -1;

    //busco que operador se uso
    if ((posicion = ecuacion.IndexOf('+')) != -1) operador = '+';
    else if ((posicion = ecuacion.IndexOf('-')) != -1) operador = '-';
    else if ((posicion = ecuacion.IndexOf('*')) != -1) operador = '*';
    else if ((posicion = ecuacion.IndexOf('/')) != -1) operador = '/';

    if (operador != ' ')
    {
        string izquierda = ecuacion.Substring(0, posicion);
        string derecha = ecuacion.Substring(posicion + 1);

        if (int.TryParse(izquierda, out int numero) && int.TryParse(derecha, out int num2))
        {
            int resultado = 0;
            bool valido = true;

            switch (operador)
            {
                case '+':
                    resultado = numero + num2;
                    break;
                case '-':
                    resultado = numero - num2;
                    break;
                case '*':
                    resultado = numero * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = numero / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: división por cero.");
                        valido = false;
                    }
                    break;
            }
            if (valido)
                Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("No se pudo interpretar alguno de los números.");
        }
    }
    else
    {
        Console.WriteLine("No se encontró un operador válido.");
    }
}
else
{
    Console.WriteLine("La entrada está vacía.");
}