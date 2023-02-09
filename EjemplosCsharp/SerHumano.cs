using System;
using System.Collections.Generic;
using System.Text;

namespace SeresVivos
{
    public class SerHumano
    {
        private int cantOjos;
        public int cantidadOjos { 
            get { return cantOjos; }
            set { 
                if(value <= 2 && value >= 0)
                    cantOjos = value; 
            }
        }
        public int cantOrejas;
        public  int cantDedos;

        public SerHumano() {
            cantOjos = 2;
            cantOrejas = 2;
            cantDedos = 10;
        }
        public void EmitirSonido() {
            Console.WriteLine("ho la");
        }

        public int RetornarCantidadOjos() {
            return cantOjos;//Retorno por valor
        }
    }
    public class Toro { }
}
