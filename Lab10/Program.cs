using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LABORATORIO 10 ===");

        // =========================
        // EJERCICIO 1
        // =========================
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        int suma = SumarDigitos(num);
        Console.WriteLine("Suma de dígitos: " + suma);

        Console.WriteLine();

        // =========================
        // EJERCICIO 2
        // =========================
        Console.Write("Ingrese número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes: " + n);
        string mensaje = ElevarCuadrado(ref n);
        Console.WriteLine(mensaje);
        Console.WriteLine("Después: " + n);

        Console.WriteLine();

        // =========================
        // EJERCICIO 3
        // =========================
        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Descuento (ej 0.25): ");
        double descuento = double.Parse(Console.ReadLine());

        double monto = AplicarDescuento(descuento, ref precio);

        Console.WriteLine("Precio final: " + precio);
        Console.WriteLine("Descuento aplicado: " + monto);

        Console.WriteLine();

        // =========================
        // EJERCICIO 4
        // =========================
        int energia = 10;

        Console.WriteLine("Energía inicial: " + energia);

        energia = ConsumirEnergia(ref energia);
        Console.WriteLine("Después de consumir: " + energia);

        energia = RecargarEnergia(ref energia);
        Console.WriteLine("Después de recargar: " + energia);

        string estado = ObtenerEstado(energia);
        Console.WriteLine("Estado: " + estado);

        string rendimiento = CalcularRendimiento(energia);
        Console.WriteLine("Rendimiento: " + rendimiento);
    }

    // =========================
    // EJERCICIO 1
    // =========================
    static int SumarDigitos(int num)
    {
        int suma = 0;

        while (num > 0)
        {
            suma += num % 10;
            num /= 10;
        }

        return suma;
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static string ElevarCuadrado(ref int n)
    {
        n = n * n;
        return "Número elevado al cuadrado";
    }

    // =========================
    // EJERCICIO 3
    // =========================
    static double AplicarDescuento(double porcentaje, ref double precio)
    {
        double descuento = precio * porcentaje;
        precio -= descuento;
        return descuento;
    }

    // =========================
    // EJERCICIO 4
    // =========================
    static int ConsumirEnergia(ref int energia)
    {
        energia -= 4;

        if (energia < 0)
            energia = 0;

        return energia;
    }

    static int RecargarEnergia(ref int energia)
    {
        energia += 6;

        if (energia > 20)
            energia = 20;

        return energia;
    }

    static string ObtenerEstado(int energia)
    {
        if (energia >= 15)
            return "Alta";
        else if (energia >= 8)
            return "Media";
        else
            return "Baja";
    }

    static string CalcularRendimiento(int energia)
    {
        if (energia == 20)
            return "S";
        else if (energia >= 15)
            return "A";
        else if (energia >= 8)
            return "B";
        else
            return "C";
    }
}
