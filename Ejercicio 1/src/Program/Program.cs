using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector sector1 = new Sector("C");
            Sector sector2 = new Sector("F");
            Shelve shelve1 = new Shelve(5);
            Shelve shelve2 = new Shelve(3);
            sector1.AddShelve(shelve1);
            shelve1.AddBook(book1);
            sector2.AddShelve(shelve2);
            shelve2.AddBook(book2);
            Console.WriteLine($"El libro {book1.Title} del autor {book1.Author} con el código {book1.Code}, forma parte del sector {sector1.NombreSector} y pertenece al estante {shelve1.NumeroEstante}");
        }
    }
}