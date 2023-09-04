using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> ListaLibros { get; set; }
        public int NumeroEstante { get; set; }

        public Shelve(int shelve)
        {
            NumeroEstante = shelve;
            ListaLibros = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.ListaLibros.Add(book);
        }
    }
}