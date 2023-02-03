using System;

namespace cosa
{
    internal class Program
    {
        static int numero_global;
        static void Main(string[] args)
        {
            #region todo hasta el martes

            #region lunes
            Console.WriteLine("Tipos numéricos");
            Console.WriteLine("Enteros");
            int el_numero = 123;
            int otro_numero;
            otro_numero = 321;
            el_numero = 70;
            #endregion
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
            numero_global = 10;
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
            #endregion

            #region Miércoles
            //Convertir strings -> numero: Parse
            int auxiliar = -1;
            try
            {
                auxiliar = int.Parse(txt);
                Console.WriteLine(4 / auxiliar);
                //int[] numeros = new int[2];
                //numeros[10] = 45;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debió colocar un símbolo numérico. (0-2023)");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("No ponga el número 0 (cero)");

                try
                {
                    int nn = 0;

                    int r = 5 / nn;
                }
                catch (DivideByZeroException e) {
                    Console.WriteLine("Usted no aprende");
                }
            }
            finally {
                Console.WriteLine("Entramos afinally");
            }

            Console.WriteLine("Fin de ejemplo try-catch");

            Console.WriteLine("ARREGLOS");
            //Unidimensional
            int[] nums = new int[4];
            nums[0] = 12;
            nums[1] = 56;
            nums[2] = 0;
            nums[3] = -23;
            num = nums[2] + 3;

            //Bidimensional
            string[,] matriz = new string[2,3];//[fila][columna]
            matriz[0,0] = "Texto";
            matriz[1,2] = "Maximo";
            //matriz[2][1] = "Valor";//está mal

            //Tridimensionales
            float[,,] cubo = new float[3,2,2];//[lado][alto][produndidad]
            cubo[2,1,1] = 34.6f;

            //Multidiemsional - n-dimensional
            int[,,,,,,,] octo_path_traveler = new int[3,4,5,6,7,8,2,10];
            octo_path_traveler[0, 0, 0, 0, 0, 0, 0, 1] = 56;
            Console.WriteLine("El resultado es: " + (octo_path_traveler[0, 0, 0, 0, 0, 0, 0, 1] + cubo[2, 1, 1] - 1));
            #endregion
            int numero_grandote = 2147483647;
            numero_grandote = numero_grandote + 1;
            Console.WriteLine(numero_grandote);
            #region condicionales
            Console.WriteLine("Condicionales");
            #endregion
        }
    }
}

namespace otroNombre
{
    namespace unoDentro
    {
        
    }
}
