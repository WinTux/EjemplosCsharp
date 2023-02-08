using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosCsharp
{
    public class SerHumano
    {
        int cantOjos = 2;
        int cantOrejas;
        int cantDedos;

        public void EmitirSonido() {
            Console.WriteLine("ho la");
        }

        public int RetornarCantidadOjos() {
            return cantOjos;
        }
    }
}
