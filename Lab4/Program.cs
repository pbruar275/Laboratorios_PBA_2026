using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1: Registro de Nave Espacial
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");

        string modelo = "XR-450";
        int capacidad = 2000;
        float combustible = 75.5f;
        bool motorActivo = true;

        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Capacidad: " + capacidad);
        Console.WriteLine("Combustible: " + combustible);
        Console.WriteLine("Motor activo: " + motorActivo);

        Console.WriteLine();

        // =========================
        // EJERCICIO 2: Conversión Implícita
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");

        short sensoresActivos = 128;
        int registroProcesador = sensoresActivos;
        double precisionTotal = registroProcesador;

        Console.WriteLine("Resultado: " + precisionTotal);

        Console.WriteLine();

        // =========================
        // EJERCICIO 3: Casting Explícito
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");

        double energiaGenerada = 987.65;
        int energiaLimitada = (int)energiaGenerada;

        Console.WriteLine("Original: " + energiaGenerada);
        Console.WriteLine("Convertido: " + energiaLimitada);

        Console.WriteLine();

        // =========================
        // EJERCICIO 4: Parse
        // =========================
        Console.WriteLine("=== EJERCICIO 4 ===");

        Console.Write("Ingresa distancia: ");
        string entrada = Console.ReadLine();

        int distancia = int.Parse(entrada);
        int resultado = distancia + 100;

        Console.WriteLine("Resultado final: " + resultado);

        Console.WriteLine();

        // =========================
        // EJERCICIO 5: Convert
        // =========================
        Console.WriteLine("=== EJERCICIO 5 ===");

        string señal = "true";
        bool oxigeno = Convert.ToBoolean(señal);

        string tempTexto = "22.8";
        double temperatura = Convert.ToDouble(tempTexto);

        Console.WriteLine("Oxígeno: " + oxigeno);
        Console.WriteLine("Temperatura: " + temperatura);

        Console.WriteLine();

        // =========================
        // EJERCICIO 6: ToString
        // =========================
        Console.WriteLine("=== EJERCICIO 6 ===");

        double velocidad = 299792.458;

        Console.WriteLine("Normal: " + velocidad.ToString());
        Console.WriteLine("Formato: " + velocidad.ToString("N3"));

        Console.WriteLine();

        // =========================
        // EJERCICIO 7: Calculadora
        // =========================
        Console.WriteLine("=== EJERCICIO 7 ===");

        Console.Write("Precio por galón: ");
        string precioTexto = Console.ReadLine();

        double precio = Convert.ToDouble(precioTexto);
        double impuesto = precio * 0.12;
        double total = precio + impuesto;

        int totalEntero = (int)total;

        Console.WriteLine("Total final: " + totalEntero);

        Console.WriteLine();
    }
}
