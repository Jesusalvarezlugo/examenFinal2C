using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("#############################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("#############################");
            Console.WriteLine("elija una opcion: ");
            opcion=Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }
    }
}
