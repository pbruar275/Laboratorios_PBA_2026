using System;

// ================= EJERCICIO 1 =================
class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

// ================= EJERCICIO 2 =================
class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

// ================= EJERCICIO 3 =================
class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

// ================= EJERCICIO 4 =================
class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}

class Program
{
    static void Main()
    {
        // ================= EJERCICIO 1 =================
        Console.WriteLine("===== EJERCICIO 1 =====");

        Persona persona1 = new Persona();

        persona1.nombre = "Pedro";
        persona1.edad = 23;
        persona1.altura = 1.82;
        persona1.estudiante = true;

        Console.WriteLine("Nombre: " + persona1.nombre);
        Console.WriteLine("Edad: " + persona1.edad);
        Console.WriteLine("Altura: " + persona1.altura);
        Console.WriteLine("Estudiante: " + persona1.estudiante);

        // ================= EJERCICIO 2 =================
        Console.WriteLine("\n===== EJERCICIO 2 =====");

        Vehiculo vehiculo1 = new Vehiculo();

        vehiculo1.marca = "Mitsubishi";
        vehiculo1.modelo = "Outlander";
        vehiculo1.anio = 2026;
        vehiculo1.color = "Negro";
        vehiculo1.placa = "P123ABC";

        Console.WriteLine("Marca: " + vehiculo1.marca);
        Console.WriteLine("Modelo: " + vehiculo1.modelo);
        Console.WriteLine("Año: " + vehiculo1.anio);
        Console.WriteLine("Color: " + vehiculo1.color);
        Console.WriteLine("Placa: " + vehiculo1.placa);

        // ================= EJERCICIO 3 =================
        Console.WriteLine("\n===== EJERCICIO 3 =====");

        Producto producto1 = new Producto();
        Producto producto2 = new Producto();

        producto1.codigo = "P001";
        producto1.nombre = "TV";
        producto1.precio = 15500.50;
        producto1.stock = 10;
        producto1.disponible = true;

        producto2.codigo = "P002";
        producto2.nombre = "Control Universal";
        producto2.precio = 150.75;
        producto2.stock = 25;
        producto2.disponible = true;

        Console.WriteLine("Producto 1");
        Console.WriteLine("Código: " + producto1.codigo);
        Console.WriteLine("Nombre: " + producto1.nombre);
        Console.WriteLine("Precio: " + producto1.precio);
        Console.WriteLine("Stock: " + producto1.stock);
        Console.WriteLine("Disponible: " + producto1.disponible);

        Console.WriteLine();

        Console.WriteLine("Producto 2");
        Console.WriteLine("Código: " + producto2.codigo);
        Console.WriteLine("Nombre: " + producto2.nombre);
        Console.WriteLine("Precio: " + producto2.precio);
        Console.WriteLine("Stock: " + producto2.stock);
        Console.WriteLine("Disponible: " + producto2.disponible);

        // ================= EJERCICIO 4 =================
        Console.WriteLine("\n===== EJERCICIO 4 =====");

        Mascota mascota1 = new Mascota();

        mascota1.nombre = "Willy";
        mascota1.especie = "Perro";
        mascota1.edad = 6;
        mascota1.peso = 12.5;
        mascota1.vacunado = true;

        Console.WriteLine("Nombre: " + mascota1.nombre);
        Console.WriteLine("Especie: " + mascota1.especie);
        Console.WriteLine("Edad: " + mascota1.edad);
        Console.WriteLine("Peso: " + mascota1.peso);
        Console.WriteLine("Vacunado: " + mascota1.vacunado);
    }
}
