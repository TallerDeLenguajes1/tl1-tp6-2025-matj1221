[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

¿String es una tipo por valor o un tipo por referencia?

String es un tipo por referencia, pero tiene un comportamiento medio raro. Aunque sea por referencia, es inmutable, o sea, cada vez que cambiamos el contenido de un string, se crea uno nuevo. Por eso muchas veces parece que fuera por valor, pero en realidad no lo es.

¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape son caracteres especiales que usamos dentro de las cadenas para representar cosas que no se pueden escribir directamente. Algunas de las más comunes son:

\n: salto de línea
\t: tabulación (como un "tab")
\0: carácter nulo

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Si ponés el símbolo @ antes del string, C# toma todo literalmente, sin interpretar ninguna secuencia de escape (como un salto de línea: \n).

Por eso, con @ podés escribir la ruta sin preocuparte por poner sin querer una secuencia de escape.
Por ejemplo: string ruta = @"C:\Users\nMatías\Documentos"; (Acá, \n generaría un salto de línea si no hubiera usado @).

Cuando ponés $, podés incluir variables directamente dentro del string, usando llaves {} (De esta manera, lo hice en el TP).

TAMBIÉN, Se pueden usar juntos: @$ o $@:
string carpeta = "Documentos";
string ruta = @$"C:\Usuarios\{carpeta}\archivo.txt";

