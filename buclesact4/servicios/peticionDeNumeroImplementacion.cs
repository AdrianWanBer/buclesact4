using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesact4.servicios
{
    internal class peticionDeNumeroImplementacion : peticionDeNumeroInterfaz
    {
        public int pedirDeNumero()
        {
            Console.WriteLine("Escribe un numero entero");
            int numeroPedido = Int32.Parse(Console.ReadLine());
            return numeroPedido;
        }
    }
}
