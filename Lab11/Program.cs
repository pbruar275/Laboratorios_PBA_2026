using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1: CONTRASEÑA
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");

        Console.Write("Ingrese contraseña: ");
        string pass = Console.ReadLine();

        bool tieneLongitud = pass.Length >= 8;
        bool tieneMayuscula = false;
        bool tieneNumero = false;
        bool tieneEspecial = false;

        for (int i = 0; i < pass.Length; i++)
        {
            char c = pass[i];

            if (c >= 'A' && c <= 'Z')
                tieneMayuscula = true;

            if (c >= '0' && c <= '9')
                tieneNumero = true;

            if (c == '@' || c == '#' || c == '$' || c == '%')
                tieneEspecial = true;
        }

        if (tieneLongitud && tieneMayuscula && tieneNumero && tieneEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: ");

            if (!tieneLongitud)
                Console.Write("falta longitud ");

            if (!tieneMayuscula)
                Console.Write("falta mayúscula ");

            if (!tieneNumero)
                Console.Write("falta número ");

            if (!tieneEspecial)
                Console.Write("falta carácter especial ");
        }

        Console.WriteLine("\n");


        // =========================
        // EJERCICIO 2: INVERTIR TEXTO
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");

        Console.Write("Ingrese texto: ");
        string texto = Console.ReadLine();

        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);

        Console.WriteLine();


        // =========================
        // EJERCICIO 3: ARREGLO
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");

        Console.Write("¿Cuántos números desea ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];

        int suma = 0;
        int mayor = int.MinValue;
        int menor = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            suma += numeros[i];

            if (numeros[i] > mayor)
                mayor = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        double promedio = (double)suma / n;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);

        Console.WriteLine();


        // =========================
        // EJERCICIO 4: BUSCAR
        // =========================
        Console.WriteLine("=== EJERCICIO 4 ===");

        int[] arreglo = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        int posicion = -1;

        for (int i = 0; i < 8; i++)
        {
            if (arreglo[i] == buscar)
            {
                encontrado = true;
                posicion = i;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine("Existe en la posición " + posicion);
        else
            Console.WriteLine("No existe en el arreglo");

        Console.WriteLine();


        // =========================
        // EJERCICIO 5: NOMBRES
        // =========================
        Console.WriteLine("=== EJERCICIO 5 ===");

        string[] nombres = new string[5];

        int masDe5 = 0;
        string masLargo = "";

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            if (nombres[i].Length > 5)
                masDe5++;

            if (nombres[i].Length > masLargo.Length)
                masLargo = nombres[i];
        }

        Console.Write("Nombres: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(nombres[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Más de 5 letras: " + masDe5);
        Console.WriteLine("Nombre más largo: " + masLargo);
    }
}
