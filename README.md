# Visor de Colección de Libros con LINQ

Este proyecto en C# permite visualizar una colección de libros usando LINQ para filtrar, ordenar o consultar datos. Se ejecuta en la consola y muestra los libros paginados cada 10 registros, organizados por título, número de páginas y fecha de publicación.

## Características

- Consulta de toda la colección de libros mediante LINQ.
- Muestra los datos en formato tabular y paginado cada 10 libros.
- Limpieza de pantalla automática para facilitar la lectura.

## Estructura del Proyecto

- `Program.cs`: Punto de entrada del programa. Ejecuta la consulta e imprime los resultados.
- `LinqQueries.cs`: Clase encargada de realizar las consultas LINQ sobre la colección de libros.
- `Book.cs`: Clase que representa un libro con atributos como título, número de páginas y fecha de publicación.

## Cómo Ejecutarlo

1. Abre el proyecto en Visual Studio.
2. Asegúrate de tener los archivos `Book.cs` y `LinqQueries.cs` implementados correctamente.
3. Ejecuta el proyecto desde la consola.

## Requisitos

- .NET 6.0 o superior
- Acceso a consola

## Ejemplo de Salida

```text
Titulo                                                            N. Paginas   Fecha publicacion

Clean Code: A Handbook of Agile Software Craftsmanship                   464   08/01/2008
The Pragmatic Programmer: Your Journey to Mastery                       352   10/30/1999
...

--- Presiona cualquier tecla para continuar ---
