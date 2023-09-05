using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    public class Doctor
    {
       public string DoctorName { get; set; }

       public string Especialidad { get; set;}

       public Doctor(string doctorName, string especialidad)
       {
            this.DoctorName = doctorName;
            this.Especialidad = especialidad;
       }
    }
}