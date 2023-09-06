using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Steven Jhonson", "5555-555-555", "986782342", "50");
            Appoiments appoiments1 = new Appoiments(DateTime.Now, "Wall Street", "5555-555-555");
            Doctor doctor1 = new Doctor("Armando", "Neurologo");
            Validacion validacion1 = new Validacion(paciente1);
            Validacion validacionn1 = new Validacion(appoiments1);
            Validacion validacionnn1 = new Validacion(doctor1);

            Console.WriteLine($"Hello, {paciente1.Name}! Here is your medical appoinment:\n"+$"Pacient info:\nName: {paciente1.Name}\nID: {paciente1.ID}\nCell number: {paciente1.NumeroCel}\nAge: {paciente1.Age}\n"+$"Dacdte:{appoiments1.Fecha}\n"+$"Place: {appoiments1.Lugar}\n"+$"Appoinment ID: {appoiments1.Codigo}\n"+$"You will be attended by {doctor1.DoctorName},{doctor1.Especialidad}");
        }
    }
}
