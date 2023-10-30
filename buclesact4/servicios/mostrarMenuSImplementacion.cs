using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesact4.servicios
{
    internal class mostrarMenuSImplementacion : mostrarMenuSInterfaz
    {
        public string continuarOparar()
        {
            Console.WriteLine("Si quiere continuar teclee: ( s ) * importante en minusculas * ");
            string eleccionS = Console.ReadLine();
            return eleccionS;
        }
    }
}
