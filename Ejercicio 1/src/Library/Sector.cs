using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string NombreSector { get; set; }
        public List<Shelve> ListaEstante { get; set; }
        
        public Sector(string sector)
        {
            NombreSector = sector;
            ListaEstante = new List<Shelve>();
        }

        public void AddShelve(Shelve shelve)
        {
            this.ListaEstante.Add(shelve);
        }
    }
}