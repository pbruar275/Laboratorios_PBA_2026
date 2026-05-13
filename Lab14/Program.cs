using System;

// ================= EJERCICIO 1 =================
class Libro
{
    public string titulo;
    public string autor;
    public int anioPublicacion;
    public bool disponible;

    // Constructor
    public Libro(string t, string a, int anio, bool d)
    {
        titulo = t;
        autor = a;
        anioPublicacion = anio;
        disponible = d;
    }

    // Mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año: " + anioPublicacion);
        Console.WriteLine("Disponible: " + disponible);
    }

    // Prestar libro
    public void PrestarLibro()
    {
        if (disponible)
        {
            disponible = false;
            Console.WriteLine("Libro prestado.");
        }
        else
        {
            Console.WriteLine("El libro no está disponible.");
        }
    }

    // Devolver libro
    public void DevolverLibro()
    {
        disponible = true;
        Console.WriteLine("Libro devuelto.");
    }
}

// ================= EJERCICIO 2 =================
class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public bool vacunado;

    // Constructor
    public Mascota(string n, string e, int edadMascota, bool v)
    {
        nombre = n;
        especie = e;
        edad = edadMascota;
        vacunado = v;
    }

    // Mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Vacunado: " + vacunado);
    }

    // Vacunar
    public void Vacunar()
    {
        vacunado = true;
        Console.WriteLine(nombre + " ha sido vacunado.");
    }

    // Cumplir años
    public void CumplirAnios()
    {
        edad++;
        Console.WriteLine(nombre + " ahora tiene " + edad + " años.");
    }
}

// ================= EJERCICIO 3 =================
class Estudiante
{
    public string nombre;
    public int edad;
    public string grado;
    public double[] notas;

    // Constructor
    public Estudiante(string n, int e, string g, double[] notasEstudiante)
    {
        nombre = n;
        edad = e;
        grado = g;
        notas = notasEstudiante;
    }

    // Calcular promedio
    public double CalcularPromedio()
    {
        double suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        return suma / notas.Length;
    }

    // Mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Grado: " + grado);

        Console.Write("Notas: ");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Promedio: " + CalcularPromedio());
    }

    // Aprobar
    public void Aprobar()
    {
        if (CalcularPromedio() >= 61)
        {
            Console.WriteLine(nombre + " aprobó.");
        }
        else
        {
            Console.WriteLine(nombre + " reprobó.");
        }
    }

    // Agregar nota
    public void AgregarNota(double nuevaNota)
    {
        double[] nuevoArreglo = new double[notas.Length + 1];

        for (int i = 0; i < notas.Length; i++)
        {
            nuevoArreglo[i] = notas[i];
        }

        nuevoArreglo[notas.Length] = nuevaNota;

        notas = nuevoArreglo;

        Console.WriteLine("Nota agregada correctamente.");
    }
}

class Program
{
    static void Main()
    {
        // ================= EJERCICIO 1 =================
        Console.WriteLine("===== EJERCICIO 1 =====");

        Libro libro1 = new Libro("Harry Potter", "J.K Rowling", 2001, true);
        Libro libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943, true);

        libro1.MostrarInformacion();
        Console.WriteLine();

        libro2.MostrarInformacion();
        Console.WriteLine();

        libro1.PrestarLibro();
        Console.WriteLine("Disponible: " + libro1.disponible);

        libro1.DevolverLibro();
        Console.WriteLine("Disponible: " + libro1.disponible);

        // ================= EJERCICIO 2 =================
        Console.WriteLine("\n===== EJERCICIO 2 =====");

        Mascota mascota1 = new Mascota("Willy", "Perro", 4, false);
        Mascota mascota2 = new Mascota("Michi", "Gato", 2, true);

        mascota1.MostrarInformacion();
        Console.WriteLine();

        mascota2.MostrarInformacion();
        Console.WriteLine();

        mascota1.Vacunar();
        mascota1.CumplirAnios();

        Console.WriteLine();

        mascota1.MostrarInformacion();

        // ================= EJERCICIO 3 =================
        Console.WriteLine("\n===== EJERCICIO 3 =====");

        double[] notas1 = { 70, 80, 90 };
        double[] notas2 = { 50, 60, 55 };

        Estudiante estudiante1 = new Estudiante("Pedro", 23, "Primer Año", notas1);
        Estudiante estudiante2 = new Estudiante("Ana", 19, "Primer Año", notas2);

        estudiante1.MostrarInformacion();
        estudiante1.Aprobar();

        Console.WriteLine();

        estudiante2.MostrarInformacion();
        estudiante2.Aprobar();

        Console.WriteLine();

        estudiante1.AgregarNota(100);

        estudiante1.MostrarInformacion();
        estudiante1.Aprobar();
    }
}
