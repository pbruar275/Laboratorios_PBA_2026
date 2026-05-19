using System;

class Parcela
{
    public string tipoCultivo;
    public int crecimiento;
    public int mesesNecesarios;
    public bool regada;
    public bool vacia;

    public Parcela()
    {
        tipoCultivo = "Vacía";
        crecimiento = 0;
        mesesNecesarios = 0;
        regada = false;
        vacia = true;
    }
}

class Program
{
    static void Main()
    {
        double dinero;
        int empleados;
        double sueldoEmpleado;
        int meses;
        int filas;
        int columnas;

        double totalIngresos = 0;
        double totalEgresos = 0;
        int totalRiegos = 0;

        int cosechasPapa = 0;
        int cosechasTomate = 0;
        int cosechasFresa = 0;

        Console.WriteLine("===== GESTIÓN DE GRANJA =====\n");

        dinero = LeerDouble("Ingrese dinero inicial: ");
        empleados = LeerEntero("Ingrese cantidad de empleados: ");
        sueldoEmpleado = LeerDouble("Ingrese sueldo por empleado: ");
        meses = LeerEntero("Ingrese meses a simular: ");
        filas = LeerEntero("Ingrese cantidad de filas: ");
        columnas = LeerEntero("Ingrese cantidad de columnas: ");

        Parcela[,] parcelas = new Parcela[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                parcelas[i, j] = new Parcela();
            }
        }

        int opcion = 0;

