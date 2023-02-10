using otroNombre;
using otroNombre.unoDentro;
using SeresVivos;
using System;
using System.Drawing;

namespace cosa
{
    internal class Program
    {
        static int numero_global;
        static void Main(string[] args)
        {
            /*
            switch (args[0]) {
                case "==version":
                    Console.WriteLine("La version de mi programa es la v1.0.1");
                    break;
                case "-hack":
                    Console.WriteLine("Hackeando la " + args[1]);
                    break;
                default:
                    Console.WriteLine("NO SE RECONOCE EL COMANDO");
                    break;
            }
            */
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
            //Simple
            bool esEmpleado;// true | false
            esEmpleado = true;

            if (!esEmpleado) {
                Console.WriteLine("Claro que es empleado, hast ala pregunta ofende");
                int xx = 24;
                Console.WriteLine(xx / 3 * 2);
            }
            //Compuesta
            if (!(num > 2 || num2 < 80)) Console.WriteLine("num es mayor a 2 y algo más");

            else Console.WriteLine("no se que valor tiene num pero acá te lo dejo:" + num);

            if (esEmpleado)
            {
                if (!(num < 10))
                {
                    Console.WriteLine("Es empleado y su numero es menor a 10");
                }
                else
                {
                    Console.WriteLine("Es empleado pero su numero es mayor o igual a 10");
                }
            }
            else
            {
                Console.WriteLine("no es empleado, nada que decir al respecto.");
            }

            /*
             p: pepe tiene 10 años
             q: pepe estudia en la escuela de la zona
             r: num es menor a 10

            p ^ q
            p v q
            ¬p
            p => q
            (¬p ^ (p v q)) => ¬(p v q) 
             */

            Console.WriteLine("Continuamos con la ejecución como es habitual.");

            //Switch
            int num_dia = 6;
            if (num_dia == 1)
                Console.WriteLine("Lunes");
            else
                if (num_dia == 2)
                Console.WriteLine("Martes");
            else
                    if (num_dia == 3)
                Console.WriteLine("Miercoles");
            else
                        if (num_dia == 4)
                Console.WriteLine("Jueves");
            else
                            if (num_dia == 5)
                Console.WriteLine("Viernes");
            else
                                if (num_dia == 6)
                Console.WriteLine("Sabado");
            else
                                    if (num_dia == 7)
                Console.WriteLine("Domingo");
            else Console.WriteLine("No es un numero valido");

            switch (num_dia) {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("No es un numero valido");
                    break;
            }

            #endregion

            #region iteraciones
            Console.WriteLine("Iteraciones");
            //While (mientras)
            int contador = 5;
            while (contador > 0) {
                Console.WriteLine(contador);
                --contador;//primero decrementa, luego usa.
                contador--;//primero lo usa, luego lo decrenta.
            }

            int c = 10;
            Console.WriteLine(c);   //10
            Console.WriteLine(c++); //10
            Console.WriteLine(c);   //11
            Console.WriteLine(++c); //12
            Console.WriteLine(c);   //12

            int[,] mtx = new int[3, 5];
            int fila, columna;
            fila = 0; columna = 0;
            while (fila <= 4) {
                columna = 0;
                while (columna <= 2) {
                    mtx[columna++,fila] = 1;
                }
                fila++;
            }

            //Mostrando la matriz:
            
            fila = 0;
            while (fila <= 4)
            {
                columna = 0;
                while (columna <= 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[" + mtx[columna++,fila] + "]");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                fila++;
            }

            bool yaPaso = false;

            //FOR (para)
            int i = -3550;
            for (i = 2; i <= 10; i+=2) { // i++ i-- i+=3 i = i +3;
                Console.WriteLine("Hola " + i);
                if(!yaPaso && i >5)
                {
                    i = -3;
                    yaPaso = true;
                }
            }

            //do while
            do {
                Console.WriteLine("Mira que la variable fila tiene el valor: " + fila);
            } while (fila <= 4);


            ///Encontrar donde está el valor 100
            ///
            int[] arreglo = new int[4];
            arreglo[0] = arreglo[1] = arreglo[2] = arreglo[3] = 0;
            arreglo[0] = 100;

            int indice_respuesta = -1;
            for (i= 0; i < 4; i++) {
                if (arreglo[i] == 100)
                {
                    indice_respuesta = i;
                    break;
                }
            }
            if(indice_respuesta >-1)
                Console.WriteLine("El num 100 está en el indice " + indice_respuesta);
            else
                Console.WriteLine("No se encontró el 100 en todo el arreglo");


            Console.WriteLine("Ufff se terminó");



            #endregion

            #region OOP

            //Clase
            SerHumano ser01 = new SerHumano();//Crear una instancia
            otroNombre.unoDentro.B unObjetoB = new otroNombre.unoDentro.B();//ojo, tiene explicación
            int cant = ser01.RetornarCantidadOjos();
            Console.WriteLine("El ser humano tiene " + cant + " ojos.");
            ser01.cantidadOjos = -5;
            
            ser01.cantOrejas = -4;
            cant = ser01.RetornarCantidadOjos();
            Console.WriteLine("El ser humano tiene " + cant + " ojos.");

            Persona per01 = new Persona();
            per01.DecirNombre();
            per01.EmitirSonido();

            Empleado empA = new Empleado();
            empA.EmitirSonido();
            empA.DecirNombre();
            empA.Trabajar();

            Persona per02 = new Empleado();
            SerHumano ser02 = new Empleado();
            SerHumano ser03 = new Persona();

            int numEntero = (int)10.531f;
            Empleado empB = (Empleado)per02;//CAST

            empA.DecirCargo();
            empB.DecirCargo();


            // Pase por referencia
            Empleado empC = empA;
            empA.DecirCargo();//El cargo del empleado A
            empC.DecirCargo();//El cargo del empleado C
            empA.cargo = "Jefe de Sistemas";
            empA.DecirCargo();//El cargo del empleado A
            empC.DecirCargo();//El cargo del empleado C

            Console.WriteLine("Copiando con pases por valor:");
            // Realizar copia (evitar referencia)
            Empleado empD = new Empleado();
            empD.cargo = empA.cargo;//pase por valor
            empD.NIT = empA.NIT;//Pase por valor

            empA.DecirCargo();//El cargo del empleado A
            empD.DecirCargo();//El cargo del empleado D
            empA.cargo = "Auxiliar de desarrollo";
            empA.DecirCargo();//El cargo del empleado A
            empD.DecirCargo();//El cargo del empleado D

            //Interfaces (polimorfismo)

            #endregion
        }
    }

    public class A {
        public int Sumar(int a, int b) {
            int res = a + b;
            return res;
        }
    
    }
}

namespace otroNombre
{

    namespace unoDentro
    {
        public class B { 
        
        }

        public class Empleado : Persona{
            public string cargo;
            public int NIT;
            public Empleado() {
                cargo = "Pasante";
                NIT = -1;
            }
            
            public void Trabajar() {
                Console.WriteLine("Trabajo muy duro, como un esclavo");
            }
            public void DecirCargo() {
                Console.WriteLine("Mi cargo es " + cargo);
            }
        }
    }

    public class Persona : SerHumano {
        string nombre;
        int edad;
        int ci;
        public Persona() : base() {
            nombre = "N/A";
            edad = 18;
        }
        public void DecirNombre() {
            Console.WriteLine("Hola, mi nombre es " + nombre + " y tengo " + cantidadOjos + " ojos");
        }
    }
}
