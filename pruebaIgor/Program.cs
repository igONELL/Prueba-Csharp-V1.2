using System;
using System.Collections;
using System.Threading;

namespace pruebaIgor
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                /*----------------- INICIO LOGIN -----------------*/

                Console.WriteLine("< ---------- Login ---------- >");
                Console.WriteLine("\n");
                Console.WriteLine("Bienvenidos");
                Console.WriteLine("\n");
                Console.WriteLine("Aplicación de vehiculos");
                Console.WriteLine("\n");

                string usuario;
                string contrasena;


                Console.WriteLine("Ingrese su usuario: ");
                usuario = Console.ReadLine();
                while (usuario != "admin")
                {
                    Console.WriteLine("Vuelva a escribir su usuario");
                    usuario = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Usuario correcto!. ahora ingrese su contraseña: ");
                contrasena = Console.ReadLine();
                while (contrasena != "abc123")
                {
                    Console.WriteLine("Vuelva a escribir su contraseña");
                    contrasena = Console.ReadLine();

                }
                Console.Clear();
                Console.WriteLine("< ---------- Bienvenido a la aplicación ---------- > ");


                /*----------------- FIN LOGIN -----------------*/

                /*----------------- INICIO MENU -----------------*/
                
                ArrayList listaDeAutomoviles = new ArrayList();
                int menu;

                Console.WriteLine("Menu automoviles elija un opcion\n" +
               "\n1.- Ingrese vehiculo." +
               "\n2.- Listado de vehiculos." +
               "\n3.- Salir");
                menu = int.Parse(Console.ReadLine());

                switch (menu) {



                    case 1:

                        /*---------- Vehiculo componentes ----------*/
                        /*---------- Declarar variable ----------*/
                        Automovil nuevoAutomovil;
                        Motor nuevoMotor;
                        Mezclador nuevoMezclador;
                        Estanque nuevoEstanque;
                        Rueda nuevaRueda;


                        /*---------- Motor ----------*/
                        Console.WriteLine("Ingrese el estado del motor (0,0 a 100,0): ");
                        float nuevoMotorEstado = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el ID del motor:------->    ");
                        float nuevoId = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tipo motor:------->    ");
                        string nuevoTipoMotor = Console.ReadLine();
                        Console.WriteLine("Ingrese la cilindrada:------->    ");
                        float nuevoCilindrada = float.Parse(Console.ReadLine());
                        nuevoMotor = new Motor(nuevoMotorEstado, nuevoId, nuevoTipoMotor, nuevoCilindrada);//<--Creando objeto


                        /*---------- Mezclador ----------*/
                        Console.WriteLine("Ingrese el estado del mezclador (0,0 a 100,0): ");
                        float nuevoEstado = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese El tipo de Mezclador (Carburador o Inyector):------->    ");
                        string nuevoTipo = Console.ReadLine();
                        nuevoMezclador = new Mezclador(nuevoEstado, nuevoTipo);


                        /*---------- Estanque ----------*/
                        Console.WriteLine("Ingrese el estado estanque (0,0 a 100,0): ");
                        float autoEstanque = float.Parse(Console.ReadLine());
                        Console.WriteLine("Capacidad del estanque:------->    ");
                        float capacidadEstanque = float.Parse(Console.ReadLine());
                        Console.WriteLine("Cantidad de litros en el estanque:------->    ");
                        float litrosEstanque = float.Parse(Console.ReadLine());
                        nuevoEstanque = new Estanque(autoEstanque, capacidadEstanque, litrosEstanque);


                        /*---------- Rueda ----------*/
                        Console.WriteLine("Ingrese el estado de las ruedas (0,0 a 100,0): ");
                        float nuevoRuedas = float.Parse(Console.ReadLine());
                        Console.Write("Su rueda puede tener recubrimiento (FENOL, HULE o POLIUTERANO).\n");
                        Console.WriteLine("Ingrese el recubrimiento de las 4 ruedas que tendra su vehiculo:------->    ");
                        string nuevoRecubrimiento = Console.ReadLine();
                        Console.Write("Ingrese el primer rango de dureza del neumatico:------->    ");
                        int nuevoDurometroMen= int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo rango de dureza del neumatico:------->    ");
                        int nuevoDurometroMay = int.Parse(Console.ReadLine());
                        nuevaRueda = new Rueda(nuevoRuedas, nuevoRecubrimiento, nuevoDurometroMen, nuevoDurometroMay);


                        /*---------- Automovil ----------*/
                        Console.WriteLine("Ingrese marca de un automovil:------->    ");
                        string nuevaMarca = Console.ReadLine();
                        Console.WriteLine("Ingrese el año del automovil:------->    ");
                        float nuevoAno = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese kilometraje:------->    ");
                        float nuevoKilometraje = float.Parse(Console.ReadLine());
                        nuevoAutomovil = new Automovil(nuevoEstanque, nuevoMezclador, nuevaRueda, nuevoMotor, nuevaMarca, nuevoAno, nuevoKilometraje);

                        break;
                
                }

                /*----------------- FIN MENU -----------------*/

                Console.ReadKey();
            }

            catch (Exception)
            {
                Console.WriteLine("OpenWrite() failed");
            }
        }
    }
}


