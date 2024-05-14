using examenFinal2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Servicios
{
    internal class FicheroImplementacion:FicheroInterfaz
    {
        public void cargaInicial(List<CitaDto> listaAntgCitas, string ruta)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] cita = linea.Split(";");
                    CitaDto laCita = new CitaDto();
                    laCita.DniPaciente = cita[0];
                    laCita.Nombre = cita[1];
                    laCita.Apellidos = cita[2];
                    laCita.Especialidad = cita[3];
                    laCita.FchCita = Convert.ToDateTime(cita[4]);
                    laCita.AsistenciaCita = Boolean.Parse(cita[5]);

                    listaAntgCitas.Add(laCita);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer las listas.");
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
