using System;

class Program
{
    static void Main()
    {
        // =====================================================
        // EJERCICIO 1
        // =====================================================

        Console.WriteLine("===== EJERCICIO 1 =====");

        // Error encontrado:
        // Tipo de error: Sintaxis
        // Corrección realizada:
        // Se agregó punto y coma después de using System;
        // Explicación:
        // En C# todas las instrucciones deben finalizar con punto y coma.

        // Error encontrado:
        // Tipo de error: Sintaxis
        // Corrección realizada:
        // Se agregó ; después de string nombre
        // Explicación:
        // Las variables deben terminar con ;

        // Error encontrado:
        // Tipo de error: Sintaxis
        // Corrección realizada:
        // Se agregó ; después de int.Parse(Console.ReadLine())
        // Explicación:
        // Faltaba finalizar la instrucción correctamente.

        // Error encontrado:
        // Tipo de error: Sintaxis
        // Corrección realizada:
        // Se corrigieron las llaves del if y else.
        // Explicación:
        // El else estaba mal ubicado y el bloque no cerraba correctamente.

        string nombre;
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }

        // =====================================================
        // EJERCICIO 2
        // =====================================================

        Console.WriteLine("\n===== EJERCICIO 2 =====");

        double nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        // Error encontrado:
        // Tipo de error: Lógico
        // Corrección realizada:
        // Se agregaron paréntesis.
        // Explicación:
        // El programa compilaba, pero la división solo afectaba a nota3.

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio es: " + promedio);

        // Error encontrado:
        // Tipo de error: Lógico
        // Corrección realizada:
        // Se cambió > por >=
        // Explicación:
        // El 61 también debe aprobar.

        if (promedio >= 61)
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }

        // =====================================================
        // EJERCICIO 3
        // =====================================================

        Console.WriteLine("\n===== EJERCICIO 3 =====");

        int[] numeros = new int[5];
        int suma = 0;

        // Error encontrado:
        // Tipo de error: Ejecución
        // Corrección realizada:
        // Se cambió <=5 por <5
        // Explicación:
        // El arreglo tiene posiciones de 0 a 4.

        for (int i = 0; i < 5; i++)
        {
            bool valido = false;

            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");

                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            suma = suma + numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);

        // =====================================================
        // EJERCICIO 4
        // =====================================================

        Console.WriteLine("\n===== EJERCICIO 4 =====");

        double baseRectangulo;
        double alturaRectangulo;

        bool baseValida = false;

        while (!baseValida)
        {
            Console.WriteLine("Ingrese la base:");

            if (double.TryParse(Console.ReadLine(), out baseRectangulo))
            {
                if (baseRectangulo > 0)
                {
                    baseValida = true;
                }
                else
                {
                    Console.WriteLine("La base debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        bool alturaValida = false;

        while (!alturaValida)
        {
            Console.WriteLine("Ingrese la altura:");

            if (double.TryParse(Console.ReadLine(), out alturaRectangulo))
            {
                if (alturaRectangulo > 0)
                {
                    alturaValida = true;
                }
                else
                {
                    Console.WriteLine("La altura debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        Console.WriteLine("El área es: " + area);

        // Error encontrado:
        // Tipo de error: Lógico
        // Corrección realizada:
        // Se cambió >100 por >=100
        // Explicación:
        // El área 100 también debe considerarse grande.

        if (area >= 100)
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }

        // =====================================================
        // EJERCICIO 5
        // =====================================================

        Console.WriteLine("\n===== EJERCICIO 5 =====");

        // Análisis de la solución generada por IA:
        // Error 1:
        // El arreglo comenzaba en 1 y no en 0.

        // Error 2:
        // La condición de mayoría de edad usaba >18.

        // Error 3:
        // El promedio no utilizaba división decimal.

        // Limitación encontrada:
        // La IA generó código que parecía correcto, pero tenía errores de lógica y ejecución.

        // Importancia de la validación humana:
        // El programador debe revisar y probar el código antes de utilizarlo.

        int[] edades = new int[5];
        int sumaEdades = 0;
        int mayores = 0;
        double promedioEdades;

        for (int i = 0; i < 5; i++)
        {
            bool edadValida = false;

            while (!edadValida)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                if (int.TryParse(Console.ReadLine(), out edades[i]))
                {
                    if (edades[i] >= 0)
                    {
                        edadValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La edad no puede ser negativa.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }

            sumaEdades += edades[i];

            if (edades[i] >= 18)
            {
                mayores++;
            }
        }

        promedioEdades = (double)sumaEdades / 5;

        Console.WriteLine("El promedio de edades es: " + promedioEdades);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // =====================================================
        // REFLEXIÓN FINAL
        // =====================================================

        // ¿Por qué una solución generada por Inteligencia Artificial
        // debe ser revisada, probada y validada por una persona?

        // Porque la Inteligencia Artificial puede generar código con errores de sintaxis, lógica o ejecución.
        // Aunque el programa parezca correcto, puede producir resultados incorrectos o fallar durante la ejecución.
        // El programador debe analizar, probar y validar el código para garantizar que funcione correctamente y cumpla con los requisitos solicitados.
    }

    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        // Error encontrado:
        // Tipo de error: Lógico
        // Corrección realizada:
        // Se cambió suma por multiplicación.
        // Explicación:
        // El área de un rectángulo se calcula base * altura.

        double resultado = baseRectangulo * alturaRectangulo;
        return resultado;
    }
}
