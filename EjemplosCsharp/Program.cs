using System;

namespace cosa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos numéricos");
            Console.WriteLine("Enteros");
            int el_numero = 123;
            int otro_numero;
            otro_numero = 321;
            el_numero = 70;

            const int PI = 3;

            int respuesta = 4 + 4;
            respuesta = 4 / el_numero;
            Console.WriteLine(respuesta);
            respuesta = PI + otro_numero - 3;
            respuesta = respuesta * el_numero;
            int x = 5;
            x = x + 1;
            Console.WriteLine("Decimales");
            float num;
            num = 3.1416f;

            double num2 = 3.1416;

            // double > float
            num2 = 4.5f;
            //num = 4.6; //Error de orden de asignación

            // reales > enteros
            num = 4;
            num2 = 8;
            //el_numero = 5.8; //Error de orden de asignación
            Console.WriteLine("Introduzca un valor numerico:");
            
            int cero = 5;
            num2 = 4 + cero;
            Console.WriteLine(num2);
            

            Console.WriteLine("Tipos texto");
            string txt = Console.ReadLine();
            Console.WriteLine(txt + 4);//concatenación -> "10" + "4" -> 104

            //Convertir strings -> numero: Parse

            int auxiliar = int.Parse(txt);
            Console.WriteLine(4 / auxiliar );
        }
    }
}

namespace otroNombre
{
    namespace unoDentro
    {
        
    }
}
