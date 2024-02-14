using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DarlingAExamen1
{
    public class ClsBiblioteca: ClsLibro
    {
        public static int libros;
        public static string inicioNombreAutor;
        public static int librosEncontrados;
        Biblioteca biblioteca = new Biblioteca();

        public static List<ClsLibro> libro = new List<ClsLibro>();

        public ClsBiblioteca(int codigo, string titulo, string autor, string fecha, double precio, bool disponible) : base(codigo, titulo, autor, fecha, precio, disponible)
        {
        }

        public static void AgregarLibro()
            {
            Libro nuevoLibro = new Libro();
            Console.Write("Ingrese el código del libro: ");
            nuevoLibro.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el título del libro: ");
            nuevoLibro.Titulo = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            nuevoLibro.Autor = Console.ReadLine();
            Console.Write("Ingrese la fecha de publicación del libro (YYYY-MM-DD): ");
            nuevoLibro.FechaPublicacion = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del libro: ");
            nuevoLibro.Precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("¿El libro está disponible para prestar? (Sí/No): ");
            nuevoLibro.Disponible = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);
            biblioteca.AgregarLibro(nuevoLibro);

            libro.Add(libro);
        }

        public static void EliminarLibro()
        {
            Console.Write("Ingrese el código del libro que desea eliminar: ");
            int codigo= Convert.ToInt32(Console.ReadLine());
            Libro libroEliminar = biblioteca.ObtenerLibroPorCodigo(codigo);
            if (libroEliminar != null)
            {
                biblioteca.EliminarLibro(libroEliminar);
                Console.WriteLine("El libro ha sido eliminado de la biblioteca.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese código.");
            }

        }

        public static void MostrarLibros()
        {

            foreach (var libro in libro)
            {
                libro.Consultar();
                Console.WriteLine("-------------");
            }
        }

        public void MostrarLibroDeMayorPrecio()
        {

            
                Libro libroMayorPrecio = biblioteca.ObtenerLibroDeMayorPrecio();
            if (libroMayorPrecio != null)
                if (libroMayorPrecio != null)
            {
                Console.WriteLine( $"Libro de mayor precio:\n{libroMayorPrecio.Titulo} - Precio: {libroMayorPrecio.Precio}");
            }
            else
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
        }

        public void MostrarTresLibrosMasBaratos()
        {
            var LibrosMasBaratos = libro.OrderBy(l => l.Precio).Take(3);
            if (LibrosMasBaratos.Any())
            {
                Console.WriteLine("Los tres libros más baratos son:");
                foreach (var libro in LibrosMasBaratos)
                {
                    Console.WriteLine($"Título: {libro.Titulo} - Precio: {libro.Precio}");
                }
            }
            else
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
        }

        public static void BuscarLibrosPorAutor()
        {
            Console.Write("Ingrese el inicio del nombre del autor: ");
            string inicioNombreAutor = Console.ReadLine();
            biblioteca.BuscarLibrosPorAutor(inicioNombreAutor);
            if (librosEncontrados > 0)
            {
                Console.WriteLine("No se encontraron libros con ese autor.");
            }
            else
            {
                Console.WriteLine($"Libros encontrados cuyo autor comienza con '{inicioNombreAutor}':");
                foreach (var libro in libro)
                {
                    libro.Consultar();
                    Console.WriteLine("-------------");
                }
            }
        }

        public static void  ObtenerLibroDeMayorPrecio()
        {
            libro.OrderByDescending(libro => libro.Precio).FirstOrDefault();
        }

        public static void ObtenerTresLibrosMasBaratos()
        {
           libro.OrderBy(libro => libro.Precio).Take(3).ToList();
        }
    }
}

