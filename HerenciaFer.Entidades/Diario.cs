using System.Text;

namespace HerenciaFer.Entidades
{
    public class Diario:Publicacion
    {
        private bool tieneClasificados;

        public Diario(string nombre, DateTime fechaPublicacion,
            int cantidadPaginas, decimal precio, bool tieneClasificados) : base(nombre, fechaPublicacion, cantidadPaginas, precio)
        {
            this.tieneClasificados = tieneClasificados;
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Fecha:{FechaPublicacion.ToShortDateString()}");
            sb.AppendLine($"Cantidad de Páginas: {CantidadPaginas}");
            sb.AppendLine($"Precio:{Precio}");
            sb.AppendLine(tieneClasificados ? "Tiene Clasificados" : "No tiene Clasificados");
            return sb.ToString();
        }

    }
}