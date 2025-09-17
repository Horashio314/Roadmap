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

    class Operadores
    {

         static void Main() // Punto de arranque del programa
         {
           Aritmetica(); // Llamados a todos los elementos
            Logicos();
           Asignacion();
            Nivel_de_Bits();
           Comparacion();
           Identidad();
           Pertenencia();
           Tipo_Estructuras();
         }

        static void Aritmetica()
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
    
        static void Logicos()
        {
            bool x = true, y = false;
            bool and = x && y;
            bool or = x || y;
            bool not = !x;

            Console.WriteLine($"x AND y: {and}");   // false
            Console.WriteLine($"x OR y: {or}");     // true
            Console.WriteLine($"NOT x: {not}");     // false

        }
    
        static void Asignacion()
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
    
        static void Nivel_de_Bits() // ?/?
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

        static void Comparacion()
        {
            int m = 5, n = 10;
            bool igual = (m == n);       // false
            bool diferente = (m != n);   // true
            bool mayor = (m > n);        // false
            bool menor = (m < n);        // true
            bool mayorIgual = (m >= 5);  // true
            bool menorIgual = (n <= 10); // true



        }

        static void Identidad() // ???
        {
            object obj1 = new object();
            object obj2 = obj1;
            object obj3 = new object();

            bool mismaReferencia1 = Object.ReferenceEquals(obj1, obj2); // true
            bool mismaReferencia2 = Object.ReferenceEquals(obj1, obj3); // false


        }
   
        static void Pertenencia() // ???
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            bool contiene3 = Array.Exists(numeros, element => element == 3); // true


        }
    
        static void Tipo_Estructuras() // ???
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

/* Notas personales:

===========================================================================================================

Main: El programa está contenido en una clase llamada Operadores. Dentro de esta clase está el método
      estático Main(), que es el punto de entrada del programa. Cuando lo ejecutes, se llaman varias
      funciones que muestran ejemplos de operadores y estructuras.

===========================================================================================================

Aritmetica: Define dos números a y b y realiza operaciones básicas: suma, resta, multiplicación,
            división y módulo (resto de una división).

===========================================================================================================

Logicos: Define dos variables booleanas (true o false) y hace operaciones lógicas: AND (&&), OR (||)
         y NOT (!).

===========================================================================================================

Asignacion: Muestra cómo se pueden usar operadores de asignación combinados para modificar valores 
            (por ejemplo, +=, -=, etc.). Explica cómo cambiar el valor de una variable acumulando resultados.

===========================================================================================================

Nivel de bits: Usa operadores a nivel binario como AND, OR, XOR, NOT, desplazamientos a la izquierda y derecha.
               Muestra cómo las operaciones afectan valores enteros interpretados como bits.

===========================================================================================================

Comparacion: Compara dos números con operadores relacionales (==, !=, >, <, >=, <=) y guarda los resultados 
             booleanos.

===========================================================================================================

Identidad: Compara si dos variables apuntan al mismo objeto en memoria (referencias). Es útil para entender 
           el concepto de identidad en programación orientada a objetos.

===========================================================================================================

Pertenencia: Usa un arreglo y verifica si un elemento está contenido dentro con un método que verifica
             pertenencia (Array.Exists).

===========================================================================================================

Estructura de control:
    - Condicionales if, else if, else.
    - Estructura switch para múltiples opciones.
    - Bucles: for, while, do-while.
    - Manejo de excepciones con try-catch-finally para capturar errores y manejar situaciones inesperadas
      (ejemplo: división por cero).

===========================================================================================================

*/