/*
 * EJERCICIO:
 * Muestra ejemplos de todas las operaciones que puedes realizar con cadenas de caracteres
 * en tu lenguaje. Algunas de esas operaciones podrían ser (busca todas las que puedas):
 * - Acceso a caracteres específicos, subcadenas, longitud, concatenación, repetición,
 *   recorrido, conversión a mayúsculas y minúsculas, reemplazo, división, unión,
 *   interpolación, verificación...
 */

using System;

class Program
{
    static void Main()
    {
        string texto1 = "Hola";
        string texto2 = "Mundo";

        // 1. Concatenar cadenas (unir textos con +)
        string unido = texto1 + " " + texto2;
        Console.WriteLine("1- Concatenar: " + unido);

        // 2. Longitud de la cadena (sabes cuántos caracteres tiene la cadena)
        Console.WriteLine("2- Longitud de texto1: " + texto1.Length);

        // 3. Convertir a mayúsculas y minúsculas
        Console.WriteLine("3- Mayúsculas: " + texto1.ToUpper());
        Console.WriteLine("3- Minúsculas: " + texto2.ToLower()); 

        // 4. Comparar cadenas (comparar Textos)
        bool iguales = texto1.Equals("hola", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("4- ¿'Hola' es igual a 'hola' (sin distinguir mayúsculas)? --> " + iguales);

        // 5. Subcadena (extraer parte del texto)
        string sub = unido.Substring(5, 5); // Llega hasta la posición n°5 en el texto, y luego toma 5 caracteres
        Console.WriteLine("5- Subcadena: " + sub);

        // 6. Reemplazar texto
        string reemplazo = unido.Replace("Mundo", "C#"); // Toma el string "unido" de la 1er operacion y Remplaza "Mundo" Por "C#"
        Console.WriteLine("6- Reemplazar: " + reemplazo);

        // 7. Buscar posición de un texto dentro de otro
        int pos = unido.IndexOf("Mundo"); // Toma el string "unido" de la 1er operacion, y busca el indice de "Mundo" en ella
        Console.WriteLine("7- Posición de 'Mundo' en la cadena: " + pos);

        // 8. Comprobar si contiene un texto
        bool contiene = unido.Contains("la"); // Busca si en el string "unido" existe el texto "la" 
        Console.WriteLine("8- ¿Contiene 'la'? " + contiene);

        // 9. Quitar espacios al principio y fin
        string textoConEspacios = "  Hola Mundo  "; //
        Console.WriteLine("9- Antes de Trim: '" + textoConEspacios + "'");
        Console.WriteLine("9- Después de Trim: '" + textoConEspacios.Trim() + "'");

        // 10. Dividir cadena en partes por un separador
        string csv = "manzana,banana,naranja";
        string[] frutas = csv.Split(','); // Se usa el método Split para dividir la cadena csv en varias partes usando la coma ',' como separador. Cada vez que encuentra una coma en csv, crea una nueva subcadena como un elemento separado.
        Console.WriteLine("10- Frutas:");
        foreach (string fruta in frutas) // Recorre cada elemento del array "frutas". En cada vuelta, la variable "fruta" contiene una de las palabras.
        {
            Console.WriteLine(fruta);
        }

        // 11. Formateo con interpolación
        int tiempo = 48;
        string mensaje = $"11- Estudie {tiempo} horas en la escuela de derecho";
        Console.WriteLine(mensaje);
    }
}

/* Notas personales:

======================================================================================================

Equals(): compara dos textos y puede ignorar mayúsculas o minúsculas.

======================================================================================================

StringComparison.OrdinalIgnoreCase: se usa para comparar cadenas de texto
                                    ignorando si las letras están en mayúsculas
                                    o minúsculas

======================================================================================================

Subcadena - Substring(inicio, longitud): Es un método que se usa para extraer una 
                                         parte de una cadena más grande.

======================================================================================================

IndexOf: Busca en una cadena la posición de la primera aparición de un texto o carácter específico,
         luego evuelve un número que indica en qué lugar (índice) de la cadena está ese texto.
         Si no lo encuentra, devuelve -1

======================================================================================================

Interpolación - ($"texto {variable}"): inserta variables dentro de textos de forma sencilla.

======================================================================================================

*/