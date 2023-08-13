using System.Text;

namespace HerenciaFer.Entidades
{
    public class Publicacion
    {
        private string nombre;
        private DateTime fechaPublicacion;
        private int cantidadPaginas;
        private decimal precio;

        public Publicacion(string nombre, DateTime fechaPublicacion, int cantidadPaginas,
            decimal precio)
        {
            this.nombre = nombre;
            this.fechaPublicacion = fechaPublicacion;
            this.cantidadPaginas = cantidadPaginas;
            this.precio = precio;
        }

        protected string Nombre { get => nombre; }
        protected DateTime FechaPublicacion { get => fechaPublicacion;  }
        protected int CantidadPaginas { get => cantidadPaginas; }
        protected decimal Precio { get => precio; }

        public string MostrarDatos()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"Nombre:{nombre}");
            sb.AppendLine($"Fecha:{fechaPublicacion.ToShortDateString()}");
            sb.AppendLine($"Cantidad de Páginas: {cantidadPaginas}");
            sb.AppendLine($"Precio:{precio}");
            return sb.ToString();
        }
    }
}
