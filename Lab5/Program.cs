using System;

class Program
{
    static void Main()
    {
        // =========================
        // EJERCICIO 1
        // =========================
        Console.WriteLine("=== EJERCICIO 1 ===");

        Console.Write("Ingrese ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese PIN: ");
        int pin = int.Parse(Console.ReadLine());

        Console.Write("Ingrese Token: ");
        int token = int.Parse(Console.ReadLine());

        Console.Write("Modo seguro (1 = si, 0 = no): ");
        int modo = int.Parse(Console.ReadLine());

        bool idCorrecto = (id == 2026);
        bool pinCorrecto = (pin == 1234);
        bool tokenCorrecto = (token == 777);

        if (idCorrecto)
            Console.WriteLine("Usuario reconocido.");
        else
            Console.WriteLine("Usuario no reconocido.");

        if (pinCorrecto)
            Console.WriteLine("PIN correcto.");
        else
            Console.WriteLine("PIN incorrecto.");

        if (tokenCorrecto)
            Console.WriteLine("Token válido.");
        else
            Console.WriteLine("Token inválido.");

        if (modo == 1)
            Console.WriteLine("Modo seguro activado.");
        else
            Console.WriteLine("Modo seguro desactivado.");

        if (idCorrecto && pinCorrecto && tokenCorrecto)
            Console.WriteLine("Acceso total concedido.");
        else
            Console.WriteLine("Acceso denegado.");

        if (modo == 1)
        {
            if (token >= 700)
                Console.WriteLine("Regla extra aprobada.");
            else
                Console.WriteLine("Regla extra fallida.");
        }

        Console.WriteLine();


        // =========================
        // EJERCICIO 2
        // =========================
        Console.WriteLine("=== EJERCICIO 2 ===");

        Console.Write("Ingrese PIN: ");
        int pin2 = int.Parse(Console.ReadLine());

        if (pin2 >= 1000 && pin2 <= 9999)
            Console.WriteLine("PIN de 4 dígitos: OK.");
        else
            Console.WriteLine("PIN inválido.");

        if (pin2 % 2 == 0)
            Console.WriteLine("PIN par.");
        else
            Console.WriteLine("PIN impar.");

        if (pin2 % 5 == 0)
            Console.WriteLine("Múltiplo de 5.");
        else
            Console.WriteLine("No es múltiplo de 5.");

        if ((pin2 >= 1000 && pin2 <= 9999) && (pin2 % 2 == 0) && (pin2 % 5 != 0))
            Console.WriteLine("PIN aceptado.");
        else
            Console.WriteLine("PIN rechazado.");

        Console.WriteLine();


        // =========================
        // EJERCICIO 3
        // =========================
        Console.WriteLine("=== EJERCICIO 3 ===");

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Aceptó términos (1/0): ");
        int terminos = int.Parse(Console.ReadLine());

        Console.Write("2FA (1/0): ");
        int dosFA = int.Parse(Console.ReadLine());

        Console.Write("Puntaje: ");
        int puntaje = int.Parse(Console.ReadLine());

        bool codigoCorrecto = (codigo == 2026);
        bool edadValida = (edad >= 18);
        bool terminosOk = (terminos == 1);
        bool faOk = (dosFA == 1);
        bool puntajeOk = (puntaje >= 70);

        if (codigoCorrecto)
            Console.WriteLine("Código correcto.");
        else
            Console.WriteLine("Código incorrecto.");

        if (edadValida)
            Console.WriteLine("Edad válida.");
        else
            Console.WriteLine("Edad no válida.");

        if (terminosOk)
            Console.WriteLine("Términos aceptados.");
        else
            Console.WriteLine("Debe aceptar términos.");

        if (faOk)
            Console.WriteLine("2FA activado.");
        else
            Console.WriteLine("2FA no activado.");

        if (puntajeOk)
            Console.WriteLine("Puntaje suficiente.");
        else
            Console.WriteLine("Puntaje insuficiente.");

        if (codigoCorrecto && edadValida && terminosOk && faOk && puntajeOk)
            Console.WriteLine("Cuenta activada.");
        else
            Console.WriteLine("Cuenta NO activada.");

        Console.WriteLine();


        // =========================
        // RETO FINAL
        // =========================
        Console.WriteLine("=== RETO FINAL ===");

        Console.Write("Nota: ");
        int nota = int.Parse(Console.ReadLine());

        Console.Write("Minutos tarde: ");
        int minutos = int.Parse(Console.ReadLine());

        Console.Write("Solvencia (1/0): ");
        int solvencia = int.Parse(Console.ReadLine());

        Console.Write("Identificación (1/0): ");
        int iden = int.Parse(Console.ReadLine());

        Console.Write("Calculadora (1/0): ");
        int calc = int.Parse(Console.ReadLine());

        if (nota >= 61)
            Console.WriteLine("Requisito académico aprobado.");
        else
            Console.WriteLine("No aprobado.");

        if (minutos <= 10)
            Console.WriteLine("Hora válida.");
        else
            Console.WriteLine("Fuera de tiempo.");

        if (solvencia == 1)
            Console.WriteLine("Solvencia OK.");
        else
            Console.WriteLine("Sin solvencia.");

        if (iden == 1)
            Console.WriteLine("Identificación OK.");
        else
            Console.WriteLine("Sin identificación.");

        if (calc == 1)
            Console.WriteLine("Calculadora OK.");
        else
            Console.WriteLine("Sin calculadora.");

        if (nota >= 61 && minutos <= 10 && solvencia == 1 && iden == 1)
            Console.WriteLine("Acceso concedido.");
        else
            Console.WriteLine("Acceso denegado.");

        if (minutos > 0 && minutos <= 10)
            Console.WriteLine("Advertencia: llegó tarde.");
    }
}
