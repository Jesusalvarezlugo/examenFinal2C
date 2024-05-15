using examenFinal2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void registroLlegada(List<CitaDto> listaAntgCitas)
        {
            string dniAPedir;

            Console.WriteLine("Introduce el dni para consultar su cita: ");
            dniAPedir = Console.ReadLine();

            

            DateTime fechaActual= DateTime.Now;
            bool aux = false;

            foreach(CitaDto cita in listaAntgCitas)
            {
                if (cita.FchCita > fechaActual&&dniAPedir==cita.DniPaciente)
                {
                    Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                    aux = true;
                    break;
                }
            }

            if (aux = false)
            {
                Console.WriteLine(" No dispone de cita previa para hoy");
            }


        }

        private bool validarDni(string dni)
        {
            string[] letrasDni = {"T","R","W","A","G","M","Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E"};

            string letraDniProporcionada=dni.Substring(dni.Length-1);
            int numDni=Convert.ToInt32(dni.Substring(0,dni.Length-1));

            string letraDni = letrasDni[numDni%23];
           
            
            return true;
            
        }

        public void listadoConsultas(List<CitaDto> listaAntgCitas)
        {
            int opcion,opcionEsp;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionListado();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se volvera al menu principal");
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se mostraran las consultas");
                        mostrarConsultas(listaAntgCitas);
                        
                        break;

                    case 2:
                        Console.WriteLine("[INFO] se imprimiran las consultas");
                        break;
                }
            }
        }

        private void elegirEspecialidad()
        {
            MenuInterfaz mi = new MenuImplementacion();
            CitaDto cita = new CitaDto();
            int opcionEsp;

            opcionEsp = mi.mostrarMenuYSeleccioneSp();

            switch (opcionEsp)
            {
                case 1:
                    Console.WriteLine("Psicologia");
                     cita.Especialidad = "Psicologia";
                    break;

                case 2:
                    Console.WriteLine("Traumatologia");
                     cita.Especialidad = "Traumatologia";
                    break;

                case 3:
                    Console.WriteLine("Fisioterapia");
                     cita.Especialidad = "Fisioterapia";
                    break;
            }

            
        }

        private  void mostrarConsultas(List<CitaDto> listaAntgCitas)
        {
            elegirEspecialidad();
            string fechaAPedir;
            Console.WriteLine("Elija una fecha (dd-MM-yyyy)");
            fechaAPedir = Console.ReadLine();

            foreach(CitaDto cita in listaAntgCitas)
            {
                if (fechaAPedir == cita.FchCita.ToString("dd-MM-yyyy"))
                {
                    Console.WriteLine(cita.ToString());
                }
            }
        }

        private void imprimirConsultasCompleto(List<CitaDto> listaAntgCitas)
        {
            DateTime fechaAPedir;
            FicheroInterfaz fi = new FicheroImplementacion();
            string rutaArchivo;
            string fechaFormateada;

            Console.WriteLine("Introduce la fecha para imprimir las consultas:(dd-MM-yyyy) ");
            fechaAPedir = Convert.ToDateTime(Console.ReadLine());
            

            foreach (CitaDto cita in listaAntgCitas)
            {
                if (fechaAPedir.ToString("dd-MM-yyyy") == cita.FchCita.ToString("dd-MM-yyyy"))
                {

                    fi.imprimirConsultas(listaAntgCitas);
                }
              
            }
            
        }


    }
}
