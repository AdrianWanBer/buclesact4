using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesact4.servicios
{
    internal class calculoImplementacion : calculoInterfaz
    {
        public void calculo(int numeroInt)
        {
            int i;

            for (i=numeroInt ; i>=1 ; i--)
            {
                numeroInt = i * numeroInt;
                Console.WriteLine(numeroInt);
            }

        }
    }
}