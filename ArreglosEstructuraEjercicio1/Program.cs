using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosEstructuraEjercicio1
{
    internal class Program
    {
        static void ejercicio1()
        {
            // Se crea un arreglo de 6 posiciones:
            // 5 para los parciales y 1 para el promedio.
            double[] calificaciones = new double[6];

            // Instancia de la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Llenamos las primeras 5 posiciones con calificaciones aleatorias entre 0 y 10.
            for (int i = 0; i < 5; i++)
            {
                // Genera un número aleatorio de tipo double entre 0 y 10, redondeado a 2 decimales.
                calificaciones[i] = Math.Round(rnd.NextDouble() * 10, 2);
            }

            // Calculamos la suma de las 5 calificaciones.
            double suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += calificaciones[i];
            }

            // Calculamos el promedio y lo asignamos a la última posición del arreglo.
            double promedio = suma / 5;
            calificaciones[5] = Math.Round(promedio, 2);  // Redondeamos el promedio a 2 decimales.

            // Mostramos las calificaciones parciales.
            Console.WriteLine("Calificaciones parciales:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Parcial {i + 1}: {calificaciones[i]}");
            }

            // Mostramos el promedio.
            Console.WriteLine("\nPromedio: " + calificaciones[5]);
        }

        static void ejercicio2()
        {
            // Declaramos los tres arreglos:
            // groupA y groupB contendrán los promedios de cada alumno en los dos grupos.
            // highest almacenará el promedio más alto de cada posición.
            double[] groupA = new double[5];
            double[] groupB = new double[5];
            double[] highest = new double[5];

            // Instancia de la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Llenamos los arreglos groupA y groupB con promedios aleatorios entre 0 y 10, redondeados a 2 decimales.
            for (int i = 0; i < 5; i++)
            {
                groupA[i] = Math.Round(rnd.NextDouble() * 10, 2);
                groupB[i] = Math.Round(rnd.NextDouble() * 10, 2);
            }

            // Para cada posición, comparamos los promedios y guardamos el mayor en el arreglo highest.
            for (int i = 0; i < 5; i++)
            {
                highest[i] = (groupA[i] >= groupB[i]) ? groupA[i] : groupB[i];
            }

            // Mostramos los promedios de cada grupo (opcional).
            Console.WriteLine("Promedios del Grupo A:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {groupA[i]}");
            }

            Console.WriteLine("\nPromedios del Grupo B:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Alumno {i + 1}: {groupB[i]}");
            }

            // Imprimimos los promedios más altos de cada posición.
            Console.WriteLine("\nPromedios más altos (por posición):");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Posición {i + 1}: {highest[i]}");
            }
        }

        static void ejercicio3()
        {
            // Declaramos un arreglo de 5 renglones y 4 columnas.
            // Las primeras 3 columnas (índices 0 a 2) almacenarán los parciales,
            // y la cuarta columna (índice 3) almacenará el promedio.
            double[,] calificaciones = new double[5, 4];

            // Instanciamos la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Recorremos cada alumno (cada renglón).
            for (int i = 0; i < 5; i++)
            {
                double suma = 0;

                // Generamos y almacenamos 3 parciales aleatorios para el alumno actual.
                // Se utilizan los índices 0, 1 y 2 para los parciales.
                for (int j = 0; j < 3; j++)
                {
                    // Genera un número aleatorio entre 0 y 10, redondeado a 2 decimales.
                    double parcial = Math.Round(rnd.NextDouble() * 10, 2);
                    calificaciones[i, j] = parcial;
                    suma += parcial;
                }

                // Calculamos el promedio de los 3 parciales y lo almacenamos en la cuarta columna (índice 3).
                double promedio = Math.Round(suma / 3, 2);
                calificaciones[i, 3] = promedio;
            }

            // Mostramos en consola las calificaciones y el promedio de cada alumno.
            Console.WriteLine("Alumno\tParcial 1\tParcial 2\tParcial 3\tPromedio");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Alumno {i + 1}:\t");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{calificaciones[i, j]}\t\t");
                }
                Console.WriteLine();
            }
        }

        static void ejercicio4()
        {
            // Declaramos la matriz de 10 renglones y 3 columnas:
            // Columna 0: Promedio del Grupo A.
            // Columna 1: Promedio del Grupo B.
            // Columna 2: Promedio más alto entre el Grupo A y B.
            double[,] promedios = new double[10, 3];

            // Instancia de la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Se llenan las dos primeras columnas con promedios aleatorios entre 0 y 10.
            for (int i = 0; i < 10; i++)
            {
                // Generamos los promedios para cada grupo y redondeamos a 2 decimales.
                double promedioA = Math.Round(rnd.NextDouble() * 10, 2);
                double promedioB = Math.Round(rnd.NextDouble() * 10, 2);

                promedios[i, 0] = promedioA;
                promedios[i, 1] = promedioB;

                // Determinamos y almacenamos en la tercera columna el mayor promedio de ambos grupos.
                promedios[i, 2] = (promedioA >= promedioB) ? promedioA : promedioB;
            }

            // Imprimimos los promedios de cada alumno.
            Console.WriteLine("Alumno\tGrupo A\tGrupo B\tMayor Promedio");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Alumno {i + 1}:\t{promedios[i, 0]}\t{promedios[i, 1]}\t{promedios[i, 2]}");
            }
        }

        static void ejercicio5()
        {
            // Declaramos un arreglo para almacenar las ventas de 100 clientes.
            double[] ventas = new double[100];

            // Variable para acumular el total de ingresos.
            double totalIngresos = 0.0;

            // Instanciamos la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Simulamos las ventas para 100 clientes.
            // Se asume que cada venta es un valor aleatorio entre 1 y 100 (puede ajustarse según se requiera).
            for (int i = 0; i < ventas.Length; i++)
            {
                // Genera una venta aleatoria entre 1 y 100, redondeada a 2 decimales.
                double venta = Math.Round(rnd.NextDouble() * 100 + 1, 2);
                ventas[i] = venta;

                // Acumulamos la venta en el total de ingresos.
                totalIngresos += venta;
            }

            // Imprimimos las ventas individuales de cada cliente (opcional).
            Console.WriteLine("Ventas por cliente:");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"Cliente {i + 1}: ${ventas[i]}");
            }

            // Imprimimos el ingreso total del supermercado.
            Console.WriteLine("\nIngreso total del supermercado: $" + totalIngresos);
        }

        static void ejercicio6()
        {
            // Declaramos un arreglo para almacenar 20 números.
            int[] numeros = new int[20];

            // Variables para contar números pares e impares.
            int contadorPares = 0;
            int contadorImpares = 0;

            // Instanciamos la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Generamos 20 números aleatorios (por ejemplo, entre 0 y 100) y los almacenamos en el arreglo.
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(0, 101);  // Genera un número entre 0 y 100 (inclusive 0, exclusivo 101)
            }

            // Recorremos el arreglo para contar cuántos números son pares e impares.
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                    contadorPares++;
            }
            contadorImpares = numeros.Length - contadorPares;

            // Mostramos los números generados.
            Console.WriteLine("Números generados:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}: {numeros[i]}");
            }

            // Mostramos la cantidad de números pares e impares.
            Console.WriteLine("\nCantidad de números pares: " + contadorPares);
            Console.WriteLine("Cantidad de números impares: " + contadorImpares);
        }

        static void ejercicio7()
        {
            // Declaramos tres arreglos de 20 elementos cada uno.
            int[] numeros = new int[20];
            int[] cuadrados = new int[20];
            int[] cubos = new int[20];

            // Instanciamos la clase Random para generar números aleatorios.
            Random rnd = new Random();

            // Generamos 20 números aleatorios (por ejemplo, entre 0 y 100) y calculamos sus cuadrados y cubos.
            for (int i = 0; i < 20; i++)
            {
                // Genera un número aleatorio entre 0 y 100.
                numeros[i] = rnd.Next(0, 101);

                // Calcula y almacena el cuadrado y el cubo del número.
                cuadrados[i] = numeros[i] * numeros[i];
                cubos[i] = numeros[i] * numeros[i] * numeros[i];
            }

            // Mostramos el contenido de los arreglos en formato de tabla.
            Console.WriteLine("Número\tCuadrado\tCubo");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{numeros[i]}\t{cuadrados[i]}\t\t{cubos[i]}");
            }
        }

        static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("      MENÚ DE EJERCICIOS");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Ejercicio 6");
            Console.WriteLine("7. Ejercicio 7");
            Console.WriteLine("0. Salir");
            Console.WriteLine("==================================");
            Console.Write("Ingrese una opción: ");
        }

        static bool ValidarInput(ref int opc)
        {
            if (!int.TryParse(Console.ReadLine(), out opc))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        static void seleccionarEjercicios(ref int opc)
        {
            Console.Clear();
            switch (opc)
            {
                case 1:
                    ejercicio1();
                    break;
                case 2:
                    ejercicio2();
                    break;
                case 3:
                    ejercicio3();
                    break;
                case 4:
                    ejercicio4();
                    break;
                case 5:
                    ejercicio5();
                    break;
                case 6:
                    ejercicio6();
                    break;
                case 7:
                    ejercicio7();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            if (opc != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            int opcion = -1;

            do
            {
                ImprimirMenu();
                if (!ValidarInput(ref opcion)) { continue; }
                seleccionarEjercicios(ref opcion);
            } while (opcion != 0);
        }
    }
}