using EspacioCalculadora;
using System;

Calculadora calcu = new Calculadora();
string opcion;
double numero;

do
{
    Console.WriteLine("\nCalculadora\nMenu\n\n-Sumar\n-Resta\n-Multiplicar\n-Dividir\n-Limpiar\n-Salir\n\nSeleccione una opcion: ");
    opcion = Console.ReadLine();
    opcion = opcion.ToLower();

    switch (opcion)
    {
        case "sumar":
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out numero);
            calcu.Sumar(numero);
            break;

        case "restar":
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out numero);
            calcu.Restar(numero);
            break;

        case "multiplicar":
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out numero);
            calcu.Multiplicar(numero);
            break;

        case "dividir":
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out numero);
            calcu.Dividir(numero);
            break;

        case "limpiar":
            calcu.Limpiar();
            break;

        default:
            break;

    }

    Console.WriteLine($"\nEl resultado de la operacion es {calcu.Resultado}");

} while (opcion != "salir");