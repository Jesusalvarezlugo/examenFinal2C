using examenFinal2.Dtos;
using examenFinal2.Servicios;

namespace examenFinal2.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            List<CitaDto> listaCitas = new List<CitaDto>();
            string rutaArchivo = "citas.txt";

            
            fi.cargaInicial(listaCitas,rutaArchivo);

            foreach(CitaDto cita in listaCitas)
            {
                Console.WriteLine(cita.ToString());
            }
            try
            {
                while (!cerrarMenu)
                {
                    opcion = mi.mostrarMenuYSeleccionPrin();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("[INFO] Se cerrara la aplicacion.");
                            fi.ficheroLog("[INFO] Se cerrara la aplicacion.");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("[INFO] Registro de llegada.");
                            oi.registroLlegada(listaCitas);
                            break;

                        case 2:
                            Console.WriteLine("[INFO] Listado de consultas.");
                            oi.listadoConsultas(listaCitas);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el codigo.");
            }
            
        }
    }
}
