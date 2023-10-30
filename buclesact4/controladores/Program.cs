using buclesact4.servicios;

namespace buclesact4.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            peticionDeNumeroInterfaz np = new peticionDeNumeroImplementacion();
            calculoInterfaz ci = new calculoImplementacion();
            mostrarMenuSInterfaz mmsi = new mostrarMenuSImplementacion();
            string eleccion;
            do
            {
                int numeroEscrito = np.pedirDeNumero();
                ci.calculo(numeroEscrito);
                eleccion = mmsi.continuarOparar();
            } while (eleccion == "s");
        }
    }
}

