using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarlingAExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
        public static int opcion;
        // metodo para desplegar un menu
        public static void menu()
        {

            do // bucle que se ejecuta almenos una vez 
            {
                Console.WriteLine("--Sistema de Biblioteca--");
                Console.WriteLine("1. Agreegar un libro a la biblioteca");
                Console.WriteLine("2. Eliminar un libro de la biblioteca");
                Console.WriteLine("3. Mostrar todos los libros de la biblioteca");
                Console.WriteLine("4. Buscar Libros");
                Console.WriteLine("5. Mostrar libro de mayor precio");
                Console.WriteLine("6. Mostrar los 3 libros más baratos");
                Console.WriteLine("7. Buscar libros por inicio del nombre del autor");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Digite una opción...");


                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    switch (opcion) // condicional que dependiendo de la opcion dada por el usuario muestra diferentes metodos
                    {
                        case 1: ClsBiblioteca.AgregarLibro(); break;

                        case 2: ClsBiblioteca.EliminarLibro(); break;

                        case 3: ClsBiblioteca.MostrarLibros(); break;

                        case 4: ClsBiblioteca.BuscarLibrosPorAutor(); ; break;

                        case 6: ClsBiblioteca.ObtenerLibroDeMayorPrecio(); break;

                        case 7: ClsBiblioteca. ObtenerTresLibrosMasBaratos(); break;

                        case 8: Console.WriteLine("Saliendo..."); break;

                        default: Console.WriteLine("Digite una opción correcta"); break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción ingresada no es válida. Por favor, ingrese un número.");
                }

            } while (opcion != 8);


        }

    }
}




