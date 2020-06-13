using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir = 0;
            Agenda agenda = new Agenda();
            do
            {


                Console.WriteLine("Que onda perry? Elegi cachorro de leche");
                Console.WriteLine("1. Ver contactos");
                Console.WriteLine("2. Agregar contacto");
                Console.WriteLine("3. Borra el ultimo contacto");
                Console.WriteLine("4. Buscar por nombre");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        agenda.Limpiar();
                        Console.WriteLine("1. Ver orden ascendente");
                        Console.WriteLine("2. Ver orden descendente");

                        opcion = int.Parse(Console.ReadLine());
                        agenda.Limpiar();
                        switch (opcion)
                        {
                            case 1:
                                agenda.Mostrar();
                                agenda.Esperar();
                                agenda.Limpiar();
                                break;
                            case 2:
                                agenda.MostrarDesc();
                                agenda.Esperar();
                                agenda.Limpiar();
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                break;
                        }

                        break;
                    case 2:
                        agenda.Limpiar();
                        Console.WriteLine("Ingrese el nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono");
                        int telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el email");
                        string email = Console.ReadLine();
                        Contacto c = new Contacto(nombre, telefono, email);
                        agenda.AgregarContactos(c);

                        Console.WriteLine("Contacto creado con exito");
                        agenda.Esperar();
                        agenda.Limpiar();
                        break;
                    case 3:
                        agenda.Limpiar();
                        agenda.BorrarUltimo();
                        Console.WriteLine("Ultimo contacto borrado con exito");
                        agenda.Esperar();
                        agenda.Limpiar();

                        break;
                    case 4:
                        agenda.Limpiar();
                        Console.WriteLine("Ingrese el nombre que desea buscar");
                        string nom = Console.ReadLine();
                        Console.WriteLine(agenda.BuscarNombre(nom));
                        agenda.Esperar();
                        agenda.Limpiar();

                        break;
                    case 5:
                        agenda.Limpiar();
                        Console.WriteLine("Desea salir del programa");
                        Console.WriteLine("Ingrese 1 para salir o 0 para seguir");
                        salir = int.Parse(Console.ReadLine());
                        agenda.Limpiar();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (salir == 0);

       }
    }
}
