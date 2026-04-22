using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");

        int aprobados = 0;
        int reprobados = 0;
        double sumaNotas = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese nota del estudiante " + i + ": ");
            double nota = double.Parse(Console.ReadLine());

            sumaNotas += nota;

            if (nota >= 61)
                aprobados++;
            else
                reprobados++;
        }

        double promedio = sumaNotas / 10;

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);

        Console.WriteLine();


        // =========================
        // EJERCICIO 2
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");

        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;

            if (i % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Pares: " + pares);
        Console.WriteLine("Impares: " + impares);

        Console.WriteLine();


        // =========================
        // EJERCICIO 3
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");

        int opcion;
        double totalVentas = 0;
        int clientes = 0;

        do
        {
            Console.WriteLine("1. Registrar compra");
            Console.WriteLine("2. Mostrar total de ventas");
            Console.WriteLine("3. Mostrar clientes");
            Console.WriteLine("4. Salir");

            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Monto de compra: ");
                    double monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientes++;
                    break;

                case 2:
                    Console.WriteLine("Total ventas: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 4);


        // =========================
        // EJERCICIO 4
        // =========================
        Console.WriteLine("=== EJERCICIO 4 ===");

        int numero;
        int total = 0;
        int positivos = 0;
        int negativos = 0;
        int sumaTotal = 0;

        do
        {
            Console.Write("Ingrese número (0 para salir): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                total++;
                sumaTotal += numero;

                if (numero > 0)
                    positivos++;
                else
                    negativos++;
            }

        } while (numero != 0);

        Console.WriteLine("Cantidad: " + total);
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Suma total: " + sumaTotal);

        Console.WriteLine();


        // =========================
        // EJERCICIO 5
        // =========================
        Console.WriteLine("=== EJERCICIO 5 ===");

        Console.Write("Ingrese N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
