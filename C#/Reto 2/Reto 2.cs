using System;

class Program
{
    // Variable global (vale en toda la clase)
    static int contadorGlobal = 0;

    static void Main(string[] args)
    {
        // 1. Función sin parámetros y sin retorno
        Saludar(); // Va a mostrar un saludo

        // 2. Función con un parámetro y sin retorno
        SaludarPersona("Watson");

        // 3. Función con varios parámetros y sin retorno
        SumarYMostrar(4, 5);

        // 4. Función con parámetros y con retorno
        int resultado = Multiplicar(3, 7);
        Console.WriteLine("El resultado de la multiplicación es: " + resultado);

        // 5. Función dentro de otra función (función local)
        FuncionExterior();

        // 6. Probamos variables globales y locales
        int variableLocal = 10; // Variable local
        Console.WriteLine("Valor inicial de variable global: " + contadorGlobal);
        Console.WriteLine("Valor inicial de variable local: " + variableLocal);

        Incrementar(contadorGlobal, variableLocal); // Pasamos variables

        Console.WriteLine("Después de incrementar:");
        Console.WriteLine("Variable global: " + contadorGlobal);
        Console.WriteLine("Variable local (no cambió): " + variableLocal);

        // 7. Uso de función ya creada en C#: Math.Sqrt() (raíz cuadrada)
        double raiz = Math.Sqrt(9);
        Console.WriteLine("La raíz cuadrada de 9 es: " + raiz);
    }

    // Función sin parámetros y sin retorno
    static void Saludar()
    {
        Console.WriteLine("¡Hola! Esto es una función sin parámetros y sin retorno.");
    }

    // Función con un parámetro y sin retorno
    static void SaludarPersona(string nombre)
    {
        Console.WriteLine("¡Hola, " + nombre + "!");
    }

    // Función con varios parámetros y sin retorno
    static void SumarYMostrar(int num1, int num2)
    {
        int suma = num1 + num2;
        Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);
    }

    // Función con parámetros y con un valor de retorno
    static int Multiplicar(int a, int b)
    {
        return a * b; // Devuelve el resultado
    }

    // Función dentro de otra función (función local)
    static void FuncionExterior()
    {
        Console.WriteLine("Esta es la función exterior.");

        // Función local (solo existe aquí)
        void FunciónInterior()
        {
            Console.WriteLine("Esta es la función interior.");
        }

        // Llamamos a la función interna
        FunciónInterior();
    }

    // Función que incrementa la variable global y recibe una variable local
    static void Incrementar(int global, int local)
    {
        // Incrementamos la variable global
        global++;
        // Nota: esto no cambia la variable global original, solo la copia
        contadorGlobal = global;

        // La variable local (pasada como parámetro) solo cambia aquí
        local++;
        Console.WriteLine("Dentro de la función: global = " + global);
        Console.WriteLine("Dentro de la función: local = " + local);
    }
}


/* 

Notas personales:

===========================================================================================================

Funciones sin parámetros ni retorno: solo muestran un mensaje.

===========================================================================================================

Funciones con parámetros: reciben datos, como SaludarPersona

===========================================================================================================

Funciones con retorno: devuelven un valor, como Multiplicar.

===========================================================================================================

Funciones dentro de funciones: FunciónInterior(), solo existe dentro de FuncionExterior().

===========================================================================================================

Variables globales: contadorGlobal, se puede usar en toda la clase. Casos practicos como, 
                    - Compartir información: Permiten que diferentes partes del programa accedan 
                    a un mismo dato sin tener que enviarlo de una función a otra.
                    - Guardar estado común: Sirven para mantener datos que varias funciones 
                    necesitan consultar o actualizar, como un contador o una configuración.
                    - Facilitan el acceso: No se debe crear la variable muchas veces, solo una 
                    vez y está lista para usarse en varios lugares.

===========================================================================================================

Variables locales: variableLocal y los parámetros, solo viven dentro de su función.

===========================================================================================================

Uso de funciones predefinidas: Math.Sqrt() calcula la raíz cuadrada.

===========================================================================================================

*/