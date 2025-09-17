using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Array (arreglo) - tamaño fijo
        int[] array = { 5, 3, 8, 1 };
        Console.WriteLine("Array original:");
        ImprimirArray(array); //  llama a la función ImprimirArray y le pasa como argumento el array llamado array.

        // Actualizar elemento
        array[2] = 10; // cambia el 8 por 10
        Console.WriteLine("Array después de actualizar");
        ImprimirArray(array);

        // Ordenar array
        Array.Sort(array);
        Console.WriteLine("Array ordenado:");
        ImprimirArray(array);

        // 2. List<T> - tamaño dinámico
        List<int> lista = new List<int>() { 7, 4, 2 };
        Console.WriteLine("\nLista original:");
        ImprimirLista(lista);

        // Insertar elementos
        lista.Add(9);
        lista.Insert(1, 6);
        Console.WriteLine("Lista después de insertar:");
        ImprimirLista(lista);

        // Actualizar elemento
        lista[0] = 10;
        Console.WriteLine("Lista después de actualizar:");
        ImprimirLista(lista);

        // Eliminar elementos
        lista.Remove(6);
        lista.RemoveAt(2);
        Console.WriteLine("Lista después de eliminar:");
        ImprimirLista(lista);

        // Ordenar lista
        lista.Sort();
        Console.WriteLine("Lista ordenada:");
        ImprimirLista(lista);

        // 3. Dictionary<TKey,TValue> - colección clave-valor
        Dictionary<string, int> edades = new Dictionary<string, int>()
        {
            {"Luis", 25 },
            {"Watson", 30 },
            {"Marta", 22 }
        };
        Console.WriteLine("\nDiccionario original:");
        ImprimirDiccionario(edades);

        // Insertar o actualizar
        edades["Juan"] = 28;  // inserta nuevo
        edades["Luis"] = 26;   // actualiza Luis

        Console.WriteLine("Diccionario después de insertar/actualizar:");
        ImprimirDiccionario(edades);

        // Eliminar
        edades.Remove("Watson");
        Console.WriteLine("Diccionario después de eliminar a Watson:");
        ImprimirDiccionario(edades);

        // Ordenar diccionario por clave y mostrar
        Console.WriteLine("Diccionario ordenado por clave:");
        foreach (var clave in new SortedSet<string>(edades.Keys))
        {
            Console.WriteLine($"{clave}: {edades[clave]}");
        }
    }

    // Esta función toma el array y imprime en consola todos sus elementos, uno por uno.
    static void ImprimirArray(int[] arr) // Recibe un array de enteros llamado "arr"
    {
        foreach (int num in arr) // En cada vuelta del bucle, la variable num toma el valor de un elemento diferente del array, uno por uno.
        {
            Console.Write(num + " "); // Imprime el número actual (num) en la consola. Después del número, imprime un espacio " " para separar los números que se van mostrando.
        }
        Console.WriteLine(); // Esto hace un salto de línea para que la próxima salida en consola empiece en otra línea.
    }

    static void ImprimirLista(List<int> lista) // Recibe una lista de enteros llamada "lista"
    {
        foreach (int num in lista) // Lo mismo que con el array
        {
            Console.Write(num + " "); // Misma paja
        }
        Console.WriteLine();
    }

    static void ImprimirDiccionario(Dictionary<string, int> dic) // Recibe un diccionario llamado "dic"
    {
        foreach (var item in dic) // En cada vuelta del bucle, item es un objeto que contiene dos partes: la clave (item.Key) y el valor (item.Value)
        {
            Console.WriteLine(item.Key + ": " + item.Value); // Imprime la clave seguida de dos puntos y el valor correspondiente.
        }
    }
}

/* Notas Personales

<>: Indican que una clase, método o interfaz es genérica, es decir, puede  
    trabajar con diferentes tipos de datos sin que tengas que crear muchas 
    versiones para cada tipo.

=============================================================================

[]: Se utilizan para indicar que una variable es un array, es decir,
    una colección o lista de elementos del mismo tipo.

Por ejemplo, cuando escribes int[] numeros; estás diciendo:
"declaro una variable llamada numeros que puede contener varios enteros,
no solo uno".

=============================================================================

Arrays (Arreglos): Son colecciones de tamaño fijo donde guardas varios
valores del mismo tipo. No puedes cambiar su tamaño después de declararlos.

Ejemplo: el array tiene los números 5, 3, 8 y 1.

Se puede modificar cualquiera usando su índice, por ejemplo "array = 10"

Se ordena con Array.Sort()

=============================================================================

Listas: colecciones dinámicas que permiten insertar, borrar, actualizar y 
        ordenar fácilmente con métodos como Add(), Insert(), Remove(), 
        RemoveAt() y Sort()

Add(): sirve para agregar un elemento al final de una lista.

Insert(): se usa para insertar un elemento en una posición específica dentro de la lista.

Remove(): Elimina la primera aparición de un elemento

RemoveAt(): Elimina un elemento por índice

Sort(): se usa para ordenar los elementos de una lista.

=============================================================================

Diccionarios: Guardan pares clave-valor. Puedes agregar, actualizar y eliminar 
              elementos con asignación y Remove(). Para mostrar ordenados, 
              recorremos usando un conjunto ordenado de claves.

clave-valor: Un par clave-valor es una forma de almacenar 
             datos en donde a cada clave, que es un identificador único, le corresponde 
             un valor asociado.

 - Ejemplo:
Clave (Key): "Luis" 	    | Valor (Value): 25 (edad)
Clave (Key): "Watson" 	    | Valor (Value): 30 (edad)

=============================================================================

foreach: Es un tipo especial de bucle que se usa para recorrer todos los
         elementos de una colección (como un array, una lista, o cualquier 
         conjunto de datos) de forma sencilla y clara.

        Se declara especificando el tipo del elemento, un nombre para cada
        elemento dentro del bucle, y la colección que vas a recorrer.


- Uso:
foreach (tipo elemento in coleccion)
    {
         (( Código que usa "elemento" ))
    }   


- Ejemplo: 
1)
string[] nombres = { "Luis", "Watson", "Marta" };

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

2)
Imprime:
Luis
Watson
Marta

=============================================================================

Coleccion: Las listas, los array, etc...
Elemento: La mamada que esta dentro de las listas y demas

*/