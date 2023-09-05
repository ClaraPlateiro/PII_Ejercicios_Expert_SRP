using System;
using System.Text;
using Library;

namespace Library
{
    public class AppointmentService
    {
        public Paciente DatosCliente { get; set; }
        public Appoiments Reserva { get; set; }
        public Doctor Medico { get; set; }

        

        public AppointmentService (Paciente datoscliente, Appoiments reserva, Doctor medico)
        {
            this.DatosCliente = datoscliente;
            this.Reserva = reserva;
            this.Medico = medico;
        }

    }
}
