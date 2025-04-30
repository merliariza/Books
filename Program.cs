﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinqQueries queries = new LinqQueries();
        ImprimirValores(queries.TodaLaColeccion);
    }

    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros = 0;
        Console.Clear();
        Console.WriteLine("{0,-70} {1,7} {2,20}\n", "Titulo", "N. Paginas", "Fecha publicacion");

        foreach (Book book in books)
        {
            registros++;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());

            if (registros % 10 == 0)
            {
                Console.WriteLine("\n--- Presiona cualquier tecla para continuar ---");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("{0,-70} {1,7} {2,20}\n", "Titulo", "N. Paginas", "Fecha publicacion");
            }
        }
    }
}
