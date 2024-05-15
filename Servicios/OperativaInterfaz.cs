using examenFinal2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Servicios
{
    internal interface OperativaInterfaz
    {
        public void registroLlegada(List<CitaDto> listaAntgCitas);

        public void listadoConsultas(List<CitaDto> listaAntgCitas);
        

        
    }
}
