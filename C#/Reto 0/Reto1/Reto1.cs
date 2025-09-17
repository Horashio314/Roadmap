using System;
using System.Linq;

/*
 * EJERCICIO:
 * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
 *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
 *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
 * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
 *   que representen todos los tipos de estructuras de control que existan
 *   en tu lenguaje:
 *   Condicionales, iterativas, excepciones...
 * - Debes hacer print por consola del resultado de todos los ejemplos.
 */

namespace Aritmetico.Reto1
{

    class Aritmetica
    {
        static void Main()
        {
            int a = 10, b = 3;
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            int modulo = a % b;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Módulo: {modulo}");
        }
    }

    class Logicos
    {
        static void Main()
        {
            bool x = true, y = false;
            bool and = x && y;
            bool or = x || y;
            bool not = !x;

            Console.WriteLine($"x AND y: {and}");   // false
            Console.WriteLine($"x OR y: {or}");     // true
            Console.WriteLine($"NOT x: {not}");     // false

        }
    }

    class Asignacion
    {
        static void Main()
        {
            int c = 5;
            c += 3;  // equivalente a c = c + 3; c = 8
            Console.WriteLine($"c después de c += 3: {c}");
            c -= 2;  // c = 6
            Console.WriteLine($"c después de c -= 2: {c}");
            c *= 4;  // c = 24
            Console.WriteLine($"c después de c *= 4: {c}");
            c /= 3;  // c = 8
            Console.WriteLine($"c después de c /= 3: {c}");
            c %= 5;  // c = 3
            Console.WriteLine($"c después de c %= 5: {c}");
        }
    }

    class Nivel_de_Bits // ?/?
    {
        static void Main()
        {
            int p = 6;  // 0110 en binario
            int q = 3;  // 0011 en binario
            int andBit = p & q;   // 2 (0010)
            int orBit = p | q;    // 7 (0111)
            int xorBit = p ^ q;   // 5 (0101)
            int notBit = ~p;      // -7 (complemento a uno)
            int shiftLeft = p << 1;  // 12 (1100)
            int shiftRight = p >> 1; // 3 (0011)

            Console.WriteLine($"p & q = {andBit}");         // 2
            Console.WriteLine($"p | q = {orBit}");          // 7
            Console.WriteLine($"p ^ q = {xorBit}");         // 5
            Console.WriteLine($"~p = {notBit}");             // -7
            Console.WriteLine($"p << 1 = {shiftLeft}");     // 12
            Console.WriteLine($"p >> 1 = {shiftRight}");    // 3

        }
    }

    class Comparación
    {
        static void Main()
        {
            int m = 5, n = 10;
            bool igual = (m == n);       // false
            bool diferente = (m != n);   // true
            bool mayor = (m > n);        // false
            bool menor = (m < n);        // true
            bool mayorIgual = (m >= 5);  // true
            bool menorIgual = (n <= 10); // true



        }
    }

    class Identidad // ???
    {
        static void Main()
        {
            object obj1 = new object();
            object obj2 = obj1;
            object obj3 = new object();

            bool mismaReferencia1 = Object.ReferenceEquals(obj1, obj2); // true
            bool mismaReferencia2 = Object.ReferenceEquals(obj1, obj3); // false


        }
    }

    class Pertenencia  // ???
    {
        static void Main()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            bool contiene3 = Array.Exists(numeros, element => element == 3); // true


        }
    }

    class Tipo_Estructuras
    {
        static void Main()
        {
            int x = 15, y = 20;

            // Estructura condicional if else
            if (x > y)
            {
                Console.WriteLine("x es mayor que y");
            }
            else if (x == y)
            {
                Console.WriteLine("x es igual a y");
            }
            else
            {
                Console.WriteLine("x es menor que y");
            }

            // Estructura switch
            int opcion = 2;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elegiste la opción 1");
                    break;
                case 2:
                    Console.WriteLine("Elegiste la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Elegiste la opción 3");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            // Bucle for
            Console.WriteLine("Bucle for:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }

            // Bucle while
            Console.WriteLine("Bucle while:");
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            // Bucle do-while
            Console.WriteLine("Bucle do-while:");
            int valor = 0;
            do
            {
                Console.WriteLine($"Valor: {valor}");
                valor++;
            } while (valor < 5);

            // Manejo de excepciones con try-catch
            try
            {
                int divisor = 0;
                int resultado = y / divisor;  // Esto lanzará una excepción
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            finally
            {
                Console.WriteLine("Bloque finally: se ejecuta siempre.");
            }
        }
    }

}