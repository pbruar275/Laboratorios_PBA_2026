using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1
        // =========================
        Console.WriteLine("=== EJERCICIO 1: Clasificación de vehículo ===");
        Console.Write("Ingrese el tipo de vehículo (1-5): ");
        int vehiculo = int.Parse(Console.ReadLine());

        switch (vehiculo)
        {
            case 1:
                Console.WriteLine("Bicicleta -> No motorizado");
                break;
            case 2:
                Console.WriteLine("Motocicleta -> Ligero");
                break;
            case 3:
                Console.WriteLine("Auto -> Mediano");
                break;
            case 4:
                Console.WriteLine("Camión -> Pesado");
                break;
            case 5:
                Console.WriteLine("Autobús -> Transporte público");
                break;
            default:
                Console.WriteLine("Error: número fuera de rango.");
                break;
        }

        Console.WriteLine();

        // =========================
        // EJERCICIO 2
        // =========================
        Console.WriteLine("=== EJERCICIO 2: Límite de crédito ===");
        Console.Write("Ingrese el tipo de tarjeta: ");
        int tipoTarjeta = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el límite actual: ");
        double limiteActual = double.Parse(Console.ReadLine());

        double aumento = 0;

        switch (tipoTarjeta)
        {
            case 1:
                aumento = limiteActual * 0.25;
                break;
            case 2:
                aumento = limiteActual * 0.35;
                break;
            case 3:
                aumento = limiteActual * 0.40;
                break;
            default:
                aumento = limiteActual * 0.50;
                break;
        }

        double nuevoLimite = limiteActual + aumento;

        Console.WriteLine("El nuevo límite de crédito es: " + nuevoLimite);

        Console.WriteLine();

        // =========================
        // EJERCICIO 3
        // =========================
        Console.WriteLine("=== EJERCICIO 3: Evaluación de empleados ===");
        Console.Write("Ingrese la puntuación: ");
        double puntuacion = double.Parse(Console.ReadLine());

        string nivel = "";
        double dinero = 0;

        if (puntuacion == 0.0)
        {
            nivel = "Inaceptable";
            dinero = 2400 * puntuacion;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Dinero recibido: " + dinero);
        }
        else if (puntuacion == 0.4)
        {
            nivel = "Aceptable";
            dinero = 2400 * puntuacion;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Dinero recibido: " + dinero);
        }
        else if (puntuacion >= 0.6)
        {
            nivel = "Meritorio";
            dinero = 2400 * puntuacion;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Dinero recibido: " + dinero);
        }
        else
        {
            Console.WriteLine("Puntuación no válida.");
        }

        Console.WriteLine();

        // =========================
        // EJERCICIO 4
        // =========================
        Console.WriteLine("=== EJERCICIO 4: Pizzería Bella Napoli ===");
        Console.Write("¿Quiere pizza vegetariana? (1 = Sí, 2 = No): ");
        int tipoPizza = int.Parse(Console.ReadLine());

        string ingrediente = "";

        switch (tipoPizza)
        {
            case 1:
                Console.WriteLine("Ingredientes vegetarianos:");
                Console.WriteLine("1. Pimiento");
                Console.WriteLine("2. Tofu");
                Console.Write("Elija un ingrediente: ");
                int opcionVeg = int.Parse(Console.ReadLine());

                switch (opcionVeg)
                {
                    case 1:
                        ingrediente = "Pimiento";
                        Console.WriteLine("Pizza vegetariana con mozzarella, tomate y " + ingrediente);
                        break;
                    case 2:
                        ingrediente = "Tofu";
                        Console.WriteLine("Pizza vegetariana con mozzarella, tomate y " + ingrediente);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Ingredientes no vegetarianos:");
                Console.WriteLine("1. Peperoni");
                Console.WriteLine("2. Jamón");
                Console.WriteLine("3. Salmón");
                Console.Write("Elija un ingrediente: ");
                int opcionNoVeg = int.Parse(Console.ReadLine());

                switch (opcionNoVeg)
                {
                    case 1:
                        ingrediente = "Peperoni";
                        Console.WriteLine("Pizza no vegetariana con mozzarella, tomate y " + ingrediente);
                        break;
                    case 2:
                        ingrediente = "Jamón";
                        Console.WriteLine("Pizza no vegetariana con mozzarella, tomate y " + ingrediente);
                        break;
                    case 3:
                        ingrediente = "Salmón";
                        Console.WriteLine("Pizza no vegetariana con mozzarella, tomate y " + ingrediente);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}
