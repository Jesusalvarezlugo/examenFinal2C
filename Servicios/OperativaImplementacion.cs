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


        }

        private bool validarDni(string dni)
        {
            string[] letrasDni = {"T","R","W","A","G","M","Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E"};

            string letraDni=dni.Substring(dni.Length-1);
            int numDni=Convert.ToInt32(dni.Substring(0,dni.Length-1));

           

            return true;
        }
    }
}
