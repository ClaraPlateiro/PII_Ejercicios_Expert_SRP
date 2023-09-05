using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    public class Paciente
    {
        public string Name { get; set;}

        public string ID { get; set;}

        public string NumeroCel { get; set;}

        public string Age { get; set;}

        public Paciente(string name, string id, string numeroCel, string age)
       {
            this.Name = name;
            this.ID = id;
            this.NumeroCel = numeroCel;
            this.Age = age;
       }
    
    }

}