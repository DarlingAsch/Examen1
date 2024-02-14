using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarlingAExamen1
{
    public class ClsLibro : ILibro
    {
        int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Fecha { get; set; }
        public double Precio { get; set; }
        bool Disponible { get; set; }



        public ClsLibro(int codigo, string titulo, string autor, string fecha, double precio, bool disponible)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            Fecha = fecha;
            Precio = precio;
            Disponible = disponible;

        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' no está disponible en este momento.");
            }
        }

        public void Devolver()
        {
            Disponible = true;
            Console.WriteLine($"Se ha devuelto el libro '{Titulo}'.");
        }

        public void Consultar()
        {
            Console.WriteLine($"Información del libro: \nTítulo: {Titulo}\nAutor: {Autor}\nFecha de Publicación: {Fecha}\nPrecio: {Precio}\nDisponible: {(Disponible ? "Sí" : "No")}");
        }


    }    

        
}
