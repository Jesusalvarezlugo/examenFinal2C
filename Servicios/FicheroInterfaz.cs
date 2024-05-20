using examenFinal2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenFinal2.Servicios
{
    internal interface FicheroInterfaz
    {
        public void cargaInicial(List<CitaDto> listaAntgCitas, string ruta);

        public void imprimirConsultas(List<CitaDto> listaAntgCitas,string rutaArchivo);

        public void ficheroLog(string texto);
    }
}
