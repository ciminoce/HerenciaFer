using HerenciaFer.Datos;
using HerenciaFer.Entidades;
using HerenciaFer.Entidades.Enums;

namespace HerenciaFer.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion("El Día", DateTime.Today, 100, 200);
            Revista revista = new Revista("El Grafico", DateTime.Today, 200, 500, TipoRevista.Deportes);
            
            Libro libro = new Libro("El señor de los Anillos", new DateTime(1970, 12, 5), 500, 5000, 97946464, "J.R.R. Tolkien");
            Diario diario = new Diario("El Planeta", DateTime.Today, 100, 100, true);
            PuestoDeDiarios puestoDeDiarios = new PuestoDeDiarios();
            
            puestoDeDiarios.Agregar(revista);
            puestoDeDiarios.Agregar(libro);
            puestoDeDiarios.Agregar(diario);
            //Upcasting
            Publicacion revista2 = new Revista("Batman", DateTime.Today, 150, 500, TipoRevista.Modas);
            ((Revista)revista2).TipoRevista = TipoRevista.Comic;

            Revista revista3=(Revista)revista2;
            Console.WriteLine(revista3.MostrarDatos());

            Console.WriteLine(revista2.MostrarDatos());
            Console.WriteLine(publicacion.MostrarDatos());
            Console.WriteLine(revista.MostrarDatos());
            Console.WriteLine(libro.MostrarDatos());
            Console.WriteLine(diario.MostrarDatos());

            Imprimir(revista3);
            Console.WriteLine(puestoDeDiarios.GetCantidad());
            Console.WriteLine(puestoDeDiarios.MostrarDatosPublicaciones());
        }
        public static void Imprimir(Publicacion publicacion)
        {
            Console.WriteLine(publicacion.MostrarDatos());
        }
    }
}