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

                Console.Write("Ingrese su usuario:    ");
                usuario = Console.ReadLine();
                while (usuario != "admin")
                {
                    Console.WriteLine("Vuelva a escribir su usuario");
                    usuario = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("< ---------- Login ---------- >");
                Console.WriteLine("\n");
                Console.WriteLine("Bienvenidos");
                Console.WriteLine("\n");
                Console.WriteLine("Aplicación de vehiculos");
                Console.WriteLine("\n");
                Console.Write("Usuario correcto!. ahora ingrese su contraseña:     ");
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
                int menu = 0;

                do
                {

                    Console.WriteLine("\n\nAplicación de vehiculos");
                    Console.WriteLine("\n\nMenu automoviles elija un opcion\n" +
                   "\n1.- Ingrese vehiculo." +
                   "\n2.- Listado de vehiculos." +
                   "\n0.- Salir");
                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {

                        case 1:

                            /*---------- Vehiculo componentes ----------*/
                            /*---------- Declarar variable ----------*/
                            Automovil nuevoAutomovil;
                            Motor nuevoMotor;
                            Mezclador nuevoMezclador;
                            Estanque nuevoEstanque;
                            Rueda nuevaRueda;


                            /*---------- Motor ----------*/
                            Console.Write("\nIngrese el estado del motor puede ser entre (0,0 a 100,0):------->    ");
                            float nuevoMotorEstado = float.Parse(Console.ReadLine());
                            Console.WriteLine("\nIngrese los tiempos del motor “DOS_TIEMPOS” o “CUATRO_TIEMPOS”:    ");
                            string nuevoTiempos = Console.ReadLine();
                            Console.Write("\nIngrese el ID numerico del motor:------->    ");
                            float nuevoId = float.Parse(Console.ReadLine());
                            Console.Write("\nIngrese el tipo motor:------->    ");
                            string nuevoTipoMotor = Console.ReadLine();
                            Console.Write("\nIngrese la cilindrada:------->    ");
                            float nuevoCilindrada = float.Parse(Console.ReadLine());
                            nuevoMotor = new Motor(nuevoMotorEstado, nuevoId, 
                                                    nuevoTipoMotor, nuevoCilindrada, nuevoTiempos);//<--Creando objeto


                            /*---------- Mezclador ----------*/
                            Console.Write("\nIngrese el estado del mezclador puede ser entre (0,0 a 100,0):------->    ");
                            float nuevoEstado = float.Parse(Console.ReadLine());
                            Console.Write("\nIngrese El tipo de Mezclador (Carburador o Inyector):------->    ");
                            string nuevoTipo = Console.ReadLine();
                            nuevoMezclador = new Mezclador(nuevoEstado, nuevoTipo);


                            /*---------- Estanque ----------*/
                            Console.Write("\nIngrese el estado estanque puede ser entre (0,0 a 100,0):------->     ");
                            float autoEstanque = float.Parse(Console.ReadLine());
                            Console.Write("\nCapacidad del estanque:------->    ");
                            float capacidadEstanque = float.Parse(Console.ReadLine());
                            Console.Write("\nCantidad de litros en el estanque:------->    ");
                            float litrosEstanque = float.Parse(Console.ReadLine());
                            nuevoEstanque = new Estanque(autoEstanque, capacidadEstanque, litrosEstanque);


                            /*---------- Rueda ----------*/
                            Console.Write("\nIngrese el estado de las ruedas puede ser entre (0,0 a 100,0):------->    ");
                            float nuevoRuedas = float.Parse(Console.ReadLine());
                            Console.Write("\nSu rueda puede tener recubrimiento (FENOL, HULE o POLIUTERANO).");
                            Console.Write("\nIngrese el recubrimiento de las 4 ruedas que tendra su vehiculo:------->    ");
                            string nuevoRecubrimiento = Console.ReadLine();
                            Console.Write("\nIngrese el primer rango de dureza del neumatico:------->    ");
                            int nuevoDurometroMen = int.Parse(Console.ReadLine());
                            Console.Write("\nIngrese el segundo rango de dureza del neumatico:------->    ");
                            int nuevoDurometroMay = int.Parse(Console.ReadLine());
                            nuevaRueda = new Rueda(nuevoRuedas, nuevoRecubrimiento, 
                                                    nuevoDurometroMen, nuevoDurometroMay);


                            /*---------- Automovil ----------*/
                            Console.Write("\nIngrese marca de un automovil:------->    ");
                            string nuevaMarca = Console.ReadLine();
                            Console.Write("\nIngrese el año del automovil:------->    ");
                            float nuevoAno = float.Parse(Console.ReadLine());
                            Console.Write("\nIngrese kilometraje:------->    ");
                            float nuevoKilometraje = float.Parse(Console.ReadLine());
                            nuevoAutomovil = new Automovil(nuevoEstanque, nuevoMezclador, 
                                                            nuevaRueda, nuevoMotor, nuevaMarca, 
                                                            nuevoAno, nuevoKilometraje);
                            listaDeAutomoviles.Add(nuevoAutomovil);
                            Console.Clear();
                            Console.WriteLine("Su automovil se ha añadido con exito\n\n");
                            break;

                        case 2:
                            int cantidadVehiculos = 0;
                            foreach (object item in listaDeAutomoviles)
                            {
                                cantidadVehiculos++;
                                Automovil v = (Automovil)item;

                                Console.WriteLine("\nCantidad de vehiculos guardados:    " + cantidadVehiculos);

                                /*---------- Motor ----------*/
                                Console.WriteLine("Estado de los componenetes:    " + v.Motor.EstadoComponente);
                                Console.WriteLine("Tiempos del motor:    " + v.Motor.Tiempos);
                                Console.WriteLine("ID numerico del motor:    " + v.Motor.Id);
                                Console.WriteLine("Tipo del motor del vehiculo:    " + v.Motor.Tipo);
                                Console.WriteLine("\nTipo de cilindrada:    " + v.Motor.Cilindrada);

                                /*---------- Mezclador ----------*/
                                Console.WriteLine("Estado de los componenetes:    " + v.Mezclador.EstadoComponente);
                                Console.WriteLine("\nEl mezclador es de tipo:    " + v.Mezclador.Tipo);

                                /*---------- Estanque ----------*/
                                Console.WriteLine("Estado de los componenetes:    " + v.Estanque.EstadoComponente);
                                Console.WriteLine("Capacidad del estanque:    " + v.Estanque.Capacidad);
                                Console.WriteLine("\nCantidad de litros en el estanque:    " + v.Estanque.Litros);

                                /*---------- Rueda ----------*/
                                Console.WriteLine("Estado de los componenetes:    " + v.Rueda.EstadoComponente);
                                Console.WriteLine("Tipo recubrimiento de las ruedas:    " + v.Rueda.Recubrimiento);
                                Console.WriteLine("El valor menor de dureza de la rueda:    " + v.Rueda.MenorDurometro);
                                Console.WriteLine("\nEl valor mayor de dureza de la rueda:    " + v.Rueda.MayorDurometro);

                                /*---------- Automovil ----------*/
                                Console.WriteLine("Marca del automovil:    " + v.Marca);
                                Console.WriteLine("Año del automovil:    " + v.Ano);
                                Console.WriteLine("Kilometraje del automovil:    " + v.Kilometraje);
                            }

                            Console.WriteLine("chaolovimoh");

                            break;

                        case 3:
                            Environment.Exit(0);

                            break;


                            /*----------------- FIN MENU -----------------*/

                    }
                } while ( menu != 0 );
                


                    /* [20:02] SEBASTIAN IGNACIO LOPEZ MUÑOZ
                      Define una variable de tipo ArrayList y ponele un nombre, 
                      por ejemplo arrayVehiculos
                     la instancias con new ArrayList();
                     y cada vez que creas un objeto vehiculo, lo guardas dentro 
                     del arraylist usando el método Add
                      algo asi como arrayVehiculos.Add(miVehiculo);
                     miVehiculo seria algo asi como Automovil miVehiculo = new Automovil();*/


                    Console.ReadKey();
            }

            catch (Exception)
            {
                Console.WriteLine("OpenWrite() failed");
            }
        }
    }
}


