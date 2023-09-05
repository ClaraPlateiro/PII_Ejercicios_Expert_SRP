using System;
using System.Collections.Generic;
using Library;

namespace Library
{
    public class Validacion
    {
        public Validacion(Paciente persona)
        {
            if (persona == null)
            {
                throw new ArgumentNullException(nameof(persona), "Enter a valid patient");
            }
            if (string.IsNullOrWhiteSpace(persona.Name))
            {
                throw new ArgumentException("Unable to schedule appointment, 'name' is required\n", nameof(persona.Name));
            }
            if (string.IsNullOrWhiteSpace(persona.ID))
            {
                throw new ArgumentException("Unable to schedule appointment, 'id' is required\n", nameof(persona.ID));
            }
            if (string.IsNullOrWhiteSpace(persona.NumeroCel))
            {
                throw new ArgumentException("Unable to schedule appointment, 'phone number' is required\n", nameof(persona.NumeroCel));
            }
            if (string.IsNullOrWhiteSpace(persona.Age))
            {
                throw new ArgumentException("Unable to schedule appointment, 'age' is required\n", nameof(persona.Age));
            }
        }
        public Validacion(Doctor doc)
        {
            if (string.IsNullOrWhiteSpace(doc.DoctorName))
            {
                throw new ArgumentException("Unable to schedule appointment, 'doctor name' is required\n", nameof(doc.DoctorName));
            }
            if (string.IsNullOrWhiteSpace(doc.Especialidad))
            {
                throw new ArgumentException("Unable to schedule appointment, 'especialidad' is required\n", nameof(doc.Especialidad));
            }
        }
        public Validacion(Appoiments reservas)
        {
            if (string.IsNullOrWhiteSpace(reservas.Lugar))
            {
                throw new ArgumentException("Unable to schedule appointment, 'appoinment place' is required\n", nameof(reservas.Lugar));
            }
            if (string.IsNullOrWhiteSpace(reservas.Codigo))
            {
                throw new ArgumentException("Unable to schedule appointment, 'appoinmentid' is required\n", nameof(reservas.Codigo));
            }
        }
    }
}