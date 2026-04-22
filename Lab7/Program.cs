using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1: SUMA CON WHILE
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");

        int N = 0;

        // Validación
        while (N <= 0)
        {
            Console.Write("¿Cuántos números desea sumar? ");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
                Console.WriteLine("Debe ser mayor que 0.");
        }

        int contador = 1;
        double suma = 0;

        while (contador <= N)
        {
            Console.Write("Ingrese número " + contador + ": ");
            double num = double.Parse(Console.ReadLine());

            suma += num;
            contador++;
        }

        double promedio = suma / N;

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);

        Console.WriteLine();


        // =========================
        // EJERCICIO 2: MENÚ DO-WHILE
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");

        int opcion;

        do
        {
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Km a Millas");
            Console.WriteLine("4. Salir");

            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            double valor, resultado;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese Celsius: ");
                    valor = double.Parse(Console.ReadLine());
                    resultado = (valor * 9 / 5) + 32;
                    Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                    break;

                case 2:
                    Console.Write("Ingrese Fahrenheit: ");
                    valor = double.Parse(Console.ReadLine());
                    resultado = (valor - 32) * 5 / 9;
                    Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                    break;

                case 3:
                    Console.Write("Ingrese Km: ");
                    valor = double.Parse(Console.ReadLine());
                    resultado = valor * 0.621371;
                    Console.WriteLine("Resultado: " + resultado.ToString("F2"));
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
        // EJERCICIO 3: ADIVINA EL NÚMERO
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        int intento = 0;
        int numero;

        do
        {
            Console.Write("Adivine el número (1-100): ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 100)
            {
                Console.WriteLine("Número inválido.");
                continue;
            }

            intento++;

            if (numero < numeroSecreto)
                Console.WriteLine("Más alto");
            else if (numero > numeroSecreto)
                Console.WriteLine("Más bajo");

        } while (numero != numeroSecreto);

        Console.WriteLine("¡Correcto! Intentos: " + intento);

        Console.WriteLine();


        // =========================
        // EJERCICIO 4: PIN CON INTENTOS
        // =========================
        Console.WriteLine("=== EJERCICIO 4 ===");

        int pinCorrecto = 1234;
        int intentos = 0;
        int pin;

        do
        {
            Console.Write("Ingrese PIN: ");
            pin = int.Parse(Console.ReadLine());

            if (pin == pinCorrecto)
            {
                Console.WriteLine("Acceso concedido.");
                break;
            }
            else
            {
                Console.WriteLine("PIN incorrecto.");
            }

            intentos++;

        } while (intentos < 3);

        if (pin != pinCorrecto)
        {
            Console.WriteLine("Cuenta bloqueada.");
        }
    }
}
