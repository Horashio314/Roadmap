using System;

/*
 * EJERCICIO:
 * - Muestra ejemplos de asignación de variables "por valor" y "por referencia", según
 *   su tipo de dato.
 * - Muestra ejemplos de funciones con variables que se les pasan "por valor" y 
 *   "por referencia", y cómo se comportan en cada caso en el momento de ser modificadas.
 * (Entender estos conceptos es algo esencial en la gran mayoría de lenguajes)
 */

class Program
{
    // Función que recibe un entero por valor (copia)
    static void CambiarValor(int x)
    {
        x = 100;  // Solo cambia la copia local
        Console.WriteLine("Dentro de CambiarValor, x = " + x);
    }

    // Función que recibe un entero por referencia (ref)
    static void CambiarValorRef(ref int x)
    {
        x = 100;  // Cambia la variable original
        Console.WriteLine("Dentro de CambiarValorRef, x = " + x);
    }

    // Clase para demostrar paso por referencia con objetos (tipos por referencia)
    class Persona
    {
        public string Nombre;
    }

    // Función que cambia el contenido del objeto
    static void CambiarNombre(Persona p) // Aunque no se usa ref, se pasa una copia de la referencia (puntero) al mismo objeto.
    {
        p.Nombre = "Luis";  // Dentro de la función, se modifica la propiedad Nombre del objeto a "Luis". Como esa referencia apunta al mismo objeto, el cambio es visible afuera de la función.
        Console.WriteLine("Dentro de CambiarNombre, Nombre = " + p.Nombre);
    }

    // Función que intenta reasignar el objeto (no cambia fuera porque la referencia llega por valor)
    static void ReasignarObjeto(Persona p) // Dentro de la función, se crea un nuevo objeto Persona y se asigna a la variable local p.
    {
        p = new Persona();
        p.Nombre = "Carlos"; // Se asigna el nombre "Carlos" a este nuevo objeto.
        Console.WriteLine("Dentro de ReasignarObjeto, Nombre = " + p.Nombre); // Y aqui cambio de "Luis" a "Carlos" de forma local.
    }

    // Función que reasigna objeto pasando la referencia por referencia con 'ref'
    static void ReasignarObjetoRef(ref Persona p)
    {
        p = new Persona();
        p.Nombre = "Carlos";
        Console.WriteLine("Dentro de ReasignarObjetoRef, Nombre = " + p.Nombre);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Variables por valor ==="); // Guardan el valor directamente. Cambiar el valor de una copia NO afecta al original.
        int a = 5; // 'a' guarda el valor 5 directamente
        int b = a; // 'b' es una copia de 'a' (valor 5)
        b = 10;     // cambio 'b' a 10, pero 'a' sigue siendo 5
        Console.WriteLine($"a = {a}, b = {b}");  // a = 5, b = 10

        Console.WriteLine("\n=== Variables por referencia ==="); // Guardan una dirección o referencia de los datos. Dos variables pueden apuntar al mismo objeto, por lo que cambiar a través de una afecta a la otra.
        int[] array1 = { 1, 2, 3 };
        int[] array2 = array1; // 'array2' apunta al mismo array que 'array1', es decir, basicamente es como una redireccion del primer array
        array2[0] = 10; // cambiar 'array2' afecta también a 'array1'
        Console.WriteLine($"array1[0] = {array1[0]}, array2[0] = {array2[0]}");

        Console.WriteLine("\n=== Paso por valor en función ==="); // El valor se copia en el parámetro. Cambios dentro no afectan variable original.
        int num = 5;
        CambiarValor(num);
        Console.WriteLine("Después de CambiarValor, num = " + num);  // Sigue siendo 5

        Console.WriteLine("\n=== Paso por referencia en función ==="); // Lo contrario a lo de arriba. En vez de enviar una copia del valor, se envía una referencia de la variable original.
        int num2 = 5;
        CambiarValorRef(ref num2);
        Console.WriteLine("Después de CambiarValorRef, num2 = " + num2);  // Cambió a 100

        Console.WriteLine("\n=== Paso por referencia con objetos ===");
        Persona persona = new Persona();
        persona.Nombre = "Ana"; // Se crea un objeto Persona con un nombre "ana"
        CambiarNombre(persona); // Se pasa ese objeto a la función
        Console.WriteLine("Después de CambiarNombre, Nombre = " + persona.Nombre);  // Cambió a Luis

        Console.WriteLine("\n=== Reasignar objeto dentro de función (sin ref) ===");
        ReasignarObjeto(persona);
        Console.WriteLine("Después de ReasignarObjeto, Nombre = " + persona.Nombre);  // Sigue Luis por que se cambio arriba

        Console.WriteLine("\n=== Reasignar objeto dentro de función (con ref) ==="); // Mismo pedo que con "Paso por referencia en función" pero ahora con objetos
        ReasignarObjetoRef(ref persona);
        Console.WriteLine("Después de ReasignarObjetoRef, Nombre = " + persona.Nombre);  // Cambió a Carlos
    }
}



/* Notas personales:

=================================================================================================

\n : Dentro de una cadena de texto, \n indica que se debe insertar un salto de línea ahí.

=================================================================================================

Paso por valor en función: El "Paso por valor en función" en C# significa que cuando se 
                           llama a una función y le envias una variable, lo que realmente se 
                           envía a la función es una copia de esa variable, no la variable
                           original.

En español: Basicamente, la variable "a" que es "5", la envian como copia a la funcion
            "CambiarValor", y al llegar a la funcion "CambiarValor" se le asigna ahora
            como nombre "x", para luego asignarle un nuevo valor que ahora sera 100.

=================================================================================================

ref: se usa la palabra clave ref para indicar que un parámetro se pasa por referencia. es decir.
     que estás pasando a la función una referencia directa de la variable original, no una copia.

Data: Los objetos en C# son tipos de referencia, por lo que cuando pasas un objeto a una función
      sin ref, en realidad se pasa una copia de la referencia (la "dirección" que apunta al mismo objeto).

==================================================================================================

*/