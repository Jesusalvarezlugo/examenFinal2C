using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Dtos
{
    internal class CitaDto
    {
        //Atributos

        long idCita;
        string dniPaciente = "aaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fchCita;
        bool asistenciaCita = false;

        

        //Getters y Setters
        public long IdCita { get => idCita; set => idCita = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FchCita { get => fchCita; set => fchCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }

        //Constructores

        public CitaDto()
        {

        }
        public CitaDto(long idCita, string dniPaciente, string nombre, string apellidos, string especialidad, DateTime fchCita, bool asistenciaCita)
        {
            this.idCita = idCita;
            this.dniPaciente = dniPaciente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fchCita = fchCita;
            this.asistenciaCita = asistenciaCita;
        }


        override
            public string ToString()
        {
            string texto = this.dniPaciente+";"+this.nombre+";"+this.apellidos+";"+this.especialidad+";"+this.fchCita+";"+this.asistenciaCita+"\n";
            return texto;
        }
    }
}
