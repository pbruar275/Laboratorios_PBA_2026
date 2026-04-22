using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LABORATORIO 9 - PROCEDIMIENTOS ===");
        Console.WriteLine();

        // Ejercicio 1
        Console.WriteLine("=== EJERCICIO 1 ===");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        SaludoPersonalizado(nombre);
        MostrarCurso();
        Console.WriteLine();

        // Ejercicio 2
        Console.WriteLine("=== EJERCICIO 2 ===");

        Console.Write("Ingrese el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("Ingrese la base del rectángulo: ");
        double baseRect = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRect = double.Parse(Console.ReadLine());
        AreaRectangulo(baseRect, alturaRect);

        Console.Write("Ingrese la base del triángulo: ");
        double baseTri = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo: ");
        double alturaTri = double.Parse(Console.ReadLine());
        AreaTriangulo(baseTri, alturaTri);

        Console.WriteLine();

        // Ejercicio 3
        Console.WriteLine("=== EJERCICIO 3 ===");
        MenuFiguras();

        Console.WriteLine();

        // Ejercicio 4
        Console.WriteLine("=== EJERCICIO 4 ===");
        RegistroNotas();

        Console.WriteLine();

        // Ejercicio 5
        Console.WriteLine("=== EJERCICIO 5 ===");
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Antes: " + num1 + ", " + num2);
        Intercambiar(ref num1, ref num2);
        Console.WriteLine("Después: " + num1 + ", " + num2);
    }

    // =========================
    // EJERCICIO 1
    // =========================
    static void SaludoPersonalizado(string nombre)
    {
        Console.WriteLine("Hola, " + nombre + ". Bienvenido/a.");
    }

    static void MostrarCurso()
    {
        Console.WriteLine("Curso: Diseño de algoritmos y lenguajes de programación");
        Console.WriteLine("Laboratorio 9");
    }

    // =========================
    // EJERCICIO 2
    // =========================
    static void AreaCuadrado(double lado)
    {
        double area = lado * lado;
        Console.WriteLine("Área del cuadrado: " + area);
    }

    static void AreaRectangulo(double baseRect, double alturaRect)
    {
        double area = baseRect * alturaRect;
        Console.WriteLine("Área del rectángulo: " + area);
    }

    static void AreaTriangulo(double baseTri, double alturaTri)
    {
        double area = (baseTri * alturaTri) / 2;
        Console.WriteLine("Área del triángulo: " + area);
    }

    // =========================
    // EJERCICIO 3
    // =========================
    static void MenuFiguras()
    {
        int opcion;

        do
        {
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese N: ");
                    int n1 = int.Parse(Console.ReadLine());
                    DibujarCuadrado(n1);
                    break;

                case 2:
                    Console.Write("Ingrese N: ");
                    int n2 = int.Parse(Console.ReadLine());
                    DibujarTriangulo(n2);
                    break;

                case 3:
                    Console.Write("Ingrese N: ");
                    int n3 = int.Parse(Console.ReadLine());
                    DibujarLinea(n3);
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }

    static void DibujarCuadrado(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DibujarLinea(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    // =========================
    // EJERCICIO 4
    // =========================
    static void RegistroNotas()
    {
        double suma = 0;
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese la nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());

            EvaluarNota(nota);

            suma += nota;

            if (nota >= 61)
                aprobados++;
            else
                reprobados++;
        }

        MostrarResumen(suma, aprobados, reprobados);
    }

    static void EvaluarNota(double nota)
    {
        if (nota >= 61)
            Console.WriteLine("Aprueba");
        else
            Console.WriteLine("Reprueba");
    }

    static void MostrarResumen(double suma, int aprobados, int reprobados)
    {
        double promedio = suma / 5;
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }

    // =========================
    // EJERCICIO 5
    // =========================
    static void Intercambiar(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }
}
