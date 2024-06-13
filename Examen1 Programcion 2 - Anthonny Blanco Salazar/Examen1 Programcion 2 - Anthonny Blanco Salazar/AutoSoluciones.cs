using System;
using System.Security.Cryptography.X509Certificates;

namespace AutoSoluciones
{
    internal class AutoSoluciones
    {
        static void Main(string[] args)

        {



            int num, num1;
            string linea, linea2;
            bool continuar = true;

            Clientes[] clientes1 = new Clientes[0];

            while (continuar)
            {
                Console.WriteLine();

                Console.WriteLine("Bienvenido al Sistema de AutoSoluciones");
                Console.WriteLine();
                Console.WriteLine("Seleccione qué acción desea realizar: ");
                Console.WriteLine("1 - Gestion de Clientes");
                Console.WriteLine("2 - Gestion de Vehiculos");
                Console.WriteLine("3 - Gestiones de Servicio ");
                Console.WriteLine("4 - Gestion de Citas");
                Console.WriteLine("5 - Gestion de Mecanicos");
                Console.WriteLine("6 - Salir del Sistema");

                Console.Write("Ingrese un número del 1 al 6: ");
                Console.WriteLine();
                Console.WriteLine();
                linea2 = Console.ReadLine();
                num1 = int.Parse(linea2);



                switch (num1)
                {


                    case 1:

                        while (continuar)
                        {
                            Console.Clear();
                            Console.WriteLine("Gestion de Clientes");

                            Console.WriteLine("Seleccione qué acción desea realizar: ");
                            Console.WriteLine("1 - Ingresar Datos");
                            Console.WriteLine("2 - Mostrar Datos");
                            Console.WriteLine("3 - Salir");
                            Console.Write("Ingrese un número del 1 al 3: ");
                            Console.WriteLine();
                            Console.WriteLine();
                            linea = Console.ReadLine();
                            num = int.Parse(linea);


                            switch (num)
                            {
                                case 1:

                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Ingresar Datos");

                                    clientes1 = IngresarObjeto(clientes1);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Mostrar Datos");
                                    MostrarObjetos(clientes1);

                                    break;

                                case 3:
                                    continuar = false;
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("El número que ingresó está fuera de rango");
                                    break;
                            }

                            Console.WriteLine("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();


                        }

                       

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("No Disponible");

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("No Disponible");

                        


                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("No Disponible");

                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine("No Disponible");
                        break;
                    case 6:

                        Console.WriteLine("Saliendo del sistema");

                         Environment.Exit(0);
                        break;

                }

            }
        }






        static Clientes[] IngresarObjeto(Clientes[] clientes)

        {

            Console.WriteLine("Ingrese el nombre del Cliente");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su direccion de Residencia");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese su telefono celular");
            string telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el correo electronico");
            string correo = Console.ReadLine();

            // Crear un nuevo arreglo con un tamaño mayor para almacenar el nuevo objeto

            Clientes[] nuevosclientes = new Clientes[clientes.Length + 1];

            for (int i = 0; i < clientes.Length; i++)
              
        {
                nuevosclientes[i] = clientes[i];
          
        }

            nuevosclientes[nuevosclientes.Length - 1] = new Clientes(nombre, direccion, telefono, correo);
      
        Console.WriteLine("Objeto ingresado correctamente.");
            return nuevosclientes;
    }






    private  static void MostrarObjetos(Clientes[] clientes)
        {
            Console.Clear();
            Console.WriteLine("Clientes Ingresados");
            for (int i = 0; i < clientes.Length; i++)
            {
                Clientes clie = clientes[i];
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nombre: " + clie.Nombre);
                Console.WriteLine("Direccion: " +clie.Direccion);
                Console.WriteLine("Telefono: " + clie.Telefono);
                Console.WriteLine("Correo: " + clie.Correo);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }



    class Clientes
    {
        public string Nombre;
        public string Direccion;
        public string Telefono;
        public string Correo;
      


        public Clientes(string nombre, string direccion, string telefono, string correo)
        {
            {
                this.Nombre = nombre;
                this.Direccion = direccion;
                this.Telefono = telefono;
                this.Correo = correo;
            }


        }
    }
}
