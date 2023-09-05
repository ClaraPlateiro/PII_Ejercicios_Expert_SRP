using System;
using Library;

namespace Library
{
    public class Appoiments
    {
        public string Lugar { get; set; }

        public string Codigo { get;}

        public DateTime Fecha { get;}

        public Appoiments(DateTime fecha, string lugar, string id)
        {
            this.Lugar = lugar;
            this.Codigo = id;
            this.Fecha = fecha;
        }
    }
}