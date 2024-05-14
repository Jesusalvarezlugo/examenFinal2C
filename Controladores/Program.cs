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
            try
            {
                while (!cerrarMenu)
                {
                    opcion = mi.mostrarMenuYSeleccionPrin();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("[INFO] Se cerrara la aplicacion.");
                            break;

                        case 1:
                            Console.WriteLine("[INFO] Registro de llegada.");
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