        while (opcion != 5 && meses > 0 && dinero > 0)
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcelas");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar de mes");
            Console.WriteLine("5. Salir");

            opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:

                    int filaSembrar = LeerEntero("Fila: ");
                    int columnaSembrar = LeerEntero("Columna: ");

                    if (PosicionValida(filaSembrar, columnaSembrar, filas, columnas))
                    {
                        if (parcelas[filaSembrar, columnaSembrar].vacia)
                        {
                            Console.WriteLine("Seleccione cultivo:");
                            Console.WriteLine("1. Papa");
                            Console.WriteLine("2. Tomate");
                            Console.WriteLine("3. Fresa");

                            int cultivo = LeerEntero("Opción: ");

                            if (cultivo == 1)
                            {
                                parcelas[filaSembrar, columnaSembrar].tipoCultivo = "Papa";
                                parcelas[filaSembrar, columnaSembrar].mesesNecesarios = 2;
                            }
                            else if (cultivo == 2)
                            {
                                parcelas[filaSembrar, columnaSembrar].tipoCultivo = "Tomate";
                                parcelas[filaSembrar, columnaSembrar].mesesNecesarios = 3;
                            }
                            else if (cultivo == 3)
                            {
                                parcelas[filaSembrar, columnaSembrar].tipoCultivo = "Fresa";
                                parcelas[filaSembrar, columnaSembrar].mesesNecesarios = 4;
                            }
                            else
                            {
                                Console.WriteLine("Cultivo inválido.");
                                break;
                            }

                            parcelas[filaSembrar, columnaSembrar].crecimiento = 0;
                            parcelas[filaSembrar, columnaSembrar].regada = false;
                            parcelas[filaSembrar, columnaSembrar].vacia = false;

                            Console.WriteLine("Cultivo sembrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("La parcela ya tiene una siembra.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }

                    break;

                case 2:

                    int filaRegar = LeerEntero("Fila: ");
                    int columnaRegar = LeerEntero("Columna: ");

                    if (PosicionValida(filaRegar, columnaRegar, filas, columnas))
                    {
                        Parcela parcela = parcelas[filaRegar, columnaRegar];

                        if (!parcela.vacia)
                        {
                            if (!parcela.regada)
                            {
                                if (dinero >= 40)
                                {
                                    parcela.regada = true;
                                    dinero -= 40;
                                    totalEgresos += 40;
                                    totalRiegos++;

                                    Console.WriteLine("Parcela regada correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("No hay suficiente dinero.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La parcela ya fue regada este mes.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La parcela está vacía.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }

                    break;

                case 3:

                    int filaConsulta = LeerEntero("Fila: ");
                    int columnaConsulta = LeerEntero("Columna: ");

                    if (PosicionValida(filaConsulta, columnaConsulta, filas, columnas))
                    {
                        Parcela parcelaConsulta = parcelas[filaConsulta, columnaConsulta];

                        if (!parcelaConsulta.vacia)
                        {
                            Console.WriteLine("Tipo de cultivo: " + parcelaConsulta.tipoCultivo);
                            Console.WriteLine("Crecimiento: " + parcelaConsulta.crecimiento + " / " + parcelaConsulta.mesesNecesarios + " meses");

                            if (parcelaConsulta.regada)
                            {
                                Console.WriteLine("Regada este mes: Sí");
                            }
                            else
                            {
                                Console.WriteLine("Regada este mes: No");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La parcela está vacía.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posición inválida.");
                    }

                    break;

                case 4:

                    meses--;

                    double pagoEmpleados = empleados * sueldoEmpleado;

                    dinero -= pagoEmpleados;
                    totalEgresos += pagoEmpleados;

                    Console.WriteLine("\nSe pagó Q" + pagoEmpleados + " a empleados.");

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            Parcela parcelaActual = parcelas[i, j];

                            if (!parcelaActual.vacia)
                            {
                                if (parcelaActual.regada)
                                {
                                    parcelaActual.crecimiento += 2;
                                }
                                else
                                {
                                    parcelaActual.crecimiento += 1;
                                }

                                Console.WriteLine("La parcela [" + i + "," + j + "] avanzó crecimiento.");

                                if (parcelaActual.crecimiento >= parcelaActual.mesesNecesarios)
                                {
                                    double ganancia = 0;

                                    if (parcelaActual.tipoCultivo == "Papa")
                                    {
                                        ganancia = 450;
                                        cosechasPapa++;
                                    }
                                    else if (parcelaActual.tipoCultivo == "Tomate")
                                    {
                                        ganancia = 650;
                                        cosechasTomate++;
                                    }
                                    else if (parcelaActual.tipoCultivo == "Fresa")
                                    {
                                        ganancia = 900;
                                        cosechasFresa++;
                                    }

                                    dinero += ganancia;
                                    totalIngresos += ganancia;

                                    Console.WriteLine("Se cosechó " + parcelaActual.tipoCultivo + " y se ganaron Q" + ganancia);

                                    parcelas[i, j] = new Parcela();
                                }
                                else
                                {
                                    parcelaActual.regada = false;
                                }
                            }
                        }
                    }

                    Console.WriteLine("Meses restantes: " + meses);
                    Console.WriteLine("Dinero actual: Q" + dinero);

                    break;

                case 5:

                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        Console.WriteLine("\n===== REPORTE FINAL =====");

        Console.WriteLine("Dinero final: Q" + dinero);
        Console.WriteLine("Total ingresos: Q" + totalIngresos);
        Console.WriteLine("Total egresos: Q" + totalEgresos);
        Console.WriteLine("Meses restantes: " + meses);

        Console.WriteLine("Cosechas de papa: " + cosechasPapa);
        Console.WriteLine("Cosechas de tomate: " + cosechasTomate);
        Console.WriteLine("Cosechas de fresa: " + cosechasFresa);

        Console.WriteLine("Total de riegos: " + totalRiegos);

        int parcelasVacias = 0;
        int parcelasPapa = 0;
        int parcelasTomate = 0;
        int parcelasFresa = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (parcelas[i, j].vacia)
                {
                    parcelasVacias++;
                }
                else if (parcelas[i, j].tipoCultivo == "Papa")
                {
                    parcelasPapa++;
                }
                else if (parcelas[i, j].tipoCultivo == "Tomate")
                {
                    parcelasTomate++;
                }
                else if (parcelas[i, j].tipoCultivo == "Fresa")
                {
                    parcelasFresa++;
                }
            }
        }

        Console.WriteLine("Parcelas con papa: " + parcelasPapa);
        Console.WriteLine("Parcelas con tomate: " + parcelasTomate);
        Console.WriteLine("Parcelas con fresa: " + parcelasFresa);
        Console.WriteLine("Parcelas vacías: " + parcelasVacias);

        Console.WriteLine("\nFin de la simulación.");
    }

    static bool PosicionValida(int fila, int columna, int filas, int columnas)
    {
        if (fila >= 0 && fila < filas && columna >= 0 && columna < columnas)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int LeerEntero(string mensaje)
    {
        int valor;
        bool valido = false;

        do
        {
            Console.Write(mensaje);

            if (int.TryParse(Console.ReadLine(), out valor))
            {
                if (valor > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un número mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

        } while (!valido);

        return valor;
    }

    static double LeerDouble(string mensaje)
    {
        double valor;
        bool valido = false;

        do
        {
            Console.Write(mensaje);

            if (double.TryParse(Console.ReadLine(), out valor))
            {
                if (valor > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un número mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

        } while (!valido);

        return valor;
    }
}
